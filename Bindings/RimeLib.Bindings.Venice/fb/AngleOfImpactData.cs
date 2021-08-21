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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class AngleOfImpactData : FrostbiteContainer
	{
		[ContainerField(Name: "Zone12Delimiter", Offset: 0, NameHash: 1249719259, Flags: 49469), LayoutImmutable, Blittable]
		public float Zone12Delimiter { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Zone23Delimiter", Offset: 4, NameHash: 2906626489, Flags: 49469), LayoutImmutable, Blittable]
		public float Zone23Delimiter { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Zone1Multiplier", Offset: 8, NameHash: 1160298209, Flags: 49469), LayoutImmutable, Blittable]
		public float Zone1Multiplier { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "Zone2Multiplier", Offset: 12, NameHash: 1257656802, Flags: 49469), LayoutImmutable, Blittable]
		public float Zone2Multiplier { get; set; } // 0xC (12)
		
		[ContainerField(Name: "Zone3Multiplier", Offset: 16, NameHash: 2162935267, Flags: 49469), LayoutImmutable, Blittable]
		public float Zone3Multiplier { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "Enabled", Offset: 20, NameHash: 2662400, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1249719259:
					Zone12Delimiter = (float) p_Value;
					break;

				case 2906626489:
					Zone23Delimiter = (float) p_Value;
					break;

				case 1160298209:
					Zone1Multiplier = (float) p_Value;
					break;

				case 1257656802:
					Zone2Multiplier = (float) p_Value;
					break;

				case 2162935267:
					Zone3Multiplier = (float) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 1249719259:
					return Zone12Delimiter;

				case 2906626489:
					return Zone23Delimiter;

				case 1160298209:
					return Zone1Multiplier;

				case 1257656802:
					return Zone2Multiplier;

				case 2162935267:
					return Zone3Multiplier;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1249719259:
					return typeof(AngleOfImpactData).GetProperty(nameof(Zone12Delimiter));

				case 2906626489:
					return typeof(AngleOfImpactData).GetProperty(nameof(Zone23Delimiter));

				case 1160298209:
					return typeof(AngleOfImpactData).GetProperty(nameof(Zone1Multiplier));

				case 1257656802:
					return typeof(AngleOfImpactData).GetProperty(nameof(Zone2Multiplier));

				case 2162935267:
					return typeof(AngleOfImpactData).GetProperty(nameof(Zone3Multiplier));

				case 2662400:
					return typeof(AngleOfImpactData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
