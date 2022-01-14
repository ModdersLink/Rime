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
	public class UIBundleAssetState :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string StateName { get; set; } = string.Empty;
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public UIState UIState { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string ResourceBundleName { get; set; } = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(StateName));
			p_Writer.Write((int) UIState);
			p_Writer.Write(p_EbxWriter.WriteString(ResourceBundleName));
		}
	}
}
