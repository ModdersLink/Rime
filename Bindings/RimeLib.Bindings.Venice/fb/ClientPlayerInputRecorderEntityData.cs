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
	public class ClientPlayerInputRecorderEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("ClientPlayerInputRecorderEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected string m_FileNameBase = string.Empty;
		[ContainerField(Name: "FileNameBase", Offset: 16, NameHash: 2579130353, Flags: 16509), LayoutImmutable]
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
