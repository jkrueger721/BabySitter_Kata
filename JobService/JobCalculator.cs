using System;
using System.Globalization;
using System.Threading;
using Family;
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

        List<Family> families = new List<Family>()
        {
            new Family  {Name = "A", Rate = 15},
            new Family  {Name = "B", Rate = 12}, 
            new Family  {Name = "C", Rate = 21}
        };
        public int FamilyCalculator(string shiftStart){
            var s = TimeSpan.Parse(shiftStart);
            
            if(s < TimeSpan.Parse("23:00")){
                return 15;
            } else {
                return 20;
            }
            return 0;
        }

    }
}
