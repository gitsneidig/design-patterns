using System;

namespace Ducks
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Sqeak squeak!");
        }
    }
}