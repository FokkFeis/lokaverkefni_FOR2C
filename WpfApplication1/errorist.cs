using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class canBuy : Exception
    {
        public canBuy()
            : base("Illegal operation for a Non Bool number")
        {
            // empty body                                      
        } // end default constructor 
        public canBuy(string messageValue)
            : base(messageValue)
        {
            // empty body                                     
        } // end one-argument constructor 
    }
}
