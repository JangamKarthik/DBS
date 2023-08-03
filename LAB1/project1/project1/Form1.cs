using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            checkBox1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi " + textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String radioChoice, checkChoice=null;
            if (radioButton1.Checked == true)
            {
                radioChoice = radioButton1.Text;
            }
            else {
                radioChoice = radioButton2.Text;
            }

            if (checkBox1.Checked == true) {
                checkChoice = checkBox1.Text;
            }
            if (checkBox2.Checked == true) {
                checkChoice = checkBox2.Text + " , " + checkChoice;
            }
            if (checkBox3.Checked == true)
            {
                checkChoice = checkBox3.Text + " , " + checkChoice;
            }
            if (checkBox4.Checked == true)
            {
                checkChoice = checkBox4.Text + " , " + checkChoice;
            }
            Form2 obj = new Form2(textBox1.Text,textBox2.Text,radioChoice,checkChoice,comboBox1.Text);
            obj.Show();
        }
    }
}
