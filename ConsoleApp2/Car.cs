
using System.Drawing;

namespace MyNamespace
{
    public class Car : Vehicle
    {
        // Properties
        private int WheelsNumber = 0;
        public float CabinTemperature = 0;

        public Car(int wheelsNumber,string model) : base(model)
        {
            this.WheelsNumber = wheelsNumber;
        }
     
        public override void accelerate()
        {
            velocity += 5;
        }

        public override void brake()
        {
            velocity -= 10;
        }
    }  
}
