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
    public partial class Form2 : Form
    {
        String msg,name,rc,cbc,cb;
        public Form2(String msg, String name, String rc, String cbc, String cb) 
        {
            InitializeComponent();
            this.msg = msg;
            this.name = name;
            this.rc = rc;
            this.cbc = cbc;
            this.cb = cb;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "your info: \n\n" + "Message: " + msg + "\n\n" + "Name: " + name + "\n\n" + "gender: " + rc + "\n\n" + "hobbies: " + cbc + "\n\n" + "state: " + cb;
        }
    }
}
