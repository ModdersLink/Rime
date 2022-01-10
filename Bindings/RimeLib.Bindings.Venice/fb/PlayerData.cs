///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class PlayerData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<PlayerViewData> PlayerView { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<InputActionMappingsData> InputMapping { get; set; } = new();

		public static void Deserialize(PlayerData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PlayerView.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.InputConceptDefinition.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.InputMapping.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
