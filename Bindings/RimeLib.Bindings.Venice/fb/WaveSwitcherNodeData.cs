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
	public class WaveSwitcherNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Index { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Advance { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Wave { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort IndexChanged { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public RefArray<SoundWaveAsset> Waves { get; set; } = new RefArray<SoundWaveAsset>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float DefaultIndex { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool IsRandom { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool RandomStartIndex { get; set; } // 0x31 (49)
		
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
