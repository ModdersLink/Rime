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
	[ContainerType(4, 36)]
	public class VoiceOverContainerNode :
		VoiceOverStructureNode
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<VoiceOverValueConnection> Condition { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<VoiceOverStructureNode> TrueRelationship { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<VoiceOverStructureNode> FalseRelationship { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public VoiceOverContainerConditionMode ConditionMode { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float Probability { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Condition = p_EbxWriter.GetArrayWriter(Condition.GetType(), Condition.Count);
			p_Writer.Write(s_Condition.ArrayIndex);
			foreach (var s_Entry in Condition)
			{
				s_Condition.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Interval));
			(RimeWriter Writer, uint ArrayIndex) s_TrueRelationship = p_EbxWriter.GetArrayWriter(TrueRelationship.GetType(), TrueRelationship.Count);
			p_Writer.Write(s_TrueRelationship.ArrayIndex);
			foreach (var s_Entry in TrueRelationship)
			{
				s_TrueRelationship.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_FalseRelationship = p_EbxWriter.GetArrayWriter(FalseRelationship.GetType(), FalseRelationship.Count);
			p_Writer.Write(s_FalseRelationship.ArrayIndex);
			foreach (var s_Entry in FalseRelationship)
			{
				s_FalseRelationship.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write((int) ConditionMode);
			p_Writer.Write(Probability);
		}
	}
}
