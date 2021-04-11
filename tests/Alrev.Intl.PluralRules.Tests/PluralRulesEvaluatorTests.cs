using Alrev.Intl.Abstractions.PluralRules;
using System;
using System.Globalization;
using Xunit;

namespace Alrev.Intl.PluralRules.Tests
{
    [Collection("PluralRulesEvaluator")]
    public class PluralRulesEvaluatorTests
    {
        private PluralRulesEvaluatorFixture fixture;

        public PluralRulesEvaluatorTests(PluralRulesEvaluatorFixture fixture)
        {
            this.fixture = fixture;
        }
        [Fact]
        public void UnknownPluralRulesTypeValues_ShouldThrow_ArgumentException()
        {
            Exception ex = Record.Exception(() => this.fixture.Evaluator.Evaluate("1", PluralRulesTypeValues.Unknown, CultureInfo.CurrentCulture));
            Assert.IsType<ArgumentException>(ex);
        }

        [Fact]
        public void UnknownCulture_ShouldThrow_CultureNotFoundException()
        {
            Exception ex = Record.Exception(() => this.fixture.Evaluator.Evaluate("1", PluralRulesTypeValues.Ordinal, new CultureInfo("aa")));
            Assert.IsType<CultureNotFoundException>(ex);
        }

        [Fact]
        public void EvaluateFrenchOrdinalWithString_ShouldReturn_PluralRulesValuesOne()
        {
            PluralRulesValues result = this.fixture.Evaluator.Evaluate("1", PluralRulesTypeValues.Ordinal, new CultureInfo("fr"));
            Assert.Equal(PluralRulesValues.One, result);
        }

        [Fact]
        public void EvaluateFrenchCardinalWithString_ShouldReturn_PluralRulesValuesOne()
        {
            PluralRulesValues result = this.fixture.Evaluator.Evaluate("1", PluralRulesTypeValues.Cardinal, new CultureInfo("fr"));
            Assert.Equal(PluralRulesValues.One, result);
        }

        [Fact]
        public void EvaluateFrenchOrdinalWithInteger_ShouldReturn_PluralRulesValuesOne()
        {
            PluralRulesValues result = this.fixture.Evaluator.Evaluate(1, PluralRulesTypeValues.Ordinal, new CultureInfo("fr"));
            Assert.Equal(PluralRulesValues.One, result);
        }

        [Fact]
        public void EvaluateFrenchCardinalWithInteger_ShouldReturn_PluralRulesValuesOne()
        {
            PluralRulesValues result = this.fixture.Evaluator.Evaluate(1, PluralRulesTypeValues.Cardinal, new CultureInfo("fr"));
            Assert.Equal(PluralRulesValues.One, result);
        }

        [Fact]
        public void EvaluateFrenchOrdinalWithDouble_ShouldReturn_PluralRulesValuesOne()
        {
            PluralRulesValues result = this.fixture.Evaluator.Evaluate(1.0, PluralRulesTypeValues.Ordinal, new CultureInfo("fr"));
            Assert.Equal(PluralRulesValues.One, result);
        }

        [Fact]
        public void EvaluateFrenchCardinalWithDouble_ShouldReturn_PluralRulesValuesOne()
        {
            PluralRulesValues result = this.fixture.Evaluator.Evaluate(1.0, PluralRulesTypeValues.Cardinal, new CultureInfo("fr"));
            Assert.Equal(PluralRulesValues.One, result);
        }
    }
}
