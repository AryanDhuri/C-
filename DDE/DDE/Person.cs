namespace DataEncapsulationDemo
{

    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 && value < 100)
                    age = value;
                else
                    Console.WriteLine("Invalid age. Age must be between 0 and 100.");




            }
        }

    }
}
