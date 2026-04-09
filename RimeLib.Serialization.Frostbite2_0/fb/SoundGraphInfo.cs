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
	[ContainerType(4, 24)]
	public partial class SoundGraphInfo :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private List<SoundGraphVoiceInfo> _Voices = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private List<SoundGraphLinkedPluginAttribute> _LinkedPluginAttributes = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<SoundGraphPluginConnection> _Connections = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<SoundGraphPluginConstructParam> _ConstructParams = new();
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _PluginsParamCount;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _PluginCount;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Voices = p_EbxWriter.GetArrayWriter(Voices.GetType(), Voices.Count);
			p_Writer.Write(s_Voices.ArrayIndex);
			foreach (var s_Entry in Voices)
			{
				s_Entry.Serialize(s_Voices.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_LinkedPluginAttributes = p_EbxWriter.GetArrayWriter(LinkedPluginAttributes.GetType(), LinkedPluginAttributes.Count);
			p_Writer.Write(s_LinkedPluginAttributes.ArrayIndex);
			foreach (var s_Entry in LinkedPluginAttributes)
			{
				s_Entry.Serialize(s_LinkedPluginAttributes.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Connections = p_EbxWriter.GetArrayWriter(Connections.GetType(), Connections.Count);
			p_Writer.Write(s_Connections.ArrayIndex);
			foreach (var s_Entry in Connections)
			{
				s_Entry.Serialize(s_Connections.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ConstructParams = p_EbxWriter.GetArrayWriter(ConstructParams.GetType(), ConstructParams.Count);
			p_Writer.Write(s_ConstructParams.ArrayIndex);
			foreach (var s_Entry in ConstructParams)
			{
				s_Entry.Serialize(s_ConstructParams.Writer, p_EbxWriter);
			}
			p_Writer.Write(PluginsParamCount);
			p_Writer.Write(PluginCount);
		}
	}
}
