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

        public bool IfInTimeRange(string shiftTime)
        {
            bool condition = true;
            var s = TimeSpan.Parse(shiftTime);
            
            if( s <= endTime)
            {
               if(s >= startTime && s <= endTime)
               {
                  condition = true;
               }
            }
            else if(s >= startTime || s <= endTime)
            {
                condition = true;
            } 
            else 
            {
               condition = false;
            }
            
            return condition;
        
        }

       
        public int FamilyARate(string shiftStart)
        {
            var s = TimeSpan.Parse(shiftStart);
            
            if(s < TimeSpan.Parse("23:00:00")){
                return 15;
            } else {
                return 20;
            }
            return 0;
        }
        public int FamilyBRate(string shiftStart)
        {
            var s = TimeSpan.Parse(shiftStart);

            if(s < TimeSpan.Parse("22:00:00")){
                return 12;
            } else {
                return 16;
            }
            return 0;
        }
        public int FamilyCRate(string shiftStart){
            var s = TimeSpan.Parse(shiftStart);
            if(s < TimeSpan.Parse("21:00:00")){
                return 21;
            } else{
                return 15;
            }
            return 0;
        }

    }
}
