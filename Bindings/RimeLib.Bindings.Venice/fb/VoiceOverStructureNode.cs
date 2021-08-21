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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class VoiceOverStructureNode : 
		VoiceOverNode
	{
		protected VoiceOverLogicFlowMode m_FlowMode = new VoiceOverLogicFlowMode();
		[ContainerField(Name: "FlowMode", Offset: 8, NameHash: 1740495380, Flags: 137)]
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
