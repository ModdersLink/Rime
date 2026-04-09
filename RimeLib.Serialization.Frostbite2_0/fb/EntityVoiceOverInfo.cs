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
	public partial class EntityVoiceOverInfo :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<VoiceOverObject> _VoiceOverType = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<VoiceOverLabel> _Labels = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteImport(VoiceOverType));
			(RimeWriter Writer, uint ArrayIndex) s_Labels = p_EbxWriter.GetArrayWriter(Labels.GetType(), Labels.Count);
			p_Writer.Write(s_Labels.ArrayIndex);
			foreach (var s_Entry in Labels)
			{
				s_Labels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
