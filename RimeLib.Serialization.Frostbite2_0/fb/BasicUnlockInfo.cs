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
	[ContainerType(4, 36)]
	public class BasicUnlockInfo :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public GUID UnlockGuid { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint Identifier { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public uint UnlockScore { get; set; }
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public List<string> Licenses { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public List<string> AdditionalLicenses { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string StringId { get; set; } = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			UnlockGuid.Serialize(p_Writer);
			p_Writer.Write(Identifier);
			p_Writer.Write(UnlockScore);
			(RimeWriter Writer, uint ArrayIndex) s_Licenses = p_EbxWriter.GetArrayWriter(Licenses.GetType(), Licenses.Count);
			p_Writer.Write(s_Licenses.ArrayIndex);
			foreach (var s_Entry in Licenses)
			{
				s_Licenses.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_AdditionalLicenses = p_EbxWriter.GetArrayWriter(AdditionalLicenses.GetType(), AdditionalLicenses.Count);
			p_Writer.Write(s_AdditionalLicenses.ArrayIndex);
			foreach (var s_Entry in AdditionalLicenses)
			{
				s_AdditionalLicenses.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(StringId));
		}
	}
}
