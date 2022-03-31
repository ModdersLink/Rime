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
	[ContainerType(4, 40)]
	public class StaticListItem :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string ItemName { get; set; } = string.Empty;
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public UIDataSourceInfo DynamicDisable { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public UIDataSourceInfo DynamicNewContent { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool AppendPlatformToSID { get; set; }
		
		[ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		public bool ExcludeInRetail { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ItemName));
			DynamicDisable.Serialize(p_Writer, p_EbxWriter);
			DynamicNewContent.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AppendPlatformToSID);
			p_Writer.Write(ExcludeInRetail);
			p_Writer.WriteNullBytes(2);
		}
	}
}
