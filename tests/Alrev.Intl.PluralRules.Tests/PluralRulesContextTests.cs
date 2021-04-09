using System;
using Xunit;

namespace Alrev.Intl.PluralRules.Tests
{
    public class PluralRulesContextTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NullOrWhiteSpace_ShouldThrow_ArgumentNullException(string input)
        {
            Exception ex = Record.Exception(() => PluralRulesContext.Create(input));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Theory]
        [InlineData("invalid")]
        [InlineData("+1")]
        [InlineData("--1")]
        [InlineData("1.")]
        [InlineData(".1")]
        [InlineData("1.2c")]
        [InlineData("1.c")]
        public void InvalidFormat_ShouldThrow_ArgumentException(string input)
        {
            Exception ex = Record.Exception(() => PluralRulesContext.Create(input));
            Assert.IsType<ArgumentException>(ex);
        }

        [Theory]
        [InlineData("0", 0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData("1", 1, 1, 0, 0, 0, 0, 0, 0)]
        [InlineData("1.0", 1, 1, 1, 0, 0, 0, 0, 0)]
        [InlineData("1.00", 1, 1, 2, 0, 0, 0, 0, 0)]
        [InlineData("1.3", 1.3, 1, 1, 1, 3, 3, 0, 0)]
        [InlineData("1.30", 1.3, 1, 2, 1, 30, 3, 0, 0)]
        [InlineData("1.03", 1.03, 1, 2, 2, 3, 3, 0, 0)]
        [InlineData("1.230", 1.23, 1, 3, 2, 230, 23, 0, 0)]
        [InlineData("1200000", 1200000, 1200000, 0, 0, 0, 0, 0, 0)]
        [InlineData("1.2c6", 1200000, 1200000, 0, 0, 0, 0, 6, 6)]
        [InlineData("123c6", 123000000, 123000000, 0, 0, 0, 0, 6, 6)]
        [InlineData("123c5", 12300000, 12300000, 0, 0, 0, 0, 5, 5)]
        [InlineData("1200.50", 1200.5, 1200, 2, 1, 50, 5, 0, 0)]
        [InlineData("1.20050c3", 1200.5, 1200, 1, 1, 5, 5, 3, 3)]
        [InlineData("-0", 0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData("-1", 1, 1, 0, 0, 0, 0, 0, 0)]
        [InlineData("-1.0", 1, 1, 1, 0, 0, 0, 0, 0)]
        [InlineData("-1.00", 1, 1, 2, 0, 0, 0, 0, 0)]
        [InlineData("-1.3", 1.3, 1, 1, 1, 3, 3, 0, 0)]
        [InlineData("-1.30", 1.3, 1, 2, 1, 30, 3, 0, 0)]
        [InlineData("-1.03", 1.03, 1, 2, 2, 3, 3, 0, 0)]
        [InlineData("-1.230", 1.23, 1, 3, 2, 230, 23, 0, 0)]
        [InlineData("-1200000", 1200000, 1200000, 0, 0, 0, 0, 0, 0)]
        [InlineData("-1.2c6", 1200000, 1200000, 0, 0, 0, 0, 6, 6)]
        [InlineData("-123c6", 123000000, 123000000, 0, 0, 0, 0, 6, 6)]
        [InlineData("-123c5", 12300000, 12300000, 0, 0, 0, 0, 5, 5)]
        [InlineData("-1200.50", 1200.5, 1200, 2, 1, 50, 5, 0, 0)]
        [InlineData("-1.20050c3", 1200.5, 1200, 1, 1, 5, 5, 3, 3)]
        public void SpecificInput_ShouldReturn_ExpectedResult(string input, double n, int i, int v, int w, int f, int t, int e, int c)
        {
            PluralRulesContext prc = PluralRulesContext.Create(input);
            Assert.Equal(input, prc.input);
            Assert.Equal(n, prc.n);
            Assert.Equal(i, prc.i);
            Assert.Equal(v, prc.v);
            Assert.Equal(w, prc.w);
            Assert.Equal(f, prc.f);
            Assert.Equal(t, prc.t);
            Assert.Equal(c, prc.c);
            Assert.Equal(e, prc.e);
        }
    }
}
