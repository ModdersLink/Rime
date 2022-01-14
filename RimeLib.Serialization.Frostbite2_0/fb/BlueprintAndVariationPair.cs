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
	[ContainerType(4, 20)]
	public class BlueprintAndVariationPair :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<Asset> BaseAsset { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<ObjectVariation> Variation { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(BaseAsset));
			p_Writer.Write(p_EbxWriter.WriteImport(Variation));
		}
	}
}
