///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class TestCaseEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TimeOut { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string TestGroup { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string TestCaseName { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool Stable { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3344659518:
					TimeOut = (float) p_Value;
					break;

				case 1436402060:
					TestGroup = (string) p_Value;
					break;

				case 2495365472:
					TestCaseName = (string) p_Value;
					break;

				case 3319702312:
					Stable = (bool) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3344659518:
					return TimeOut;

				case 1436402060:
					return TestGroup;

				case 2495365472:
					return TestCaseName;

				case 3319702312:
					return Stable;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3344659518:
					return typeof(TestCaseEntityData).GetProperty(nameof(TimeOut));

				case 1436402060:
					return typeof(TestCaseEntityData).GetProperty(nameof(TestGroup));

				case 2495365472:
					return typeof(TestCaseEntityData).GetProperty(nameof(TestCaseName));

				case 3319702312:
					return typeof(TestCaseEntityData).GetProperty(nameof(Stable));

				case 2662400:
					return typeof(TestCaseEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
