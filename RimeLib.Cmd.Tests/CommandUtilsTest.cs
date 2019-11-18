using Xunit;

namespace RimeLib.Cmd.Tests
{
    public class CommandUtilsTest
    {
        [Fact]
        public void TestParseArguments()
        {
            Assert.Equal(
                CommandUtils.ParseArguments("one"),
                new[] { "one" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one two"),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one    two"),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one \"two\""),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one \"two\" \"three spaced\""),
                new[] { "one", "two", "three spaced" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one \"two\" \"three \\\"spaced\\\"\""),
                new[] { "one", "two", "three \"spaced\"" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one\"two\""),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one\"two"),
                new[] { "one", "two" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one\"two\"three"),
                new[] { "one", "two", "three" }
            );

            Assert.Equal(
                CommandUtils.ParseArguments("one t\\wo"),
                new[] { "one", "t\\wo" }
            );
        }
    }
}
