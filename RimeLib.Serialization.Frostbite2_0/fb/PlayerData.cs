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

namespace fb
{
	[ContainerType(4, 24)]
	public class PlayerData :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<PlayerViewData> PlayerView { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<InputActionMappingsData> InputMapping { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(PlayerView));
			p_Writer.Write(p_EbxWriter.WriteImport(InputConceptDefinition));
			p_Writer.Write(p_EbxWriter.WriteImport(InputMapping));
		}
	}
}
