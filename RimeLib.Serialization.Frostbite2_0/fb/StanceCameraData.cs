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
	[ContainerType(4, 8)]
	public class StanceCameraData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<int> ValidStances { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<int> DefaultCameraForStances { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ValidStances = p_EbxWriter.GetArrayWriter(ValidStances.GetType(), ValidStances.Count);
			p_Writer.Write(s_ValidStances.ArrayIndex);
			foreach (var s_Entry in ValidStances)
			{
				s_ValidStances.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_DefaultCameraForStances = p_EbxWriter.GetArrayWriter(DefaultCameraForStances.GetType(), DefaultCameraForStances.Count);
			p_Writer.Write(s_DefaultCameraForStances.ArrayIndex);
			foreach (var s_Entry in DefaultCameraForStances)
			{
				s_DefaultCameraForStances.Writer.Write(s_Entry);
			}
		}
	}
}
