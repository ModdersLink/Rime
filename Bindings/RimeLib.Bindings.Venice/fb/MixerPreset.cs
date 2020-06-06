///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MixerPreset : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint NameHash { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public List<MixerPresetGroupData> Groups { get; set; } = new List<MixerPresetGroupData>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<MixerPresetNodeData> Nodes { get; set; } = new List<MixerPresetNodeData>(); // 0x10 (16)
		
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
