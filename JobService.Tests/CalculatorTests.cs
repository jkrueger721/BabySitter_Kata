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
        public void ShouldRoundUpWholeNumber()
        {
        //Given
        var result = _jobService.FullHour(2.02);
        //When
        Assert.Equal(3, result);
        //Then
        }
        

        [Fact]
        public void ReturnTrueIfInTimeRange()
        {
            var result = _jobService.IfInTimeRange("23:59");

            Assert.True(result, "shift start should at or after 5pm shift end before or on 4am");
        }
        [Fact]
        public void FamilyAShouldPay15Before11PM()
        {
        //Given
        var result = _jobService.FamilyCalculator("22:00:00");
        //When
        Assert.Equal(15, result);
        //Then
        }
    }
}
