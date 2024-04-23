﻿
// Copyright (c) 2014 Przemek Walkowski

using LiczbyNaSlowaNETCore;
using Xunit;

namespace LiczbyNaSlowaNETCoreTests
{
    public class SplitDecimal
    {
        [Fact]
        public void Test_SplitDecimal_50_50()
        {
            var options = new NumberToTextOptions
            {
                SplitDecimal = "i"
            };

            Assert.Equal("piecdziesiat i piecdziesiat", NumberToText.Convert(50.50M, options));
        }

        [Fact]
        public void Test_SplitDecimal_5_5()
        {
            var options = new NumberToTextOptions
            {
                Currency = Currency.PLN,
                SplitDecimal = "i"
            };

            Assert.Equal("piec zlotych i piecdziesiat groszy", NumberToText.Convert(5.5M, options));
        }

        [Fact]
        public void Test_SplitDecimal_12_23()
        {
            var options = new NumberToTextOptions
            {
                Currency = Currency.PLN,
                SplitDecimal = "i"
            };

            Assert.Equal("dwanascie zlotych i dwadziescia trzy grosze", NumberToText.Convert(12.23M, options));
        }

        [Fact]
        public void Test_SplitDecimal_12_02()
        {
            var options = new NumberToTextOptions
            {
                Currency = Currency.PLN,
                SplitDecimal = " oraz "
            };

            Assert.Equal("dwanascie zlotych  oraz  dwa grosze", NumberToText.Convert(12.02M, options));
        }

        [Fact]
        public void Test_SplitDecimal_0_12()
        {
            var options = new NumberToTextOptions
            {
                Currency = Currency.PLN
            };

            Assert.Equal("zero zlotych dwanascie groszy", NumberToText.Convert(0.12M, options));
        }
    }
}
