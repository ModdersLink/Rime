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
	public class AdvancedDogTagData : 
		DogTagData
	{
		[ContainerField(68), LayoutImmutable]
		public string StatCode { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable]
		public string StatSID { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public bool IsStatMeasuredInTime { get; set; } // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3117339322:
					StatCode = (string) p_Value;
					break;

				case 2176854761:
					StatSID = (string) p_Value;
					break;

				case 3369514563:
					IsStatMeasuredInTime = (bool) p_Value;
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
				case 3117339322:
					return StatCode;

				case 2176854761:
					return StatSID;

				case 3369514563:
					return IsStatMeasuredInTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3117339322:
					return typeof(AdvancedDogTagData).GetProperty(nameof(StatCode));

				case 2176854761:
					return typeof(AdvancedDogTagData).GetProperty(nameof(StatSID));

				case 3369514563:
					return typeof(AdvancedDogTagData).GetProperty(nameof(IsStatMeasuredInTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
