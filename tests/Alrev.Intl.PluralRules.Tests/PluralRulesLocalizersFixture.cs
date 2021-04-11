using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.PluralRules;
using Alrev.Intl.PluralRules.Globalization;

namespace Alrev.Intl.PluralRules.Tests
{
    public class PluralRulesLocalizersFixture
    {
        public IResourceSetLocalizer<IPluralRulesResource> CardinalLocalizer { get; private set; }
        public IResourceSetLocalizer<IPluralRulesResource> OrdinalLocalizer { get; private set; }

        public PluralRulesLocalizersFixture()
        {
            this.CardinalLocalizer = new PluralRulesCardinalLocalizer();
            this.OrdinalLocalizer = new PluralRulesOrdinalLocalizer();
        }
    }
}
