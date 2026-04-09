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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 36)]
	public partial class VoiceOverContainerNode :
		VoiceOverStructureNode
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<VoiceOverValueConnection> _Condition = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<VoiceOverIntervalNode> _Interval = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<VoiceOverStructureNode> _TrueRelationship = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private RefArray<VoiceOverStructureNode> _FalseRelationship = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private VoiceOverContainerConditionMode _ConditionMode = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _Probability;

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
