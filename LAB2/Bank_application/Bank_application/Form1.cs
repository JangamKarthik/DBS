using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_application
{
    public partial class Form1 : Form
    {
        public String name;
        public Customer c;
        public Form1()
        {
            InitializeComponent();
            c = new Customer("xyz","abc123","1234",12,11,"12/12/12");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2(name,c);
            obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }
    }
   
}
