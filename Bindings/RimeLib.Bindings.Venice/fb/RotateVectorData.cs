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
	public class RotateVectorData : 
		EvaluatorData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Angle { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool RotateWithinPlane { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool InputAffectsPhi { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205597860:
					Angle = (float) p_Value;
					break;

				case 658584111:
					RotateWithinPlane = (bool) p_Value;
					break;

				case 2136254690:
					InputAffectsPhi = (bool) p_Value;
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
				case 205597860:
					return Angle;

				case 658584111:
					return RotateWithinPlane;

				case 2136254690:
					return InputAffectsPhi;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 205597860:
					return typeof(RotateVectorData).GetProperty(nameof(Angle));

				case 658584111:
					return typeof(RotateVectorData).GetProperty(nameof(RotateWithinPlane));

				case 2136254690:
					return typeof(RotateVectorData).GetProperty(nameof(InputAffectsPhi));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
