///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class BlueprintAndVariationPair : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<Asset> BaseAsset { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<ObjectVariation> Variation { get; set; } = new();

		public static void Deserialize(BlueprintAndVariationPair p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BaseAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Variation.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
