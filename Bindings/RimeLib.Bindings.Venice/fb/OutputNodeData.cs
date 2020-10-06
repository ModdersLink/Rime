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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(80), ContainerClass]
	public class OutputNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("OutputNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_BypassHeadroom = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(1367046584)]
		public AudioGraphNodePort BypassHeadroom { get { return m_BypassHeadroom; } set { if (OnPropertyChanging("OutputNodeData." + nameof(BypassHeadroom), this, m_BypassHeadroom, value)) m_BypassHeadroom = value; } } // 0x10 (16)
		
		protected float m_MinDistance = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1885855628)]
		public float MinDistance { get { return m_MinDistance; } set { if (OnPropertyChanging("OutputNodeData." + nameof(MinDistance), this, m_MinDistance, value)) m_MinDistance = value; } } // 0x18 (24)
		
		protected AudioCurve m_AttenuationCurve = new AudioCurve();
		[ContainerField(28), MemberInfoFlag(41), ContainerFieldNameHash(2265142096)]
		public AudioCurve AttenuationCurve { get { return m_AttenuationCurve; } set { if (OnPropertyChanging("OutputNodeData." + nameof(AttenuationCurve), this, m_AttenuationCurve, value)) m_AttenuationCurve = value; } } // 0x1C (28)
		
		protected float m_Gain = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088703076)]
		public float Gain { get { return m_Gain; } set { if (OnPropertyChanging("OutputNodeData." + nameof(Gain), this, m_Gain, value)) m_Gain = value; } } // 0x24 (36)
		
		protected float m_HFDampingDistance = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1492194832)]
		public float HFDampingDistance { get { return m_HFDampingDistance; } set { if (OnPropertyChanging("OutputNodeData." + nameof(HFDampingDistance), this, m_HFDampingDistance, value)) m_HFDampingDistance = value; } } // 0x28 (40)
		
		protected float m_HFDampingObstruction = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2765497953)]
		public float HFDampingObstruction { get { return m_HFDampingObstruction; } set { if (OnPropertyChanging("OutputNodeData." + nameof(HFDampingObstruction), this, m_HFDampingObstruction, value)) m_HFDampingObstruction = value; } } // 0x2C (44)
		
		protected float m_HFDampingOcclusion = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2385956062)]
		public float HFDampingOcclusion { get { return m_HFDampingOcclusion; } set { if (OnPropertyChanging("OutputNodeData." + nameof(HFDampingOcclusion), this, m_HFDampingOcclusion, value)) m_HFDampingOcclusion = value; } } // 0x30 (48)
		
		protected SoundGraphPluginRef m_MainSendPlugin = new SoundGraphPluginRef();
		[ContainerField(52), MemberInfoFlag(41), ContainerFieldNameHash(1346040091)]
		public SoundGraphPluginRef MainSendPlugin { get { return m_MainSendPlugin; } set { if (OnPropertyChanging("OutputNodeData." + nameof(MainSendPlugin), this, m_MainSendPlugin, value)) m_MainSendPlugin = value; } } // 0x34 (52)
		
		protected CtrRef<SoundBusData> m_MainSend = new CtrRef<SoundBusData>();
		[ContainerField(56), MemberInfoFlag(53), ContainerFieldNameHash(4099336946), ContainerCtrRef]
		public CtrRef<SoundBusData> MainSend { get { return m_MainSend; } set { if (OnPropertyChanging("OutputNodeData." + nameof(MainSend), this, m_MainSend, value)) m_MainSend = value; } } // 0x38 (56)
		
		protected string m_OutputName = string.Empty;
		[ContainerField(60), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(543054269)]
		public string OutputName { get { return m_OutputName; } set { if (OnPropertyChanging("OutputNodeData." + nameof(OutputName), this, m_OutputName, value)) m_OutputName = value; } } // 0x3C (60)
		
		protected OutputTransformSource m_TransformSource = new OutputTransformSource();
		[ContainerField(64), MemberInfoFlag(137), ContainerFieldNameHash(2934743092)]
		public OutputTransformSource TransformSource { get { return m_TransformSource; } set { if (OnPropertyChanging("OutputNodeData." + nameof(TransformSource), this, m_TransformSource, value)) m_TransformSource = value; } } // 0x40 (64)
		
		protected uint m_OutputNameHash = new uint();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1998058351)]
		public uint OutputNameHash { get { return m_OutputNameHash; } set { if (OnPropertyChanging("OutputNodeData." + nameof(OutputNameHash), this, m_OutputNameHash, value)) m_OutputNameHash = value; } } // 0x44 (68)
		
		protected SoundGraphPluginRef m_LowPassPlugin = new SoundGraphPluginRef();
		[ContainerField(72), MemberInfoFlag(41), ContainerFieldNameHash(4212923945)]
		public SoundGraphPluginRef LowPassPlugin { get { return m_LowPassPlugin; } set { if (OnPropertyChanging("OutputNodeData." + nameof(LowPassPlugin), this, m_LowPassPlugin, value)) m_LowPassPlugin = value; } } // 0x48 (72)
		
		protected SoundGraphPluginRef m_VuPlugin = new SoundGraphPluginRef();
		[ContainerField(75), MemberInfoFlag(41), ContainerFieldNameHash(2033640783)]
		public SoundGraphPluginRef VuPlugin { get { return m_VuPlugin; } set { if (OnPropertyChanging("OutputNodeData." + nameof(VuPlugin), this, m_VuPlugin, value)) m_VuPlugin = value; } } // 0x4B (75)
		
		protected bool m_Solo = new bool();
		[ContainerField(78), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2089419354)]
		public bool Solo { get { return m_Solo; } set { if (OnPropertyChanging("OutputNodeData." + nameof(Solo), this, m_Solo, value)) m_Solo = value; } } // 0x4E (78)
		
		protected bool m_EnableHdr = new bool();
		[ContainerField(79), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2899402426)]
		public bool EnableHdr { get { return m_EnableHdr; } set { if (OnPropertyChanging("OutputNodeData." + nameof(EnableHdr), this, m_EnableHdr, value)) m_EnableHdr = value; } } // 0x4F (79)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 1367046584:
					BypassHeadroom = (AudioGraphNodePort) p_Value;
					break;

				case 1885855628:
					MinDistance = (float) p_Value;
					break;

				case 2265142096:
					AttenuationCurve = (AudioCurve) p_Value;
					break;

				case 2088703076:
					Gain = (float) p_Value;
					break;

				case 1492194832:
					HFDampingDistance = (float) p_Value;
					break;

				case 2765497953:
					HFDampingObstruction = (float) p_Value;
					break;

				case 2385956062:
					HFDampingOcclusion = (float) p_Value;
					break;

				case 1346040091:
					MainSendPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 4099336946:
					MainSend = (CtrRef<SoundBusData>) p_Value;
					break;

				case 543054269:
					OutputName = (string) p_Value;
					break;

				case 2934743092:
					TransformSource = (OutputTransformSource) Enum.ToObject(typeof(OutputTransformSource), p_Value);
					break;

				case 1998058351:
					OutputNameHash = (uint) p_Value;
					break;

				case 4212923945:
					LowPassPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 2033640783:
					VuPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 2089419354:
					Solo = (bool) p_Value;
					break;

				case 2899402426:
					EnableHdr = (bool) p_Value;
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
				case 5862146:
					return In;

				case 1367046584:
					return BypassHeadroom;

				case 1885855628:
					return MinDistance;

				case 2265142096:
					return AttenuationCurve;

				case 2088703076:
					return Gain;

				case 1492194832:
					return HFDampingDistance;

				case 2765497953:
					return HFDampingObstruction;

				case 2385956062:
					return HFDampingOcclusion;

				case 1346040091:
					return MainSendPlugin;

				case 4099336946:
					return MainSend;

				case 543054269:
					return OutputName;

				case 2934743092:
					return TransformSource;

				case 1998058351:
					return OutputNameHash;

				case 4212923945:
					return LowPassPlugin;

				case 2033640783:
					return VuPlugin;

				case 2089419354:
					return Solo;

				case 2899402426:
					return EnableHdr;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(OutputNodeData).GetProperty(nameof(In));

				case 1367046584:
					return typeof(OutputNodeData).GetProperty(nameof(BypassHeadroom));

				case 1885855628:
					return typeof(OutputNodeData).GetProperty(nameof(MinDistance));

				case 2265142096:
					return typeof(OutputNodeData).GetProperty(nameof(AttenuationCurve));

				case 2088703076:
					return typeof(OutputNodeData).GetProperty(nameof(Gain));

				case 1492194832:
					return typeof(OutputNodeData).GetProperty(nameof(HFDampingDistance));

				case 2765497953:
					return typeof(OutputNodeData).GetProperty(nameof(HFDampingObstruction));

				case 2385956062:
					return typeof(OutputNodeData).GetProperty(nameof(HFDampingOcclusion));

				case 1346040091:
					return typeof(OutputNodeData).GetProperty(nameof(MainSendPlugin));

				case 4099336946:
					return typeof(OutputNodeData).GetProperty(nameof(MainSend));

				case 543054269:
					return typeof(OutputNodeData).GetProperty(nameof(OutputName));

				case 2934743092:
					return typeof(OutputNodeData).GetProperty(nameof(TransformSource));

				case 1998058351:
					return typeof(OutputNodeData).GetProperty(nameof(OutputNameHash));

				case 4212923945:
					return typeof(OutputNodeData).GetProperty(nameof(LowPassPlugin));

				case 2033640783:
					return typeof(OutputNodeData).GetProperty(nameof(VuPlugin));

				case 2089419354:
					return typeof(OutputNodeData).GetProperty(nameof(Solo));

				case 2899402426:
					return typeof(OutputNodeData).GetProperty(nameof(EnableHdr));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
