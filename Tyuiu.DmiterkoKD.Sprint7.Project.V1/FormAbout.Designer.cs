namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_DKD = new PictureBox();
            OK_DKD = new Button();
            labelInfo_DKD = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DKD).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_DKD
            // 
            pictureBox_DKD.Image = (Image)resources.GetObject("pictureBox_DKD.Image");
            pictureBox_DKD.Location = new Point(68, 55);
            pictureBox_DKD.Name = "pictureBox_DKD";
            pictureBox_DKD.Size = new Size(249, 326);
            pictureBox_DKD.TabIndex = 1;
            pictureBox_DKD.TabStop = false;
            // 
            // OK_DKD
            // 
            OK_DKD.Location = new Point(484, 316);
            OK_DKD.Name = "OK_DKD";
            OK_DKD.Size = new Size(137, 65);
            OK_DKD.TabIndex = 2;
            OK_DKD.Text = "OK";
            OK_DKD.UseVisualStyleBackColor = true;
            OK_DKD.Click += OK_DKD_Click;
            // 
            // labelInfo_DKD
            // 
            labelInfo_DKD.AutoSize = true;
            labelInfo_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_DKD.Location = new Point(356, 118);
            labelInfo_DKD.Name = "labelInfo_DKD";
            labelInfo_DKD.Size = new Size(387, 140);
            labelInfo_DKD.TabIndex = 3;
            labelInfo_DKD.Text = "Разработчик Дмитерко К.Д.\r\nгруппа ИБКСб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка С#\r\n \r\nТюменский индустриальный университет 2024\r\nВысшая школа цифровых технологий 2024\r\n";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(labelInfo_DKD);
            Controls.Add(OK_DKD);
            Controls.Add(pictureBox_DKD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox_DKD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox_DKD;
        private Button OK_DKD;
        private Label labelInfo_DKD;
    }
}