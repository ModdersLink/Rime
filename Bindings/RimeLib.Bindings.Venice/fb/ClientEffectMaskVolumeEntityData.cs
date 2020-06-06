///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ClientEffectMaskVolumeEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ApplyEffectCurve { get; set; } = new Vec4(); // 0x60 (96)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float LifeTimeInSeconds { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float UpdatePeriodInSeconds { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2484955953:
					ApplyEffectCurve = (Vec4) p_Value;
					break;

				case 3163808466:
					LifeTimeInSeconds = (float) p_Value;
					break;

				case 1890008213:
					UpdatePeriodInSeconds = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
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
				case 2484955953:
					return ApplyEffectCurve;

				case 3163808466:
					return LifeTimeInSeconds;

				case 1890008213:
					return UpdatePeriodInSeconds;

				case 3298407133:
					return Radius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2484955953:
					return typeof(ClientEffectMaskVolumeEntityData).GetProperty(nameof(ApplyEffectCurve));

				case 3163808466:
					return typeof(ClientEffectMaskVolumeEntityData).GetProperty(nameof(LifeTimeInSeconds));

				case 1890008213:
					return typeof(ClientEffectMaskVolumeEntityData).GetProperty(nameof(UpdatePeriodInSeconds));

				case 3298407133:
					return typeof(ClientEffectMaskVolumeEntityData).GetProperty(nameof(Radius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
