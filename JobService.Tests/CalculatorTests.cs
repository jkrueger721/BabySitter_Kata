using System;
using JobService;
using Xunit;

namespace JobService.Tests
{
    public class CalculatorTests
    {
        private readonly JobCalculator _jobService;

        public CalculatorTests()
        {
            _jobService = new JobCalculator();
        }


        [Fact]
        public void ReturnTrueIfInTimeRange()
        {
            var result = _jobService.IsShiftStartAfter5pm();

            Assert.False(result, "should show not before 5pm");
        }
    }
}
