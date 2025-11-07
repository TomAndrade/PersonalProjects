using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreDLL
{
    public class ConversorTempo
    {
        // Converta unidades de tempo.
        // 1 min = 60 sec;
        // 1 hour = 60 min;
        // 1 day = 24h;
        // 1 week = 7 days;
        // 1 month = 30 days;
        // 1 year = 365,25 days;

        public static int minToSec(int minutes)
        {
            return minutes * 60;
        }
        public static int hourToMinutes(int hours)
        {
            return hours * 60;
        }
        public static int dayToHours(int days)
        {
            return days * 24;
        }
        public static int weekToDays(int weeks)
        {
            return weeks * 7;
        }
        public static int monthToDays(int months)
        {
            return months * 30;
        }
        public static double yearToDays(double years)
        {
            return years * 365.25;
        }

    }
}
