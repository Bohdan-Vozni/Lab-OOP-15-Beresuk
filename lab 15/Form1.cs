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

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            textBox_side.Text = String.Empty;
            textBox_small_basis.Text = String.Empty;
            textBox_large_basis.Text = String.Empty;
            label_result.Visible = false;
        }

        private void button_area_Click(object sender, EventArgs e)
        {
            float side = 0;
            float small_basis = 0;
            float large_basis = 0;
            double result = 0;

            string str_side = textBox_side.Text;
            string str_small_basis = textBox_small_basis.Text;
            string str_large_basis = textBox_large_basis.Text;

            if (!float.TryParse(str_side, out side)
                || !float.TryParse(str_small_basis, out small_basis)
                || !float.TryParse(str_large_basis, out large_basis)
                )
            {
                MessageBox.Show($"Неправильно введений текст {str_small_basis}");
                button_delete_Click(null, EventArgs.Empty);
                return;
            }
            else
            {
                if (large_basis < small_basis + 2 * side)
                {
                    double h = Math.Sqrt(Math.Pow(side, 2) - Math.Pow(((large_basis - small_basis) / 2), 2));
                    result = ((large_basis + small_basis) / 2) * h;
                    label_result.Visible = true;
                    label_result.Text = $"Площа: {result:F3}";
                }
                else
                {
                    MessageBox.Show($"не існує такої трапеції");
                    button_delete_Click(null, EventArgs.Empty);
                    return;
                }
            }


        }

        private void button_perimeter_Click(object sender, EventArgs e)
        {
            float side = 0;
            float small_basis = 0;
            float large_basis = 0;
            double result = 0;

            string str_side = textBox_side.Text;
            string str_small_basis = textBox_small_basis.Text;
            string str_large_basis = textBox_large_basis.Text;

            if (!float.TryParse(str_side, out side)
                || !float.TryParse(str_small_basis, out small_basis)
                || !float.TryParse(str_large_basis, out large_basis)
                )
            {
                MessageBox.Show($"Неправильно введений текст {str_small_basis}");
                button_delete_Click(null, EventArgs.Empty);
                return;
            }
            else
            {
                if (large_basis < small_basis + 2 * side)
                {
                    result = 2 * side + small_basis + large_basis;
                    label_result.Visible = true;
                    label_result.Text = $"Периметер: {result}";
                }
                else
                {
                    MessageBox.Show($"не існує такої трапеції");
                    button_delete_Click(null, EventArgs.Empty);
                    return;
                }                
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
