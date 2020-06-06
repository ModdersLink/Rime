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
	public class SoundPatchAsset : 
		SoundGraphAsset
	{
		[ContainerField(24)]
		public RefArray<AudioGraphNodeData> OutputNodes { get; set; } = new RefArray<AudioGraphNodeData>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Loudness { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float AILoudness { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float DopplerFactor { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MasterPitch { get; set; } // 0x2C (44)
		
		[ContainerField(48)]
		public CtrRef<MixGroup> MixGroup { get; set; } = new CtrRef<MixGroup>(); // 0x30 (48)
		
		[ContainerField(52)]
		public CtrRef<AudioGraphEvent> DefaultStopEvent { get; set; } = new CtrRef<AudioGraphEvent>(); // 0x34 (52)
		
		[ContainerField(56)]
		public CtrRef<AudioGraphEvent> DefaultStartEvent { get; set; } = new CtrRef<AudioGraphEvent>(); // 0x38 (56)
		
		[ContainerField(60)]
		public CtrRef<AudioGraphEvent> DefaultForceInitEvent { get; set; } = new CtrRef<AudioGraphEvent>(); // 0x3C (60)
		
		[ContainerField(64)]
		public CtrRef<AudioGraphEvent> DefaultEnterScopeEvent { get; set; } = new CtrRef<AudioGraphEvent>(); // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool IsPersistent { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool IsLooping { get; set; } // 0x45 (69)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 740996521:
					OutputNodes = (RefArray<AudioGraphNodeData>) p_Value;
					break;

				case 2678891068:
					Loudness = (float) p_Value;
					break;

				case 2389898900:
					AILoudness = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 1757845912:
					DopplerFactor = (float) p_Value;
					break;

				case 1108720767:
					MasterPitch = (float) p_Value;
					break;

				case 3598170502:
					MixGroup = (CtrRef<MixGroup>) p_Value;
					break;

				case 113607258:
					DefaultStopEvent = (CtrRef<AudioGraphEvent>) p_Value;
					break;

				case 3663021474:
					DefaultStartEvent = (CtrRef<AudioGraphEvent>) p_Value;
					break;

				case 2837520997:
					DefaultForceInitEvent = (CtrRef<AudioGraphEvent>) p_Value;
					break;

				case 3819788512:
					DefaultEnterScopeEvent = (CtrRef<AudioGraphEvent>) p_Value;
					break;

				case 2920156954:
					IsPersistent = (bool) p_Value;
					break;

				case 1137411139:
					IsLooping = (bool) p_Value;
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
				case 740996521:
					return OutputNodes;

				case 2678891068:
					return Loudness;

				case 2389898900:
					return AILoudness;

				case 3298407133:
					return Radius;

				case 1757845912:
					return DopplerFactor;

				case 1108720767:
					return MasterPitch;

				case 3598170502:
					return MixGroup;

				case 113607258:
					return DefaultStopEvent;

				case 3663021474:
					return DefaultStartEvent;

				case 2837520997:
					return DefaultForceInitEvent;

				case 3819788512:
					return DefaultEnterScopeEvent;

				case 2920156954:
					return IsPersistent;

				case 1137411139:
					return IsLooping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 740996521:
					return typeof(SoundPatchAsset).GetProperty(nameof(OutputNodes));

				case 2678891068:
					return typeof(SoundPatchAsset).GetProperty(nameof(Loudness));

				case 2389898900:
					return typeof(SoundPatchAsset).GetProperty(nameof(AILoudness));

				case 3298407133:
					return typeof(SoundPatchAsset).GetProperty(nameof(Radius));

				case 1757845912:
					return typeof(SoundPatchAsset).GetProperty(nameof(DopplerFactor));

				case 1108720767:
					return typeof(SoundPatchAsset).GetProperty(nameof(MasterPitch));

				case 3598170502:
					return typeof(SoundPatchAsset).GetProperty(nameof(MixGroup));

				case 113607258:
					return typeof(SoundPatchAsset).GetProperty(nameof(DefaultStopEvent));

				case 3663021474:
					return typeof(SoundPatchAsset).GetProperty(nameof(DefaultStartEvent));

				case 2837520997:
					return typeof(SoundPatchAsset).GetProperty(nameof(DefaultForceInitEvent));

				case 3819788512:
					return typeof(SoundPatchAsset).GetProperty(nameof(DefaultEnterScopeEvent));

				case 2920156954:
					return typeof(SoundPatchAsset).GetProperty(nameof(IsPersistent));

				case 1137411139:
					return typeof(SoundPatchAsset).GetProperty(nameof(IsLooping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
