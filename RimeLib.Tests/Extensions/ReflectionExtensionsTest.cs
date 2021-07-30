using RimeLib.Extensions;

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

        public void TestIsNullable()
        {
            //Assert.IsTrue(typeof(NullabilityTest).GetProperty("NullableInt")!.IsNullable());
            //Assert.IsTrue(typeof(NullabilityTest).GetProperty("NullableString")!.IsNullable());
            //Assert.IsTrue(typeof(NullabilityTest).GetProperty("NullableObject")!.IsNullable());
            //Assert.IsFalse(typeof(NullabilityTest).GetProperty("NonNullableInt")!.IsNullable());
            //Assert.IsFalse(typeof(NullabilityTest).GetProperty("NonNullableString")!.IsNullable());
            //Assert.IsFalse(typeof(NullabilityTest).GetProperty("NonNullableObject")!.IsNullable());
        }
    }
}