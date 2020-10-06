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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class AntTrackItemData : 
		DataContainer
	{
		protected AntRef m_Controller = new AntRef();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(1870777401)]
		public AntRef Controller { get { return m_Controller; } set { if (OnPropertyChanging("AntTrackItemData." + nameof(Controller), this, m_Controller, value)) m_Controller = value; } } // 0x8 (8)
		
		protected int m_SequenceTrackIndex = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2030753355)]
		public int SequenceTrackIndex { get { return m_SequenceTrackIndex; } set { if (OnPropertyChanging("AntTrackItemData." + nameof(SequenceTrackIndex), this, m_SequenceTrackIndex, value)) m_SequenceTrackIndex = value; } } // 0xC (12)
		
		protected int m_StartTime = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3727579056)]
		public int StartTime { get { return m_StartTime; } set { if (OnPropertyChanging("AntTrackItemData." + nameof(StartTime), this, m_StartTime, value)) m_StartTime = value; } } // 0x10 (16)
		
		protected uint m_NumTicks = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(775952821)]
		public uint NumTicks { get { return m_NumTicks; } set { if (OnPropertyChanging("AntTrackItemData." + nameof(NumTicks), this, m_NumTicks, value)) m_NumTicks = value; } } // 0x14 (20)
		
		protected bool m_ResumeAtEnd = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1451056774)]
		public bool ResumeAtEnd { get { return m_ResumeAtEnd; } set { if (OnPropertyChanging("AntTrackItemData." + nameof(ResumeAtEnd), this, m_ResumeAtEnd, value)) m_ResumeAtEnd = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1870777401:
					Controller = (AntRef) p_Value;
					break;

				case 2030753355:
					SequenceTrackIndex = (int) p_Value;
					break;

				case 3727579056:
					StartTime = (int) p_Value;
					break;

				case 775952821:
					NumTicks = (uint) p_Value;
					break;

				case 1451056774:
					ResumeAtEnd = (bool) p_Value;
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
				case 1870777401:
					return Controller;

				case 2030753355:
					return SequenceTrackIndex;

				case 3727579056:
					return StartTime;

				case 775952821:
					return NumTicks;

				case 1451056774:
					return ResumeAtEnd;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1870777401:
					return typeof(AntTrackItemData).GetProperty(nameof(Controller));

				case 2030753355:
					return typeof(AntTrackItemData).GetProperty(nameof(SequenceTrackIndex));

				case 3727579056:
					return typeof(AntTrackItemData).GetProperty(nameof(StartTime));

				case 775952821:
					return typeof(AntTrackItemData).GetProperty(nameof(NumTicks));

				case 1451056774:
					return typeof(AntTrackItemData).GetProperty(nameof(ResumeAtEnd));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
