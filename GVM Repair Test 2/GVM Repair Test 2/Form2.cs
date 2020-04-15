using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Net;

namespace GVM_Repair_Test_2
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Giel\Documents\DB_GVMREPAIR.mdf;Integrated Security = True; Connect Timeout = 30");
        private int selectedRow;
        string imgLocation = "";
        public Form2()
        {
            InitializeComponent();
        }
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID, Naam, Serienummer, Model, Prijs, URL from [Table]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();

        }

        private void btn_Display2_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            connection.Open();
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Table] set Naam = '" + txtBox_Naam_Nieuw.Text + "', Serienummer = '" + txtBox_Serie_Nieuw.Text + "', Model = '" + cBoxModel_Nieuw.Text + "', Prijs = '" + txtBox_Prijs_Nieuw.Text + "', URL = '" + txtBox_Prijs_Nieuw.Text + "', Afbeelding = @images where ID = '" + lbl_IDnr.Text + "'";
            cmd.Parameters.Add("@images", SqlDbType.Image).Value = images;
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data();
            MessageBox.Show("Data geupdate");
        }

        private void btn_LaadFoto_Nieuw_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlg.FileName.ToString();
                txtBox_URL_Nieuw.Text = imgLocation;
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                
                
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                lbl_IDnr.Text = row.Cells["ID"].Value.ToString();
                txtBox_Naam_Nieuw.Text = row.Cells["Naam"].Value.ToString();
                txtBox_Serie_Nieuw.Text = row.Cells["Serienummer"].Value.ToString();
                cBoxModel_Nieuw.Text = row.Cells["Model"].Value.ToString();
                txtBox_Prijs_Nieuw.Text = row.Cells["Prijs"].Value.ToString();         
                txtBox_URL_Nieuw.Text = row.Cells["URL"].Value.ToString();
                pictureBox1.ImageLocation = txtBox_URL_Nieuw.Text;


                /*byte[] img = (byte[])dataGridView2.CurrentRow.Cells["Afbeelding"].Value;

                if (img == null)
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Giel\Pictures\no_image.png");
                }
                else
                {
                   MemoryStream ms = new MemoryStream(img);

                }
                */

            }
        }
    }
}
