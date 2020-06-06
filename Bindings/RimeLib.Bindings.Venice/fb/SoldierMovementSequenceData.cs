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
	public class SoldierMovementSequenceData : 
		MovementActionData
	{
		[ContainerField(8)]
		public CtrRef<RecordedInputData> RecordedInput { get; set; } = new CtrRef<RecordedInputData>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int InputRecordingIndex { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IgnoreRecordingIndexFilter { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool ReportWhenFinished { get; set; } // 0x11 (17)
		
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
