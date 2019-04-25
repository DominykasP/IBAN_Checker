namespace IBANCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIBAN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCheckEntered = new MetroFramework.Controls.MetroTile();
            this.lblEnteredResult = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtFile = new MetroFramework.Controls.MetroTextBox();
            this.btnSelectFile = new MetroFramework.Controls.MetroTile();
            this.lblFileResult = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(356, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(263, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Check if the entered IBAN is valid";
            // 
            // txtIBAN
            // 
            // 
            // 
            // 
            this.txtIBAN.CustomButton.Image = null;
            this.txtIBAN.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.txtIBAN.CustomButton.Name = "";
            this.txtIBAN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIBAN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIBAN.CustomButton.TabIndex = 1;
            this.txtIBAN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIBAN.CustomButton.UseSelectable = true;
            this.txtIBAN.CustomButton.Visible = false;
            this.txtIBAN.Lines = new string[0];
            this.txtIBAN.Location = new System.Drawing.Point(71, 146);
            this.txtIBAN.MaxLength = 32767;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.PasswordChar = '\0';
            this.txtIBAN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIBAN.SelectedText = "";
            this.txtIBAN.SelectionLength = 0;
            this.txtIBAN.SelectionStart = 0;
            this.txtIBAN.ShortcutsEnabled = true;
            this.txtIBAN.Size = new System.Drawing.Size(247, 23);
            this.txtIBAN.TabIndex = 1;
            this.txtIBAN.UseSelectable = true;
            this.txtIBAN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIBAN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "IBAN:";
            // 
            // btnCheckEntered
            // 
            this.btnCheckEntered.ActiveControl = null;
            this.btnCheckEntered.Location = new System.Drawing.Point(23, 189);
            this.btnCheckEntered.Name = "btnCheckEntered";
            this.btnCheckEntered.Size = new System.Drawing.Size(295, 48);
            this.btnCheckEntered.TabIndex = 2;
            this.btnCheckEntered.Text = "Check";
            this.btnCheckEntered.UseSelectable = true;
            this.btnCheckEntered.Click += new System.EventHandler(this.btnCheckEntered_Click);
            // 
            // lblEnteredResult
            // 
            this.lblEnteredResult.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEnteredResult.Location = new System.Drawing.Point(23, 280);
            this.lblEnteredResult.Name = "lblEnteredResult";
            this.lblEnteredResult.Size = new System.Drawing.Size(295, 147);
            this.lblEnteredResult.Style = MetroFramework.MetroColorStyle.Green;
            this.lblEnteredResult.TabIndex = 6;
            this.lblEnteredResult.Text = "nan";
            this.lblEnteredResult.UseCustomForeColor = true;
            this.lblEnteredResult.Visible = false;
            this.lblEnteredResult.WrapToLine = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(472, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(237, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Check if IBANs in file are valid";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(472, 148);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "File:";
            // 
            // txtFile
            // 
            // 
            // 
            // 
            this.txtFile.CustomButton.Image = null;
            this.txtFile.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txtFile.CustomButton.Name = "";
            this.txtFile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFile.CustomButton.TabIndex = 1;
            this.txtFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFile.CustomButton.UseSelectable = true;
            this.txtFile.CustomButton.Visible = false;
            this.txtFile.Enabled = false;
            this.txtFile.Lines = new string[] {
        "Please select a file"};
            this.txtFile.Location = new System.Drawing.Point(510, 146);
            this.txtFile.MaxLength = 32767;
            this.txtFile.Name = "txtFile";
            this.txtFile.PasswordChar = '\0';
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFile.SelectedText = "";
            this.txtFile.SelectionLength = 0;
            this.txtFile.SelectionStart = 0;
            this.txtFile.ShortcutsEnabled = true;
            this.txtFile.Size = new System.Drawing.Size(267, 23);
            this.txtFile.TabIndex = 6;
            this.txtFile.Text = "Please select a file";
            this.txtFile.UseSelectable = true;
            this.txtFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.ActiveControl = null;
            this.btnSelectFile.Location = new System.Drawing.Point(472, 189);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(305, 48);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "Select a file";
            this.btnSelectFile.UseSelectable = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblFileResult
            // 
            this.lblFileResult.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFileResult.Location = new System.Drawing.Point(472, 280);
            this.lblFileResult.Name = "lblFileResult";
            this.lblFileResult.Size = new System.Drawing.Size(305, 147);
            this.lblFileResult.Style = MetroFramework.MetroColorStyle.Green;
            this.lblFileResult.TabIndex = 6;
            this.lblFileResult.Text = "nan";
            this.lblFileResult.UseCustomForeColor = true;
            this.lblFileResult.Visible = false;
            this.lblFileResult.WrapToLine = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFileResult);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblEnteredResult);
            this.Controls.Add(this.btnCheckEntered);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtIBAN);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "IBAN validator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIBAN;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnCheckEntered;
        private MetroFramework.Controls.MetroLabel lblEnteredResult;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtFile;
        private MetroFramework.Controls.MetroTile btnSelectFile;
        private MetroFramework.Controls.MetroLabel lblFileResult;
    }
}

