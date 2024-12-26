namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    partial class FormWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindow));
            Close_DKD = new Button();
            Help_DKD = new Button();
            comboBoxMarka_DKD = new ComboBox();
            comboBoxModel_DKD = new ComboBox();
            textBoxProbeg_DKD = new TextBox();
            textBoxyear_DKD = new TextBox();
            textBoxPrice_DKD = new TextBox();
            textBoxAdress_DKD = new TextBox();
            button2 = new Button();
            panelUp_DKD = new Panel();
            Save_DKD = new Button();
            textBoxHappend_DKD = new TextBox();
            menuStrip_DKD = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ytefhToolStripMenuItem = new ToolStripMenuItem();
            rwdghToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            руководствоToolStripMenuItem = new ToolStripMenuItem();
            yesgdhToolStripMenuItem = new ToolStripMenuItem();
            добавтьToolStripMenuItem = new ToolStripMenuItem();
            руководсвоToolStripMenuItem = new ToolStripMenuItem();
            panelLeft_DKD = new Panel();
            panelAll_DKD = new Panel();
            saveFile_DKD = new SaveFileDialog();
            toolTip_DKD = new ToolTip(components);
            panelUp_DKD.SuspendLayout();
            menuStrip_DKD.SuspendLayout();
            panelLeft_DKD.SuspendLayout();
            panelAll_DKD.SuspendLayout();
            SuspendLayout();
            // 
            // Close_DKD
            // 
            Close_DKD.BackColor = Color.Azure;
            Close_DKD.FlatAppearance.BorderSize = 0;
            Close_DKD.FlatStyle = FlatStyle.Flat;
            Close_DKD.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Close_DKD.Location = new Point(751, 3);
            Close_DKD.Name = "Close_DKD";
            Close_DKD.Size = new Size(46, 37);
            Close_DKD.TabIndex = 2;
            Close_DKD.Text = "✕";
            Close_DKD.UseVisualStyleBackColor = false;
            Close_DKD.Click += button1_Click;
            // 
            // Help_DKD
            // 
            Help_DKD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Help_DKD.Location = new Point(630, 16);
            Help_DKD.Name = "Help_DKD";
            Help_DKD.Size = new Size(60, 60);
            Help_DKD.TabIndex = 3;
            Help_DKD.Text = "?";
            toolTip_DKD.SetToolTip(Help_DKD, "Информация о разработчике");
            Help_DKD.UseVisualStyleBackColor = true;
            Help_DKD.Click += Help_DKD_Click;
            // 
            // comboBoxMarka_DKD
            // 
            comboBoxMarka_DKD.BackColor = Color.LightCyan;
            comboBoxMarka_DKD.FormattingEnabled = true;
            comboBoxMarka_DKD.Location = new Point(12, 19);
            comboBoxMarka_DKD.Name = "comboBoxMarka_DKD";
            comboBoxMarka_DKD.Size = new Size(147, 23);
            comboBoxMarka_DKD.TabIndex = 4;
            comboBoxMarka_DKD.Text = "Марка";
            comboBoxMarka_DKD.SelectedIndexChanged += comboBoxMarka_DKD_SelectedIndexChanged;
            // 
            // comboBoxModel_DKD
            // 
            comboBoxModel_DKD.BackColor = Color.LightCyan;
            comboBoxModel_DKD.FormattingEnabled = true;
            comboBoxModel_DKD.Location = new Point(12, 48);
            comboBoxModel_DKD.Name = "comboBoxModel_DKD";
            comboBoxModel_DKD.Size = new Size(147, 23);
            comboBoxModel_DKD.TabIndex = 4;
            comboBoxModel_DKD.Text = "Модель";
            // 
            // textBoxProbeg_DKD
            // 
            textBoxProbeg_DKD.BackColor = Color.LightCyan;
            textBoxProbeg_DKD.Location = new Point(12, 77);
            textBoxProbeg_DKD.Name = "textBoxProbeg_DKD";
            textBoxProbeg_DKD.Size = new Size(147, 23);
            textBoxProbeg_DKD.TabIndex = 5;
            textBoxProbeg_DKD.Tag = "";
            textBoxProbeg_DKD.Enter += TextBox_Enter;
            textBoxProbeg_DKD.Leave += TextBox_Leave;
            // 
            // textBoxyear_DKD
            // 
            textBoxyear_DKD.BackColor = Color.LightCyan;
            textBoxyear_DKD.Location = new Point(204, 19);
            textBoxyear_DKD.Name = "textBoxyear_DKD";
            textBoxyear_DKD.Size = new Size(137, 23);
            textBoxyear_DKD.TabIndex = 6;
            textBoxyear_DKD.Enter += TextBox_Enter;
            textBoxyear_DKD.Leave += TextBox_Leave;
            // 
            // textBoxPrice_DKD
            // 
            textBoxPrice_DKD.BackColor = Color.LightCyan;
            textBoxPrice_DKD.Location = new Point(25, 122);
            textBoxPrice_DKD.Multiline = true;
            textBoxPrice_DKD.Name = "textBoxPrice_DKD";
            textBoxPrice_DKD.ReadOnly = true;
            textBoxPrice_DKD.Size = new Size(336, 227);
            textBoxPrice_DKD.TabIndex = 7;
            // 
            // textBoxAdress_DKD
            // 
            textBoxAdress_DKD.BackColor = Color.LightCyan;
            textBoxAdress_DKD.Location = new Point(25, 34);
            textBoxAdress_DKD.Multiline = true;
            textBoxAdress_DKD.Name = "textBoxAdress_DKD";
            textBoxAdress_DKD.ReadOnly = true;
            textBoxAdress_DKD.Size = new Size(297, 330);
            textBoxAdress_DKD.TabIndex = 8;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(204, 57);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 10;
            toolTip_DKD.SetToolTip(button2, "Выполнить расчет ");
            button2.UseVisualStyleBackColor = true;
            button2.Click += textBoxPrice_DKD_TextChanged;
            // 
            // panelUp_DKD
            // 
            panelUp_DKD.Controls.Add(textBoxHappend_DKD);
            panelUp_DKD.Controls.Add(menuStrip_DKD);
            panelUp_DKD.Controls.Add(Close_DKD);
            panelUp_DKD.Controls.Add(Help_DKD);
            panelUp_DKD.Dock = DockStyle.Top;
            panelUp_DKD.Location = new Point(0, 0);
            panelUp_DKD.Name = "panelUp_DKD";
            panelUp_DKD.Size = new Size(800, 86);
            panelUp_DKD.TabIndex = 11;
            // 
            // Save_DKD
            // 
            Save_DKD.Image = (Image)resources.GetObject("Save_DKD.Image");
            Save_DKD.Location = new Point(281, 57);
            Save_DKD.Name = "Save_DKD";
            Save_DKD.Size = new Size(60, 60);
            Save_DKD.TabIndex = 13;
            toolTip_DKD.SetToolTip(Save_DKD, "Сохранить все расчитанную информацию в файл");
            Save_DKD.UseVisualStyleBackColor = true;
            Save_DKD.Click += buttonsave;
            // 
            // textBoxHappend_DKD
            // 
            textBoxHappend_DKD.BackColor = Color.LightCyan;
            textBoxHappend_DKD.BorderStyle = BorderStyle.None;
            textBoxHappend_DKD.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxHappend_DKD.Location = new Point(25, 16);
            textBoxHappend_DKD.Multiline = true;
            textBoxHappend_DKD.Name = "textBoxHappend_DKD";
            textBoxHappend_DKD.ReadOnly = true;
            textBoxHappend_DKD.Size = new Size(418, 52);
            textBoxHappend_DKD.TabIndex = 12;
            textBoxHappend_DKD.TextAlign = HorizontalAlignment.Center;
            // 
            // menuStrip_DKD
            // 
            menuStrip_DKD.Dock = DockStyle.None;
            menuStrip_DKD.GripStyle = ToolStripGripStyle.Visible;
            menuStrip_DKD.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip_DKD.Location = new Point(472, 29);
            menuStrip_DKD.Name = "menuStrip_DKD";
            menuStrip_DKD.Size = new Size(121, 28);
            menuStrip_DKD.TabIndex = 13;
            menuStrip_DKD.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.LightCyan;
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ytefhToolStripMenuItem, rwdghToolStripMenuItem, yesgdhToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(109, 24);
            toolStripMenuItem1.Text = "База данных";
            // 
            // ytefhToolStripMenuItem
            // 
            ytefhToolStripMenuItem.BackColor = Color.LightCyan;
            ytefhToolStripMenuItem.Name = "ytefhToolStripMenuItem";
            ytefhToolStripMenuItem.Size = new Size(241, 24);
            ytefhToolStripMenuItem.Text = "Перейти к папке";
            ytefhToolStripMenuItem.Click += перейтиКПапкеToolStripMenuItem_Click;
            // 
            // rwdghToolStripMenuItem
            // 
            rwdghToolStripMenuItem.BackColor = Color.LightCyan;
            rwdghToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, руководствоToolStripMenuItem });
            rwdghToolStripMenuItem.Name = "rwdghToolStripMenuItem";
            rwdghToolStripMenuItem.Size = new Size(241, 24);
            rwdghToolStripMenuItem.Text = "Добавить свою модель";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.BackColor = Color.Azure;
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(164, 24);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьмодельToolStripMenuItem_Click;
            // 
            // руководствоToolStripMenuItem
            // 
            руководствоToolStripMenuItem.BackColor = Color.Azure;
            руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            руководствоToolStripMenuItem.Size = new Size(164, 24);
            руководствоToolStripMenuItem.Text = "Руководство";
            руководствоToolStripMenuItem.Click += руководствомодельToolStripMenuItem_Click;
            // 
            // yesgdhToolStripMenuItem
            // 
            yesgdhToolStripMenuItem.BackColor = Color.LightCyan;
            yesgdhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавтьToolStripMenuItem, руководсвоToolStripMenuItem });
            yesgdhToolStripMenuItem.Name = "yesgdhToolStripMenuItem";
            yesgdhToolStripMenuItem.Size = new Size(241, 24);
            yesgdhToolStripMenuItem.Text = "Добавить свою марку";
            // 
            // добавтьToolStripMenuItem
            // 
            добавтьToolStripMenuItem.BackColor = Color.Azure;
            добавтьToolStripMenuItem.Name = "добавтьToolStripMenuItem";
            добавтьToolStripMenuItem.Size = new Size(158, 24);
            добавтьToolStripMenuItem.Text = "Добавть";
            добавтьToolStripMenuItem.Click += добавитьфирмуToolStripMenuItem1_Click;
            // 
            // руководсвоToolStripMenuItem
            // 
            руководсвоToolStripMenuItem.BackColor = Color.Azure;
            руководсвоToolStripMenuItem.Name = "руководсвоToolStripMenuItem";
            руководсвоToolStripMenuItem.Size = new Size(158, 24);
            руководсвоToolStripMenuItem.Text = "Руководсво";
            руководсвоToolStripMenuItem.Click += руководствомаркуToolStripMenuItem1_Click;
            // 
            // panelLeft_DKD
            // 
            panelLeft_DKD.Controls.Add(Save_DKD);
            panelLeft_DKD.Controls.Add(comboBoxMarka_DKD);
            panelLeft_DKD.Controls.Add(comboBoxModel_DKD);
            panelLeft_DKD.Controls.Add(textBoxProbeg_DKD);
            panelLeft_DKD.Controls.Add(button2);
            panelLeft_DKD.Controls.Add(textBoxPrice_DKD);
            panelLeft_DKD.Controls.Add(textBoxyear_DKD);
            panelLeft_DKD.Dock = DockStyle.Left;
            panelLeft_DKD.Location = new Point(0, 86);
            panelLeft_DKD.Name = "panelLeft_DKD";
            panelLeft_DKD.Size = new Size(423, 364);
            panelLeft_DKD.TabIndex = 11;
            // 
            // panelAll_DKD
            // 
            panelAll_DKD.Controls.Add(textBoxAdress_DKD);
            panelAll_DKD.Dock = DockStyle.Fill;
            panelAll_DKD.Location = new Point(423, 86);
            panelAll_DKD.Name = "panelAll_DKD";
            panelAll_DKD.Size = new Size(377, 364);
            panelAll_DKD.TabIndex = 11;
            // 
            // FormWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(panelAll_DKD);
            Controls.Add(panelLeft_DKD);
            Controls.Add(panelUp_DKD);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormWindow";
            Text = "FormWindow";
            Load += Form2_Load;
            panelUp_DKD.ResumeLayout(false);
            panelUp_DKD.PerformLayout();
            menuStrip_DKD.ResumeLayout(false);
            menuStrip_DKD.PerformLayout();
            panelLeft_DKD.ResumeLayout(false);
            panelLeft_DKD.PerformLayout();
            panelAll_DKD.ResumeLayout(false);
            panelAll_DKD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Close_DKD;
        private Button Help_DKD;
        private ComboBox comboBoxMarka_DKD;
        private ComboBox comboBoxModel_DKD;
        private TextBox textBoxProbeg_DKD;
        private TextBox textBoxyear_DKD;
        private TextBox textBoxPrice_DKD;
        private TextBox textBoxAdress_DKD;
        private Button button2;
        private Panel panelUp_DKD;
        private Panel panelLeft_DKD;
        private Panel panelAll_DKD;
        private TextBox textBoxHappend_DKD;
        private Button Save_DKD;
        private SaveFileDialog saveFile_DKD;
        private ToolTip toolTip_DKD;
        private MenuStrip menuStrip_DKD;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ytefhToolStripMenuItem;
        private ToolStripMenuItem rwdghToolStripMenuItem;
        private ToolStripMenuItem yesgdhToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem руководствоToolStripMenuItem;
        private ToolStripMenuItem добавтьToolStripMenuItem;
        private ToolStripMenuItem руководсвоToolStripMenuItem;
    }
}