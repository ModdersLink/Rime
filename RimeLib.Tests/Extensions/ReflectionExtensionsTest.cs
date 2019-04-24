using RimeLib.Extensions;
using Xunit;

namespace RimeLib.Tests.Extensions
{
    public class ReflectionExtensionsTest
    {
        class NullabilityTest
        {
            public int? NullableInt { get; set; }

            public string? NullableString { get; set; }

            public object? NullableObject { get; set; }

            public int NonNullableInt { get; set; }

            public string NonNullableString { get; set; } = "";

            public object NonNullableObject { get; set; } = false;
        }

        [Fact]
        public void TestIsNullable()
        {
            Assert.True(typeof(NullabilityTest).GetProperty("NullableInt").IsNullable());
            Assert.True(typeof(NullabilityTest).GetProperty("NullableString").IsNullable());
            Assert.True(typeof(NullabilityTest).GetProperty("NullableObject").IsNullable());
            Assert.False(typeof(NullabilityTest).GetProperty("NonNullableInt").IsNullable());
            Assert.False(typeof(NullabilityTest).GetProperty("NonNullableString").IsNullable());
            Assert.False(typeof(NullabilityTest).GetProperty("NonNullableObject").IsNullable());
        }
    }
}
