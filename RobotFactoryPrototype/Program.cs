using System;
using RobotFactoryPrototype.Robots;

namespace RobotFactoryPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("ROBOT FACTORY SYSTEM");
            Console.WriteLine("PROTOTYPE DESIGN PATTERN");
            


            

            ServiceRobot servicePrototype = new ServiceRobot(
                "SR-100",
                10,
                "1.0",
                "Assist Hospital Patients"
            );

            IndustrialRobot industrialPrototype = new IndustrialRobot(
                "IR-200",
                15,
                "2.0",
                "Welding"
            );

            EntertainmentRobot entertainmentPrototype =
                new EntertainmentRobot(
                    "ER-300",
                    8,
                    "1.5",
                    "Dance and Interact with Visitors"
                );


            

            Console.WriteLine("\n\nORIGINAL ROBOT PROTOTYPES");

            servicePrototype.DisplayDetails();
            industrialPrototype.DisplayDetails();
            entertainmentPrototype.DisplayDetails();


            
            

            ServiceRobot clonedServiceRobot =
                (ServiceRobot)servicePrototype.Clone();

            
            clonedServiceRobot.ModelName = "SR-101";
            clonedServiceRobot.BatteryCapacity = 12;
            clonedServiceRobot.SoftwareVersion = "1.1";
            clonedServiceRobot.ServiceTask =
                "Assist Hotel Guests";


            

            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)industrialPrototype.Clone();

            
            clonedIndustrialRobot.ModelName = "IR-201";
            clonedIndustrialRobot.BatteryCapacity = 20;
            clonedIndustrialRobot.SoftwareVersion = "2.1";
            clonedIndustrialRobot.IndustrialTask =
                "Assembly";


            

            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)entertainmentPrototype.Clone();

          
            clonedEntertainmentRobot.ModelName = "ER-301";
            clonedEntertainmentRobot.BatteryCapacity = 10;
            clonedEntertainmentRobot.SoftwareVersion = "1.6";
            clonedEntertainmentRobot.EntertainmentFeature =
                "Sing and Interact with Visitors";



            Console.WriteLine("\n\n CUSTOMIZED CLONED ROBOTS ");

            clonedServiceRobot.DisplayDetails();
            clonedIndustrialRobot.DisplayDetails();
            clonedEntertainmentRobot.DisplayDetails();



            Console.WriteLine(
                "\n\nORIGINAL ROBOTS AFTER CLONING"
            );

            servicePrototype.DisplayDetails();
            industrialPrototype.DisplayDetails();
            entertainmentPrototype.DisplayDetails();


            
            Console.WriteLine("     ROBOTS CLONED SUCCESSFULLY!");
            

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}