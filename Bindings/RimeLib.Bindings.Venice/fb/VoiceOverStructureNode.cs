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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(12), ContainerClass]
	public class VoiceOverStructureNode : 
		VoiceOverNode
	{
		protected VoiceOverLogicFlowMode m_FlowMode = new VoiceOverLogicFlowMode();
		[ContainerField(8), MemberInfoFlag(137), ContainerFieldNameHash(1740495380)]
		public VoiceOverLogicFlowMode FlowMode { get { return m_FlowMode; } set { if (OnPropertyChanging("VoiceOverStructureNode." + nameof(FlowMode), this, m_FlowMode, value)) m_FlowMode = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1740495380:
					FlowMode = (VoiceOverLogicFlowMode) Enum.ToObject(typeof(VoiceOverLogicFlowMode), p_Value);
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
				case 1740495380:
					return FlowMode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1740495380:
					return typeof(VoiceOverStructureNode).GetProperty(nameof(FlowMode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
