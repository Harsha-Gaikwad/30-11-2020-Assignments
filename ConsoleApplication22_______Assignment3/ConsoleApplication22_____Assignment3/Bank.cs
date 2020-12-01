using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22_____Assignment3
{
    class Bank
    {
        double NetBalance=50000;
        double transamount;
       

        public void deposit()
        {
           NetBalance  = NetBalance + transamount;
            Console.WriteLine(NetBalance);
        }

        public void withdrawal()
        {
            NetBalance = NetBalance - transamount;
            Console.WriteLine(NetBalance);
        }

        public  Bank(double transamount)
        {
            this.transamount = transamount;
        }
        public double Netbalance
        {
            get
            {
                return NetBalance;
            }
            set
            {
                NetBalance = value;
            }
        }
    }
}
