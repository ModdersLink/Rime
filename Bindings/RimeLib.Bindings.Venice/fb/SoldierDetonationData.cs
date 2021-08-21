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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class SoldierDetonationData : FrostbiteContainer
	{
		[ContainerField(Name: "Angle", Offset: 0, NameHash: 205597860, Flags: 49469), LayoutImmutable, Blittable]
		public float Angle { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "MinSpeedForActivation", Offset: 4, NameHash: 1129224071, Flags: 49469), LayoutImmutable, Blittable]
		public float MinSpeedForActivation { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Radius", Offset: 8, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "SoldierDetonationActivationDelay", Offset: 12, NameHash: 1649653383, Flags: 49469), LayoutImmutable, Blittable]
		public float SoldierDetonationActivationDelay { get; set; } // 0xC (12)
		
		[ContainerField(Name: "UseAngle", Offset: 16, NameHash: 249175111, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseAngle { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "HasSoldierDetonation", Offset: 17, NameHash: 1339359612, Flags: 49325), LayoutImmutable, Blittable]
		public bool HasSoldierDetonation { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205597860:
					Angle = (float) p_Value;
					break;

				case 1129224071:
					MinSpeedForActivation = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 1649653383:
					SoldierDetonationActivationDelay = (float) p_Value;
					break;

				case 249175111:
					UseAngle = (bool) p_Value;
					break;

				case 1339359612:
					HasSoldierDetonation = (bool) p_Value;
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

				case 1129224071:
					return MinSpeedForActivation;

				case 3298407133:
					return Radius;

				case 1649653383:
					return SoldierDetonationActivationDelay;

				case 249175111:
					return UseAngle;

				case 1339359612:
					return HasSoldierDetonation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 205597860:
					return typeof(SoldierDetonationData).GetProperty(nameof(Angle));

				case 1129224071:
					return typeof(SoldierDetonationData).GetProperty(nameof(MinSpeedForActivation));

				case 3298407133:
					return typeof(SoldierDetonationData).GetProperty(nameof(Radius));

				case 1649653383:
					return typeof(SoldierDetonationData).GetProperty(nameof(SoldierDetonationActivationDelay));

				case 249175111:
					return typeof(SoldierDetonationData).GetProperty(nameof(UseAngle));

				case 1339359612:
					return typeof(SoldierDetonationData).GetProperty(nameof(HasSoldierDetonation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
