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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class PersistenceStatTable : 
		DataContainer
	{
		protected string m_TableName = string.Empty;
		[ContainerField(Name: "TableName", Offset: 8, NameHash: 3117168284, Flags: 16509), LayoutImmutable]
		public string TableName { get { return m_TableName; } set { if (OnPropertyChanging("PersistenceStatTable." + nameof(TableName), this, m_TableName, value)) m_TableName = value; } } // 0x8 (8)
		
		protected CtrRef<AbstractPersistenceData> m_OwnerPersistenceData = new CtrRef<AbstractPersistenceData>();
		[ContainerField(Name: "OwnerPersistenceData", Offset: 12, NameHash: 1012363171, Flags: 53)]
		public CtrRef<AbstractPersistenceData> OwnerPersistenceData { get { return m_OwnerPersistenceData; } set { if (OnPropertyChanging("PersistenceStatTable." + nameof(OwnerPersistenceData), this, m_OwnerPersistenceData, value)) m_OwnerPersistenceData = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3117168284:
					TableName = (string) p_Value;
					break;

				case 1012363171:
					OwnerPersistenceData = (CtrRef<AbstractPersistenceData>) p_Value;
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
				case 3117168284:
					return TableName;

				case 1012363171:
					return OwnerPersistenceData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3117168284:
					return typeof(PersistenceStatTable).GetProperty(nameof(TableName));

				case 1012363171:
					return typeof(PersistenceStatTable).GetProperty(nameof(OwnerPersistenceData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
