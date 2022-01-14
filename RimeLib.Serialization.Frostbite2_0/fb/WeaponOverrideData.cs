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
	[ContainerType(4, 16)]
	public class WeaponOverrideData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<DataContainer> Data { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<WeaponOverrideValue> Values { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Data));
			(RimeWriter Writer, uint ArrayIndex) s_Values = p_EbxWriter.GetArrayWriter(Values.GetType(), Values.Count);
			p_Writer.Write(s_Values.ArrayIndex);
			foreach (var s_Entry in Values)
			{
				s_Entry.Serialize(s_Values.Writer, p_EbxWriter);
			}
		}
	}
}
