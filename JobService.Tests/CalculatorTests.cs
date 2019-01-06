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
        

        [Theory]
        [InlineData("23:59:00")]
        [InlineData("04:00:00")]
        
        public void ReturnTrueIfInTimeRange(string value )
        {
            // var result = _jobService.IfInTimeRange("23:59");
            var result = _jobService.IfInTimeRange(value);

            Assert.True(result, "shift start should at or after 5pm shift end before or on 4am");
        }
        
        [Fact]
        public void FamilyAShouldPay15Before11PM()
        {
        //Given
        var result = _jobService.FamilyARate("22:00:00");
        //When
        Assert.Equal(15, result);
        //Then
        }
        [Fact]
        public void FamilyAShouldPay20After11PM()
        {
            var result = _jobService.FamilyARate("23:01:00");

            Assert.Equal(20, result);
        }
        [Fact]
        public void FamilyBShouldPay12Before10()
        {
        //Given
        var result = _jobService.FamilyBRate("21:40:00");
        //When
        Assert.Equal(12, result);
        //Then
        }
        [Fact]
        public void FamilyBShouldPay8Between10and12()
        {
        //Given
        var result = _jobService.FamilyBRate("22:01:00");
        //When
        Assert.Equal(8, result);
        //Then
        }
       [Fact]
       public void FamilyBShouldPAy16After12()
       {
       //Given
       var result = _jobService.FamilyBRate("01:02:00");
       //When
       Assert.Equal(16, result);
       //Then
       }
       
        [Fact]
        public void FamilyCShouldPay21Before9()
        {
        //Given
        var result = _jobService.FamilyCRate("08:59:00");
        //When
        Assert.Equal(21, result);
        //Then
        }
        [Fact]
        public void FamilyCShouldPay15After9()
        {
        //Given
        var result = _jobService.FamilyCRate("21:00:00");
        //When
        Assert.Equal(15, result);
        //Then
        }
    }
}
