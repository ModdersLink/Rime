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
	public class MultiCrossfaderNodeData :
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<MultiCrossfaderGroup> CrossfaderGroups { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public AudioGraphNodePort Start { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public AudioGraphNodePort Stop { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public AudioGraphNodePort Control { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public bool LockControlValue { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_CrossfaderGroups = p_EbxWriter.GetArrayWriter(CrossfaderGroups.GetType(), CrossfaderGroups.Count);
			p_Writer.Write(s_CrossfaderGroups.ArrayIndex);
			foreach (var s_Entry in CrossfaderGroups)
			{
				s_CrossfaderGroups.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			Start.Serialize(p_Writer, p_EbxWriter);
			Stop.Serialize(p_Writer, p_EbxWriter);
			Control.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LockControlValue);
			p_Writer.WriteNullBytes(3);
		}
	}
}
