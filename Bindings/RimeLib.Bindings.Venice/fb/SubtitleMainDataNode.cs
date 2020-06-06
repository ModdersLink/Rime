///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SubtitleMainDataNode : 
		TreeNodeBase
	{
		[ContainerField(12)]
		public LanguageFormat Language { get; set; } = new LanguageFormat(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<SubtitleDataNode> Subtitles { get; set; } = new RefArray<SubtitleDataNode>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3872303031:
					Language = (LanguageFormat) Enum.ToObject(typeof(LanguageFormat), p_Value);
					break;

				case 595907762:
					Subtitles = (RefArray<SubtitleDataNode>) p_Value;
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

				case 595907762:
					return Subtitles;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3872303031:
					return typeof(SubtitleMainDataNode).GetProperty(nameof(Language));

				case 595907762:
					return typeof(SubtitleMainDataNode).GetProperty(nameof(Subtitles));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
