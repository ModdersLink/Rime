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
	public partial class AIVehicleTypes :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<AIVehicleBehaviourData> _VehicleTypes = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<BehaviourData> _Goals = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<BehaviourData> _Intents = new();

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
