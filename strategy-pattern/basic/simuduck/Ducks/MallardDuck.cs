using System;

namespace Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();      
      }

        public override void display()
        {
            Console.Write("I am a mallard duck! \n");
        }
    }
}