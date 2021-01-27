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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class VoiceOverValue : 
		DataContainer
	{
		protected VoiceOverValueType m_ValueType = new VoiceOverValueType();
		[ContainerField(Name: "ValueType", Offset: 8, NameHash: 1235276758, Flags: 137)]
		public VoiceOverValueType ValueType { get { return m_ValueType; } set { if (OnPropertyChanging("VoiceOverValue." + nameof(ValueType), this, m_ValueType, value)) m_ValueType = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1235276758:
					ValueType = (VoiceOverValueType) Enum.ToObject(typeof(VoiceOverValueType), p_Value);
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
				case 1235276758:
					return ValueType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1235276758:
					return typeof(VoiceOverValue).GetProperty(nameof(ValueType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
