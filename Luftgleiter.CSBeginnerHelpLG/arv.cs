using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftgleiter.CSBeginnerHelpLG
{
    public class arv
    {
        private string _TextARV;
        private double _NumARV;
        private bool Number;
        public static implicit operator arv(string input)
        {
            arv ARVINPUT = new arv();
            //throw new NotImplementedException();
            if (input != " ")
            {
                try
                {
                    ARVINPUT._NumARV = Convert.ToDouble(input);
                    ARVINPUT.Number = true;
                }
                catch
                {
                    ARVINPUT._TextARV = input;
                    ARVINPUT.Number = false;
                }
            }
            if (ARVINPUT.Number == false)
                return ARVINPUT._TextARV;
            else return Convert.ToString(ARVINPUT._NumARV);
        }

        public static implicit operator arv(int input)
        {
            arv ARVINPUT = new arv();
            //throw new NotImplementedException();

            ARVINPUT._NumARV = Convert.ToDouble(input);


            if (ARVINPUT.Number == false)
                return ARVINPUT._TextARV;
            else return Convert.ToString(ARVINPUT._NumARV);
        }

        public static implicit operator arv(float input)
        {
            arv ARVINPUT = new arv();
            //throw new NotImplementedException();


            ARVINPUT._NumARV = Convert.ToDouble(input);
            ARVINPUT.Number = true;


            if (ARVINPUT.Number == false)
                return ARVINPUT._TextARV;

            else return Convert.ToString(ARVINPUT._NumARV);
        }

        public static implicit operator arv(double input)
        {
            arv ARVINPUT = new arv();
            //throw new NotImplementedException();


            ARVINPUT._NumARV = Convert.ToDouble(input);


            if (ARVINPUT.Number == false)
                return ARVINPUT._TextARV;
            else return Convert.ToString(ARVINPUT._NumARV);
        }

        public static implicit operator arv(bool input)
        {
            arv ARVINPUT = new arv();
            //throw new NotImplementedException();         
            ARVINPUT._TextARV = Convert.ToString(input);
            ARVINPUT.Number = false;
            return ARVINPUT._TextARV;
        }
    }

    public class Test_arv
    {

    }
}
