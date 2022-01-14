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
	[ContainerType(16, 112)]
	public class BlueprintBundleStateLogicEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public List<string> BundleNames { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_BundleNames = p_EbxWriter.GetArrayWriter(BundleNames.GetType(), BundleNames.Count);
			p_Writer.Write(s_BundleNames.ArrayIndex);
			foreach (var s_Entry in BundleNames)
			{
				s_BundleNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.WriteNullBytes(12);
		}
	}
}
