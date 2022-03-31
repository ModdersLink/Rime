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
	[ContainerType(4, 44)]
	public class UIHUDMessageBinding :
		UIDataBinding
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public UIDataSourceInfo MessageQuery { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public UIDataSourceInfo VisibilityQuery { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public int NumberOfRows { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			MessageQuery.Serialize(p_Writer, p_EbxWriter);
			VisibilityQuery.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(NumberOfRows);
		}
	}
}
