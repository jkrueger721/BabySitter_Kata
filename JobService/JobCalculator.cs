﻿using System;
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

    }
}
