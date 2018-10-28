using System;
using System.Globalization;
using System.Threading;

namespace JobService
{
    public class JobCalculator
    {
        //  DateTime startRange = new DateTime.Parse("17:00");
       
            

        // public bool IsShiftStartAfter5pm(string shiftStart ) {

        //    var s = DateTime.Parse(shiftStart);
            
        //         if (s <= startRange)
        //         {
        //             return false;
        //         } else {
        //             return true;
        //         }
            
        //     return false;
            
        // }
        public double FullHour(double hours){
                return Math.Ceiling(hours);
        }

    }
}
