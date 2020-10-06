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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class VoiceOverValueConnection : 
		DataContainer
	{
		protected CtrRef<VoiceOverExpressionNode> m_TargetNode = new CtrRef<VoiceOverExpressionNode>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(328873140), ContainerCtrRef]
		public CtrRef<VoiceOverExpressionNode> TargetNode { get { return m_TargetNode; } set { if (OnPropertyChanging("VoiceOverValueConnection." + nameof(TargetNode), this, m_TargetNode, value)) m_TargetNode = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValue> m_TargetValue = new CtrRef<VoiceOverValue>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(2234789535), ContainerCtrRef]
		public CtrRef<VoiceOverValue> TargetValue { get { return m_TargetValue; } set { if (OnPropertyChanging("VoiceOverValueConnection." + nameof(TargetValue), this, m_TargetValue, value)) m_TargetValue = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 328873140:
					TargetNode = (CtrRef<VoiceOverExpressionNode>) p_Value;
					break;

				case 2234789535:
					TargetValue = (CtrRef<VoiceOverValue>) p_Value;
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

				case 2234789535:
					return TargetValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 328873140:
					return typeof(VoiceOverValueConnection).GetProperty(nameof(TargetNode));

				case 2234789535:
					return typeof(VoiceOverValueConnection).GetProperty(nameof(TargetValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
