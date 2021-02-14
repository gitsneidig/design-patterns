using System;

namespace Ducks
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("There is no way I can fly!");
        }
    }
}