using System;
using System.Globalization;
using System.Threading;

namespace JobService
{
    public class JobCalculator
    {
         DateTime startRange = new DateTime(5, 0 , 0);
       
            

        public bool IsShiftStartAfter5pm(DateTime shiftStart ) {

           
            
                if (shiftStart <= startRange)
                {
                    return false;
                } else {
                    return true;
                }
            
            return false;
            
        }

    }
}
