using Alrev.Intl.Abstractions.PluralRules;

namespace Alrev.Intl.PluralRules.Tests
{
    public class PluralRulesEvaluatorFixture
    {
        public IPluralRulesEvaluator Evaluator { get; private set; }
        public PluralRulesLocalizersFixture LocalizersFixture { get; private set; }

        public PluralRulesEvaluatorFixture()
        {
            this.LocalizersFixture = new PluralRulesLocalizersFixture();
            this.Evaluator = new PluralRulesEvaluator(this.LocalizersFixture.CardinalLocalizer, this.LocalizersFixture.OrdinalLocalizer);
        }
    }
}
