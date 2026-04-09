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
	[ContainerType(4, 16)]
	public partial class SoundGraphPluginConnection :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private SoundGraphPluginConnectionType _ConnectionType = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private List<SoundGraphPluginConnectionParam> _Parameters = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<SoundBusData> _Bus = new();
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private sbyte _VoiceIndex;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) ConnectionType);
			(RimeWriter Writer, uint ArrayIndex) s_Parameters = p_EbxWriter.GetArrayWriter(Parameters.GetType(), Parameters.Count);
			p_Writer.Write(s_Parameters.ArrayIndex);
			foreach (var s_Entry in Parameters)
			{
				s_Entry.Serialize(s_Parameters.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Bus));
			p_Writer.Write(VoiceIndex);
			p_Writer.WriteNullBytes(3);
		}
	}
}
