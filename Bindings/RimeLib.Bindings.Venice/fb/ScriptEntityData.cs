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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class ScriptEntityData : 
		EntityData
	{
		protected string m_Code = string.Empty;
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088844616)]
		public string Code { get { return m_Code; } set { if (OnPropertyChanging("ScriptEntityData." + nameof(Code), this, m_Code, value)) m_Code = value; } } // 0xC (12)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("ScriptEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088844616:
					Code = (string) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
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
				case 2088844616:
					return Code;

				case 229961746:
					return Realm;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088844616:
					return typeof(ScriptEntityData).GetProperty(nameof(Code));

				case 229961746:
					return typeof(ScriptEntityData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
