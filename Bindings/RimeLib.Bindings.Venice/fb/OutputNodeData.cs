///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class OutputNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort BypassHeadroom { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MinDistance { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public AudioCurve AttenuationCurve { get; set; } = new AudioCurve(); // 0x1C (28)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Gain { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float HFDampingDistance { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float HFDampingObstruction { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float HFDampingOcclusion { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public SoundGraphPluginRef MainSendPlugin { get; set; } = new SoundGraphPluginRef(); // 0x34 (52)
		
		[ContainerField(56)]
		public CtrRef<SoundBusData> MainSend { get; set; } = new CtrRef<SoundBusData>(); // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable]
		public string OutputName { get; set; } // 0x3C (60)
		
		[ContainerField(64)]
		public OutputTransformSource TransformSource { get; set; } = new OutputTransformSource(); // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public uint OutputNameHash { get; set; } // 0x44 (68)
		
		[ContainerField(72)]
		public SoundGraphPluginRef LowPassPlugin { get; set; } = new SoundGraphPluginRef(); // 0x48 (72)
		
		[ContainerField(75)]
		public SoundGraphPluginRef VuPlugin { get; set; } = new SoundGraphPluginRef(); // 0x4B (75)
		
		[ContainerField(78), LayoutImmutable, Blittable]
		public bool Solo { get; set; } // 0x4E (78)
		
		[ContainerField(79), LayoutImmutable, Blittable]
		public bool EnableHdr { get; set; } // 0x4F (79)
		
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
