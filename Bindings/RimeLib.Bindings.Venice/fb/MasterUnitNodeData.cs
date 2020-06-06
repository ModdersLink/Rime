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
	public class MasterUnitNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort SettingsIndex { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Amplitude { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort MasterGain { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort MasterLfeGain { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort MasterDialogGain { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort MainMixGain { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		[ContainerField(56)]
		public AudioGraphNodePort PostEffectsGain { get; set; } = new AudioGraphNodePort(); // 0x38 (56)
		
		[ContainerField(64)]
		public AudioGraphNodePort ReverbGain { get; set; } = new AudioGraphNodePort(); // 0x40 (64)
		
		[ContainerField(72)]
		public AudioGraphNodePort FadeTime { get; set; } = new AudioGraphNodePort(); // 0x48 (72)
		
		[ContainerField(80)]
		public AudioGraphNodePort HighPassFreq { get; set; } = new AudioGraphNodePort(); // 0x50 (80)
		
		[ContainerField(88)]
		public AudioGraphNodePort LowShelfFreq { get; set; } = new AudioGraphNodePort(); // 0x58 (88)
		
		[ContainerField(96)]
		public AudioGraphNodePort LowShelfGain { get; set; } = new AudioGraphNodePort(); // 0x60 (96)
		
		[ContainerField(104)]
		public AudioGraphNodePort HighShelfFreq { get; set; } = new AudioGraphNodePort(); // 0x68 (104)
		
		[ContainerField(112)]
		public AudioGraphNodePort HighShelfGain { get; set; } = new AudioGraphNodePort(); // 0x70 (112)
		
		[ContainerField(120)]
		public AudioGraphNodePort CompThreshold { get; set; } = new AudioGraphNodePort(); // 0x78 (120)
		
		[ContainerField(128)]
		public AudioGraphNodePort CompRatio { get; set; } = new AudioGraphNodePort(); // 0x80 (128)
		
		[ContainerField(136)]
		public AudioGraphNodePort CompAttack { get; set; } = new AudioGraphNodePort(); // 0x88 (136)
		
		[ContainerField(144)]
		public AudioGraphNodePort CompRelease { get; set; } = new AudioGraphNodePort(); // 0x90 (144)
		
		[ContainerField(152)]
		public AudioGraphNodePort DistClipLevel { get; set; } = new AudioGraphNodePort(); // 0x98 (152)
		
		[ContainerField(160)]
		public AudioGraphNodePort ParallelDistortionGain { get; set; } = new AudioGraphNodePort(); // 0xA0 (160)
		
		[ContainerField(168)]
		public RefArray<MasterUnitSettings> Settings { get; set; } = new RefArray<MasterUnitSettings>(); // 0xA8 (168)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3467073726:
					SettingsIndex = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 3418201912:
					MasterGain = (AudioGraphNodePort) p_Value;
					break;

				case 3456654679:
					MasterLfeGain = (AudioGraphNodePort) p_Value;
					break;

				case 3075029008:
					MasterDialogGain = (AudioGraphNodePort) p_Value;
					break;

				case 2469993203:
					MainMixGain = (AudioGraphNodePort) p_Value;
					break;

				case 974497912:
					PostEffectsGain = (AudioGraphNodePort) p_Value;
					break;

				case 622241232:
					ReverbGain = (AudioGraphNodePort) p_Value;
					break;

				case 4001222838:
					FadeTime = (AudioGraphNodePort) p_Value;
					break;

				case 1050320730:
					HighPassFreq = (AudioGraphNodePort) p_Value;
					break;

				case 4093395621:
					LowShelfFreq = (AudioGraphNodePort) p_Value;
					break;

				case 4093417540:
					LowShelfGain = (AudioGraphNodePort) p_Value;
					break;

				case 110900543:
					HighShelfFreq = (AudioGraphNodePort) p_Value;
					break;

				case 110952414:
					HighShelfGain = (AudioGraphNodePort) p_Value;
					break;

				case 201040259:
					CompThreshold = (AudioGraphNodePort) p_Value;
					break;

				case 1938039989:
					CompRatio = (AudioGraphNodePort) p_Value;
					break;

				case 171486556:
					CompAttack = (AudioGraphNodePort) p_Value;
					break;

				case 1539642909:
					CompRelease = (AudioGraphNodePort) p_Value;
					break;

				case 3419995663:
					DistClipLevel = (AudioGraphNodePort) p_Value;
					break;

				case 2605372900:
					ParallelDistortionGain = (AudioGraphNodePort) p_Value;
					break;

				case 649772672:
					Settings = (RefArray<MasterUnitSettings>) p_Value;
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
				case 3467073726:
					return SettingsIndex;

				case 698564572:
					return Amplitude;

				case 3418201912:
					return MasterGain;

				case 3456654679:
					return MasterLfeGain;

				case 3075029008:
					return MasterDialogGain;

				case 2469993203:
					return MainMixGain;

				case 974497912:
					return PostEffectsGain;

				case 622241232:
					return ReverbGain;

				case 4001222838:
					return FadeTime;

				case 1050320730:
					return HighPassFreq;

				case 4093395621:
					return LowShelfFreq;

				case 4093417540:
					return LowShelfGain;

				case 110900543:
					return HighShelfFreq;

				case 110952414:
					return HighShelfGain;

				case 201040259:
					return CompThreshold;

				case 1938039989:
					return CompRatio;

				case 171486556:
					return CompAttack;

				case 1539642909:
					return CompRelease;

				case 3419995663:
					return DistClipLevel;

				case 2605372900:
					return ParallelDistortionGain;

				case 649772672:
					return Settings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3467073726:
					return typeof(MasterUnitNodeData).GetProperty(nameof(SettingsIndex));

				case 698564572:
					return typeof(MasterUnitNodeData).GetProperty(nameof(Amplitude));

				case 3418201912:
					return typeof(MasterUnitNodeData).GetProperty(nameof(MasterGain));

				case 3456654679:
					return typeof(MasterUnitNodeData).GetProperty(nameof(MasterLfeGain));

				case 3075029008:
					return typeof(MasterUnitNodeData).GetProperty(nameof(MasterDialogGain));

				case 2469993203:
					return typeof(MasterUnitNodeData).GetProperty(nameof(MainMixGain));

				case 974497912:
					return typeof(MasterUnitNodeData).GetProperty(nameof(PostEffectsGain));

				case 622241232:
					return typeof(MasterUnitNodeData).GetProperty(nameof(ReverbGain));

				case 4001222838:
					return typeof(MasterUnitNodeData).GetProperty(nameof(FadeTime));

				case 1050320730:
					return typeof(MasterUnitNodeData).GetProperty(nameof(HighPassFreq));

				case 4093395621:
					return typeof(MasterUnitNodeData).GetProperty(nameof(LowShelfFreq));

				case 4093417540:
					return typeof(MasterUnitNodeData).GetProperty(nameof(LowShelfGain));

				case 110900543:
					return typeof(MasterUnitNodeData).GetProperty(nameof(HighShelfFreq));

				case 110952414:
					return typeof(MasterUnitNodeData).GetProperty(nameof(HighShelfGain));

				case 201040259:
					return typeof(MasterUnitNodeData).GetProperty(nameof(CompThreshold));

				case 1938039989:
					return typeof(MasterUnitNodeData).GetProperty(nameof(CompRatio));

				case 171486556:
					return typeof(MasterUnitNodeData).GetProperty(nameof(CompAttack));

				case 1539642909:
					return typeof(MasterUnitNodeData).GetProperty(nameof(CompRelease));

				case 3419995663:
					return typeof(MasterUnitNodeData).GetProperty(nameof(DistClipLevel));

				case 2605372900:
					return typeof(MasterUnitNodeData).GetProperty(nameof(ParallelDistortionGain));

				case 649772672:
					return typeof(MasterUnitNodeData).GetProperty(nameof(Settings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
