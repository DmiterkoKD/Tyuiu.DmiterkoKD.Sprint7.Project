using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Tyuiu.DmiterkoKD.Sprint7.Project.V1.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Diagnostics;
namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    public partial class FormWindow : Form
    {
        private string placeholderText1 = "Пробег"; // Текст подсказки для первого TextBox
        private string placeholderText2 = "Год выпуска"; // Текст подсказки для второго TextBox
        DataService ds = new DataService();
        private string m = "";
        
        
        public string Txt
        {
            get { return m; }
            set { m = value;}
        }

        public FormWindow()
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializePlaceholders();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Устанавливаем текст в TextBox при загрузке формы
            textBoxHappend_DKD.Text = m;
        }
        private void InitializePlaceholders()
        {
            // Настройка первого TextBox
            textBoxProbeg_DKD.Text = placeholderText1; // Устанавливаем текст подсказки
            textBoxProbeg_DKD.ForeColor = System.Drawing.Color.Gray; // Устанавливаем цвет текста подсказки
            textBoxProbeg_DKD.Enter += TextBox_Enter;
            textBoxProbeg_DKD.Leave += TextBox_Leave;

            // Настройка второго TextBox
            textBoxyear_DKD.Text = placeholderText2; // Устанавливаем текст подсказки
            textBoxyear_DKD.ForeColor = System.Drawing.Color.Gray; // Устанавливаем цвет текста подсказки
            textBoxyear_DKD.Enter += TextBox_Enter;
            textBoxyear_DKD.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var textBox = sender as System.Windows.Forms.TextBox; // Получаем ссылку на текущий TextBox

            if (textBox != null && textBox.Text == placeholderText1 || textBox.Text == placeholderText2)
            {
                textBox.Text = ""; // Очищаем текст при фокусе
                textBox.ForeColor = System.Drawing.Color.Black; // Меняем цвет текста на черный
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == textBoxProbeg_DKD)
                {
                    textBox.Text = placeholderText1; // Восстанавливаем текст подсказки для первого TextBox
                }
                else if (textBox == textBoxyear_DKD)
                {
                    textBox.Text = placeholderText2; // Восстанавливаем текст подсказки для второго TextBox
                }
                textBox.ForeColor = System.Drawing.Color.Gray; // Меняем цвет текста на серый
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Help_DKD_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }
        private void InitializeComboBoxes()
        {
            comboBoxMarka_DKD.Items.Add("Toyota");
            comboBoxMarka_DKD.Items.Add("Skoda");
            comboBoxMarka_DKD.Items.Add("Lada");
            comboBoxMarka_DKD.Items.Add("Chevrolet");
            comboBoxMarka_DKD.Items.Add("Nissan");
            comboBoxMarka_DKD.Items.Add("YourMarka");

            comboBoxModel_DKD.Enabled = false;
        }

        private void comboBoxMarka_DKD_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, выбран ли элемент в первом ComboBox
            if (comboBoxMarka_DKD.SelectedIndex >= 0) // Если выбран элемент, отличный от "Select a brand"
            {
                comboBoxModel_DKD.Enabled = true; // Активируем второй ComboBox
                switch (comboBoxMarka_DKD.SelectedItem.ToString())
                {
                    case "Toyota":
                        comboBoxModel_DKD.Items.Add("RAV4");
                        comboBoxModel_DKD.Items.Add("Camry");
                        comboBoxModel_DKD.Items.Add("Corolla");
                        break;
                    case "Skoda":
                        comboBoxModel_DKD.Items.Add("Octavia");
                        comboBoxModel_DKD.Items.Add("Rapid");
                        comboBoxModel_DKD.Items.Add("Yeti");
                        break;
                    case "Lada":
                        comboBoxModel_DKD.Items.Add("XRAY");
                        comboBoxModel_DKD.Items.Add("Granta");
                        comboBoxModel_DKD.Items.Add("Kalina");
                        break;
                    case "Chevrolet":
                        comboBoxModel_DKD.Items.Add("Aveo");
                        comboBoxModel_DKD.Items.Add("Tahoe");
                        comboBoxModel_DKD.Items.Add("Lacetti");
                        break;
                    case "Nissan":
                        comboBoxModel_DKD.Items.Add("X-Trail");
                        comboBoxModel_DKD.Items.Add("Qashqai");
                        comboBoxModel_DKD.Items.Add("Almera");
                        break;
                    case "YourMarka":
                        comboBoxModel_DKD.Items.Add("Marka1");
                        comboBoxModel_DKD.Items.Add("Marka2");
                        comboBoxModel_DKD.Items.Add("Marka3");
                        break;
                }
            }
            else
            {
                comboBoxModel_DKD.Enabled = false; // Деактивируем второй ComboBox
            }
        }

        private void textBoxPrice_DKD_TextChanged(object sender, EventArgs e)
        {
            string s = comboBoxModel_DKD.SelectedItem.ToString();
            int m1 = ds.Model_DKD(s);
            int d = ds.Open(m);     
            string name = Convert.ToString(comboBoxMarka_DKD.Text);
            string path = $@"File\{name}InPutFile.csv";
            string res = ds.CollectTextFromFile(path, m1, d);
            textBoxPrice_DKD.Text = $"Стоимость услуги '{m}' для {name} {s} будет от {res} рублей";
            textBoxAdress_DKD.Text = "Адреса для устранения проблемы:\r\nУлица Ленина, 12\r\nПроспект Мира, 45\r\nУлица Пушкина, 23\r\nПереулок Садовый, 5\r\nШоссе Энтузиастов, 78\r\n\r\nДля уточнения: +7-919-952-07-12";
        }
        private void buttonsave(object sender, EventArgs e)
        {
            string marka = comboBoxMarka_DKD.Text;
            string model = comboBoxModel_DKD.Text;

            // Настраиваем диалог для сохранения файла
            saveFile_DKD.FileName = $"{marka}_{model}_File.csv"; // Добавляем символ "_" для лучшей читаемости
            saveFile_DKD.InitialDirectory = Directory.GetCurrentDirectory();

            // Показываем диалог и проверяем результат
            if (saveFile_DKD.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFile_DKD.FileName; // Получаем путь к файлу
                FileInfo fileInfo = new FileInfo(filePath);

                // Если файл существует, удаляем его
                if (fileInfo.Exists)
                {
                    File.Delete(filePath);
                }

                // Создаем строку с данными для записи
                string dataToAppend = $"{marka}{Environment.NewLine}{model}{Environment.NewLine}{textBoxPrice_DKD.Text}{Environment.NewLine}{textBoxAdress_DKD.Text}{Environment.NewLine}";

                try
                {
                    // Записываем данные в файл
                    File.AppendAllText(filePath, dataToAppend);
                    MessageBox.Show("Данные успешно сохранены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
                }
            }

        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void перейтиКПапкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"File";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии проводника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void руководствомодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuidModel formGuideModel = new FormGuidModel();
            formGuideModel.Show();
        }

        private void добавитьмодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"File";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии проводника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void руководствомаркуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGuidMarka formGuidCompany = new FormGuidMarka();
            formGuidCompany.Show();
        }

        private void добавитьфирмуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string folderPath = @"Tyuiu.DmiterkoKD.Sprint7";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии проводника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}