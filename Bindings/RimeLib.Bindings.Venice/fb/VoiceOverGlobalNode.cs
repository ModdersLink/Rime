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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class VoiceOverGlobalNode : 
		VoiceOverExpressionNode
	{
		protected CtrRef<VoiceOverValue> m_Value = new CtrRef<VoiceOverValue>();
		[ContainerField(Name: "Value", Offset: 8, NameHash: 225375086, Flags: 53)]
		public CtrRef<VoiceOverValue> Value { get { return m_Value; } set { if (OnPropertyChanging("VoiceOverGlobalNode." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x8 (8)
		
		protected CtrRef<VoiceOverNamedValue> m_Field = new CtrRef<VoiceOverNamedValue>();
		[ContainerField(Name: "Field", Offset: 12, NameHash: 206678151, Flags: 53)]
		public CtrRef<VoiceOverNamedValue> Field { get { return m_Field; } set { if (OnPropertyChanging("VoiceOverGlobalNode." + nameof(Field), this, m_Field, value)) m_Field = value; } } // 0xC (12)
		
		protected CtrRef<VoiceOverObject> m_Object = new CtrRef<VoiceOverObject>();
		[ContainerField(Name: "Object", Offset: 16, NameHash: 2866508144, Flags: 53)]
		public CtrRef<VoiceOverObject> Object { get { return m_Object; } set { if (OnPropertyChanging("VoiceOverGlobalNode." + nameof(Object), this, m_Object, value)) m_Object = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (CtrRef<VoiceOverValue>) p_Value;
					break;

				case 206678151:
					Field = (CtrRef<VoiceOverNamedValue>) p_Value;
					break;

				case 2866508144:
					Object = (CtrRef<VoiceOverObject>) p_Value;
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

				case 206678151:
					return Field;

				case 2866508144:
					return Object;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(VoiceOverGlobalNode).GetProperty(nameof(Value));

				case 206678151:
					return typeof(VoiceOverGlobalNode).GetProperty(nameof(Field));

				case 2866508144:
					return typeof(VoiceOverGlobalNode).GetProperty(nameof(Object));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
