//Program06
//Alarm.cs
//code by Dustin Sherer

using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Program06
{
    // Requirement 6
    class Alarm
    {
        public static int alarmCount;

        public static void SoundAlarm()
        {
            ForegroundColor = ConsoleColor.Red;
            Write("\nTHE ");
            ForegroundColor = ConsoleColor.White;
            Write("ALARM ");
            ForegroundColor = ConsoleColor.Blue;
            Write("HAS SOUNDED!");
            ResetColor();

            alarmCount++;
        }
        public static int GetAlarmCount()
        {
            return alarmCount;
        }
    }
}
