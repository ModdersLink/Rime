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
	[ContainerType(4, 12)]
	public class SceneRecordingData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<EntityRecordingData> Data { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Data = p_EbxWriter.GetArrayWriter(Data.GetType(), Data.Count);
			p_Writer.Write(s_Data.ArrayIndex);
			foreach (var s_Entry in Data)
			{
				s_Data.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
