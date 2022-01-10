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
	public class AISystemAsset : 
		GameAISystem
	{
		[ContainerField(12)]
		public CtrRef<AIVehicleTypes> Behaviours { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<OrderSettings> Orders { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<AISettingsData> Settings { get; set; } = new();

		public static void Deserialize(AISystemAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Behaviours.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Orders.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Settings.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
