using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.Abstractions.RelativeTime;
using Alrev.Intl.PluralRules;
using Alrev.Intl.PluralRules.Globalization.Cardinals;
using Alrev.Intl.PluralRules.Globalization.Ordinals;
using Alrev.Intl.RelativeTime.Globalization;

namespace Alrev.Intl.RelativeTime.Tests.Fixtures
{
    public class RelativeTimeFormatterFixture
    {
        public IResourceLocalizer<IPluralRulesCardinalResource> CardinalResourceLocalizer { get; private set; }
        public IResourceLocalizer<IPluralRulesOrdinalResource> OrdinalResourceLocalizer { get; private set; }
        public IPluralRulesEvaluator Evaluator { get; private set; }
        public IResourceLocalizer<IRelativeTimeUnitsResource> Localizer { get; private set; }
        public IRelativeTimeFormatter Formatter { get; private set; }

        public RelativeTimeFormatterFixture()
        {
            this.CardinalResourceLocalizer = new PluralRulesCardinalResourceLocalizer();
            this.OrdinalResourceLocalizer = new PluralRulesOrdinalResourceLocalizer();
            this.Evaluator = new PluralRulesEvaluator(this.CardinalResourceLocalizer, this.OrdinalResourceLocalizer);
            this.Localizer = new RelativeTimeResourceLocalizer();
            this.Formatter = new RelativeTimeFormatter(this.Localizer, this.Evaluator);
        }
    }
}
