using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_resultHarvest.Visible = false;
            label_middleHarvest1.Visible = false;
            label_middleHarvest2.Visible = false;
            label_middleHarvest3.Visible = false;
            laberl_resultHarvestGeneral.Visible = false;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            textBox_harvest1.Text = String.Empty;
            textBox_harvest2.Text = String.Empty;
            textBox_harvest3.Text = String.Empty;
            textBox_area1.Text = String.Empty;
            textBox_area2.Text = String.Empty;
            textBox_area3.Text = String.Empty;
            label_result.Visible = false;

            label_resultHarvest.Visible = false;
            label_middleHarvest1.Visible = false;
            label_middleHarvest2.Visible = false;
            label_middleHarvest3.Visible = false;
            laberl_resultHarvestGeneral.Visible = false;
        }

        private void button_area_Click(object sender, EventArgs e)
        {
            float harvest1 = 0;
            float harvest2 = 0;
            float harvest3 = 0;

            float area1 = 0;
            float area2 = 0;
            float area3 = 0;

            double result = 0;

            string str_harvest1 = textBox_harvest1.Text;
            string str_harvest2 = textBox_harvest2.Text;
            string str_harvest3 = textBox_harvest3.Text;

            string str_area1 = textBox_area1.Text;
            string str_area2 = textBox_area2.Text;
            string str_area3 = textBox_area3.Text;
            

            if (   !float.TryParse(str_harvest1, out harvest1)
                || !float.TryParse(str_harvest2, out harvest2)
                || !float.TryParse(str_harvest3, out harvest3)
                || !float.TryParse(str_area1, out area1)
                || !float.TryParse(str_area2, out area2)
                || !float.TryParse(str_area3, out area3)
                )
            {
                MessageBox.Show($"Неправильно введений текст {str_harvest2}");
                button_delete_Click(null, EventArgs.Empty);
                return;
            }
            else
            {
                float.TryParse(textBox_harvest1.Text, out float covHarvest1);
                float.TryParse(textBox_area1.Text, out float covArea1);

                label_middleHarvest1.Text = $"Вороржайність культури на першому полі: {covHarvest1 * covArea1}";

                //////
                float.TryParse(textBox_harvest2.Text, out float covHarvest2);
                float.TryParse(textBox_area2.Text, out float covArea2);

                label_middleHarvest2.Text = $"Вороржайність культури на другому полі: {covHarvest2 * covArea2}";
                ///////
                ///
                float.TryParse(textBox_harvest3.Text, out float covHarvest3);
                float.TryParse(textBox_area3.Text, out float covArea3);

                label_middleHarvest3.Text = $"Вороржайність культури на третьому полі: {covHarvest3 * covArea3}";

                //////

                laberl_resultHarvestGeneral.Text = $"Загальна врожайність культури на трьох полях: {Math.Round(((double) ((covHarvest1 * covArea1 + covHarvest2 * covArea2 + covHarvest3 * covArea3)/3.0)),2)}";



                label_resultHarvest.Visible = true;
                label_middleHarvest1.Visible = true;
                label_middleHarvest2.Visible = true;
                label_middleHarvest3.Visible = true;
                laberl_resultHarvestGeneral.Visible = true;
            }


        }

        

        private void button_swichForm_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }

       
    }
}
