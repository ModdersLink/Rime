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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(48), ContainerStruct]
	public class AirMissileJammingData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinTurnSpeed { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxRadius { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinRadius { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Theta { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Phi { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float UpdateJammingPositionTime { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxTurnSpeed { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float QuietModeProbability { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float QuietModeTime { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float JammingTime { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float TurnCalculationTime { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool EnableAirMissileJamming { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1800548181:
					MinTurnSpeed = (float) p_Value;
					break;

				case 439602313:
					MaxRadius = (float) p_Value;
					break;

				case 4053568023:
					MinRadius = (float) p_Value;
					break;

				case 228123753:
					Theta = (float) p_Value;
					break;

				case 193467636:
					Phi = (float) p_Value;
					break;

				case 1697402931:
					UpdateJammingPositionTime = (float) p_Value;
					break;

				case 3021183627:
					MaxTurnSpeed = (float) p_Value;
					break;

				case 3225989559:
					QuietModeProbability = (float) p_Value;
					break;

				case 3362853871:
					QuietModeTime = (float) p_Value;
					break;

				case 46309755:
					JammingTime = (float) p_Value;
					break;

				case 553058692:
					TurnCalculationTime = (float) p_Value;
					break;

				case 114900689:
					EnableAirMissileJamming = (bool) p_Value;
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
				case 1800548181:
					return MinTurnSpeed;

				case 439602313:
					return MaxRadius;

				case 4053568023:
					return MinRadius;

				case 228123753:
					return Theta;

				case 193467636:
					return Phi;

				case 1697402931:
					return UpdateJammingPositionTime;

				case 3021183627:
					return MaxTurnSpeed;

				case 3225989559:
					return QuietModeProbability;

				case 3362853871:
					return QuietModeTime;

				case 46309755:
					return JammingTime;

				case 553058692:
					return TurnCalculationTime;

				case 114900689:
					return EnableAirMissileJamming;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1800548181:
					return typeof(AirMissileJammingData).GetProperty(nameof(MinTurnSpeed));

				case 439602313:
					return typeof(AirMissileJammingData).GetProperty(nameof(MaxRadius));

				case 4053568023:
					return typeof(AirMissileJammingData).GetProperty(nameof(MinRadius));

				case 228123753:
					return typeof(AirMissileJammingData).GetProperty(nameof(Theta));

				case 193467636:
					return typeof(AirMissileJammingData).GetProperty(nameof(Phi));

				case 1697402931:
					return typeof(AirMissileJammingData).GetProperty(nameof(UpdateJammingPositionTime));

				case 3021183627:
					return typeof(AirMissileJammingData).GetProperty(nameof(MaxTurnSpeed));

				case 3225989559:
					return typeof(AirMissileJammingData).GetProperty(nameof(QuietModeProbability));

				case 3362853871:
					return typeof(AirMissileJammingData).GetProperty(nameof(QuietModeTime));

				case 46309755:
					return typeof(AirMissileJammingData).GetProperty(nameof(JammingTime));

				case 553058692:
					return typeof(AirMissileJammingData).GetProperty(nameof(TurnCalculationTime));

				case 114900689:
					return typeof(AirMissileJammingData).GetProperty(nameof(EnableAirMissileJamming));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
