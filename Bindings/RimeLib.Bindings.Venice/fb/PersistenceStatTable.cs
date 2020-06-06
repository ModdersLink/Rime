///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class PersistenceStatTable : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string TableName { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<AbstractPersistenceData> OwnerPersistenceData { get; set; } = new CtrRef<AbstractPersistenceData>(); // 0xC (12)
		
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
