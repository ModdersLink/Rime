///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverDialogClip : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Offset { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public List<VoiceOverDialogTake> Takes { get; set; } = new List<VoiceOverDialogTake>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<VoiceOverDialogClip> OffsetReferences { get; set; } = new RefArray<VoiceOverDialogClip>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<VoiceOverDialogClipEvents> Events { get; set; } = new CtrRef<VoiceOverDialogClipEvents>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public sbyte SequenceIndex { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2871410728:
					Offset = (float) p_Value;
					break;

				case 227600557:
					Takes = (List<VoiceOverDialogTake>) p_Value;
					break;

				case 1090086000:
					OffsetReferences = (RefArray<VoiceOverDialogClip>) p_Value;
					break;

				case 2352146554:
					Events = (CtrRef<VoiceOverDialogClipEvents>) p_Value;
					break;

				case 4101344388:
					SequenceIndex = (sbyte) p_Value;
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
				case 2871410728:
					return Offset;

				case 227600557:
					return Takes;

				case 1090086000:
					return OffsetReferences;

				case 2352146554:
					return Events;

				case 4101344388:
					return SequenceIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2871410728:
					return typeof(VoiceOverDialogClip).GetProperty(nameof(Offset));

				case 227600557:
					return typeof(VoiceOverDialogClip).GetProperty(nameof(Takes));

				case 1090086000:
					return typeof(VoiceOverDialogClip).GetProperty(nameof(OffsetReferences));

				case 2352146554:
					return typeof(VoiceOverDialogClip).GetProperty(nameof(Events));

				case 4101344388:
					return typeof(VoiceOverDialogClip).GetProperty(nameof(SequenceIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
