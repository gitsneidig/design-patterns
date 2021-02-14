using System;

namespace Ducks
{
    public abstract class Duck
    {
	    public IFlyBehavior flyBehavior;
	    public IQuackBehavior quackBehavior;
        public Duck() {
        }

        public abstract void display();

        public void performFly() {
            flyBehavior.fly();
        }

        public void performQuack() {
            quackBehavior.quack();
        }

        public void setFlyBehavior(IFlyBehavior fb) {
            flyBehavior = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb) {
            quackBehavior = qb;
        }

        public void swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }

       
    }
}