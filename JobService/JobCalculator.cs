using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
namespace JobService
{
    public class JobCalculator
    {
     TimeSpan startTime = TimeSpan.Parse("17:00:00");
     TimeSpan endTime = TimeSpan.Parse("04:00:00");
    // Family families = new List<Family>{
    //     new Family(){ Name = "A", Rate = 15, BedTime = "23:00:00", BedTimeRate = 20 },
    //     new Family(){ Name = "B", Rate = 12, BedTime = "23:00:00", BedTimeRate = 20 },
    //     new Family(){ Name = "A", Rate = 15, BedTime = "23:00:00", BedTimeRate = 20 },
        
    // };
       
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

            if(s < TimeSpan.Parse("22:00:00") && s > TimeSpan.Parse("17:00:00")){
                return 12;
            } else if(s >= TimeSpan.Parse("22:00:00") && s <= TimeSpan.Parse("23:59:59")) {
                return 8;
            }else if(s > TimeSpan.Parse("00:00:00") && s < TimeSpan.Parse("04:00:00")){
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
