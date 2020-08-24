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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class VoiceOverInfoNode : 
		VoiceOverExpressionNode
	{
		protected CtrRef<VoiceOverValueConnection> m_Object = new CtrRef<VoiceOverValueConnection>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(2866508144), ContainerCtrRef]
		public CtrRef<VoiceOverValueConnection> Object { get { return m_Object; } set { if (OnPropertyChanging("VoiceOverInfoNode." + nameof(Object), this, m_Object, value)) m_Object = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverValue> m_Value = new CtrRef<VoiceOverValue>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(225375086), ContainerCtrRef]
		public CtrRef<VoiceOverValue> Value { get { return m_Value; } set { if (OnPropertyChanging("VoiceOverInfoNode." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverNamedValue> m_Field = new CtrRef<VoiceOverNamedValue>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(206678151), ContainerCtrRef]
		public CtrRef<VoiceOverNamedValue> Field { get { return m_Field; } set { if (OnPropertyChanging("VoiceOverInfoNode." + nameof(Field), this, m_Field, value)) m_Field = value; } } // 0x10 (16)
		
		protected CtrRef<VoiceOverObject> m_ExpectedType = new CtrRef<VoiceOverObject>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(1076570403), ContainerCtrRef]
		public CtrRef<VoiceOverObject> ExpectedType { get { return m_ExpectedType; } set { if (OnPropertyChanging("VoiceOverInfoNode." + nameof(ExpectedType), this, m_ExpectedType, value)) m_ExpectedType = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2866508144:
					Object = (CtrRef<VoiceOverValueConnection>) p_Value;
					break;

				case 225375086:
					Value = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 206678151:
					Field = (CtrRef<VoiceOverNamedValue>) p_Value;
					break;

				case 1076570403:
					ExpectedType = (CtrRef<VoiceOverObject>) p_Value;
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
				case 2866508144:
					return Object;

				case 225375086:
					return Value;

				case 206678151:
					return Field;

				case 1076570403:
					return ExpectedType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2866508144:
					return typeof(VoiceOverInfoNode).GetProperty(nameof(Object));

				case 225375086:
					return typeof(VoiceOverInfoNode).GetProperty(nameof(Value));

				case 206678151:
					return typeof(VoiceOverInfoNode).GetProperty(nameof(Field));

				case 1076570403:
					return typeof(VoiceOverInfoNode).GetProperty(nameof(ExpectedType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
