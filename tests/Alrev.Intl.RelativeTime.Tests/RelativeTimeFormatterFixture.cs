using Alrev.Intl.Abstractions.RelativeTime;

namespace Alrev.Intl.RelativeTime.Tests
{
    public class RelativeTimeFormatterFixture
    {
        public IRelativeTimeFormatter Formatter { get; private set; }
        public RelativeTimeLocalizerFixture LocalizerFixture { get; private set; }
        public PluralRulesEvaluatorFixture EvaluatorFixture { get; private set; }

        public RelativeTimeFormatterFixture()
        {
            this.LocalizerFixture = new RelativeTimeLocalizerFixture();
            this.EvaluatorFixture = new PluralRulesEvaluatorFixture();
            this.Formatter = new RelativeTimeFormatter(this.LocalizerFixture.Localizer, this.EvaluatorFixture.Evaluator);
        }
    }
}
