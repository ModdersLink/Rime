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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 28)]
	public class SensingLimits : FrostbiteContainer
	{
		[ContainerField(Name: "HearingDistance", Offset: 0, NameHash: 463245528, Flags: 49469), LayoutImmutable, Blittable]
		public float HearingDistance { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "HearingCutoff", Offset: 4, NameHash: 4152714902, Flags: 49469), LayoutImmutable, Blittable]
		public float HearingCutoff { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "ViewAngle", Offset: 8, NameHash: 4017129097, Flags: 49469), LayoutImmutable, Blittable]
		public float ViewAngle { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "ViewDistance", Offset: 12, NameHash: 2201945291, Flags: 49469), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; } // 0xC (12)
		
		[ContainerField(Name: "PeripheralViewAngle", Offset: 16, NameHash: 184508389, Flags: 49469), LayoutImmutable, Blittable]
		public float PeripheralViewAngle { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "PeripheralViewDistance", Offset: 20, NameHash: 3304470503, Flags: 49469), LayoutImmutable, Blittable]
		public float PeripheralViewDistance { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "PeripheralMovementCutoff", Offset: 24, NameHash: 1163578311, Flags: 49469), LayoutImmutable, Blittable]
		public float PeripheralMovementCutoff { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 463245528:
					HearingDistance = (float) p_Value;
					break;

				case 4152714902:
					HearingCutoff = (float) p_Value;
					break;

				case 4017129097:
					ViewAngle = (float) p_Value;
					break;

				case 2201945291:
					ViewDistance = (float) p_Value;
					break;

				case 184508389:
					PeripheralViewAngle = (float) p_Value;
					break;

				case 3304470503:
					PeripheralViewDistance = (float) p_Value;
					break;

				case 1163578311:
					PeripheralMovementCutoff = (float) p_Value;
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
				case 463245528:
					return HearingDistance;

				case 4152714902:
					return HearingCutoff;

				case 4017129097:
					return ViewAngle;

				case 2201945291:
					return ViewDistance;

				case 184508389:
					return PeripheralViewAngle;

				case 3304470503:
					return PeripheralViewDistance;

				case 1163578311:
					return PeripheralMovementCutoff;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 463245528:
					return typeof(SensingLimits).GetProperty(nameof(HearingDistance));

				case 4152714902:
					return typeof(SensingLimits).GetProperty(nameof(HearingCutoff));

				case 4017129097:
					return typeof(SensingLimits).GetProperty(nameof(ViewAngle));

				case 2201945291:
					return typeof(SensingLimits).GetProperty(nameof(ViewDistance));

				case 184508389:
					return typeof(SensingLimits).GetProperty(nameof(PeripheralViewAngle));

				case 3304470503:
					return typeof(SensingLimits).GetProperty(nameof(PeripheralViewDistance));

				case 1163578311:
					return typeof(SensingLimits).GetProperty(nameof(PeripheralMovementCutoff));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
