using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.List;
using Alrev.Intl.List.Tests.Fixtures;
using System;
using System.Globalization;
using System.Threading;
using Xunit;

namespace Alrev.Intl.List.Tests
{
    [Collection("ListFormatter")]
    public class ListFormatterTests
    {
        public ListFormatterFixture Fixture { get; }

        public ListFormatterTests(ListFormatterFixture fixture)
        {
            this.Fixture = fixture;
        }

        [Fact]
        public void NullLocalizer_ShouldThrow_ArgumentNullException()
        {
            Exception ex = Record.Exception(() => new ListFormatter(null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Fact]
        public void FormatValues_WithNullCulture_ShouldThrow_ArgumentNullException()
        {
            Exception ex = Record.Exception(() => this.Fixture.Formatter.Format((CultureInfo)null, "Bonnie", "Clyde"));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Fact]
        public void FormatValues_WithNullValues_ShouldThrow_ArgumentNullException()
        {
            Exception ex = Record.Exception(() => this.Fixture.Formatter.Format((string[])null));
            Assert.IsType<ArgumentNullException>(ex);
        }

        [Fact]
        public void FormatValues_WithTypeUnknown_ShouldThrow_ArgumentException()
        {
            Exception ex = Record.Exception(() => this.Fixture.Formatter.Format(ListTypeValues.Unknown, "Bonnie", "Clyde"));
            Assert.IsType<ArgumentException>(ex);
        }

        [Fact]
        public void FormatValues_WithStyleUnknown_ShouldThrow_ArgumentException()
        {
            Exception ex = Record.Exception(() => this.Fixture.Formatter.Format(IntlStyleValues.Unknown, "Bonnie", "Clyde"));
            Assert.IsType<ArgumentException>(ex);
        }

        [Fact]
        public void FormatValues_WithNoValues_ShouldReturn_StringEmpty()
        {
            string formatted = this.Fixture.Formatter.Format(new string[] { });
            Assert.Empty(formatted);
        }

        [Fact]
        public void FormatValues_WithOneValue_ShouldReturn_OneValue()
        {
            string formatted = this.Fixture.Formatter.Format("John Doe");
            Assert.Equal("John Doe", formatted);
        }

        [Fact]
        public void FormatValues_WithNotSupportedCulture_ShouldReturn_ValuesSpaceSeparated()
        {
            string formatted = this.Fixture.Formatter.Format(CultureInfo.InvariantCulture, "Leonardo", "Raphael", "Donatello", "Michelangelo");
            Assert.Equal("Leonardo Raphael Donatello Michelangelo", formatted);
        }

        [Theory]
        [InlineData("Bonnie and Clyde", "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, and Louie", "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, and Michelangelo", "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        public void FormatValues_WithoutCulture_ShouldReturn_ExpectedValue(string expected, params string[] values)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            string formatted = this.Fixture.Formatter.Format(values);
            Assert.Equal(expected, formatted);
        }

        [Theory]
        [InlineData("Bonnie and Clyde", "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, and Louie", "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, and Michelangelo", "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        public void FormatValues_WithCulture_ShouldReturn_ExpectedValue(string expected, params string[] values)
        {
            string formatted = this.Fixture.Formatter.Format(new CultureInfo("en"), values);
            Assert.Equal(expected, formatted);
        }

        [Theory]
        [InlineData("Bonnie and Clyde", ListTypeValues.Conjunction, "Bonnie", "Clyde")]
        [InlineData("Bonnie or Clyde", ListTypeValues.Disjunction, "Bonnie", "Clyde")]
        [InlineData("Bonnie, Clyde", ListTypeValues.Unit, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, and Louie", ListTypeValues.Conjunction, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, or Louie", ListTypeValues.Disjunction, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, Louie", ListTypeValues.Unit, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, and Michelangelo", ListTypeValues.Conjunction, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, or Michelangelo", ListTypeValues.Disjunction, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", ListTypeValues.Unit, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        public void FormatValues_WithoutCulture_WithType_ShouldReturn_ExpectedValue(string expected, ListTypeValues listType, params string[] values)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            string formatted = this.Fixture.Formatter.Format(listType, values);
            Assert.Equal(expected, formatted);
        }

        [Theory]
        [InlineData("Bonnie and Clyde", ListTypeValues.Conjunction, "Bonnie", "Clyde")]
        [InlineData("Bonnie or Clyde", ListTypeValues.Disjunction, "Bonnie", "Clyde")]
        [InlineData("Bonnie, Clyde", ListTypeValues.Unit, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, and Louie", ListTypeValues.Conjunction, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, or Louie", ListTypeValues.Disjunction, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, Louie", ListTypeValues.Unit, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, and Michelangelo", ListTypeValues.Conjunction, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, or Michelangelo", ListTypeValues.Disjunction, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", ListTypeValues.Unit, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        public void FormatValues_WithCulture_WithType_ShouldReturn_ExpectedValue(string expected, ListTypeValues listType, params string[] values)
        {
            string formatted = this.Fixture.Formatter.Format(new CultureInfo("en"), listType, values);
            Assert.Equal(expected, formatted);
        }

        [Theory]
        [InlineData("Bonnie and Clyde", IntlStyleValues.Long, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, and Louie", IntlStyleValues.Long, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, and Michelangelo", IntlStyleValues.Long, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Bonnie, Clyde", IntlStyleValues.Narrow, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, Louie", IntlStyleValues.Narrow, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", IntlStyleValues.Narrow, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Bonnie & Clyde", IntlStyleValues.Short, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, & Louie", IntlStyleValues.Short, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, & Michelangelo", IntlStyleValues.Short, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        public void FormatValues_WithoutCulture_WithStyle_ShouldReturn_ExpectedValue(string expected, IntlStyleValues intlStyle, params string[] values)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            string formatted = this.Fixture.Formatter.Format(intlStyle, values);
            Assert.Equal(expected, formatted);
        }

        [Theory]
        [InlineData("Bonnie and Clyde", IntlStyleValues.Long, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, and Louie", IntlStyleValues.Long, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, and Michelangelo", IntlStyleValues.Long, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Bonnie, Clyde", IntlStyleValues.Narrow, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, Louie", IntlStyleValues.Narrow, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", IntlStyleValues.Narrow, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Bonnie & Clyde", IntlStyleValues.Short, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, & Louie", IntlStyleValues.Short, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, & Michelangelo", IntlStyleValues.Short, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        public void FormatValues_WithCulture_WithStyle_ShouldReturn_ExpectedValue(string expected, IntlStyleValues intlStyle, params string[] values)
        {
            string formatted = this.Fixture.Formatter.Format(new CultureInfo("en"), intlStyle, values);
            Assert.Equal(expected, formatted);
        }

        [Theory]
        [InlineData("Bonnie and Clyde", ListTypeValues.Conjunction, IntlStyleValues.Long, "Bonnie", "Clyde")]
        [InlineData("Bonnie or Clyde", ListTypeValues.Disjunction, IntlStyleValues.Long, "Bonnie", "Clyde")]
        [InlineData("Bonnie, Clyde", ListTypeValues.Unit, IntlStyleValues.Long, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, and Louie", ListTypeValues.Conjunction, IntlStyleValues.Long, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, or Louie", ListTypeValues.Disjunction, IntlStyleValues.Long, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, Louie", ListTypeValues.Unit, IntlStyleValues.Long, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, and Michelangelo", ListTypeValues.Conjunction, IntlStyleValues.Long, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, or Michelangelo", ListTypeValues.Disjunction, IntlStyleValues.Long, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", ListTypeValues.Unit, IntlStyleValues.Long, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Bonnie, Clyde", ListTypeValues.Conjunction, IntlStyleValues.Narrow, "Bonnie", "Clyde")]
        [InlineData("Bonnie or Clyde", ListTypeValues.Disjunction, IntlStyleValues.Narrow, "Bonnie", "Clyde")]
        [InlineData("Bonnie Clyde", ListTypeValues.Unit, IntlStyleValues.Narrow, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, Louie", ListTypeValues.Conjunction, IntlStyleValues.Narrow, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, or Louie", ListTypeValues.Disjunction, IntlStyleValues.Narrow, "Huey", "Dewey", "Louie")]
        [InlineData("Huey Dewey Louie", ListTypeValues.Unit, IntlStyleValues.Narrow, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", ListTypeValues.Conjunction, IntlStyleValues.Narrow, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, or Michelangelo", ListTypeValues.Disjunction, IntlStyleValues.Narrow, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo Raphael Donatello Michelangelo", ListTypeValues.Unit, IntlStyleValues.Narrow, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Bonnie & Clyde", ListTypeValues.Conjunction, IntlStyleValues.Short, "Bonnie", "Clyde")]
        [InlineData("Bonnie or Clyde", ListTypeValues.Disjunction, IntlStyleValues.Short, "Bonnie", "Clyde")]
        [InlineData("Bonnie, Clyde", ListTypeValues.Unit, IntlStyleValues.Short, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, & Louie", ListTypeValues.Conjunction, IntlStyleValues.Short, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, or Louie", ListTypeValues.Disjunction, IntlStyleValues.Short, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, Louie", ListTypeValues.Unit, IntlStyleValues.Short, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, & Michelangelo", ListTypeValues.Conjunction, IntlStyleValues.Short, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, or Michelangelo", ListTypeValues.Disjunction, IntlStyleValues.Short, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", ListTypeValues.Unit, IntlStyleValues.Short, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        public void FormatValues_WithoutCulture_WithTypeAndStyle_ShouldReturn_ExpectedValue(string expected, ListTypeValues listType, IntlStyleValues intStyle, params string[] values)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            string formatted = this.Fixture.Formatter.Format(listType, intStyle, values);
            Assert.Equal(expected, formatted);
        }

        [Theory]
        [InlineData("Bonnie and Clyde", ListTypeValues.Conjunction, IntlStyleValues.Long, "Bonnie", "Clyde")]
        [InlineData("Bonnie or Clyde", ListTypeValues.Disjunction, IntlStyleValues.Long, "Bonnie", "Clyde")]
        [InlineData("Bonnie, Clyde", ListTypeValues.Unit, IntlStyleValues.Long, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, and Louie", ListTypeValues.Conjunction, IntlStyleValues.Long, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, or Louie", ListTypeValues.Disjunction, IntlStyleValues.Long, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, Louie", ListTypeValues.Unit, IntlStyleValues.Long, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, and Michelangelo", ListTypeValues.Conjunction, IntlStyleValues.Long, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, or Michelangelo", ListTypeValues.Disjunction, IntlStyleValues.Long, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", ListTypeValues.Unit, IntlStyleValues.Long, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Bonnie, Clyde", ListTypeValues.Conjunction, IntlStyleValues.Narrow, "Bonnie", "Clyde")]
        [InlineData("Bonnie or Clyde", ListTypeValues.Disjunction, IntlStyleValues.Narrow, "Bonnie", "Clyde")]
        [InlineData("Bonnie Clyde", ListTypeValues.Unit, IntlStyleValues.Narrow, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, Louie", ListTypeValues.Conjunction, IntlStyleValues.Narrow, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, or Louie", ListTypeValues.Disjunction, IntlStyleValues.Narrow, "Huey", "Dewey", "Louie")]
        [InlineData("Huey Dewey Louie", ListTypeValues.Unit, IntlStyleValues.Narrow, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", ListTypeValues.Conjunction, IntlStyleValues.Narrow, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, or Michelangelo", ListTypeValues.Disjunction, IntlStyleValues.Narrow, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo Raphael Donatello Michelangelo", ListTypeValues.Unit, IntlStyleValues.Narrow, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Bonnie & Clyde", ListTypeValues.Conjunction, IntlStyleValues.Short, "Bonnie", "Clyde")]
        [InlineData("Bonnie or Clyde", ListTypeValues.Disjunction, IntlStyleValues.Short, "Bonnie", "Clyde")]
        [InlineData("Bonnie, Clyde", ListTypeValues.Unit, IntlStyleValues.Short, "Bonnie", "Clyde")]
        [InlineData("Huey, Dewey, & Louie", ListTypeValues.Conjunction, IntlStyleValues.Short, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, or Louie", ListTypeValues.Disjunction, IntlStyleValues.Short, "Huey", "Dewey", "Louie")]
        [InlineData("Huey, Dewey, Louie", ListTypeValues.Unit, IntlStyleValues.Short, "Huey", "Dewey", "Louie")]
        [InlineData("Leonardo, Raphael, Donatello, & Michelangelo", ListTypeValues.Conjunction, IntlStyleValues.Short, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, or Michelangelo", ListTypeValues.Disjunction, IntlStyleValues.Short, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        [InlineData("Leonardo, Raphael, Donatello, Michelangelo", ListTypeValues.Unit, IntlStyleValues.Short, "Leonardo", "Raphael", "Donatello", "Michelangelo")]
        public void FormatValues_WithCulture_WithTypeAndStyle_ShouldReturn_ExpectedValue(string expected, ListTypeValues listType, IntlStyleValues intStyle, params string[] values)
        {
            string formatted = this.Fixture.Formatter.Format(new CultureInfo("en"), listType, intStyle, values);
            Assert.Equal(expected, formatted);
        }
    }
}
