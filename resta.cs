using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resta_get_y_set
{
    class resta
    {
        private int num1;
        private int num2;


        public int Nume1
        {
            get => num1; set => num1 = value;
        }
        public int Nume2
        {
            get => num2; set => num2 = value;
        }


        public int Resta()
        {
            return (num1 - num2);
        }
    }
}
