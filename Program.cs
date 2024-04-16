using System;

namespace C__more__task_1
{
    class Car
    {
        private string name;
        private double maxSpeed;

        public Car(string name, double maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public void CompareSpeed(Car otherCar)
        {
            if (maxSpeed > otherCar.maxSpeed)
            {
                Console.Write($"\n{name} має бiльшу швидкiсть.");
            }
            else if (maxSpeed < otherCar.maxSpeed)
            {
                Console.Write($"\n{otherCar.name} має бiльшу швидкiсть.");
            }
            else
            {
                Console.Write("\nОбидва автомобiля мають однакову швидкiсть.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть назву першого автомобiля:");
            string name1 = Console.ReadLine();

            Console.Write("Введiть максимальну швидкiсть першого автомобiля:");
            double speed1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть назву другого автомобiля:");
            string name2 = Console.ReadLine();

            Console.Write("Введiть максимальну швидкiсть другого автомобiля:");
            double speed2 = Convert.ToDouble(Console.ReadLine());

            Car car1 = new Car(name1, speed1);
            Car car2 = new Car(name2, speed2);

            car1.CompareSpeed(car2);
        }
    }

}
