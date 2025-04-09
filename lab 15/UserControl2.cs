using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab_15
{
    public partial class UserControl_String : UserControl
    {
        internal string path = @"D:\NUBIP\2_course\2_term\OOP\Program\Lab15\File1.txt";
        public UserControl_String()
        {
            InitializeComponent();

            // greate file if dont exist
            if (!File.Exists(path)) using (FileStream sw = new FileStream(path, FileMode.Create));
            textBox_nameFile.Text = path;
                                   
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void button_changeName_file_Click(object sender, EventArgs e)
        {
            path = textBox_nameFile.Text;

            if (File.Exists(path)) // try open file 
            {
                MessageBox.Show("Існує такий фалй!");
            }
            else MessageBox.Show("Не існує такого файла");

        }

        private void button_addFile_Click(object sender, EventArgs e)
        {
            if (path != textBox_nameFile.Text)
            {
                MessageBox.Show("Ви не натиснули кнопку змінити файл");

            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(textBox_inputText.Text);
                }

                textBox_inputText.Text = String.Empty;
            }            
        }

        private void button_readFile_Click(object sender, EventArgs e)
        {
            if (path != textBox_nameFile.Text)
            {
                MessageBox.Show("Ви не натиснули кнопку змінити файл");

            }

            if (File.Exists(path))
            {
                textBox_resultRead.Text = String.Empty;
                using (StreamReader sr = new StreamReader(path: path))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        textBox_resultRead.Text += line + Environment.NewLine; ;
                        line = sr.ReadLine();
                    }

                }
            }
            else MessageBox.Show("Не існує такого файла");
        }
    }
}
