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
	[ContainerType(4, 24)]
	public class MixerPresetGroupData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public CtrRef<MixGroup> Group { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public MixGroupState State { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float AttackTime { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float ReleaseTime { get; set; }
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public List<MixGroupPropertyValue> Properties { get; set; } = new();
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool IsDominant { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Group));
			p_Writer.Write((int) State);
			p_Writer.Write(AttackTime);
			p_Writer.Write(ReleaseTime);
			(RimeWriter Writer, uint ArrayIndex) s_Properties = p_EbxWriter.GetArrayWriter(Properties.GetType(), Properties.Count);
			p_Writer.Write(s_Properties.ArrayIndex);
			foreach (var s_Entry in Properties)
			{
				s_Entry.Serialize(s_Properties.Writer, p_EbxWriter);
			}
			p_Writer.Write(IsDominant);
			p_Writer.WriteNullBytes(3);
		}
	}
}
