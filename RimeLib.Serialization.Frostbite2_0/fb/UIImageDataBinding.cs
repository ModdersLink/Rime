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
	[ContainerType(4, 48)]
	public class UIImageDataBinding :
		UIDataBinding
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string StaticImageUrl { get; set; } = string.Empty;

		[ContainerField(12), JsonProperty(Order = 12)]
		public UIDataSourceInfo ImageData { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public UIDataSourceInfo Visibility { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool Visible { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(StaticImageUrl));
			ImageData.Serialize(p_Writer, p_EbxWriter);
			Visibility.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Visible);
			p_Writer.WriteNullBytes(3);
		}
	}
}
