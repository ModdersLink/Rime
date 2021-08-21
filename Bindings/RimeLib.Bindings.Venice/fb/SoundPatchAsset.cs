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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 72)]
	public class SoundPatchAsset : 
		SoundGraphAsset
	{
		protected RefArray<AudioGraphNodeData> m_OutputNodes = new RefArray<AudioGraphNodeData>();
		[ContainerField(Name: "OutputNodes", Offset: 24, NameHash: 740996521, Flags: 65)]
		public RefArray<AudioGraphNodeData> OutputNodes { get { return m_OutputNodes; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(OutputNodes), this, m_OutputNodes, value)) m_OutputNodes = value; } } // 0x18 (24)
		
		protected float m_Loudness = new float();
		[ContainerField(Name: "Loudness", Offset: 28, NameHash: 2678891068, Flags: 49469), LayoutImmutable, Blittable]
		public float Loudness { get { return m_Loudness; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(Loudness), this, m_Loudness, value)) m_Loudness = value; } } // 0x1C (28)
		
		protected float m_AILoudness = new float();
		[ContainerField(Name: "AILoudness", Offset: 32, NameHash: 2389898900, Flags: 49469), LayoutImmutable, Blittable]
		public float AILoudness { get { return m_AILoudness; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(AILoudness), this, m_AILoudness, value)) m_AILoudness = value; } } // 0x20 (32)
		
		protected float m_Radius = new float();
		[ContainerField(Name: "Radius", Offset: 36, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x24 (36)
		
		protected float m_DopplerFactor = new float();
		[ContainerField(Name: "DopplerFactor", Offset: 40, NameHash: 1757845912, Flags: 49469), LayoutImmutable, Blittable]
		public float DopplerFactor { get { return m_DopplerFactor; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DopplerFactor), this, m_DopplerFactor, value)) m_DopplerFactor = value; } } // 0x28 (40)
		
		protected float m_MasterPitch = new float();
		[ContainerField(Name: "MasterPitch", Offset: 44, NameHash: 1108720767, Flags: 49469), LayoutImmutable, Blittable]
		public float MasterPitch { get { return m_MasterPitch; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(MasterPitch), this, m_MasterPitch, value)) m_MasterPitch = value; } } // 0x2C (44)
		
		protected CtrRef<MixGroup> m_MixGroup = new CtrRef<MixGroup>();
		[ContainerField(Name: "MixGroup", Offset: 48, NameHash: 3598170502, Flags: 53)]
		public CtrRef<MixGroup> MixGroup { get { return m_MixGroup; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(MixGroup), this, m_MixGroup, value)) m_MixGroup = value; } } // 0x30 (48)
		
		protected CtrRef<AudioGraphEvent> m_DefaultStopEvent = new CtrRef<AudioGraphEvent>();
		[ContainerField(Name: "DefaultStopEvent", Offset: 52, NameHash: 113607258, Flags: 53)]
		public CtrRef<AudioGraphEvent> DefaultStopEvent { get { return m_DefaultStopEvent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DefaultStopEvent), this, m_DefaultStopEvent, value)) m_DefaultStopEvent = value; } } // 0x34 (52)
		
		protected CtrRef<AudioGraphEvent> m_DefaultStartEvent = new CtrRef<AudioGraphEvent>();
		[ContainerField(Name: "DefaultStartEvent", Offset: 56, NameHash: 3663021474, Flags: 53)]
		public CtrRef<AudioGraphEvent> DefaultStartEvent { get { return m_DefaultStartEvent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DefaultStartEvent), this, m_DefaultStartEvent, value)) m_DefaultStartEvent = value; } } // 0x38 (56)
		
		protected CtrRef<AudioGraphEvent> m_DefaultForceInitEvent = new CtrRef<AudioGraphEvent>();
		[ContainerField(Name: "DefaultForceInitEvent", Offset: 60, NameHash: 2837520997, Flags: 53)]
		public CtrRef<AudioGraphEvent> DefaultForceInitEvent { get { return m_DefaultForceInitEvent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DefaultForceInitEvent), this, m_DefaultForceInitEvent, value)) m_DefaultForceInitEvent = value; } } // 0x3C (60)
		
		protected CtrRef<AudioGraphEvent> m_DefaultEnterScopeEvent = new CtrRef<AudioGraphEvent>();
		[ContainerField(Name: "DefaultEnterScopeEvent", Offset: 64, NameHash: 3819788512, Flags: 53)]
		public CtrRef<AudioGraphEvent> DefaultEnterScopeEvent { get { return m_DefaultEnterScopeEvent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DefaultEnterScopeEvent), this, m_DefaultEnterScopeEvent, value)) m_DefaultEnterScopeEvent = value; } } // 0x40 (64)
		
		protected bool m_IsPersistent = new bool();
		[ContainerField(Name: "IsPersistent", Offset: 68, NameHash: 2920156954, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsPersistent { get { return m_IsPersistent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(IsPersistent), this, m_IsPersistent, value)) m_IsPersistent = value; } } // 0x44 (68)
		
		protected bool m_IsLooping = new bool();
		[ContainerField(Name: "IsLooping", Offset: 69, NameHash: 1137411139, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsLooping { get { return m_IsLooping; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(IsLooping), this, m_IsLooping, value)) m_IsLooping = value; } } // 0x45 (69)
		
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
