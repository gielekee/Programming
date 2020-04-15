namespace GVM_Repair_Test_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_Naam = new System.Windows.Forms.TextBox();
            this.txtBox_Serie = new System.Windows.Forms.TextBox();
            this.txtBox_Prijs = new System.Windows.Forms.TextBox();
            this.lbl_Naam = new System.Windows.Forms.Label();
            this.lbl_Serie = new System.Windows.Forms.Label();
            this.cBox_Model = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Juist = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxModel = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_LaadFoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CreatePDF = new System.Windows.Forms.Button();
            this.txtBox_URL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_Naam
            // 
            this.txtBox_Naam.Location = new System.Drawing.Point(128, 10);
            this.txtBox_Naam.Name = "txtBox_Naam";
            this.txtBox_Naam.Size = new System.Drawing.Size(208, 22);
            this.txtBox_Naam.TabIndex = 0;
            // 
            // txtBox_Serie
            // 
            this.txtBox_Serie.Location = new System.Drawing.Point(128, 40);
            this.txtBox_Serie.Name = "txtBox_Serie";
            this.txtBox_Serie.Size = new System.Drawing.Size(208, 22);
            this.txtBox_Serie.TabIndex = 1;
            this.txtBox_Serie.TextChanged += new System.EventHandler(this.txtBox_Serie_TextChanged);
            // 
            // txtBox_Prijs
            // 
            this.txtBox_Prijs.Location = new System.Drawing.Point(128, 116);
            this.txtBox_Prijs.Name = "txtBox_Prijs";
            this.txtBox_Prijs.Size = new System.Drawing.Size(208, 22);
            this.txtBox_Prijs.TabIndex = 3;
            // 
            // lbl_Naam
            // 
            this.lbl_Naam.AutoSize = true;
            this.lbl_Naam.Location = new System.Drawing.Point(51, 14);
            this.lbl_Naam.Name = "lbl_Naam";
            this.lbl_Naam.Size = new System.Drawing.Size(49, 17);
            this.lbl_Naam.TabIndex = 4;
            this.lbl_Naam.Text = "Naam:";
            // 
            // lbl_Serie
            // 
            this.lbl_Serie.AutoSize = true;
            this.lbl_Serie.Location = new System.Drawing.Point(4, 43);
            this.lbl_Serie.Name = "lbl_Serie";
            this.lbl_Serie.Size = new System.Drawing.Size(96, 17);
            this.lbl_Serie.TabIndex = 5;
            this.lbl_Serie.Text = "Serienummer:";
            // 
            // cBox_Model
            // 
            this.cBox_Model.AutoSize = true;
            this.cBox_Model.Location = new System.Drawing.Point(50, 88);
            this.cBox_Model.Name = "cBox_Model";
            this.cBox_Model.Size = new System.Drawing.Size(50, 17);
            this.cBox_Model.TabIndex = 6;
            this.cBox_Model.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prijs:    €";
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(162, 265);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(208, 22);
            this.txtBox_Search.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(128, 229);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 30);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(226, 229);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(92, 30);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(692, 12);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(92, 30);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(376, 261);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(92, 30);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(692, 261);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(92, 30);
            this.btn_Display.TabIndex = 13;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 255);
            this.dataGridView1.TabIndex = 14;
            // 
            // lbl_Juist
            // 
            this.lbl_Juist.AutoSize = true;
            this.lbl_Juist.ForeColor = System.Drawing.Color.Red;
            this.lbl_Juist.Location = new System.Drawing.Point(95, 64);
            this.lbl_Juist.Name = "lbl_Juist";
            this.lbl_Juist.Size = new System.Drawing.Size(245, 17);
            this.lbl_Juist.TabIndex = 16;
            this.lbl_Juist.Text = "Het maximaal aantal tekens is bereikt!";
            this.lbl_Juist.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Zoek op naam:";
            // 
            // cBoxModel
            // 
            this.cBoxModel.FormattingEnabled = true;
            this.cBoxModel.Items.AddRange(new object[] {
            "iPhone 8 64GB",
            "iPhone 8 128GB",
            "iPhone XR 64GB",
            "iPhone XR 128GB",
            "iPhone 11 64GB",
            "iPhone 11 Pro 64GB"});
            this.cBoxModel.Location = new System.Drawing.Point(128, 85);
            this.cBoxModel.Name = "cBoxModel";
            this.cBoxModel.Size = new System.Drawing.Size(208, 24);
            this.cBoxModel.TabIndex = 18;
            this.cBoxModel.SelectedIndexChanged += new System.EventHandler(this.cBoxModel_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(417, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_LaadFoto
            // 
            this.btn_LaadFoto.Location = new System.Drawing.Point(453, 219);
            this.btn_LaadFoto.Name = "btn_LaadFoto";
            this.btn_LaadFoto.Size = new System.Drawing.Size(105, 26);
            this.btn_LaadFoto.TabIndex = 20;
            this.btn_LaadFoto.Text = "Bladeren...";
            this.btn_LaadFoto.UseVisualStyleBackColor = true;
            this.btn_LaadFoto.Click += new System.EventHandler(this.btn_LaadFoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Foto Klant";
            // 
            // btn_CreatePDF
            // 
            this.btn_CreatePDF.Location = new System.Drawing.Point(671, 205);
            this.btn_CreatePDF.Name = "btn_CreatePDF";
            this.btn_CreatePDF.Size = new System.Drawing.Size(113, 40);
            this.btn_CreatePDF.TabIndex = 22;
            this.btn_CreatePDF.Text = "Maak PDF";
            this.btn_CreatePDF.UseVisualStyleBackColor = true;
            this.btn_CreatePDF.Click += new System.EventHandler(this.btn_CreatePDF_Click);
            // 
            // txtBox_URL
            // 
            this.txtBox_URL.Location = new System.Drawing.Point(401, 194);
            this.txtBox_URL.Name = "txtBox_URL";
            this.txtBox_URL.Size = new System.Drawing.Size(210, 22);
            this.txtBox_URL.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 560);
            this.Controls.Add(this.txtBox_URL);
            this.Controls.Add(this.btn_CreatePDF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_LaadFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cBoxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Juist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtBox_Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBox_Model);
            this.Controls.Add(this.lbl_Serie);
            this.Controls.Add(this.lbl_Naam);
            this.Controls.Add(this.txtBox_Prijs);
            this.Controls.Add(this.txtBox_Serie);
            this.Controls.Add(this.txtBox_Naam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Naam;
        private System.Windows.Forms.TextBox txtBox_Serie;
        private System.Windows.Forms.TextBox txtBox_Prijs;
        private System.Windows.Forms.Label lbl_Naam;
        private System.Windows.Forms.Label lbl_Serie;
        private System.Windows.Forms.Label cBox_Model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Juist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxModel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_LaadFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CreatePDF;
        private System.Windows.Forms.TextBox txtBox_URL;
    }
}

