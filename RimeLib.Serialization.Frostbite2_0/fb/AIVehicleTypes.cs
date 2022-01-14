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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class AIVehicleTypes :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<AIVehicleBehaviourData> VehicleTypes { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<BehaviourData> Goals { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<BehaviourData> Intents { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_VehicleTypes = p_EbxWriter.GetArrayWriter(VehicleTypes.GetType(), VehicleTypes.Count);
			p_Writer.Write(s_VehicleTypes.ArrayIndex);
			foreach (var s_Entry in VehicleTypes)
			{
				s_VehicleTypes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Goals = p_EbxWriter.GetArrayWriter(Goals.GetType(), Goals.Count);
			p_Writer.Write(s_Goals.ArrayIndex);
			foreach (var s_Entry in Goals)
			{
				s_Goals.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Intents = p_EbxWriter.GetArrayWriter(Intents.GetType(), Intents.Count);
			p_Writer.Write(s_Intents.ArrayIndex);
			foreach (var s_Entry in Intents)
			{
				s_Intents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
