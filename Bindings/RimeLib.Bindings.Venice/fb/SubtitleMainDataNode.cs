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
	public class SubtitleMainDataNode : 
		TreeNodeBase
	{
		protected LanguageFormat m_Language = new LanguageFormat();
		[ContainerField(12), ContainerFieldNameHash(3872303031)]
		public LanguageFormat Language { get { return m_Language; } set { if (OnPropertyChanging("SubtitleMainDataNode." + nameof(Language), this, m_Language, value)) m_Language = value; } } // 0xC (12)
		
		protected RefArray<SubtitleDataNode> m_Subtitles = new RefArray<SubtitleDataNode>();
		[ContainerField(16), ContainerFieldNameHash(595907762)]
		public RefArray<SubtitleDataNode> Subtitles { get { return m_Subtitles; } set { if (OnPropertyChanging("SubtitleMainDataNode." + nameof(Subtitles), this, m_Subtitles, value)) m_Subtitles = value; } } // 0x10 (16)
		
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
