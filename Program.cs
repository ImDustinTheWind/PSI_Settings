// Program06
// Program.cs
// code by Dustin Sherer

using System;
using static System.Console;

namespace Program06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the PrintRequirement() method to output a line
            PrintRequirement(1);
            WriteLine("\nWelcome to Assignment 06 - <Dustin Sherer>");


            /******************************************************************************************************/
            // Create three instance fields in Program.cs: : lowPSISetting, highPSISetting, and desiredPSI.
            /******************************************************************************************************/
            PrintRequirement(2);

            WriteLine("Requirement 2 in the comments.");

            float lowPSISetting = 10;
            float highPSISetting = 45;
            float desiredPSI = 0;

            float storeLowPSI;
            float storeHighPSI;

            /******************************************************************************************************/
            // Create a local method in Program.cs named ChangeAirPressure(). See
            //     SayHello() in the chapter Static and Parameters for an analogy.
            /******************************************************************************************************/
            PrintRequirement(3);

            WriteLine("Requirement 3 in the comments.");

            /******************************************************************************************************/
            // . ChangeAirPressure() specifics:
            // a.Call ChangeAirPressure() such that lowPSISetting can be changed by
            //      the method but highPSISetting cannot. Include the parameter
            //      desiredPSI that can be changed by the method but does not have to
            //      be set before the call.
            // b.Ask user to enter desiredPSI.
            // c.Check that desiredPSI is within the range between lowPSISetting and highPSISetting.
            // d.Report status of the range check back to the user.
            // e.Ask user if s / he would like to change lowPSISetting, if so, change it
            //      and check again to determine if desiredPSI is within the range.
            /******************************************************************************************************/
            PrintRequirement(4);

            // prep for requirement 5
            storeLowPSI = lowPSISetting;
            storeHighPSI = highPSISetting;

            // 4.a
            ChangeAirPressure(ref lowPSISetting, highPSISetting, out desiredPSI);

            /******************************************************************************************************/
            //Back in Program.cs, show the effect of on lowPSISetting, highPSISetting, and
            //      desiredPSI before and after the call to ChangeAirPressure().
            /******************************************************************************************************/
            PrintRequirement(5);

            // low, high, desired -> Before
            DisplayMessage("Yellow", "\n\tBefore call to ChangAirPresure*");
            WriteLine("lowPSISetting = {0}", storeLowPSI);
            WriteLine("highPSISetting = {0}", storeHighPSI);
            WriteLine("desiredPSI has no value");

            // low, high, desired -> After
            DisplayMessage("Yellow", "\n\tAfter call to ChangAirPresure*");
            WriteLine("lowPSISetting = {0}", lowPSISetting);
            WriteLine("highPSISetting = {0}", highPSISetting);
            WriteLine("desiredPSI = {0}", desiredPSI);

            /******************************************************************************************************/
            //Create a class named Alarm with the following:
            // a.Contains no constructors
            // b.Member to record how many times the alarm is sounded.
            // c.Method SoundAlarm() which outputs alarm messages to the console
            //      that the alarm has been sounded. Each message should contain the
            //      colors: red, white, and blue.
            // d.Method GetAlarmCount() to return the alarm count.
            /******************************************************************************************************/
            PrintRequirement(6);

            WriteLine("Requirement 6 in the comments of Alarm.cs");

            /******************************************************************************************************/
            //Back in Program.cs, ask the user if they would like to sound the alarm, if so,
            //sound the alarm. Continue to ask and sound the alarm until the user enters: NO.
            /******************************************************************************************************/
            PrintRequirement(7);

            string sAlarm;

            // ask user if they would like to sound the alarm
            Write("\nWould you like to sound the alarm? Enter 'NO' to stop the alarm: ");
            sAlarm = ReadLine();
            
            // alarm will sound as many times user enters 'y'
            while(!(sAlarm == "NO"))
            {
                Alarm.SoundAlarm();

                Write("\nWould you like the alarm to sound again? ");
                sAlarm = ReadLine();
            }

            // printout number of times alarm was sounded
            WriteLine("The alarm was sounded {0} times.", Alarm.GetAlarmCount());

            /******************************************************************************************************/
            // Thank you Message
            /******************************************************************************************************/
            PrintRequirement(8);
            WriteLine("\nThank you for running Program06.");

            /******************************************************************************************************/
            // Experience
            /******************************************************************************************************/
            PrintRequirement(6);
            WriteLine("Before this assignment I had been a little curious how 'TryParse()' functioned the way it did. But after working through this assignment, it sure does make a lot more sense.");

            ForegroundColor = ConsoleColor.White;
            WriteLine("\nPress any key to proceed.");
            ReadKey(true);
        }


        /******************************************************************************************************/
        // Requirements 3 & 4
        /******************************************************************************************************/
        static void ChangeAirPressure(ref float lowPSISetting, float highPSISetting, out float desiredPSI)
        {
            char change;
            float storeLowSetting;

            // 4.b
            //ask user for desired PSI
            Write("Please enter the desired PSI: ");
            float.TryParse(ReadLine(), out desiredPSI);

            // 4.c & 4.d
            //compare desired PSI to low/high range
            if(desiredPSI >= lowPSISetting && desiredPSI <= highPSISetting)
            {
                WriteLine("\nDesired PSI is within range.");
            }
            else if(desiredPSI < lowPSISetting)
            {
                WriteLine("\nDesired PSI is below range.");
            }
            else if (desiredPSI < highPSISetting)
            {
                WriteLine("\nDesired PSI is above range.");
            }
            else
            {
                WriteLine("\nDesired PSI is out of range or invalid.");
            }

            // 4.e
            //ask user if they would like to change low psi setting
            Write("\nWould you like to adjust the low PSI Setting? (y/n): ");
            change = ReadLine()[0];

            if(change == 'y')
            {
                storeLowSetting = lowPSISetting;

                Write("\nPlease enter new low PSI setting: ");
                float.TryParse(ReadLine(), out lowPSISetting);

                if(lowPSISetting > highPSISetting)
                {
                    WriteLine("\nLow PSI setting can not be greater than high PSI setting, low PSI setting will remain unchanged.");
                    lowPSISetting = storeLowSetting;
                }
                else if(lowPSISetting < 0)
                {
                    WriteLine("\nLow PSI setting can not be less than 0 PSI, low PSI setting will remain unchanged.");
                    lowPSISetting = storeLowSetting;
                }
                else
                {
                    WriteLine("\nLow PSI setting changed to {0}", lowPSISetting);
                }

                // compare again and update, if adjusted low PSI puts desired PSI in range
                if (desiredPSI >= lowPSISetting && desiredPSI <= highPSISetting)
                {
                    WriteLine("\nAfter Low PSI setting adjustment, desired PSI is within range.");
                }
                else if (desiredPSI < lowPSISetting)
                {
                    WriteLine("\nAfter Low PSI setting adjustment, desired PSI is below range.");
                }
                else if (desiredPSI < highPSISetting)
                {
                    WriteLine("\nAfter Low PSI setting adjustment, desired PSI is above range.");
                }
                else
                {
                    WriteLine("\nAfter Low PSI setting adjustment, desired PSI is out of range or invalid.");
                }

                return;
            }
            else if(change == 'n')
            {
                WriteLine("\nLow PSI setting will remain unchanged.");
            }
            else
            {
                WriteLine("\nInvalid entry, low PSI setting will remain unchanged.");
            }
            return;
        }

        static void PrintRequirement(int reqNum)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"\nRequiremenet {reqNum}");
            ResetColor();
        }

        static void DisplayMessage(string color, string message)
        {
            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
            WriteLine(message);
            ResetColor();
        }
    }
}
