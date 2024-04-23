﻿
// Copyright (c) 2014 Przemek Walkowski

using LiczbyNaSlowaNETCore;
using Xunit;

namespace LiczbyNaSlowaNETCoreTests.PolishStemsDictionary
{
    public class Hundreds : TestBase
    {
        [Fact]
        public void Test_123()
        {
            Assert.Equal("sto dwadzieścia trzy", NumberToText.Convert(123, PolishDictionaryWithStemsOptions));
        }

        [Fact]
        public void Test_403()
        {
            Assert.Equal("czterysta trzy", NumberToText.Convert(403));
        }

        [Fact]
        public void Test_320()
        {
            Assert.Equal("trzysta dwadziescia", NumberToText.Convert(320));
        }

        [Fact]
        public void Test_700()
        {
            Assert.Equal("siedemset", NumberToText.Convert(700));
        }

        [Fact]
        public void Test_999()
        {
            Assert.Equal("dziewiecset dziewiecdziesiat dziewiec", NumberToText.Convert(999));
        }
    }
}
