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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class DivisibleLoopPlayerNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Start = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(230748069)]
		public AudioGraphNodePort Start { get { return m_Start; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(Start), this, m_Start, value)) m_Start = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Stop = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(2089401213)]
		public AudioGraphNodePort Stop { get { return m_Stop; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(Stop), this, m_Stop, value)) m_Stop = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Amplitude = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(698564572)]
		public AudioGraphNodePort Amplitude { get { return m_Amplitude; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(Amplitude), this, m_Amplitude, value)) m_Amplitude = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_FreezeSegment = new AudioGraphNodePort();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(3532981773)]
		public AudioGraphNodePort FreezeSegment { get { return m_FreezeSegment; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(FreezeSegment), this, m_FreezeSegment, value)) m_FreezeSegment = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_Output = new AudioGraphNodePort();
		[ContainerField(40), MemberInfoFlag(41), ContainerFieldNameHash(2895736442)]
		public AudioGraphNodePort Output { get { return m_Output; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(Output), this, m_Output, value)) m_Output = value; } } // 0x28 (40)
		
		protected CtrRef<SoundWaveAsset> m_Wave = new CtrRef<SoundWaveAsset>();
		[ContainerField(48), MemberInfoFlag(53), ContainerFieldNameHash(2089277184), ContainerCtrRef]
		public CtrRef<SoundWaveAsset> Wave { get { return m_Wave; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(Wave), this, m_Wave, value)) m_Wave = value; } } // 0x30 (48)
		
		protected AudioGraphNodePort m_ExternalWave = new AudioGraphNodePort();
		[ContainerField(52), MemberInfoFlag(41), ContainerFieldNameHash(2162866621)]
		public AudioGraphNodePort ExternalWave { get { return m_ExternalWave; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(ExternalWave), this, m_ExternalWave, value)) m_ExternalWave = value; } } // 0x34 (52)
		
		protected List<DivisibleLoopPlayerPlugins> m_Plugins = new List<DivisibleLoopPlayerPlugins>();
		[ContainerField(60), MemberInfoFlag(65), ContainerFieldNameHash(14514271), ContainerArray]
		public List<DivisibleLoopPlayerPlugins> Plugins { get { return m_Plugins; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(Plugins), this, m_Plugins, value)) m_Plugins = value; } } // 0x3C (60)
		
		protected float m_CrossFadeLength = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2603726337)]
		public float CrossFadeLength { get { return m_CrossFadeLength; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(CrossFadeLength), this, m_CrossFadeLength, value)) m_CrossFadeLength = value; } } // 0x40 (64)
		
		protected bool m_StartAtRandomPosition = new bool();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(663970258)]
		public bool StartAtRandomPosition { get { return m_StartAtRandomPosition; } set { if (OnPropertyChanging("DivisibleLoopPlayerNodeData." + nameof(StartAtRandomPosition), this, m_StartAtRandomPosition, value)) m_StartAtRandomPosition = value; } } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 2089401213:
					Stop = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 3532981773:
					FreezeSegment = (AudioGraphNodePort) p_Value;
					break;

				case 2895736442:
					Output = (AudioGraphNodePort) p_Value;
					break;

				case 2089277184:
					Wave = (CtrRef<SoundWaveAsset>) p_Value;
					break;

				case 2162866621:
					ExternalWave = (AudioGraphNodePort) p_Value;
					break;

				case 14514271:
					Plugins = (List<DivisibleLoopPlayerPlugins>) p_Value;
					break;

				case 2603726337:
					CrossFadeLength = (float) p_Value;
					break;

				case 663970258:
					StartAtRandomPosition = (bool) p_Value;
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
				case 230748069:
					return Start;

				case 2089401213:
					return Stop;

				case 698564572:
					return Amplitude;

				case 3532981773:
					return FreezeSegment;

				case 2895736442:
					return Output;

				case 2089277184:
					return Wave;

				case 2162866621:
					return ExternalWave;

				case 14514271:
					return Plugins;

				case 2603726337:
					return CrossFadeLength;

				case 663970258:
					return StartAtRandomPosition;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230748069:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Start));

				case 2089401213:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Stop));

				case 698564572:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Amplitude));

				case 3532981773:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(FreezeSegment));

				case 2895736442:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Output));

				case 2089277184:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Wave));

				case 2162866621:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(ExternalWave));

				case 14514271:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(Plugins));

				case 2603726337:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(CrossFadeLength));

				case 663970258:
					return typeof(DivisibleLoopPlayerNodeData).GetProperty(nameof(StartAtRandomPosition));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
