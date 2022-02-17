
using System.Drawing;

namespace MyNamespace
{
    public abstract class Vehicle {

        // properties
        public float velocity = 0f;
        public string model = "";

        public Vehicle(string model)
        {
            this.model = model;
            Console.WriteLine($"New vehicle was created with name {model}");
        }

        // functionality or methods
        public abstract void accelerate();
        public abstract void brake();

        public virtual void showState()
        {
            Console.WriteLine("The $model is running at $velocity Km/h");
        }
    }
}
