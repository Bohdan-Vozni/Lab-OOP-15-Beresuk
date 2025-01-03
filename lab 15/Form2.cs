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

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_swichForm_firstProgram_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_switchName_Click(object sender, EventArgs e)
        {
            userControl_Name.Visible = true;
            userControl_String1.Visible = false;

        }

        private void button_switchString_Click(object sender, EventArgs e)
        {
            
            userControl_Name.Visible = false;
            userControl_String1.Visible = true;
        }
    }
}
