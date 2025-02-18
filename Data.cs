using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos
{
    internal class Data
    {
        public string projetos { get; set; }
        public string tipos { get; set; }       
        public string status { get; set; }
        public decimal centavos { get; set; }


        public DateTime date_init { get; set; }
        public DateTime date_done { get; set; }
        public DateTime date_expect { get; set; }


    }
}
