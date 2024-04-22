using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public  interface Interface1
    {
        int Variable {  get;  }
    }

    abstract class AbstractC
    {
        protected int Variable;
        public abstract void Set(int value);
    }
     class ChildC : AbstractC, Interface1
    {
        private int variable2;

        public ChildC(int value2)
        {
            variable2 = value2;
        }

        int Interface1.Variable
        {
            get 
            { 
                
                return variable2 + Variable;
            }
        }

        public override void Set(int value)
        {
            Variable = value;
        }

       /* static void Main(string[] args)
        {
            ChildC c1 = new ChildC(6);
            c1.Set(10);
            int result = c1.Variable;
            Console.WriteLine("Addition = "+result);


        }*/
    }
}
