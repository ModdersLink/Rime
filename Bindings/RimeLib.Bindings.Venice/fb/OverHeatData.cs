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
	[ContainerType(16)]
	public class OverHeatData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float HeatPerBullet { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float HeatDropPerSecond { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float OverHeatPenaltyTime { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float OverHeatThreshold { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public FireEffectData OverHeatEffect { get; set; } = new FireEffectData(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2230088284:
					HeatPerBullet = (float) p_Value;
					break;

				case 2173208259:
					HeatDropPerSecond = (float) p_Value;
					break;

				case 1305646237:
					OverHeatPenaltyTime = (float) p_Value;
					break;

				case 1042108772:
					OverHeatThreshold = (float) p_Value;
					break;

				case 3498278916:
					OverHeatEffect = (FireEffectData) p_Value;
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
				case 2230088284:
					return HeatPerBullet;

				case 2173208259:
					return HeatDropPerSecond;

				case 1305646237:
					return OverHeatPenaltyTime;

				case 1042108772:
					return OverHeatThreshold;

				case 3498278916:
					return OverHeatEffect;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2230088284:
					return typeof(OverHeatData).GetProperty(nameof(HeatPerBullet));

				case 2173208259:
					return typeof(OverHeatData).GetProperty(nameof(HeatDropPerSecond));

				case 1305646237:
					return typeof(OverHeatData).GetProperty(nameof(OverHeatPenaltyTime));

				case 1042108772:
					return typeof(OverHeatData).GetProperty(nameof(OverHeatThreshold));

				case 3498278916:
					return typeof(OverHeatData).GetProperty(nameof(OverHeatEffect));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
