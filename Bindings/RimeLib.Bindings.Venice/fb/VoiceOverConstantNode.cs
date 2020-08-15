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
	public class VoiceOverConstantNode : 
		VoiceOverExpressionNode
	{
		protected CtrRef<VoiceOverValue> m_Value = new CtrRef<VoiceOverValue>();
		[ContainerField(8), ContainerFieldNameHash(225375086)]
		public CtrRef<VoiceOverValue> Value { get { return m_Value; } set { if (OnPropertyChanging("VoiceOverConstantNode." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverConstantValue> m_Source = new CtrRef<VoiceOverConstantValue>();
		[ContainerField(12), ContainerFieldNameHash(3339738264)]
		public CtrRef<VoiceOverConstantValue> Source { get { return m_Source; } set { if (OnPropertyChanging("VoiceOverConstantNode." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 3339738264:
					Source = (CtrRef<VoiceOverConstantValue>) p_Value;
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
				case 225375086:
					return Value;

				case 3339738264:
					return Source;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(VoiceOverConstantNode).GetProperty(nameof(Value));

				case 3339738264:
					return typeof(VoiceOverConstantNode).GetProperty(nameof(Source));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
