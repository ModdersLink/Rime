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
	public class SubtitleDataNode : 
		TreeNodeBase
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Time { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DisplayTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string SID1 { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string SID2 { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089313744:
					Time = (float) p_Value;
					break;

				case 1925139498:
					DisplayTime = (float) p_Value;
					break;

				case 2089461706:
					SID1 = (string) p_Value;
					break;

				case 2089461705:
					SID2 = (string) p_Value;
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
				case 2089313744:
					return Time;

				case 1925139498:
					return DisplayTime;

				case 2089461706:
					return SID1;

				case 2089461705:
					return SID2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089313744:
					return typeof(SubtitleDataNode).GetProperty(nameof(Time));

				case 1925139498:
					return typeof(SubtitleDataNode).GetProperty(nameof(DisplayTime));

				case 2089461706:
					return typeof(SubtitleDataNode).GetProperty(nameof(SID1));

				case 2089461705:
					return typeof(SubtitleDataNode).GetProperty(nameof(SID2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
