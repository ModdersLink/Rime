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
	[ContainerType(4)]
	public class TurnEffectData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MaxRollAngle { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxPitchAngle { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float YawVelocityThreshhold { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float VelocityThreshhold { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SafeTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float BeginTime { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float HoldTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float EndTime { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 863732973:
					MaxRollAngle = (float) p_Value;
					break;

				case 1228368214:
					MaxPitchAngle = (float) p_Value;
					break;

				case 3352651138:
					YawVelocityThreshhold = (float) p_Value;
					break;

				case 2190993229:
					VelocityThreshhold = (float) p_Value;
					break;

				case 1593077185:
					SafeTime = (float) p_Value;
					break;

				case 900554935:
					BeginTime = (float) p_Value;
					break;

				case 3936329343:
					HoldTime = (float) p_Value;
					break;

				case 4286530879:
					EndTime = (float) p_Value;
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
				case 863732973:
					return MaxRollAngle;

				case 1228368214:
					return MaxPitchAngle;

				case 3352651138:
					return YawVelocityThreshhold;

				case 2190993229:
					return VelocityThreshhold;

				case 1593077185:
					return SafeTime;

				case 900554935:
					return BeginTime;

				case 3936329343:
					return HoldTime;

				case 4286530879:
					return EndTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 863732973:
					return typeof(TurnEffectData).GetProperty(nameof(MaxRollAngle));

				case 1228368214:
					return typeof(TurnEffectData).GetProperty(nameof(MaxPitchAngle));

				case 3352651138:
					return typeof(TurnEffectData).GetProperty(nameof(YawVelocityThreshhold));

				case 2190993229:
					return typeof(TurnEffectData).GetProperty(nameof(VelocityThreshhold));

				case 1593077185:
					return typeof(TurnEffectData).GetProperty(nameof(SafeTime));

				case 900554935:
					return typeof(TurnEffectData).GetProperty(nameof(BeginTime));

				case 3936329343:
					return typeof(TurnEffectData).GetProperty(nameof(HoldTime));

				case 4286530879:
					return typeof(TurnEffectData).GetProperty(nameof(EndTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
