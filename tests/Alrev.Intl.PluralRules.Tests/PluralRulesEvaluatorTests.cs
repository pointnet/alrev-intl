using Alrev.Intl.Abstractions.PluralRules;
using System;
using System.Globalization;
using Xunit;

namespace Alrev.Intl.PluralRules.Tests
{
    public class PluralRulesEvaluatorTests
    {
        [Fact]
        public void UnknownPluralRulesTypeValues_ShouldThrow_ArgumentException()
        {
            PluralRulesEvaluator pre = new PluralRulesEvaluator();
            Exception ex = Record.Exception(() => pre.Evaluate("1", PluralRulesTypeValues.Unknown, CultureInfo.CurrentCulture));
            Assert.IsType<ArgumentException>(ex);
        }

        [Fact]
        public void UnknownCulture_ShouldThrow_CultureNotFoundException()
        {
            PluralRulesEvaluator pre = new PluralRulesEvaluator();
            Exception ex = Record.Exception(() => pre.Evaluate("1", PluralRulesTypeValues.Ordinal, new CultureInfo("aa")));
            Assert.IsType<CultureNotFoundException>(ex);
        }

        [Fact]
        public void EvaluateFrenchOrdinal_ShouldReturn_PluralRulesValuesOne()
        {
            PluralRulesEvaluator pre = new PluralRulesEvaluator();
            PluralRulesValues result = pre.Evaluate("1", PluralRulesTypeValues.Ordinal, new CultureInfo("fr"));
            Assert.Equal(PluralRulesValues.One, result);
        }

        [Fact]
        public void EvaluateFrenchCardinal_ShouldReturn_PluralRulesValuesOne()
        {
            PluralRulesEvaluator pre = new PluralRulesEvaluator();
            PluralRulesValues result = pre.Evaluate("1", PluralRulesTypeValues.Cardinal, new CultureInfo("fr"));
            Assert.Equal(PluralRulesValues.One, result);
        }
    }
}
