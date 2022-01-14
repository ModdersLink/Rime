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
	public class UIColorTemplate :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<UIColor> Colors { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool Active { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Colors = p_EbxWriter.GetArrayWriter(Colors.GetType(), Colors.Count);
			p_Writer.Write(s_Colors.ArrayIndex);
			foreach (var s_Entry in Colors)
			{
				s_Colors.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(Active);
			p_Writer.WriteNullBytes(3);
		}
	}
}
