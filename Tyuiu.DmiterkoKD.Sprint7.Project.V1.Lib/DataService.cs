using System.Reflection;

namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1.Lib
{
    public class DataService
    {
        public string OpenValue(string k)
        {
            if (k == "System.Windows.Forms.Button, Text: Плановое обслуживание")
            {
                return "Плановое обслуживание";
            }
            else if (k == "System.Windows.Forms.Button, Text: Замена масла")
            {
                return "Замена масла";
            }
            else if (k == "System.Windows.Forms.Button, Text: Заправка кондиционера")
            {
                return "Заправка кондиционера";
            }
            else if (k == "System.Windows.Forms.Button, Text: Обслуживание систем охлаждения")
            {
                return "Обслуживание систем охлаждения";
            }
            else if (k == "System.Windows.Forms.Button, Text: Ременот электронных систем")
            {
                return "Ременот электронных систем";
            }
            else if (k == "System.Windows.Forms.Button, Text: Ремонт тормозной системы")
            {
                return "Ремонт тормозной системы";
            }
            else if (k == "System.Windows.Forms.Button, Text: Ремонт двигателя")
            {
                return "Ремонт двигателя";
            }
            else
            {
                return "Ремент ходовой части";
            }
        }
        
        public int Open(string k)
        {
            if (k == "Плановое обслуживание")
            {
                return 1;
            }
            else if (k == "Замена масла")
            {
                return 2;
            }
            else if (k == "Заправка кондиционера Ремент ходовой части")
            {
                return 3;
            }
            else if (k == "Обслуживание систем охлаждения")
            {
                return 4;
            }
            else if (k == "Ременот электронных систем")
            {
                return 5;
            }
            else if (k == "Ремонт тормозной системы")
            {
                return 6;
            }
            else if (k == "Ремонт двигателя")
            {
                return 7;
            }
            else
            {
                return 8;
            }
        }
        public int Model_DKD(string k)
        {
            if (k == "RAV4" || k == "Octavia" || k == "XRAY" || k == "Aveo" || k == "X-Trail" || k == "Model 1")
            {
                return 0;
            }
            else if (k == "Rapid" || k == "Camry" || k == "Granta" || k == "Tahoe" || k == "Qashqai" || k == "Model 2")
            {
                return 1;
            }
            else if (k == "Corolla" || k == "Yeti" || k == "Kalina" || k == "Lacetti" || k == "Almera" || k == "Model 3")
            {
                return 2;
            }
            else { return 3; }
        }
        public string CollectTextFromFile(string path, int m, int k)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] matrix = new string[rows, columns];


            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToString(line_r[c]);
                }
            }

            string res = matrix[m, k];

            return res;
        }
       
    }
}
