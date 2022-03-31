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
	[ContainerType(4, 28)]
	public class EntityRecordingData :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public GUID EntityGuid { get; set; } = GUID.Empty;

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<PropertyRecordingData> Data { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			EntityGuid.Serialize(p_Writer);
			(RimeWriter Writer, uint ArrayIndex) s_Data = p_EbxWriter.GetArrayWriter(Data.GetType(), Data.Count);
			p_Writer.Write(s_Data.ArrayIndex);
			foreach (var s_Entry in Data)
			{
				s_Data.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
