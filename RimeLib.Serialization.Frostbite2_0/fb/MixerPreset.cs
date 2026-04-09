///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 20)]
	public partial class MixerPreset :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _NameHash;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<MixerPresetGroupData> _Groups = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<MixerPresetNodeData> _Nodes = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(NameHash);
			(RimeWriter Writer, uint ArrayIndex) s_Groups = p_EbxWriter.GetArrayWriter(Groups.GetType(), Groups.Count);
			p_Writer.Write(s_Groups.ArrayIndex);
			foreach (var s_Entry in Groups)
			{
				s_Entry.Serialize(s_Groups.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Nodes = p_EbxWriter.GetArrayWriter(Nodes.GetType(), Nodes.Count);
			p_Writer.Write(s_Nodes.ArrayIndex);
			foreach (var s_Entry in Nodes)
			{
				s_Entry.Serialize(s_Nodes.Writer, p_EbxWriter);
			}
		}
	}
}
