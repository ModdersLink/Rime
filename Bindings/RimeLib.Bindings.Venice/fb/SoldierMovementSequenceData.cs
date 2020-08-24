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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class SoldierMovementSequenceData : 
		MovementActionData
	{
		protected CtrRef<RecordedInputData> m_RecordedInput = new CtrRef<RecordedInputData>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(1633327487), ContainerCtrRef]
		public CtrRef<RecordedInputData> RecordedInput { get { return m_RecordedInput; } set { if (OnPropertyChanging("SoldierMovementSequenceData." + nameof(RecordedInput), this, m_RecordedInput, value)) m_RecordedInput = value; } } // 0x8 (8)
		
		protected int m_InputRecordingIndex = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(228494272)]
		public int InputRecordingIndex { get { return m_InputRecordingIndex; } set { if (OnPropertyChanging("SoldierMovementSequenceData." + nameof(InputRecordingIndex), this, m_InputRecordingIndex, value)) m_InputRecordingIndex = value; } } // 0xC (12)
		
		protected bool m_IgnoreRecordingIndexFilter = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2391351758)]
		public bool IgnoreRecordingIndexFilter { get { return m_IgnoreRecordingIndexFilter; } set { if (OnPropertyChanging("SoldierMovementSequenceData." + nameof(IgnoreRecordingIndexFilter), this, m_IgnoreRecordingIndexFilter, value)) m_IgnoreRecordingIndexFilter = value; } } // 0x10 (16)
		
		protected bool m_ReportWhenFinished = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(644020589)]
		public bool ReportWhenFinished { get { return m_ReportWhenFinished; } set { if (OnPropertyChanging("SoldierMovementSequenceData." + nameof(ReportWhenFinished), this, m_ReportWhenFinished, value)) m_ReportWhenFinished = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1633327487:
					RecordedInput = (CtrRef<RecordedInputData>) p_Value;
					break;

				case 228494272:
					InputRecordingIndex = (int) p_Value;
					break;

				case 2391351758:
					IgnoreRecordingIndexFilter = (bool) p_Value;
					break;

				case 644020589:
					ReportWhenFinished = (bool) p_Value;
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
				case 1633327487:
					return RecordedInput;

				case 228494272:
					return InputRecordingIndex;

				case 2391351758:
					return IgnoreRecordingIndexFilter;

				case 644020589:
					return ReportWhenFinished;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1633327487:
					return typeof(SoldierMovementSequenceData).GetProperty(nameof(RecordedInput));

				case 228494272:
					return typeof(SoldierMovementSequenceData).GetProperty(nameof(InputRecordingIndex));

				case 2391351758:
					return typeof(SoldierMovementSequenceData).GetProperty(nameof(IgnoreRecordingIndexFilter));

				case 644020589:
					return typeof(SoldierMovementSequenceData).GetProperty(nameof(ReportWhenFinished));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
