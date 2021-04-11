using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.PluralRules;

namespace Alrev.Intl.RelativeTime.Tests
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
