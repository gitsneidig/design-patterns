using System;

namespace Ducks
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack quack!");
        }
    }
}