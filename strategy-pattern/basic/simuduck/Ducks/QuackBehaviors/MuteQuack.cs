using System;

namespace Ducks
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Alas, I cannot quack!");
        }
    }
}