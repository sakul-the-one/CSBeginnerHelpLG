using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBeginnerHelpLG
{
    public class arv
    {
        public string arvs;
          
        public void SetValue(int Value) 
        {
            arvs = Convert.ToString(Value);
        }
        public void SetValue(float Value)
        {
            arvs = Convert.ToString(Value);
        }
        public void SetValue(double Value)
        {
            arvs = Convert.ToString(Value);
        }
        public void SetValue(string Value)
        {
           arvs = Value;
        }
        public void SetValue(bool Value)
        {
            arvs = Convert.ToString(Value);
        }
        public string convertToString() 
        {
            return arvs;
        }
        public double convertTodouble()
        {
            double Numb = Convert.ToDouble(arvs); 
            return  Numb;
        }
        public bool convertToBool() 
        {
            // bool boool = Convert.ToBoolean(arvs);
            bool boool;
            if (arvs == "true" || arvs == "TRue" || arvs == "True") 
            {
                boool = true;
                return boool;
            }
            else 
            {
                boool = false;
                return boool;
            }
        }
        
        public  void AddValue(double Value)
        {
                double arvss = Convert.ToDouble(Value);
                arvs += arvss;
        }
        public void AddValue(string Value)
        {
                arvs += Value;
        }
 
        public void TakeValue(double Value)
        {
            double arvss = Convert.ToDouble(arvs);
            arvss -= Value;
            arvs = Convert.ToString(arvss);
        }
    }
}
