///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class VoiceOverContainerNode : 
		VoiceOverStructureNode
	{
		protected RefArray<VoiceOverValueConnection> m_Condition = new RefArray<VoiceOverValueConnection>();
		[ContainerField(12), ContainerFieldNameHash(1800624758)]
		public RefArray<VoiceOverValueConnection> Condition { get { return m_Condition; } set { if (OnPropertyChanging("VoiceOverContainerNode." + nameof(Condition), this, m_Condition, value)) m_Condition = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverIntervalNode> m_Interval = new CtrRef<VoiceOverIntervalNode>();
		[ContainerField(16), ContainerFieldNameHash(4280103418)]
		public CtrRef<VoiceOverIntervalNode> Interval { get { return m_Interval; } set { if (OnPropertyChanging("VoiceOverContainerNode." + nameof(Interval), this, m_Interval, value)) m_Interval = value; } } // 0x10 (16)
		
		protected RefArray<VoiceOverStructureNode> m_TrueRelationship = new RefArray<VoiceOverStructureNode>();
		[ContainerField(20), ContainerFieldNameHash(2563717655)]
		public RefArray<VoiceOverStructureNode> TrueRelationship { get { return m_TrueRelationship; } set { if (OnPropertyChanging("VoiceOverContainerNode." + nameof(TrueRelationship), this, m_TrueRelationship, value)) m_TrueRelationship = value; } } // 0x14 (20)
		
		protected RefArray<VoiceOverStructureNode> m_FalseRelationship = new RefArray<VoiceOverStructureNode>();
		[ContainerField(24), ContainerFieldNameHash(1133905660)]
		public RefArray<VoiceOverStructureNode> FalseRelationship { get { return m_FalseRelationship; } set { if (OnPropertyChanging("VoiceOverContainerNode." + nameof(FalseRelationship), this, m_FalseRelationship, value)) m_FalseRelationship = value; } } // 0x18 (24)
		
		protected VoiceOverContainerConditionMode m_ConditionMode = new VoiceOverContainerConditionMode();
		[ContainerField(28), ContainerFieldNameHash(1106041141)]
		public VoiceOverContainerConditionMode ConditionMode { get { return m_ConditionMode; } set { if (OnPropertyChanging("VoiceOverContainerNode." + nameof(ConditionMode), this, m_ConditionMode, value)) m_ConditionMode = value; } } // 0x1C (28)
		
		protected float m_Probability = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(35957416)]
		public float Probability { get { return m_Probability; } set { if (OnPropertyChanging("VoiceOverContainerNode." + nameof(Probability), this, m_Probability, value)) m_Probability = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1800624758:
					Condition = (RefArray<VoiceOverValueConnection>) p_Value;
					break;

				case 4280103418:
					Interval = (CtrRef<VoiceOverIntervalNode>) p_Value;
					break;

				case 2563717655:
					TrueRelationship = (RefArray<VoiceOverStructureNode>) p_Value;
					break;

				case 1133905660:
					FalseRelationship = (RefArray<VoiceOverStructureNode>) p_Value;
					break;

				case 1106041141:
					ConditionMode = (VoiceOverContainerConditionMode) Enum.ToObject(typeof(VoiceOverContainerConditionMode), p_Value);
					break;

				case 35957416:
					Probability = (float) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1800624758:
					return Condition;

				case 4280103418:
					return Interval;

				case 2563717655:
					return TrueRelationship;

				case 1133905660:
					return FalseRelationship;

				case 1106041141:
					return ConditionMode;

				case 35957416:
					return Probability;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1800624758:
					return typeof(VoiceOverContainerNode).GetProperty(nameof(Condition));

				case 4280103418:
					return typeof(VoiceOverContainerNode).GetProperty(nameof(Interval));

				case 2563717655:
					return typeof(VoiceOverContainerNode).GetProperty(nameof(TrueRelationship));

				case 1133905660:
					return typeof(VoiceOverContainerNode).GetProperty(nameof(FalseRelationship));

				case 1106041141:
					return typeof(VoiceOverContainerNode).GetProperty(nameof(ConditionMode));

				case 35957416:
					return typeof(VoiceOverContainerNode).GetProperty(nameof(Probability));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
