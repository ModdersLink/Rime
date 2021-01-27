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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class SubtitleDataNode : 
		TreeNodeBase
	{
		protected float m_Time = new float();
		[ContainerField(Name: "Time", Offset: 12, NameHash: 2089313744, Flags: 49469), LayoutImmutable, Blittable]
		public float Time { get { return m_Time; } set { if (OnPropertyChanging("SubtitleDataNode." + nameof(Time), this, m_Time, value)) m_Time = value; } } // 0xC (12)
		
		protected float m_DisplayTime = new float();
		[ContainerField(Name: "DisplayTime", Offset: 16, NameHash: 1925139498, Flags: 49469), LayoutImmutable, Blittable]
		public float DisplayTime { get { return m_DisplayTime; } set { if (OnPropertyChanging("SubtitleDataNode." + nameof(DisplayTime), this, m_DisplayTime, value)) m_DisplayTime = value; } } // 0x10 (16)
		
		protected string m_SID1 = string.Empty;
		[ContainerField(Name: "SID1", Offset: 20, NameHash: 2089461706, Flags: 16509), LayoutImmutable]
		public string SID1 { get { return m_SID1; } set { if (OnPropertyChanging("SubtitleDataNode." + nameof(SID1), this, m_SID1, value)) m_SID1 = value; } } // 0x14 (20)
		
		protected string m_SID2 = string.Empty;
		[ContainerField(Name: "SID2", Offset: 24, NameHash: 2089461705, Flags: 16509), LayoutImmutable]
		public string SID2 { get { return m_SID2; } set { if (OnPropertyChanging("SubtitleDataNode." + nameof(SID2), this, m_SID2, value)) m_SID2 = value; } } // 0x18 (24)
		
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
