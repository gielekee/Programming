namespace GVM_Repair_Test_2
{
    partial class Form2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_Display2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxModel_Nieuw = new System.Windows.Forms.ComboBox();
            this.txtBox_Serie_Nieuw = new System.Windows.Forms.TextBox();
            this.txtBox_Prijs_Nieuw = new System.Windows.Forms.TextBox();
            this.txtBox_Naam_Nieuw = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_IDnr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_LaadFoto_Nieuw = new System.Windows.Forms.Button();
            this.txtBox_URL_Nieuw = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(399, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(695, 309);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_Display2
            // 
            this.btn_Display2.Location = new System.Drawing.Point(399, 12);
            this.btn_Display2.Name = "btn_Display2";
            this.btn_Display2.Size = new System.Drawing.Size(95, 25);
            this.btn_Display2.TabIndex = 31;
            this.btn_Display2.Text = "Display";
            this.btn_Display2.UseVisualStyleBackColor = true;
            this.btn_Display2.Click += new System.EventHandler(this.btn_Display2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Naam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Serienummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Prijs:    €";
            // 
            // cBoxModel_Nieuw
            // 
            this.cBoxModel_Nieuw.FormattingEnabled = true;
            this.cBoxModel_Nieuw.Items.AddRange(new object[] {
            "iPhone 8 64GB",
            "iPhone 8 128GB",
            "iPhone XR 64GB",
            "iPhone XR 128GB",
            "iPhone 11 64GB"});
            this.cBoxModel_Nieuw.Location = new System.Drawing.Point(156, 99);
            this.cBoxModel_Nieuw.Name = "cBoxModel_Nieuw";
            this.cBoxModel_Nieuw.Size = new System.Drawing.Size(208, 24);
            this.cBoxModel_Nieuw.TabIndex = 34;
            // 
            // txtBox_Serie_Nieuw
            // 
            this.txtBox_Serie_Nieuw.Location = new System.Drawing.Point(156, 70);
            this.txtBox_Serie_Nieuw.Name = "txtBox_Serie_Nieuw";
            this.txtBox_Serie_Nieuw.Size = new System.Drawing.Size(208, 22);
            this.txtBox_Serie_Nieuw.TabIndex = 25;
            // 
            // txtBox_Prijs_Nieuw
            // 
            this.txtBox_Prijs_Nieuw.Location = new System.Drawing.Point(156, 131);
            this.txtBox_Prijs_Nieuw.Name = "txtBox_Prijs_Nieuw";
            this.txtBox_Prijs_Nieuw.Size = new System.Drawing.Size(208, 22);
            this.txtBox_Prijs_Nieuw.TabIndex = 26;
            // 
            // txtBox_Naam_Nieuw
            // 
            this.txtBox_Naam_Nieuw.Location = new System.Drawing.Point(156, 40);
            this.txtBox_Naam_Nieuw.Name = "txtBox_Naam_Nieuw";
            this.txtBox_Naam_Nieuw.Size = new System.Drawing.Size(208, 22);
            this.txtBox_Naam_Nieuw.TabIndex = 24;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(12, 399);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(127, 39);
            this.btn_Update.TabIndex = 32;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(109, 12);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(25, 17);
            this.lbl_ID.TabIndex = 35;
            this.lbl_ID.Text = "ID:";
            // 
            // lbl_IDnr
            // 
            this.lbl_IDnr.AutoSize = true;
            this.lbl_IDnr.Location = new System.Drawing.Point(153, 12);
            this.lbl_IDnr.Name = "lbl_IDnr";
            this.lbl_IDnr.Size = new System.Drawing.Size(0, 17);
            this.lbl_IDnr.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btn_LaadFoto_Nieuw
            // 
            this.btn_LaadFoto_Nieuw.Location = new System.Drawing.Point(250, 355);
            this.btn_LaadFoto_Nieuw.Name = "btn_LaadFoto_Nieuw";
            this.btn_LaadFoto_Nieuw.Size = new System.Drawing.Size(114, 28);
            this.btn_LaadFoto_Nieuw.TabIndex = 38;
            this.btn_LaadFoto_Nieuw.Text = "Bladeren...";
            this.btn_LaadFoto_Nieuw.UseVisualStyleBackColor = true;
            this.btn_LaadFoto_Nieuw.Click += new System.EventHandler(this.btn_LaadFoto_Nieuw_Click);
            // 
            // txtBox_URL_Nieuw
            // 
            this.txtBox_URL_Nieuw.Location = new System.Drawing.Point(13, 357);
            this.txtBox_URL_Nieuw.Name = "txtBox_URL_Nieuw";
            this.txtBox_URL_Nieuw.Size = new System.Drawing.Size(231, 22);
            this.txtBox_URL_Nieuw.TabIndex = 39;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.txtBox_URL_Nieuw);
            this.Controls.Add(this.btn_LaadFoto_Nieuw);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_IDnr);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.cBoxModel_Nieuw);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Display2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtBox_Prijs_Nieuw);
            this.Controls.Add(this.txtBox_Serie_Nieuw);
            this.Controls.Add(this.txtBox_Naam_Nieuw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "Form2";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_Display2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxModel_Nieuw;
        private System.Windows.Forms.TextBox txtBox_Serie_Nieuw;
        private System.Windows.Forms.TextBox txtBox_Prijs_Nieuw;
        private System.Windows.Forms.TextBox txtBox_Naam_Nieuw;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_IDnr;
        private System.Windows.Forms.Button btn_LaadFoto_Nieuw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBox_URL_Nieuw;
    }
}