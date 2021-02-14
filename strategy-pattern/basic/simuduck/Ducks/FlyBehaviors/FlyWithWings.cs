using System;

namespace Ducks
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I believe I can fly!");
        }
    }
}