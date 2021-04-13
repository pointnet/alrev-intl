using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.PluralRules.Globalization.Cardinals;
using Alrev.Intl.PluralRules.Globalization.Ordinals;

namespace Alrev.Intl.PluralRules.Tests.Fixtures
{
    public class PluralRulesEvaluatorFixture
    {
        public IResourceLocalizer<IPluralRulesCardinalResource> CardinalResourceLocalizer { get; private set; }
        public IResourceLocalizer<IPluralRulesOrdinalResource> OrdinalResourceLocalizer { get; private set; }
        public IPluralRulesEvaluator Evaluator { get; private set; }

        public PluralRulesEvaluatorFixture()
        {
            this.CardinalResourceLocalizer = new PluralRulesCardinalResourceLocalizer();
            this.OrdinalResourceLocalizer = new PluralRulesOrdinalResourceLocalizer();
            this.Evaluator = new PluralRulesEvaluator(this.CardinalResourceLocalizer, this.OrdinalResourceLocalizer);
        }
    }
}
