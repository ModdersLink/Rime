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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class SubtitleDataTree : 
		TreeBase
	{
		protected RefArray<SubtitleMainDataNode> m_Subtitles = new RefArray<SubtitleMainDataNode>();
		[ContainerField(Name: "Subtitles", Offset: 12, NameHash: 595907762, Flags: 65)]
		public RefArray<SubtitleMainDataNode> Subtitles { get { return m_Subtitles; } set { if (OnPropertyChanging("SubtitleDataTree." + nameof(Subtitles), this, m_Subtitles, value)) m_Subtitles = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 595907762:
					Subtitles = (RefArray<SubtitleMainDataNode>) p_Value;
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
				case 595907762:
					return typeof(SubtitleDataTree).GetProperty(nameof(Subtitles));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
