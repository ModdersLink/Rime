///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 36)]
	public class VoiceOverContainerNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public List<CtrRef<VoiceOverValueConnection>> Condition { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<VoiceOverStructureNode>> TrueRelationship { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<VoiceOverStructureNode>> FalseRelationship { get; set; } = new();

		[ContainerField(28)]
		public VoiceOverContainerConditionMode ConditionMode { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Probability { get; set; }

		public static void Deserialize(VoiceOverContainerNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Condition.Clear();
			(RimeReader Reader, uint Count) s_Condition = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Condition.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverValueConnection>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Condition.Reader.ReadUInt32()));
				p_Instance.Condition.Add(s_CtrRef);
			}
			
			s_Condition.Reader.Dispose();
			p_Instance.Interval.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TrueRelationship.Clear();
			(RimeReader Reader, uint Count) s_TrueRelationship = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TrueRelationship.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverStructureNode>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TrueRelationship.Reader.ReadUInt32()));
				p_Instance.TrueRelationship.Add(s_CtrRef);
			}
			
			s_TrueRelationship.Reader.Dispose();
			p_Instance.FalseRelationship.Clear();
			(RimeReader Reader, uint Count) s_FalseRelationship = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FalseRelationship.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverStructureNode>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_FalseRelationship.Reader.ReadUInt32()));
				p_Instance.FalseRelationship.Add(s_CtrRef);
			}
			
			s_FalseRelationship.Reader.Dispose();
			p_Instance.ConditionMode = (VoiceOverContainerConditionMode) p_Reader.ReadInt32();
			p_Instance.Probability = p_Reader.ReadSingle();
		}

	}
}
