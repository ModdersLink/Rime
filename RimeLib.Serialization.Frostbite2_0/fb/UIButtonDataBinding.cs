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
	public class UIButtonDataBinding :
		UIDataBinding
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public UIDataSourceInfo ButtonsDatasource { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public UIButtonSet DefaultButtonSet { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public UIDataSourceInfo Visibility { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public bool InvertVisible { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		public bool Visible { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
		public bool InputOnRelease { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ButtonsDatasource.Serialize(p_Writer, p_EbxWriter);
			DefaultButtonSet.Serialize(p_Writer, p_EbxWriter);
			Visibility.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(InvertVisible);
			p_Writer.Write(Visible);
			p_Writer.Write(InputOnRelease);
			p_Writer.WriteNullBytes(1);
		}
	}
}
