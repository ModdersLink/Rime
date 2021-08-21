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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class MixerPreset : 
		DataContainer
	{
		protected uint m_NameHash = new uint();
		[ContainerField(Name: "NameHash", Offset: 8, NameHash: 994057744, Flags: 49421), LayoutImmutable, Blittable]
		public uint NameHash { get { return m_NameHash; } set { if (OnPropertyChanging("MixerPreset." + nameof(NameHash), this, m_NameHash, value)) m_NameHash = value; } } // 0x8 (8)
		
		protected List<MixerPresetGroupData> m_Groups = new List<MixerPresetGroupData>();
		[ContainerField(Name: "Groups", Offset: 12, NameHash: 2573340009, Flags: 65)]
		public List<MixerPresetGroupData> Groups { get { return m_Groups; } set { if (OnPropertyChanging("MixerPreset." + nameof(Groups), this, m_Groups, value)) m_Groups = value; } } // 0xC (12)
		
		protected List<MixerPresetNodeData> m_Nodes = new List<MixerPresetNodeData>();
		[ContainerField(Name: "Nodes", Offset: 16, NameHash: 215794742, Flags: 65)]
		public List<MixerPresetNodeData> Nodes { get { return m_Nodes; } set { if (OnPropertyChanging("MixerPreset." + nameof(Nodes), this, m_Nodes, value)) m_Nodes = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 994057744:
					NameHash = (uint) p_Value;
					break;

				case 2573340009:
					Groups = (List<MixerPresetGroupData>) p_Value;
					break;

				case 215794742:
					Nodes = (List<MixerPresetNodeData>) p_Value;
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
				case 994057744:
					return NameHash;

				case 2573340009:
					return Groups;

				case 215794742:
					return Nodes;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 994057744:
					return typeof(MixerPreset).GetProperty(nameof(NameHash));

				case 2573340009:
					return typeof(MixerPreset).GetProperty(nameof(Groups));

				case 215794742:
					return typeof(MixerPreset).GetProperty(nameof(Nodes));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
