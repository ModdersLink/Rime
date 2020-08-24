///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class VehicleLockableInfoData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float HeatSignature { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RadarSignature { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float LowAltitudeHeight { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float LowAltitudeHeatSignature { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2221510681:
					HeatSignature = (float) p_Value;
					break;

				case 1808737829:
					RadarSignature = (float) p_Value;
					break;

				case 768153502:
					LowAltitudeHeight = (float) p_Value;
					break;

				case 3927766749:
					LowAltitudeHeatSignature = (float) p_Value;
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
				case 2221510681:
					return HeatSignature;

				case 1808737829:
					return RadarSignature;

				case 768153502:
					return LowAltitudeHeight;

				case 3927766749:
					return LowAltitudeHeatSignature;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2221510681:
					return typeof(VehicleLockableInfoData).GetProperty(nameof(HeatSignature));

				case 1808737829:
					return typeof(VehicleLockableInfoData).GetProperty(nameof(RadarSignature));

				case 768153502:
					return typeof(VehicleLockableInfoData).GetProperty(nameof(LowAltitudeHeight));

				case 3927766749:
					return typeof(VehicleLockableInfoData).GetProperty(nameof(LowAltitudeHeatSignature));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
