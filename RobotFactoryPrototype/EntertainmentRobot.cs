using System;
using System.Collections.Generic;
using System.Text;

namespace RobotFactoryPrototype.Robots
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override Robot Clone()
        {
            return new EntertainmentRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                EntertainmentFeature
            );
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("\n Entertainment Robot ");
            base.DisplayDetails();
            Console.WriteLine(
                $"Entertainment Feature : {EntertainmentFeature}"
            );
        }
    }
}