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
	public class LandingFlapData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float ActivationHeight { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float HeightTolerance { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ActivationVelocity { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float VelocityTolerance { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2266632686:
					ActivationHeight = (float) p_Value;
					break;

				case 593358163:
					HeightTolerance = (float) p_Value;
					break;

				case 1432155942:
					ActivationVelocity = (float) p_Value;
					break;

				case 43464475:
					VelocityTolerance = (float) p_Value;
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
				case 2266632686:
					return ActivationHeight;

				case 593358163:
					return HeightTolerance;

				case 1432155942:
					return ActivationVelocity;

				case 43464475:
					return VelocityTolerance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2266632686:
					return typeof(LandingFlapData).GetProperty(nameof(ActivationHeight));

				case 593358163:
					return typeof(LandingFlapData).GetProperty(nameof(HeightTolerance));

				case 1432155942:
					return typeof(LandingFlapData).GetProperty(nameof(ActivationVelocity));

				case 43464475:
					return typeof(LandingFlapData).GetProperty(nameof(VelocityTolerance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
