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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class MultiCrossfaderGroup : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_Amplitude = new AudioGraphNodePort();
		[ContainerField(Name: "Amplitude", Offset: 8, NameHash: 698564572, Flags: 41)]
		public AudioGraphNodePort Amplitude { get { return m_Amplitude; } set { if (OnPropertyChanging("MultiCrossfaderGroup." + nameof(Amplitude), this, m_Amplitude, value)) m_Amplitude = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Start = new AudioGraphNodePort();
		[ContainerField(Name: "Start", Offset: 16, NameHash: 230748069, Flags: 41)]
		public AudioGraphNodePort Start { get { return m_Start; } set { if (OnPropertyChanging("MultiCrossfaderGroup." + nameof(Start), this, m_Start, value)) m_Start = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Stop = new AudioGraphNodePort();
		[ContainerField(Name: "Stop", Offset: 24, NameHash: 2089401213, Flags: 41)]
		public AudioGraphNodePort Stop { get { return m_Stop; } set { if (OnPropertyChanging("MultiCrossfaderGroup." + nameof(Stop), this, m_Stop, value)) m_Stop = value; } } // 0x18 (24)
		
		protected float m_FadeAmplitude = new float();
		[ContainerField(Name: "FadeAmplitude", Offset: 32, NameHash: 282245178, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeAmplitude { get { return m_FadeAmplitude; } set { if (OnPropertyChanging("MultiCrossfaderGroup." + nameof(FadeAmplitude), this, m_FadeAmplitude, value)) m_FadeAmplitude = value; } } // 0x20 (32)
		
		protected float m_FadeBegin = new float();
		[ContainerField(Name: "FadeBegin", Offset: 36, NameHash: 3160511748, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeBegin { get { return m_FadeBegin; } set { if (OnPropertyChanging("MultiCrossfaderGroup." + nameof(FadeBegin), this, m_FadeBegin, value)) m_FadeBegin = value; } } // 0x24 (36)
		
		protected float m_FadeEnd = new float();
		[ContainerField(Name: "FadeEnd", Offset: 40, NameHash: 1422737676, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeEnd { get { return m_FadeEnd; } set { if (OnPropertyChanging("MultiCrossfaderGroup." + nameof(FadeEnd), this, m_FadeEnd, value)) m_FadeEnd = value; } } // 0x28 (40)
		
		protected FaderType m_FadeType = new FaderType();
		[ContainerField(Name: "FadeType", Offset: 44, NameHash: 4001206363, Flags: 137)]
		public FaderType FadeType { get { return m_FadeType; } set { if (OnPropertyChanging("MultiCrossfaderGroup." + nameof(FadeType), this, m_FadeType, value)) m_FadeType = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 2089401213:
					Stop = (AudioGraphNodePort) p_Value;
					break;

				case 282245178:
					FadeAmplitude = (float) p_Value;
					break;

				case 3160511748:
					FadeBegin = (float) p_Value;
					break;

				case 1422737676:
					FadeEnd = (float) p_Value;
					break;

				case 4001206363:
					FadeType = (FaderType) Enum.ToObject(typeof(FaderType), p_Value);
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
				case 698564572:
					return Amplitude;

				case 230748069:
					return Start;

				case 2089401213:
					return Stop;

				case 282245178:
					return FadeAmplitude;

				case 3160511748:
					return FadeBegin;

				case 1422737676:
					return FadeEnd;

				case 4001206363:
					return FadeType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 698564572:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(Amplitude));

				case 230748069:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(Start));

				case 2089401213:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(Stop));

				case 282245178:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(FadeAmplitude));

				case 3160511748:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(FadeBegin));

				case 1422737676:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(FadeEnd));

				case 4001206363:
					return typeof(MultiCrossfaderGroup).GetProperty(nameof(FadeType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
