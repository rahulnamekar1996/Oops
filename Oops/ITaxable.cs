using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
     public interface ITaxable
    {
        double PayTax();  // public ,absract ,virtual

    }
    public class job : ITaxable
    {
        private Double sallary;
        private double taxamount;

        public job()
        {
            sallary = 10000;
        }

        public double PayTax()
        {
            taxamount = sallary * 0.20;
            return taxamount;
        }
    }
    public class Buisiness : ITaxable
    {
        private Double sallary;
        private double taxamount;

        public Buisiness()
        {
            sallary = 10000;
        }

        public double PayTax()
        {
            taxamount = sallary * 0.30;
            return taxamount;
        }
    }

}
