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
        var result = _jobService.FullHour(4.5);
        //When
        Assert.Equal(5, result);
        //Then
        }

    //     [Fact]
    //     public void ReturnTrueIfInTimeRange()
    //     {
    //         var result = _jobService.IsShiftStartAfter5pm("17:57");

    //         Assert.False(result, "should show not before 5pm");
    //     }
    }
}
