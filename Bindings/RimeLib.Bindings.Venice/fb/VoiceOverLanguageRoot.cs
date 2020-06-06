///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverLanguageRoot : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<AudioLanguage> Language { get; set; } = new CtrRef<AudioLanguage>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string Path { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3872303031:
					Language = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 2089448296:
					Path = (string) p_Value;
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

				case 2089448296:
					return Path;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3872303031:
					return typeof(VoiceOverLanguageRoot).GetProperty(nameof(Language));

				case 2089448296:
					return typeof(VoiceOverLanguageRoot).GetProperty(nameof(Path));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
