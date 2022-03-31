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
	public class StatsCategoryVehicleStateTypeData :
		StatsCategoryBaseData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public List<VehicleStateType> States { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_States = p_EbxWriter.GetArrayWriter(States.GetType(), States.Count);
			p_Writer.Write(s_States.ArrayIndex);
			foreach (var s_Entry in States)
			{
				s_States.Writer.Write((int) s_Entry);
			}
		}
	}
}
