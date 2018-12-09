using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Creditcard
    {
        private string name;
        private string number;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Number
        {
            get
            {
                string x;
                x = number.Substring(number.Length - 4);
                return x;
            }
            set
            {
                number = value;
            }
        }

        public Creditcard()
        {
            name = null;
            number = null;
        }
        ~Creditcard()
        {

        }
    }
}
