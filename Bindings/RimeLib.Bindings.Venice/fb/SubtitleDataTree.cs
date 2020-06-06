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
	public class SubtitleDataTree : 
		TreeBase
	{
		[ContainerField(12)]
		public RefArray<SubtitleMainDataNode> Subtitles { get; set; } = new RefArray<SubtitleMainDataNode>(); // 0xC (12)
		
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
