///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VoiceOverContainerNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public RefArray<VoiceOverValueConnection> Condition { get; set; } = new RefArray<VoiceOverValueConnection>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new CtrRef<VoiceOverIntervalNode>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<VoiceOverStructureNode> TrueRelationship { get; set; } = new RefArray<VoiceOverStructureNode>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<VoiceOverStructureNode> FalseRelationship { get; set; } = new RefArray<VoiceOverStructureNode>(); // 0x18 (24)
		
		[ContainerField(28)]
		public VoiceOverContainerConditionMode ConditionMode { get; set; } = new VoiceOverContainerConditionMode(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Probability { get; set; } // 0x20 (32)
		
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
