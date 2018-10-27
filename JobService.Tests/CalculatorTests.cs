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
        public void ReturnFalseEarlierThan5PM()
        {
            var result = _jobService.JobStartTime();

            Assert.False(result, "should not be earlier than 5pm");
        }
    }
}
