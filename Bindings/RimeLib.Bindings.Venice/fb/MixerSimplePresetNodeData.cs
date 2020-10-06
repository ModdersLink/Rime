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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class MixerSimplePresetNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Index = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(214509467)]
		public AudioGraphNodePort Index { get { return m_Index; } set { if (OnPropertyChanging("MixerSimplePresetNodeData." + nameof(Index), this, m_Index, value)) m_Index = value; } } // 0x8 (8)
		
		protected RefArray<MixerPreset> m_Presets = new RefArray<MixerPreset>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(3463460435), ContainerRefArray]
		public RefArray<MixerPreset> Presets { get { return m_Presets; } set { if (OnPropertyChanging("MixerSimplePresetNodeData." + nameof(Presets), this, m_Presets, value)) m_Presets = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 214509467:
					Index = (AudioGraphNodePort) p_Value;
					break;

				case 3463460435:
					Presets = (RefArray<MixerPreset>) p_Value;
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

				case 3463460435:
					return Presets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 214509467:
					return typeof(MixerSimplePresetNodeData).GetProperty(nameof(Index));

				case 3463460435:
					return typeof(MixerSimplePresetNodeData).GetProperty(nameof(Presets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
