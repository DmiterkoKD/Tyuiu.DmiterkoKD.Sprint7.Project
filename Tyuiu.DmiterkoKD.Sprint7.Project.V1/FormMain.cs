using System.Xml.Linq;
using Tyuiu.DmiterkoKD.Sprint7.Project.V1.Lib;
namespace Tyuiu.DmiterkoKD.Sprint7.Project.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonOpenForm_Click(object sender, EventArgs e)
        {                
            DataService ds = new DataService();
            string m = Convert.ToString(sender);
            string k = ds.OpenValue(m);
            //System.Windows.Forms.Button, Text: Замена масла
            FormWindow fn = new FormWindow();
            fn.Txt = k;           
            fn.Show();
            this.Hide();
        }
    }
}
