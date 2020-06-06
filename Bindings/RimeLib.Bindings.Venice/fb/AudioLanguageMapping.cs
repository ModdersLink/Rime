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
	public class AudioLanguageMapping : FrostbiteContainer
	{
		[ContainerField(0)]
		public CtrRef<AudioLanguage> Source { get; set; } = new CtrRef<AudioLanguage>(); // 0x0 (0)
		
		[ContainerField(4)]
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
