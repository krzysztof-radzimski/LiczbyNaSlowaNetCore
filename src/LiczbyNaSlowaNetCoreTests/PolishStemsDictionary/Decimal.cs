﻿
// Copyright (c) 2014 Przemek Walkowski

using LiczbyNaSlowaNETCore;
using Xunit;

namespace LiczbyNaSlowaNETCoreTests.PolishStemsDictionary
{
    public class Decimal : TestBase
    {
        [Fact]
        public void Test_4_4()
        {
            Assert.Equal("cztery czterdzieści", NumberToText.Convert(4.4M, PolishDictionaryWithStemsOptions));
        }

        [Fact]
        public void Test_4_40()
        {
            Assert.Equal("cztery czterdzieści", NumberToText.Convert(4.40M, PolishDictionaryWithStemsOptions));
        }

        [Fact]
        public void Test_12_23()
        {
            Assert.Equal("dwanaście dwadzieścia trzy", NumberToText.Convert(12.23M, PolishDictionaryWithStemsOptions));
        }

        [Fact]
        public void Test_12()
        {
            Assert.Equal("dwanaście", NumberToText.Convert(12M, PolishDictionaryWithStemsOptions));
        }

        [Fact]
        public void Test_0_12()
        {
            Assert.Equal("zero dwanaście", NumberToText.Convert(0.12M, PolishDictionaryWithStemsOptions));
        }

        [Fact]
        public void Test_Infinity()
        {
            Assert.Equal("", NumberToText.Convert(999999999999999999999M));
        }

        [Fact]
        public void Test_141000_23()
        {
            Assert.Equal("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
        }

        [Fact]
        public void Test_141000_230()
        {
            Assert.Equal("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
        }

        [Fact]
        public void Test_141000_23030()
        {
            Assert.Equal("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
        }
    }
}
