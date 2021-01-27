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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class AudioObstructionMaterialInfo : FrostbiteContainer
	{
		[ContainerField(Name: "Material", Offset: 0, NameHash: 845639918, Flags: 53)]
		public CtrRef<MaterialContainerPair> Material { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x0 (0)
		
		[ContainerField(Name: "ObstructionFrequency", Offset: 4, NameHash: 3471859443, Flags: 49469), LayoutImmutable, Blittable]
		public float ObstructionFrequency { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "GainReduction", Offset: 8, NameHash: 1506744413, Flags: 49469), LayoutImmutable, Blittable]
		public float GainReduction { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 845639918:
					Material = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 3471859443:
					ObstructionFrequency = (float) p_Value;
					break;

				case 1506744413:
					GainReduction = (float) p_Value;
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
				case 845639918:
					return Material;

				case 3471859443:
					return ObstructionFrequency;

				case 1506744413:
					return GainReduction;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 845639918:
					return typeof(AudioObstructionMaterialInfo).GetProperty(nameof(Material));

				case 3471859443:
					return typeof(AudioObstructionMaterialInfo).GetProperty(nameof(ObstructionFrequency));

				case 1506744413:
					return typeof(AudioObstructionMaterialInfo).GetProperty(nameof(GainReduction));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
