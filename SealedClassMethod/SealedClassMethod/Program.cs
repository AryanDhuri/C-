namespace SealedClassMethod
{
    class Animal
    {
        public virtual void Makessound()
        {
            Console.WriteLine("Animal Sound");
        }
    }

    class Dog : Animal
    {
        sealed public override void Makessound()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d=new Dog();
            d.Makessound();
        }
    }
}
 