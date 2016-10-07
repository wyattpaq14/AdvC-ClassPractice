using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    public class ValueInput
    {
        private string val1;
        private string val2;

        //Empty constructor
        public ValueInput() { } 

        //Constructor
        public ValueInput(string val1, string val2)
        {
            this.Val1 = val1;
            this.Val2 = val2;
        }

        //Properties
        public string Val1
        {
            get
            {
                return val1;
            }
            set
            {
                val1 = value;
            }
        }
        
        public string Val2
        {
            get
            {
                return val2;
            }
            set
            {
                val2 = value;
            }

        }

        //Method

        public string getValues()
        {
            return "val 1:" + val1 + "      Val2: " + val2;
        }



    }
}
