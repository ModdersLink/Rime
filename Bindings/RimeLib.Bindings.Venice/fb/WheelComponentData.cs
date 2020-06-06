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
	public class WheelComponentData : 
		PartComponentData
	{
		[ContainerField(112)]
		public CtrRef<WheelConfigData> Config { get; set; } = new CtrRef<WheelConfigData>(); // 0x70 (112)
		
		[ContainerField(116)]
		public WheelPhysicsType PhysicsType { get; set; } = new WheelPhysicsType(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float EffectClampVelocity { get; set; } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2713732399:
					Config = (CtrRef<WheelConfigData>) p_Value;
					break;

				case 1744391446:
					PhysicsType = (WheelPhysicsType) Enum.ToObject(typeof(WheelPhysicsType), p_Value);
					break;

				case 2869239062:
					EffectClampVelocity = (float) p_Value;
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
				case 2713732399:
					return Config;

				case 1744391446:
					return PhysicsType;

				case 2869239062:
					return EffectClampVelocity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2713732399:
					return typeof(WheelComponentData).GetProperty(nameof(Config));

				case 1744391446:
					return typeof(WheelComponentData).GetProperty(nameof(PhysicsType));

				case 2869239062:
					return typeof(WheelComponentData).GetProperty(nameof(EffectClampVelocity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
