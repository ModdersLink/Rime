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
	public class SubWorldInclusionSetting :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<SubWorldInclusionCriterion> Criterion { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<string> EnabledOptions { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Criterion));
			(RimeWriter Writer, uint ArrayIndex) s_EnabledOptions = p_EbxWriter.GetArrayWriter(EnabledOptions.GetType(), EnabledOptions.Count);
			p_Writer.Write(s_EnabledOptions.ArrayIndex);
			foreach (var s_Entry in EnabledOptions)
			{
				s_EnabledOptions.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
