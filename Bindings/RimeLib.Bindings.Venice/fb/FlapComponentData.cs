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
    [ContainerType(16)]
	public class FlapComponentData : 
		PartComponentData
	{
		[ContainerField(112)]
		public RotationAxisEnum RotationAxis { get; set; } = new RotationAxisEnum(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float RotationScale { get; set; } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3148542130:
					RotationAxis = (RotationAxisEnum) Enum.ToObject(typeof(RotationAxisEnum), p_Value);
					break;

				case 801800009:
					RotationScale = (float) p_Value;
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
				case 3148542130:
					return RotationAxis;

				case 801800009:
					return RotationScale;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3148542130:
					return typeof(FlapComponentData).GetProperty(nameof(RotationAxis));

				case 801800009:
					return typeof(FlapComponentData).GetProperty(nameof(RotationScale));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
