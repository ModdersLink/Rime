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
	[ContainerType(4, 16)]
	public class LevelSaveData :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint SaveSize { get; set; }

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<string> SaveNames { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SaveSize);
			(RimeWriter Writer, uint ArrayIndex) s_SaveNames = p_EbxWriter.GetArrayWriter(SaveNames.GetType(), SaveNames.Count);
			p_Writer.Write(s_SaveNames.ArrayIndex);
			foreach (var s_Entry in SaveNames)
			{
				s_SaveNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
