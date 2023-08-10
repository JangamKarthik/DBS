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
    public partial class Form2 : Form
    {
        String name;
        Customer c2;
        public void getvalues(Customer c) { 
        
        }
        public Form2(String name,Customer c2)
        {
            InitializeComponent();
            this.name = name;
            this.c2=c2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = c2.id;

            label2.Text = name;
        }
    }
}
