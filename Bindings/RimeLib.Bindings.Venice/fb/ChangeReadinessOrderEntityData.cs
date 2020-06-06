///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ChangeReadinessOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40)]
		public ReadinessLevel Pulse { get; set; } = new ReadinessLevel(); // 0x28 (40)
		
		[ContainerField(44)]
		public ReadinessLevel Minimum { get; set; } = new ReadinessLevel(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool AllowDecrease { get; set; } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231633466:
					Pulse = (ReadinessLevel) Enum.ToObject(typeof(ReadinessLevel), p_Value);
					break;

				case 1011407507:
					Minimum = (ReadinessLevel) Enum.ToObject(typeof(ReadinessLevel), p_Value);
					break;

				case 3792051486:
					AllowDecrease = (bool) p_Value;
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
				case 231633466:
					return Pulse;

				case 1011407507:
					return Minimum;

				case 3792051486:
					return AllowDecrease;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231633466:
					return typeof(ChangeReadinessOrderEntityData).GetProperty(nameof(Pulse));

				case 1011407507:
					return typeof(ChangeReadinessOrderEntityData).GetProperty(nameof(Minimum));

				case 3792051486:
					return typeof(ChangeReadinessOrderEntityData).GetProperty(nameof(AllowDecrease));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
