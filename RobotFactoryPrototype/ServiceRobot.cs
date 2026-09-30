using System;

namespace RobotFactoryPrototype.Robots
{
    public class ServiceRobot : Robot
    {
        
        public string ServiceTask { get; set; }

        
        public ServiceRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        
        public override Robot Clone()
        {
            return new ServiceRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                ServiceTask
            );
        }

        
        public override void DisplayDetails()
        {
            Console.WriteLine("\nSERVICE ROBOT");

            base.DisplayDetails();

            Console.WriteLine($"Service Task     : {ServiceTask}");
        }
    }
}