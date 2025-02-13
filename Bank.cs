using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos
{
    internal class Bank
    {
        private int Id { get; set; }
        private double Cash { get; set; }
        private string Name { get; set; }

        public Bank(int id , string name) 
        {
            Id = id;
            Name = name;  
        }

        public double Add_Cash(double morecash)
        {
            return Cash += morecash;
        }

        public double Out_cash(double lesscash)
        {
            return Cash -= lesscash;
        }

        public override string ToString()
        {
            if (Cash == Cash)
            {
                return $"ID {Id},holder's: {Name}, Cash: ${Cash} ";
            }
            else
            {
               return $"Update Data: \nID {Id}, holder's: {Name}, Cash: ${Cash}";
            }
        }

        

    }
}
