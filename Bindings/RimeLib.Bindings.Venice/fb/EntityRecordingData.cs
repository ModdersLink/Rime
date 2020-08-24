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
	public class EntityRecordingData : 
		DataContainer
	{
		protected GUID m_EntityGuid = new GUID();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49501), ContainerFieldNameHash(1697800481)]
		public GUID EntityGuid { get { return m_EntityGuid; } set { if (OnPropertyChanging("EntityRecordingData." + nameof(EntityGuid), this, m_EntityGuid, value)) m_EntityGuid = value; } } // 0x8 (8)
		
		protected RefArray<PropertyRecordingData> m_Data = new RefArray<PropertyRecordingData>();
		[ContainerField(24), MemberInfoFlag(65), ContainerFieldNameHash(2088730869), ContainerRefArray]
		public RefArray<PropertyRecordingData> Data { get { return m_Data; } set { if (OnPropertyChanging("EntityRecordingData." + nameof(Data), this, m_Data, value)) m_Data = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1697800481:
					EntityGuid = (GUID) p_Value;
					break;

				case 2088730869:
					Data = (RefArray<PropertyRecordingData>) p_Value;
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
				case 1697800481:
					return EntityGuid;

				case 2088730869:
					return Data;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1697800481:
					return typeof(EntityRecordingData).GetProperty(nameof(EntityGuid));

				case 2088730869:
					return typeof(EntityRecordingData).GetProperty(nameof(Data));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
