using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Interface
{
    interface IIfc1
    {
        string PrintOut(string s);
    }

    internal class Myclass: IIfc1
    {
        public string PrintOut(string s)
        {  
            return s; 
        }


    }

}
