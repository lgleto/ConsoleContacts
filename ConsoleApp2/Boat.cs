
using System.Drawing;

namespace MyNamespace
{
    public class Boat : Vehicle
    {
        public Boat(string model) : base(model)
        {
            
        }
        
        public override void accelerate()
        {
            velocity += 2;
        }

        public override void brake()
        {
            velocity -= 1;
        }

        public override void showState()
        {
            Console.WriteLine($"The Boat $model is running at {velocity} Miles/h");
        }
    }  
}
