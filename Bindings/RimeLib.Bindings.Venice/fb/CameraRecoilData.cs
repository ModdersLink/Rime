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
	public class CameraRecoilData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float SpringConstant { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SpringDamping { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SpringMinThresholdAngle { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3561415946:
					SpringConstant = (float) p_Value;
					break;

				case 1976598700:
					SpringDamping = (float) p_Value;
					break;

				case 130500136:
					SpringMinThresholdAngle = (float) p_Value;
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
				case 3561415946:
					return SpringConstant;

				case 1976598700:
					return SpringDamping;

				case 130500136:
					return SpringMinThresholdAngle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3561415946:
					return typeof(CameraRecoilData).GetProperty(nameof(SpringConstant));

				case 1976598700:
					return typeof(CameraRecoilData).GetProperty(nameof(SpringDamping));

				case 130500136:
					return typeof(CameraRecoilData).GetProperty(nameof(SpringMinThresholdAngle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
