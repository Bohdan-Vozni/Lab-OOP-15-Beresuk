using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_15
{
    public partial class UserControl_Name : UserControl
    {
        public UserControl_Name()
        {
            InitializeComponent();
            hideInfo();

            textBox_name.KeyDown += textBox_name_KeyDown;   // Прив'язуємо подію KeyDown до textBox_name
        }

        private void UserControl_Name_Load(object sender, EventArgs e)
        {

        }
        public void hideInfo()
        {
            textBox_name.Text = String.Empty;
            label_resultName.Visible = false;
            label_countSymbol_name.Visible = false;

        }


        private void textBox_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  
            {
                button_ok.PerformClick(); // Викликаємо подію кнопки натискання
                e.Handled = true; // Запобігаємо подальшій обробці події
            }
        }

        private void button_ok_Click_1(object sender, EventArgs e)
        {
            string str = textBox_name.Text;

            if (str == String.Empty) hideInfo();
            else
            {
                string[] result = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = String.Empty;
                string surName = String.Empty;

                try
                {
                    name = new string(result[0].Reverse().ToArray());
                    surName = new string(result[1].Reverse().ToArray());
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильний формат введених даних");    
                    
                }
                
                label_resultName.Text = $"Слова в зворотньому порядку: {name} {surName}";
                label_countSymbol_name.Text = $"Кількість символів: {str.Length}";

                label_resultName.Visible = true;
                label_countSymbol_name.Visible = true;
                
                

            }
        }
    }
}
