using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RimeLib.Cmd.Tests
{
    [TestClass]
    public class CommandUtilsTest
    {
        [TestMethod]
        public void TestParseArguments()
        {
            Assert.AreEqual(
                CommandUtils.ParseArguments("one"),
                new[] { "one" }
            );

            Assert.AreEqual(
                CommandUtils.ParseArguments("one two"),
                new[] { "one", "two" }
            );

            Assert.AreEqual(
                CommandUtils.ParseArguments("one    two"),
                new[] { "one", "two" }
            );

            Assert.AreEqual(
                CommandUtils.ParseArguments("one \"two\""),
                new[] { "one", "two" }
            );

            Assert.AreEqual(
                CommandUtils.ParseArguments("one \"two\" \"three spaced\""),
                new[] { "one", "two", "three spaced" }
            );

            Assert.AreEqual(
                CommandUtils.ParseArguments("one \"two\" \"three \\\"spaced\\\"\""),
                new[] { "one", "two", "three \"spaced\"" }
            );

            Assert.AreEqual(
                CommandUtils.ParseArguments("one\"two\""),
                new[] { "one", "two" }
            );

            Assert.AreEqual(
                CommandUtils.ParseArguments("one\"two"),
                new[] { "one", "two" }
            );

            Assert.AreEqual(
                CommandUtils.ParseArguments("one\"two\"three"),
                new[] { "one", "two", "three" }
            );

            Assert.AreEqual(
                CommandUtils.ParseArguments("one t\\wo"),
                new[] { "one", "t\\wo" }
            );
        }
    }
}
