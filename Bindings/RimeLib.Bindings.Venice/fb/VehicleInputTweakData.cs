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
	public class VehicleInputTweakData : 
		DataContainer
	{
		[ContainerField(8)]
		public VehicleInputTweakType InputTweakType { get; set; } = new VehicleInputTweakType(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinSpeed { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinSpeedScale { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxSpeedScale { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3111564359:
					InputTweakType = (VehicleInputTweakType) Enum.ToObject(typeof(VehicleInputTweakType), p_Value);
					break;

				case 3368183944:
					MinSpeed = (float) p_Value;
					break;

				case 396228950:
					MaxSpeed = (float) p_Value;
					break;

				case 1840139696:
					MinSpeedScale = (float) p_Value;
					break;

				case 33238958:
					MaxSpeedScale = (float) p_Value;
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
				case 3111564359:
					return InputTweakType;

				case 3368183944:
					return MinSpeed;

				case 396228950:
					return MaxSpeed;

				case 1840139696:
					return MinSpeedScale;

				case 33238958:
					return MaxSpeedScale;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3111564359:
					return typeof(VehicleInputTweakData).GetProperty(nameof(InputTweakType));

				case 3368183944:
					return typeof(VehicleInputTweakData).GetProperty(nameof(MinSpeed));

				case 396228950:
					return typeof(VehicleInputTweakData).GetProperty(nameof(MaxSpeed));

				case 1840139696:
					return typeof(VehicleInputTweakData).GetProperty(nameof(MinSpeedScale));

				case 33238958:
					return typeof(VehicleInputTweakData).GetProperty(nameof(MaxSpeedScale));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
