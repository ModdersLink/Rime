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
	public class VoiceOverDialogClip : 
		DataContainer
	{
		protected float m_Offset = new float();
		[ContainerField(Name: "Offset", Offset: 8, NameHash: 2871410728, Flags: 49469), LayoutImmutable, Blittable]
		public float Offset { get { return m_Offset; } set { if (OnPropertyChanging("VoiceOverDialogClip." + nameof(Offset), this, m_Offset, value)) m_Offset = value; } } // 0x8 (8)
		
		protected List<VoiceOverDialogTake> m_Takes = new List<VoiceOverDialogTake>();
		[ContainerField(Name: "Takes", Offset: 12, NameHash: 227600557, Flags: 65)]
		public List<VoiceOverDialogTake> Takes { get { return m_Takes; } set { if (OnPropertyChanging("VoiceOverDialogClip." + nameof(Takes), this, m_Takes, value)) m_Takes = value; } } // 0xC (12)
		
		protected RefArray<VoiceOverDialogClip> m_OffsetReferences = new RefArray<VoiceOverDialogClip>();
		[ContainerField(Name: "OffsetReferences", Offset: 16, NameHash: 1090086000, Flags: 65)]
		public RefArray<VoiceOverDialogClip> OffsetReferences { get { return m_OffsetReferences; } set { if (OnPropertyChanging("VoiceOverDialogClip." + nameof(OffsetReferences), this, m_OffsetReferences, value)) m_OffsetReferences = value; } } // 0x10 (16)
		
		protected CtrRef<VoiceOverDialogClipEvents> m_Events = new CtrRef<VoiceOverDialogClipEvents>();
		[ContainerField(Name: "Events", Offset: 20, NameHash: 2352146554, Flags: 53)]
		public CtrRef<VoiceOverDialogClipEvents> Events { get { return m_Events; } set { if (OnPropertyChanging("VoiceOverDialogClip." + nameof(Events), this, m_Events, value)) m_Events = value; } } // 0x14 (20)
		
		protected sbyte m_SequenceIndex = new sbyte();
		[ContainerField(Name: "SequenceIndex", Offset: 24, NameHash: 4101344388, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte SequenceIndex { get { return m_SequenceIndex; } set { if (OnPropertyChanging("VoiceOverDialogClip." + nameof(SequenceIndex), this, m_SequenceIndex, value)) m_SequenceIndex = value; } } // 0x18 (24)
		
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
