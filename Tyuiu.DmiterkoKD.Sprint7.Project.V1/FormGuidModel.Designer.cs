namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    partial class FormGuidModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuidModel));
            labelTwo_DKD = new Label();
            labelFour_DKD = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelZero_DKD = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            Close_DKD = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // labelTwo_DKD
            // 
            labelTwo_DKD.AutoSize = true;
            labelTwo_DKD.Font = new Font("Segoe UI", 11F);
            labelTwo_DKD.Location = new Point(12, 251);
            labelTwo_DKD.Name = "labelTwo_DKD";
            labelTwo_DKD.Size = new Size(781, 60);
            labelTwo_DKD.TabIndex = 1;
            labelTwo_DKD.Text = resources.GetString("labelTwo_DKD.Text");
            // 
            // labelFour_DKD
            // 
            labelFour_DKD.AutoSize = true;
            labelFour_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFour_DKD.Location = new Point(12, 524);
            labelFour_DKD.Name = "labelFour_DKD";
            labelFour_DKD.Size = new Size(746, 40);
            labelFour_DKD.TabIndex = 3;
            labelFour_DKD.Text = "После внесения изменений в файл нажмите \"Файл\" в верхнем меню Блокнота. Выберите \"Сохранить\" и \r\nзакройте файл.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 108);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 325);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(628, 50);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // labelZero_DKD
            // 
            labelZero_DKD.AutoSize = true;
            labelZero_DKD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelZero_DKD.Location = new Point(12, 27);
            labelZero_DKD.Name = "labelZero_DKD";
            labelZero_DKD.Size = new Size(107, 21);
            labelZero_DKD.TabIndex = 8;
            labelZero_DKD.Text = "Руководство";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(764, 40);
            label1.TabIndex = 9;
            label1.Text = "Найдите и нажмите на кнопку \"Добавить\". После нажатия кнопки \"Добавить\" откроется новое окно. В этом\r\n окне вы увидите файлы с доступными моделями автомобилей.";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 471);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(419, 50);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 378);
            label2.Name = "label2";
            label2.Size = new Size(700, 80);
            label2.TabIndex = 12;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Close_DKD
            // 
            Close_DKD.BackColor = Color.Azure;
            Close_DKD.FlatAppearance.BorderSize = 0;
            Close_DKD.FlatStyle = FlatStyle.Flat;
            Close_DKD.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Close_DKD.Location = new Point(742, 11);
            Close_DKD.Name = "Close_DKD";
            Close_DKD.Size = new Size(46, 37);
            Close_DKD.TabIndex = 13;
            Close_DKD.Text = "✕";
            Close_DKD.UseVisualStyleBackColor = false;
            Close_DKD.Click += Close_DKD_Click;
            // 
            // FormGuidModel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 584);
            Controls.Add(Close_DKD);
            Controls.Add(label2);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(labelZero_DKD);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(labelFour_DKD);
            Controls.Add(labelTwo_DKD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGuidModel";
            Text = "Руководство";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTwo_DKD;
        private Label labelFour_DKD;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label labelZero_DKD;
        private Label label1;
        private PictureBox pictureBox5;
        private Label label2;
        private Button Close_DKD;
    }
}