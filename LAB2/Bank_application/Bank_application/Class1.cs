using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application
{
    public class Customer
    {
        public String name;
        public String id;
        String pass;
        int accno;
        int bal;
        String lad;

        public Customer(String name, String id, String pass, int accno, int bal, String lad)
        {
            this.name = name;
            this.id = id;
            this.pass = pass;
            this.accno = accno;
            this.bal = bal;
            this.lad = lad;
        }
    }
}
