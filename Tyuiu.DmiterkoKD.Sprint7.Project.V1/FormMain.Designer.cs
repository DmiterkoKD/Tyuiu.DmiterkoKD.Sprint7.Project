namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonPlan_DKD = new Button();
            buttonMove_DKD = new Button();
            buttonStop_DKD = new Button();
            buttonEnergy_DKD = new Button();
            buttonSO_DKD = new Button();
            buttonFridge_DKD = new Button();
            buttonXCH_DKD = new Button();
            buttonOil_DKD = new Button();
            panel_DKD = new Panel();
            textBoxChoose_DKD = new TextBox();
            Hello_DKD = new TextBox();
            toolTip_DKD = new ToolTip(components);
            panel_DKD.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPlan_DKD
            // 
            buttonPlan_DKD.BackColor = Color.LightCyan;
            buttonPlan_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlan_DKD.Location = new Point(64, 172);
            buttonPlan_DKD.Name = "buttonPlan_DKD";
            buttonPlan_DKD.Size = new Size(200, 200);
            buttonPlan_DKD.TabIndex = 0;
            buttonPlan_DKD.Text = "Плановое обслуживание";
            toolTip_DKD.SetToolTip(buttonPlan_DKD, "Диагностика и обслуживание по нормам производителя\r\n");
            buttonPlan_DKD.UseVisualStyleBackColor = false;
            buttonPlan_DKD.Click += buttonOpenForm_Click;
            // 
            // buttonMove_DKD
            // 
            buttonMove_DKD.BackColor = Color.LightCyan;
            buttonMove_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMove_DKD.Location = new Point(539, 399);
            buttonMove_DKD.Name = "buttonMove_DKD";
            buttonMove_DKD.Size = new Size(200, 200);
            buttonMove_DKD.TabIndex = 1;
            buttonMove_DKD.Text = "Ремонт двигателя";
            toolTip_DKD.SetToolTip(buttonMove_DKD, "Проффесиональная диагностика всех типов двигателей");
            buttonMove_DKD.UseVisualStyleBackColor = false;
            buttonMove_DKD.Click += buttonOpenForm_Click;
            // 
            // buttonStop_DKD
            // 
            buttonStop_DKD.BackColor = Color.LightCyan;
            buttonStop_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStop_DKD.Location = new Point(303, 399);
            buttonStop_DKD.Name = "buttonStop_DKD";
            buttonStop_DKD.Size = new Size(200, 200);
            buttonStop_DKD.TabIndex = 2;
            buttonStop_DKD.Text = "Ремонт тормозной системы";
            toolTip_DKD.SetToolTip(buttonStop_DKD, "Диагностика и ремонт с контролем качества");
            buttonStop_DKD.UseVisualStyleBackColor = false;
            buttonStop_DKD.Click += buttonOpenForm_Click;
            // 
            // buttonEnergy_DKD
            // 
            buttonEnergy_DKD.BackColor = Color.LightCyan;
            buttonEnergy_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEnergy_DKD.Location = new Point(54, 399);
            buttonEnergy_DKD.Name = "buttonEnergy_DKD";
            buttonEnergy_DKD.Size = new Size(200, 200);
            buttonEnergy_DKD.TabIndex = 3;
            buttonEnergy_DKD.Text = "Ремонт электронных систем";
            toolTip_DKD.SetToolTip(buttonEnergy_DKD, "Комплексная проверка и ремонт на проввесиональном оборудование");
            buttonEnergy_DKD.UseVisualStyleBackColor = false;
            buttonEnergy_DKD.Click += buttonOpenForm_Click;
            // 
            // buttonSO_DKD
            // 
            buttonSO_DKD.BackColor = Color.LightCyan;
            buttonSO_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSO_DKD.Location = new Point(781, 172);
            buttonSO_DKD.Name = "buttonSO_DKD";
            buttonSO_DKD.Size = new Size(200, 200);
            buttonSO_DKD.TabIndex = 4;
            buttonSO_DKD.Text = "Обслуживание систем охлаждения";
            toolTip_DKD.SetToolTip(buttonSO_DKD, "Диагностика по чек-листу");
            buttonSO_DKD.UseVisualStyleBackColor = false;
            buttonSO_DKD.Click += buttonOpenForm_Click;
            // 
            // buttonFridge_DKD
            // 
            buttonFridge_DKD.BackColor = Color.LightCyan;
            buttonFridge_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFridge_DKD.Location = new Point(539, 172);
            buttonFridge_DKD.Name = "buttonFridge_DKD";
            buttonFridge_DKD.Size = new Size(200, 200);
            buttonFridge_DKD.TabIndex = 5;
            buttonFridge_DKD.Text = "Заправка кондиционера";
            toolTip_DKD.SetToolTip(buttonFridge_DKD, "Аппаратная замена на импортное оборудование");
            buttonFridge_DKD.UseVisualStyleBackColor = false;
            buttonFridge_DKD.Click += buttonOpenForm_Click;
            // 
            // buttonXCH_DKD
            // 
            buttonXCH_DKD.BackColor = Color.LightCyan;
            buttonXCH_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonXCH_DKD.Location = new Point(781, 399);
            buttonXCH_DKD.Name = "buttonXCH_DKD";
            buttonXCH_DKD.Size = new Size(200, 200);
            buttonXCH_DKD.TabIndex = 6;
            buttonXCH_DKD.Text = "Ремонт ходовой части";
            toolTip_DKD.SetToolTip(buttonXCH_DKD, "Диагности и ремонт по чек-листу");
            buttonXCH_DKD.UseVisualStyleBackColor = false;
            buttonXCH_DKD.Click += buttonOpenForm_Click;
            // 
            // buttonOil_DKD
            // 
            buttonOil_DKD.AutoEllipsis = true;
            buttonOil_DKD.BackColor = Color.LightCyan;
            buttonOil_DKD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOil_DKD.Location = new Point(303, 172);
            buttonOil_DKD.Name = "buttonOil_DKD";
            buttonOil_DKD.Size = new Size(200, 200);
            buttonOil_DKD.TabIndex = 7;
            buttonOil_DKD.Text = "Замена масла";
            toolTip_DKD.SetToolTip(buttonOil_DKD, "Замена масла всех деталей и систем\r\n");
            buttonOil_DKD.UseVisualStyleBackColor = false;
            buttonOil_DKD.Click += buttonOpenForm_Click;
            // 
            // panel_DKD
            // 
            panel_DKD.Controls.Add(textBoxChoose_DKD);
            panel_DKD.Controls.Add(Hello_DKD);
            panel_DKD.Controls.Add(buttonOil_DKD);
            panel_DKD.Controls.Add(buttonXCH_DKD);
            panel_DKD.Controls.Add(buttonFridge_DKD);
            panel_DKD.Controls.Add(buttonSO_DKD);
            panel_DKD.Controls.Add(buttonEnergy_DKD);
            panel_DKD.Controls.Add(buttonStop_DKD);
            panel_DKD.Controls.Add(buttonMove_DKD);
            panel_DKD.Controls.Add(buttonPlan_DKD);
            panel_DKD.Dock = DockStyle.Fill;
            panel_DKD.Location = new Point(0, 0);
            panel_DKD.Name = "panel_DKD";
            panel_DKD.Size = new Size(1000, 650);
            panel_DKD.TabIndex = 0;
            // 
            // textBoxChoose_DKD
            // 
            textBoxChoose_DKD.BackColor = Color.Azure;
            textBoxChoose_DKD.BorderStyle = BorderStyle.None;
            textBoxChoose_DKD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxChoose_DKD.Location = new Point(352, 105);
            textBoxChoose_DKD.Multiline = true;
            textBoxChoose_DKD.Name = "textBoxChoose_DKD";
            textBoxChoose_DKD.ReadOnly = true;
            textBoxChoose_DKD.Size = new Size(376, 50);
            textBoxChoose_DKD.TabIndex = 9;
            textBoxChoose_DKD.Text = "Выберите услугу, которая Вам нужна.";
            // 
            // Hello_DKD
            // 
            Hello_DKD.BackColor = Color.Azure;
            Hello_DKD.BorderStyle = BorderStyle.None;
            Hello_DKD.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Hello_DKD.Location = new Point(314, 12);
            Hello_DKD.Multiline = true;
            Hello_DKD.Name = "Hello_DKD";
            Hello_DKD.ReadOnly = true;
            Hello_DKD.Size = new Size(400, 107);
            Hello_DKD.TabIndex = 8;
            Hello_DKD.Text = "Добро пожаловать в автосервис!\r\n";
            Hello_DKD.TextAlign = HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1000, 650);
            Controls.Add(panel_DKD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            Text = "Авторемонтная мастерская";
            panel_DKD.ResumeLayout(false);
            panel_DKD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonPlan_DKD;
        private Button buttonMove_DKD;
        private Button buttonStop_DKD;
        private Button buttonEnergy_DKD;
        private Button buttonSO_DKD;
        private Button buttonFridge_DKD;
        private Button buttonXCH_DKD;
        private Button buttonOil_DKD;
        private Panel panel_DKD;
        private TextBox Hello_DKD;
        private TextBox textBoxChoose_DKD;
        private ToolTip toolTip_DKD;
    }
}
