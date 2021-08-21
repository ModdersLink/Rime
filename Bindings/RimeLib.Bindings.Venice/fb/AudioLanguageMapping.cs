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
	public class AudioLanguageMapping : FrostbiteContainer
	{
		[ContainerField(Name: "Source", Offset: 0, NameHash: 3339738264, Flags: 53)]
		public CtrRef<AudioLanguage> Source { get; set; } = new CtrRef<AudioLanguage>(); // 0x0 (0)
		
		[ContainerField(Name: "Target", Offset: 4, NameHash: 3215022804, Flags: 53)]
		public CtrRef<AudioLanguage> Target { get; set; } = new CtrRef<AudioLanguage>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3339738264:
					Source = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 3215022804:
					Target = (CtrRef<AudioLanguage>) p_Value;
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
				case 3339738264:
					return Source;

				case 3215022804:
					return Target;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3339738264:
					return typeof(AudioLanguageMapping).GetProperty(nameof(Source));

				case 3215022804:
					return typeof(AudioLanguageMapping).GetProperty(nameof(Target));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
