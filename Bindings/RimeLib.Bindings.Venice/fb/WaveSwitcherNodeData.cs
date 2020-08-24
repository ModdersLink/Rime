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
	public class WaveSwitcherNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Index = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(214509467)]
		public AudioGraphNodePort Index { get { return m_Index; } set { if (OnPropertyChanging("WaveSwitcherNodeData." + nameof(Index), this, m_Index, value)) m_Index = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Advance = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(343579199)]
		public AudioGraphNodePort Advance { get { return m_Advance; } set { if (OnPropertyChanging("WaveSwitcherNodeData." + nameof(Advance), this, m_Advance, value)) m_Advance = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Wave = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(2089277184)]
		public AudioGraphNodePort Wave { get { return m_Wave; } set { if (OnPropertyChanging("WaveSwitcherNodeData." + nameof(Wave), this, m_Wave, value)) m_Wave = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_IndexChanged = new AudioGraphNodePort();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(3560418393)]
		public AudioGraphNodePort IndexChanged { get { return m_IndexChanged; } set { if (OnPropertyChanging("WaveSwitcherNodeData." + nameof(IndexChanged), this, m_IndexChanged, value)) m_IndexChanged = value; } } // 0x20 (32)
		
		protected RefArray<SoundWaveAsset> m_Waves = new RefArray<SoundWaveAsset>();
		[ContainerField(40), MemberInfoFlag(65), ContainerFieldNameHash(226670451), ContainerRefArray]
		public RefArray<SoundWaveAsset> Waves { get { return m_Waves; } set { if (OnPropertyChanging("WaveSwitcherNodeData." + nameof(Waves), this, m_Waves, value)) m_Waves = value; } } // 0x28 (40)
		
		protected float m_DefaultIndex = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2048165968)]
		public float DefaultIndex { get { return m_DefaultIndex; } set { if (OnPropertyChanging("WaveSwitcherNodeData." + nameof(DefaultIndex), this, m_DefaultIndex, value)) m_DefaultIndex = value; } } // 0x2C (44)
		
		protected bool m_IsRandom = new bool();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(421699588)]
		public bool IsRandom { get { return m_IsRandom; } set { if (OnPropertyChanging("WaveSwitcherNodeData." + nameof(IsRandom), this, m_IsRandom, value)) m_IsRandom = value; } } // 0x30 (48)
		
		protected bool m_RandomStartIndex = new bool();
		[ContainerField(49), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3711152288)]
		public bool RandomStartIndex { get { return m_RandomStartIndex; } set { if (OnPropertyChanging("WaveSwitcherNodeData." + nameof(RandomStartIndex), this, m_RandomStartIndex, value)) m_RandomStartIndex = value; } } // 0x31 (49)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 214509467:
					Index = (AudioGraphNodePort) p_Value;
					break;

				case 343579199:
					Advance = (AudioGraphNodePort) p_Value;
					break;

				case 2089277184:
					Wave = (AudioGraphNodePort) p_Value;
					break;

				case 3560418393:
					IndexChanged = (AudioGraphNodePort) p_Value;
					break;

				case 226670451:
					Waves = (RefArray<SoundWaveAsset>) p_Value;
					break;

				case 2048165968:
					DefaultIndex = (float) p_Value;
					break;

				case 421699588:
					IsRandom = (bool) p_Value;
					break;

				case 3711152288:
					RandomStartIndex = (bool) p_Value;
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
				case 214509467:
					return Index;

				case 343579199:
					return Advance;

				case 2089277184:
					return Wave;

				case 3560418393:
					return IndexChanged;

				case 226670451:
					return Waves;

				case 2048165968:
					return DefaultIndex;

				case 421699588:
					return IsRandom;

				case 3711152288:
					return RandomStartIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 214509467:
					return typeof(WaveSwitcherNodeData).GetProperty(nameof(Index));

				case 343579199:
					return typeof(WaveSwitcherNodeData).GetProperty(nameof(Advance));

				case 2089277184:
					return typeof(WaveSwitcherNodeData).GetProperty(nameof(Wave));

				case 3560418393:
					return typeof(WaveSwitcherNodeData).GetProperty(nameof(IndexChanged));

				case 226670451:
					return typeof(WaveSwitcherNodeData).GetProperty(nameof(Waves));

				case 2048165968:
					return typeof(WaveSwitcherNodeData).GetProperty(nameof(DefaultIndex));

				case 421699588:
					return typeof(WaveSwitcherNodeData).GetProperty(nameof(IsRandom));

				case 3711152288:
					return typeof(WaveSwitcherNodeData).GetProperty(nameof(RandomStartIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
