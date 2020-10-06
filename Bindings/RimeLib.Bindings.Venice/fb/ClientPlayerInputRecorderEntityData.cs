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
	public class ClientPlayerInputRecorderEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("ClientPlayerInputRecorderEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected string m_FileNameBase = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2579130353)]
		public string FileNameBase { get { return m_FileNameBase; } set { if (OnPropertyChanging("ClientPlayerInputRecorderEntityData." + nameof(FileNameBase), this, m_FileNameBase, value)) m_FileNameBase = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2579130353:
					FileNameBase = (string) p_Value;
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

				case 2579130353:
					return FileNameBase;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(ClientPlayerInputRecorderEntityData).GetProperty(nameof(Realm));

				case 2579130353:
					return typeof(ClientPlayerInputRecorderEntityData).GetProperty(nameof(FileNameBase));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
