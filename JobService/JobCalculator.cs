using System;
using System.Globalization;
using System.Threading;

namespace JobService
{
    public class JobCalculator
    {
     TimeSpan startTime = TimeSpan.Parse("17:00:00");
     TimeSpan endTime = TimeSpan.Parse("04:00:00");
       
       
        public double FullHour(double hours)
        {
            
                return Math.Ceiling(hours) ;
        }

        public bool IfInTimeRange(string shiftStart)
        {

            var s = TimeSpan.Parse(shiftStart);

            if( s <= endTime){

               if(s >= startTime && s <= endTime){
                   return true;
               }
            
            }else {
                if(s >= startTime || s <= endTime){
                    return true;
                }

            }
            return true;
                       
        }

       
        public int FamilyACalculator(string shiftStart){
            var s = TimeSpan.Parse(shiftStart);
            
            if(s < TimeSpan.Parse("23:00:00")){
                return 15;
            } else {
                return 20;
            }
            return 0;
        }
        public int FamilyBCalculator(string shiftStart)
        {
            var s = TimeSpan.Parse(shiftStart);

            if(s < TimeSpan.Parse("22:00:00")){
                return 12;
            } else {
                return 16;
            }
            return 0;
        }

    }
}
