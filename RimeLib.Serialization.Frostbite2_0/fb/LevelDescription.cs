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
	public class LevelDescription :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string Description { get; set; } = string.Empty;
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<LevelDescriptionComponent> Components { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public bool IsCoop { get; set; }
		
		[ContainerField(13), LayoutImmutable, Blittable, JsonProperty(Order = 13)]
		public bool IsMenu { get; set; }
		
		[ContainerField(14), LayoutImmutable, Blittable, JsonProperty(Order = 14)]
		public bool IsMultiplayer { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteString(Description));
			(RimeWriter Writer, uint ArrayIndex) s_Components = p_EbxWriter.GetArrayWriter(Components.GetType(), Components.Count);
			p_Writer.Write(s_Components.ArrayIndex);
			foreach (var s_Entry in Components)
			{
				s_Components.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(IsCoop);
			p_Writer.Write(IsMenu);
			p_Writer.Write(IsMultiplayer);
			p_Writer.WriteNullBytes(1);
		}
	}
}
