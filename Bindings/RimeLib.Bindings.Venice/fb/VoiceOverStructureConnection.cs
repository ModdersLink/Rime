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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VoiceOverStructureConnection : 
		DataContainer
	{
		protected CtrRef<VoiceOverStructureNode> m_TargetNode = new CtrRef<VoiceOverStructureNode>();
		[ContainerField(Name: "TargetNode", Offset: 8, NameHash: 328873140, Flags: 53)]
		public CtrRef<VoiceOverStructureNode> TargetNode { get { return m_TargetNode; } set { if (OnPropertyChanging("VoiceOverStructureConnection." + nameof(TargetNode), this, m_TargetNode, value)) m_TargetNode = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverRelationshipInput> m_TargetInput = new CtrRef<VoiceOverRelationshipInput>();
		[ContainerField(Name: "TargetInput", Offset: 12, NameHash: 2268616418, Flags: 53)]
		public CtrRef<VoiceOverRelationshipInput> TargetInput { get { return m_TargetInput; } set { if (OnPropertyChanging("VoiceOverStructureConnection." + nameof(TargetInput), this, m_TargetInput, value)) m_TargetInput = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 328873140:
					TargetNode = (CtrRef<VoiceOverStructureNode>) p_Value;
					break;

				case 2268616418:
					TargetInput = (CtrRef<VoiceOverRelationshipInput>) p_Value;
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
				case 328873140:
					return TargetNode;

				case 2268616418:
					return TargetInput;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 328873140:
					return typeof(VoiceOverStructureConnection).GetProperty(nameof(TargetNode));

				case 2268616418:
					return typeof(VoiceOverStructureConnection).GetProperty(nameof(TargetInput));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
