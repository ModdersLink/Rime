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
	public class AudioLanguagesDependancyObject : 
		DataContainer
	{
		[ContainerField(8)]
		public RefArray<AudioLanguage> AudioLanguages { get; set; } = new RefArray<AudioLanguage>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 582937106:
					AudioLanguages = (RefArray<AudioLanguage>) p_Value;
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
				case 582937106:
					return AudioLanguages;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 582937106:
					return typeof(AudioLanguagesDependancyObject).GetProperty(nameof(AudioLanguages));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
