using System;
using Ducks;

namespace SimUDuck
{
    class Program
    {
        //static void Main(string[] args)
        static void Main()
        {
            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.performFly();
            mallard.setFlyBehavior(new FlyNoWay());
            mallard.performFly();
            mallard.performQuack();
        }
    }
}
