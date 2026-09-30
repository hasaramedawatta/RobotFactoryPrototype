using System;

namespace RobotFactoryPrototype.Robots
{
    public class IndustrialRobot : Robot
    {
        
        public string IndustrialTask { get; set; }

        
        public IndustrialRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        
        public override Robot Clone()
        {
            return new IndustrialRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                IndustrialTask
            );
        }

       
        public override void DisplayDetails()
        {
            Console.WriteLine("\n INDUSTRIAL ROBOT ");

            base.DisplayDetails();

            Console.WriteLine($"Industrial Task  : {IndustrialTask}");
        }
    }
}