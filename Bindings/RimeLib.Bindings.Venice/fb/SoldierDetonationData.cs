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
	public class SoldierDetonationData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Angle { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MinSpeedForActivation { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SoldierDetonationActivationDelay { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UseAngle { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
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
