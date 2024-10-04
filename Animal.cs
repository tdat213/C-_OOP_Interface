using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_Interface
{
    interface IliveBirth
    {
        string BabyCall();
    }
    internal class Animal
    {
    }

    class Cat : Animal, IliveBirth
    {
        string IliveBirth.BabyCall()
        {
            return "mew mew";
        }
    }

    class Dog : Animal, IliveBirth
    {
        string IliveBirth.BabyCall()
        {
            return "miu miu";
        }
    }

    class Bird : Animal
    {
    }
}
