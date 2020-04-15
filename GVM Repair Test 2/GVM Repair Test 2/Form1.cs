using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = iTextSharp.text.Image;

namespace GVM_Repair_Test_2
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Giel\Documents\DB_GVMREPAIR.mdf;Integrated Security = True; Connect Timeout = 30");
        string imgLocation = "";



        public Form1()
        {
            InitializeComponent();

        }
        public class GlobalData
        {
            // you can read connection string from web.config/app.config
            // Connect to database
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Giel\Documents\DB_GVMREPAIR.mdf;Integrated Security = True; Connect Timeout = 30");
            public GlobalData() { }
            public DataTable GetData(string query)
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dtToReturn = new DataTable();
                da.Fill(dtToReturn);
                return dtToReturn;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GlobalData db = new GlobalData();
            dataGridView1.DataSource = db.GetData("select * from [Table]");
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            connection.Open();
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Table] (Naam,Serienummer,Model,Prijs,URL,Afbeelding) values ('" + txtBox_Naam.Text + "','" + txtBox_Serie.Text + "','" + cBoxModel.Text + "','" + txtBox_Prijs.Text + "','" + txtBox_URL.Text + "',@images) ";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data();
            MessageBox.Show("Data toegevoegd");

        }
        private void btn_LaadFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlg.FileName.ToString();
                txtBox_URL.Text = imgLocation;
                pictureBox1.ImageLocation = imgLocation;
            }
        }
        // om data te laten zien
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Naam, Serienummer, Model, Prijs, URL from [Table]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();

        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void txtBox_Serie_TextChanged(object sender, EventArgs e)
        {
            txtBox_Serie.MaxLength = 11;
            if (txtBox_Serie.TextLength == 11)
            {
                lbl_Juist.Visible = true;
            }
            else
                lbl_Juist.Visible = false;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Table] where Naam = '" + txtBox_Naam.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            txtBox_Naam.Text = "";
            txtBox_Serie.Text = "";
            cBoxModel.Text = "";
            txtBox_Prijs.Text = "";
            display_data();
            MessageBox.Show("Data verwijderd");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();


        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table] where Naam = '" + txtBox_Search.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
            txtBox_Naam.Text = "";
            txtBox_Serie.Text = "";
            cBoxModel.Text = "";
            txtBox_Prijs.Text = "";
        }

        private void cBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iph8_64gb = 500;
            int iph8_128gb = 550;
            int iphxr_64gb = 650;
            int iphxr_128gb = 700;
            int iph11_64gb = 775;
            int iph11pro_64gb = 1080;

            string iPhone864GB = Convert.ToString(iph8_64gb);
            string iPhone8128GB = Convert.ToString(iph8_128gb);
            string iPhoneXR64GB = Convert.ToString(iphxr_64gb);
            string iPhoneXR128GB = Convert.ToString(iphxr_128gb);
            string iPhone1164GB = Convert.ToString(iph11_64gb);
            string iPhone11PRO64GB = Convert.ToString(iph11pro_64gb);
            if (cBoxModel.SelectedItem.ToString() == "iPhone 8 64GB")
            {
                txtBox_Prijs.Text = iPhone864GB;
            }
            else if (cBoxModel.SelectedItem.ToString() == "iPhone 8 128GB")
            {
                txtBox_Prijs.Text = iPhone8128GB;
            }
            else if (cBoxModel.SelectedItem.ToString() == "iPhone XR 64GB")
            {
                txtBox_Prijs.Text = iPhoneXR64GB;
            }
            else if (cBoxModel.SelectedItem.ToString() == "iPhone XR 128GB")
            {
                txtBox_Prijs.Text = iPhoneXR128GB;
            }
            else if (cBoxModel.SelectedItem.ToString() == "iPhone 11 64GB")
            {
                txtBox_Prijs.Text = iPhone1164GB;
            }
            else if (cBoxModel.SelectedItem.ToString() == "iPhone 11 Pro 64GB")
            {
                txtBox_Prijs.Text = iPhone11PRO64GB;
            }
        }

        public void exportgridtopdf(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            // Add header 
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //Add datarow
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        private void btn_CreatePDF_Click(object sender, EventArgs e)
        {
          
            Document doc = new Document(PageSize.A4);

            try
            {

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/GVMReport.pdf", FileMode.Create));
                doc.Open();
                PdfPTable tbl = new PdfPTable(7);
                DataTable dt = new GlobalData().GetData("select * from [Table]");
                foreach (DataColumn c in dt.Columns)
                {
                    tbl.AddCell(new Phrase(c.Caption));
                }

                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                var fnt = new iTextSharp.text.Font(bf, 13.0f, 1, BaseColor.BLUE);

                foreach (DataRow row in dt.Rows)
                {
                    
                    tbl.AddCell(new Phrase(row[0].ToString()));
                    tbl.AddCell(new Phrase(row[1].ToString()));
                    tbl.AddCell(new Phrase(row[2].ToString()));
                    tbl.AddCell(new Phrase(row[3].ToString()));
                    tbl.AddCell(new Phrase(row[4].ToString()));
                    tbl.AddCell(new Phrase(row[5].ToString()));
                    tbl.AddCell(new Phrase(row[6].ToString()));


                }
                doc.Add(tbl);
                doc.Close();
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/GVMReport.pdf");
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
        
        }
    }

    
            
        

