using Alrev.Intl.PluralRules.Globalization;

namespace Alrev.Intl.PluralRules.Tests
{
    public class PluralRulesLocalizersFixture
    {
        public PluralRulesOrdinalLocalizer OrdinalLocalizer { get; private set; }
        public PluralRulesCardinalLocalizer CardinalLocalizer { get; private set; }

        public PluralRulesLocalizersFixture()
        {
            this.OrdinalLocalizer = new PluralRulesOrdinalLocalizer();
            this.CardinalLocalizer = new PluralRulesCardinalLocalizer();
        }
    }
}
