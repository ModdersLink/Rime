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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 56)]
	public class VoiceOverSystemAsset : 
		Asset
	{
		protected RefArray<VoiceOverInterval> m_Intervals = new RefArray<VoiceOverInterval>();
		[ContainerField(Name: "Intervals", Offset: 12, NameHash: 3804459337, Flags: 65)]
		public RefArray<VoiceOverInterval> Intervals { get { return m_Intervals; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(Intervals), this, m_Intervals, value)) m_Intervals = value; } } // 0xC (12)
		
		protected RefArray<VoiceOverLabel> m_Labels = new RefArray<VoiceOverLabel>();
		[ContainerField(Name: "Labels", Offset: 16, NameHash: 2902520752, Flags: 65)]
		public RefArray<VoiceOverLabel> Labels { get { return m_Labels; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(Labels), this, m_Labels, value)) m_Labels = value; } } // 0x10 (16)
		
		protected RefArray<VoiceOverObject> m_Types = new RefArray<VoiceOverObject>();
		[ContainerField(Name: "Types", Offset: 20, NameHash: 227325038, Flags: 65)]
		public RefArray<VoiceOverObject> Types { get { return m_Types; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(Types), this, m_Types, value)) m_Types = value; } } // 0x14 (20)
		
		protected RefArray<VoiceOverObject> m_Objects = new RefArray<VoiceOverObject>();
		[ContainerField(Name: "Objects", Offset: 24, NameHash: 105488131, Flags: 65)]
		public RefArray<VoiceOverObject> Objects { get { return m_Objects; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(Objects), this, m_Objects, value)) m_Objects = value; } } // 0x18 (24)
		
		protected RefArray<VoiceOverGlobalConstantValue> m_Constants = new RefArray<VoiceOverGlobalConstantValue>();
		[ContainerField(Name: "Constants", Offset: 28, NameHash: 2658787400, Flags: 65)]
		public RefArray<VoiceOverGlobalConstantValue> Constants { get { return m_Constants; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(Constants), this, m_Constants, value)) m_Constants = value; } } // 0x1C (28)
		
		protected CtrRef<AudioLanguage> m_MasterLanguage = new CtrRef<AudioLanguage>();
		[ContainerField(Name: "MasterLanguage", Offset: 32, NameHash: 1351373419, Flags: 53)]
		public CtrRef<AudioLanguage> MasterLanguage { get { return m_MasterLanguage; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(MasterLanguage), this, m_MasterLanguage, value)) m_MasterLanguage = value; } } // 0x20 (32)
		
		protected CtrRef<VoiceOverPronunciation> m_DefaultPronunciation = new CtrRef<VoiceOverPronunciation>();
		[ContainerField(Name: "DefaultPronunciation", Offset: 36, NameHash: 3211842017, Flags: 53)]
		public CtrRef<VoiceOverPronunciation> DefaultPronunciation { get { return m_DefaultPronunciation; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(DefaultPronunciation), this, m_DefaultPronunciation, value)) m_DefaultPronunciation = value; } } // 0x24 (36)
		
		protected RefArray<VoiceOverPronunciation> m_Pronunciations = new RefArray<VoiceOverPronunciation>();
		[ContainerField(Name: "Pronunciations", Offset: 40, NameHash: 3948025177, Flags: 65)]
		public RefArray<VoiceOverPronunciation> Pronunciations { get { return m_Pronunciations; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(Pronunciations), this, m_Pronunciations, value)) m_Pronunciations = value; } } // 0x28 (40)
		
		protected RefArray<VoiceOverConversationQueueGroup> m_QueueGroups = new RefArray<VoiceOverConversationQueueGroup>();
		[ContainerField(Name: "QueueGroups", Offset: 44, NameHash: 2104403224, Flags: 65)]
		public RefArray<VoiceOverConversationQueueGroup> QueueGroups { get { return m_QueueGroups; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(QueueGroups), this, m_QueueGroups, value)) m_QueueGroups = value; } } // 0x2C (44)
		
		protected CtrRef<VoiceOverConversationQueueGroup> m_DefaultPositionedQueueGroup = new CtrRef<VoiceOverConversationQueueGroup>();
		[ContainerField(Name: "DefaultPositionedQueueGroup", Offset: 48, NameHash: 2574585400, Flags: 53)]
		public CtrRef<VoiceOverConversationQueueGroup> DefaultPositionedQueueGroup { get { return m_DefaultPositionedQueueGroup; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(DefaultPositionedQueueGroup), this, m_DefaultPositionedQueueGroup, value)) m_DefaultPositionedQueueGroup = value; } } // 0x30 (48)
		
		protected CtrRef<VoiceOverConversationQueueGroup> m_DefaultUnpositionedQueueGroup = new CtrRef<VoiceOverConversationQueueGroup>();
		[ContainerField(Name: "DefaultUnpositionedQueueGroup", Offset: 52, NameHash: 4048247171, Flags: 53)]
		public CtrRef<VoiceOverConversationQueueGroup> DefaultUnpositionedQueueGroup { get { return m_DefaultUnpositionedQueueGroup; } set { if (OnPropertyChanging("VoiceOverSystemAsset." + nameof(DefaultUnpositionedQueueGroup), this, m_DefaultUnpositionedQueueGroup, value)) m_DefaultUnpositionedQueueGroup = value; } } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3804459337:
					Intervals = (RefArray<VoiceOverInterval>) p_Value;
					break;

				case 2902520752:
					Labels = (RefArray<VoiceOverLabel>) p_Value;
					break;

				case 227325038:
					Types = (RefArray<VoiceOverObject>) p_Value;
					break;

				case 105488131:
					Objects = (RefArray<VoiceOverObject>) p_Value;
					break;

				case 2658787400:
					Constants = (RefArray<VoiceOverGlobalConstantValue>) p_Value;
					break;

				case 1351373419:
					MasterLanguage = (CtrRef<AudioLanguage>) p_Value;
					break;

				case 3211842017:
					DefaultPronunciation = (CtrRef<VoiceOverPronunciation>) p_Value;
					break;

				case 3948025177:
					Pronunciations = (RefArray<VoiceOverPronunciation>) p_Value;
					break;

				case 2104403224:
					QueueGroups = (RefArray<VoiceOverConversationQueueGroup>) p_Value;
					break;

				case 2574585400:
					DefaultPositionedQueueGroup = (CtrRef<VoiceOverConversationQueueGroup>) p_Value;
					break;

				case 4048247171:
					DefaultUnpositionedQueueGroup = (CtrRef<VoiceOverConversationQueueGroup>) p_Value;
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
				case 3804459337:
					return Intervals;

				case 2902520752:
					return Labels;

				case 227325038:
					return Types;

				case 105488131:
					return Objects;

				case 2658787400:
					return Constants;

				case 1351373419:
					return MasterLanguage;

				case 3211842017:
					return DefaultPronunciation;

				case 3948025177:
					return Pronunciations;

				case 2104403224:
					return QueueGroups;

				case 2574585400:
					return DefaultPositionedQueueGroup;

				case 4048247171:
					return DefaultUnpositionedQueueGroup;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3804459337:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(Intervals));

				case 2902520752:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(Labels));

				case 227325038:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(Types));

				case 105488131:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(Objects));

				case 2658787400:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(Constants));

				case 1351373419:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(MasterLanguage));

				case 3211842017:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(DefaultPronunciation));

				case 3948025177:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(Pronunciations));

				case 2104403224:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(QueueGroups));

				case 2574585400:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(DefaultPositionedQueueGroup));

				case 4048247171:
					return typeof(VoiceOverSystemAsset).GetProperty(nameof(DefaultUnpositionedQueueGroup));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
