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
	public class ClientPlayerInputPlaybackEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("ClientPlayerInputPlaybackEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected string m_FileName = string.Empty;
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(1134474212)]
		public string FileName { get { return m_FileName; } set { if (OnPropertyChanging("ClientPlayerInputPlaybackEntityData." + nameof(FileName), this, m_FileName, value)) m_FileName = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 1134474212:
					FileName = (string) p_Value;
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
				case 229961746:
					return Realm;

				case 1134474212:
					return FileName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(ClientPlayerInputPlaybackEntityData).GetProperty(nameof(Realm));

				case 1134474212:
					return typeof(ClientPlayerInputPlaybackEntityData).GetProperty(nameof(FileName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
