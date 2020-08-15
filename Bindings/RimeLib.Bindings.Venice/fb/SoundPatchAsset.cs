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
	[ContainerType(4)]
	public class SoundPatchAsset : 
		SoundGraphAsset
	{
		protected RefArray<AudioGraphNodeData> m_OutputNodes = new RefArray<AudioGraphNodeData>();
		[ContainerField(24), ContainerFieldNameHash(740996521)]
		public RefArray<AudioGraphNodeData> OutputNodes { get { return m_OutputNodes; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(OutputNodes), this, m_OutputNodes, value)) m_OutputNodes = value; } } // 0x18 (24)
		
		protected float m_Loudness = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(2678891068)]
		public float Loudness { get { return m_Loudness; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(Loudness), this, m_Loudness, value)) m_Loudness = value; } } // 0x1C (28)
		
		protected float m_AILoudness = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(2389898900)]
		public float AILoudness { get { return m_AILoudness; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(AILoudness), this, m_AILoudness, value)) m_AILoudness = value; } } // 0x20 (32)
		
		protected float m_Radius = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(3298407133)]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x24 (36)
		
		protected float m_DopplerFactor = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(1757845912)]
		public float DopplerFactor { get { return m_DopplerFactor; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DopplerFactor), this, m_DopplerFactor, value)) m_DopplerFactor = value; } } // 0x28 (40)
		
		protected float m_MasterPitch = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(1108720767)]
		public float MasterPitch { get { return m_MasterPitch; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(MasterPitch), this, m_MasterPitch, value)) m_MasterPitch = value; } } // 0x2C (44)
		
		protected CtrRef<MixGroup> m_MixGroup = new CtrRef<MixGroup>();
		[ContainerField(48), ContainerFieldNameHash(3598170502)]
		public CtrRef<MixGroup> MixGroup { get { return m_MixGroup; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(MixGroup), this, m_MixGroup, value)) m_MixGroup = value; } } // 0x30 (48)
		
		protected CtrRef<AudioGraphEvent> m_DefaultStopEvent = new CtrRef<AudioGraphEvent>();
		[ContainerField(52), ContainerFieldNameHash(113607258)]
		public CtrRef<AudioGraphEvent> DefaultStopEvent { get { return m_DefaultStopEvent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DefaultStopEvent), this, m_DefaultStopEvent, value)) m_DefaultStopEvent = value; } } // 0x34 (52)
		
		protected CtrRef<AudioGraphEvent> m_DefaultStartEvent = new CtrRef<AudioGraphEvent>();
		[ContainerField(56), ContainerFieldNameHash(3663021474)]
		public CtrRef<AudioGraphEvent> DefaultStartEvent { get { return m_DefaultStartEvent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DefaultStartEvent), this, m_DefaultStartEvent, value)) m_DefaultStartEvent = value; } } // 0x38 (56)
		
		protected CtrRef<AudioGraphEvent> m_DefaultForceInitEvent = new CtrRef<AudioGraphEvent>();
		[ContainerField(60), ContainerFieldNameHash(2837520997)]
		public CtrRef<AudioGraphEvent> DefaultForceInitEvent { get { return m_DefaultForceInitEvent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DefaultForceInitEvent), this, m_DefaultForceInitEvent, value)) m_DefaultForceInitEvent = value; } } // 0x3C (60)
		
		protected CtrRef<AudioGraphEvent> m_DefaultEnterScopeEvent = new CtrRef<AudioGraphEvent>();
		[ContainerField(64), ContainerFieldNameHash(3819788512)]
		public CtrRef<AudioGraphEvent> DefaultEnterScopeEvent { get { return m_DefaultEnterScopeEvent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(DefaultEnterScopeEvent), this, m_DefaultEnterScopeEvent, value)) m_DefaultEnterScopeEvent = value; } } // 0x40 (64)
		
		protected bool m_IsPersistent = new bool();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(2920156954)]
		public bool IsPersistent { get { return m_IsPersistent; } set { if (OnPropertyChanging("SoundPatchAsset." + nameof(IsPersistent), this, m_IsPersistent, value)) m_IsPersistent = value; } } // 0x44 (68)
		
		protected bool m_IsLooping = new bool();
		[ContainerField(69), LayoutImmutable, Blittable, ContainerFieldNameHash(1137411139)]
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
