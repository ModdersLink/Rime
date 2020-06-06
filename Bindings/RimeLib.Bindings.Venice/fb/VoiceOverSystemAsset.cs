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
	public class VoiceOverSystemAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<VoiceOverInterval> Intervals { get; set; } = new RefArray<VoiceOverInterval>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<VoiceOverLabel> Labels { get; set; } = new RefArray<VoiceOverLabel>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<VoiceOverObject> Types { get; set; } = new RefArray<VoiceOverObject>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<VoiceOverObject> Objects { get; set; } = new RefArray<VoiceOverObject>(); // 0x18 (24)
		
		[ContainerField(28)]
		public RefArray<VoiceOverGlobalConstantValue> Constants { get; set; } = new RefArray<VoiceOverGlobalConstantValue>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<AudioLanguage> MasterLanguage { get; set; } = new CtrRef<AudioLanguage>(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<VoiceOverPronunciation> DefaultPronunciation { get; set; } = new CtrRef<VoiceOverPronunciation>(); // 0x24 (36)
		
		[ContainerField(40)]
		public RefArray<VoiceOverPronunciation> Pronunciations { get; set; } = new RefArray<VoiceOverPronunciation>(); // 0x28 (40)
		
		[ContainerField(44)]
		public RefArray<VoiceOverConversationQueueGroup> QueueGroups { get; set; } = new RefArray<VoiceOverConversationQueueGroup>(); // 0x2C (44)
		
		[ContainerField(48)]
		public CtrRef<VoiceOverConversationQueueGroup> DefaultPositionedQueueGroup { get; set; } = new CtrRef<VoiceOverConversationQueueGroup>(); // 0x30 (48)
		
		[ContainerField(52)]
		public CtrRef<VoiceOverConversationQueueGroup> DefaultUnpositionedQueueGroup { get; set; } = new CtrRef<VoiceOverConversationQueueGroup>(); // 0x34 (52)
		
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
