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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class SoundWaveLocalizationInfo : FrostbiteContainer
	{
		[ContainerField(Name: "Language", Offset: 0, NameHash: 3872303031, Flags: 53)]
		public CtrRef<AudioLanguage> Language { get; set; } = new CtrRef<AudioLanguage>(); // 0x0 (0)
		
		[ContainerField(Name: "FirstVariationIndex", Offset: 4, NameHash: 4275355664, Flags: 49389), LayoutImmutable, Blittable]
		public ushort FirstVariationIndex { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "VariationCount", Offset: 6, NameHash: 1780023607, Flags: 49389), LayoutImmutable, Blittable]
		public ushort VariationCount { get; set; } // 0x6 (6)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3872303031:
					Language = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 4275355664:
					FirstVariationIndex = (ushort) p_Value;
					break;

				case 1780023607:
					VariationCount = (ushort) p_Value;
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
				case 3872303031:
					return Language;

				case 4275355664:
					return FirstVariationIndex;

				case 1780023607:
					return VariationCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3872303031:
					return typeof(SoundWaveLocalizationInfo).GetProperty(nameof(Language));

				case 4275355664:
					return typeof(SoundWaveLocalizationInfo).GetProperty(nameof(FirstVariationIndex));

				case 1780023607:
					return typeof(SoundWaveLocalizationInfo).GetProperty(nameof(VariationCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
