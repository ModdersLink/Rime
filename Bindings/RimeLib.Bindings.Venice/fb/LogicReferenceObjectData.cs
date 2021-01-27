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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class LogicReferenceObjectData : 
		ReferenceObjectData
	{
		protected SubRealm m_SubRealm = new SubRealm();
		[ContainerField(Name: "SubRealm", Offset: 96, NameHash: 1747841366, Flags: 137)]
		public SubRealm SubRealm { get { return m_SubRealm; } set { if (OnPropertyChanging("LogicReferenceObjectData." + nameof(SubRealm), this, m_SubRealm, value)) m_SubRealm = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1747841366:
					SubRealm = (SubRealm) Enum.ToObject(typeof(SubRealm), p_Value);
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
				case 1747841366:
					return SubRealm;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1747841366:
					return typeof(LogicReferenceObjectData).GetProperty(nameof(SubRealm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
