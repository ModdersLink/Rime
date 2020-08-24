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
	public class SocketObjectData : 
		SocketObjectDataBase
	{
		protected GUID m_Asset1pGuid = new GUID();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49501), ContainerFieldNameHash(229660779)]
		public GUID Asset1pGuid { get { return m_Asset1pGuid; } set { if (OnPropertyChanging("SocketObjectData." + nameof(Asset1pGuid), this, m_Asset1pGuid, value)) m_Asset1pGuid = value; } } // 0x8 (8)
		
		protected List<GUID> m_Variation1pGuids = new List<GUID>();
		[ContainerField(24), MemberInfoFlag(65), ContainerFieldNameHash(2848287545), ContainerArray]
		public List<GUID> Variation1pGuids { get { return m_Variation1pGuids; } set { if (OnPropertyChanging("SocketObjectData." + nameof(Variation1pGuids), this, m_Variation1pGuids, value)) m_Variation1pGuids = value; } } // 0x18 (24)
		
		protected GUID m_Asset1pZoomGuid = new GUID();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49501), ContainerFieldNameHash(1108630652)]
		public GUID Asset1pZoomGuid { get { return m_Asset1pZoomGuid; } set { if (OnPropertyChanging("SocketObjectData." + nameof(Asset1pZoomGuid), this, m_Asset1pZoomGuid, value)) m_Asset1pZoomGuid = value; } } // 0x1C (28)
		
		protected List<GUID> m_Variation1pZoomGuids = new List<GUID>();
		[ContainerField(44), MemberInfoFlag(65), ContainerFieldNameHash(2457058062), ContainerArray]
		public List<GUID> Variation1pZoomGuids { get { return m_Variation1pZoomGuids; } set { if (OnPropertyChanging("SocketObjectData." + nameof(Variation1pZoomGuids), this, m_Variation1pZoomGuids, value)) m_Variation1pZoomGuids = value; } } // 0x2C (44)
		
		protected GUID m_Asset3pGuid = new GUID();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49501), ContainerFieldNameHash(156129193)]
		public GUID Asset3pGuid { get { return m_Asset3pGuid; } set { if (OnPropertyChanging("SocketObjectData." + nameof(Asset3pGuid), this, m_Asset3pGuid, value)) m_Asset3pGuid = value; } } // 0x30 (48)
		
		protected List<GUID> m_Variation3pGuids = new List<GUID>();
		[ContainerField(64), MemberInfoFlag(65), ContainerFieldNameHash(412553787), ContainerArray]
		public List<GUID> Variation3pGuids { get { return m_Variation3pGuids; } set { if (OnPropertyChanging("SocketObjectData." + nameof(Variation3pGuids), this, m_Variation3pGuids, value)) m_Variation3pGuids = value; } } // 0x40 (64)
		
		protected RefArray<CustomizedMaterialData> m_CustomizedMaterials = new RefArray<CustomizedMaterialData>();
		[ContainerField(68), MemberInfoFlag(65), ContainerFieldNameHash(474428220), ContainerRefArray]
		public RefArray<CustomizedMaterialData> CustomizedMaterials { get { return m_CustomizedMaterials; } set { if (OnPropertyChanging("SocketObjectData." + nameof(CustomizedMaterials), this, m_CustomizedMaterials, value)) m_CustomizedMaterials = value; } } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229660779:
					Asset1pGuid = (GUID) p_Value;
					break;

				case 2848287545:
					Variation1pGuids = (List<GUID>) p_Value;
					break;

				case 1108630652:
					Asset1pZoomGuid = (GUID) p_Value;
					break;

				case 2457058062:
					Variation1pZoomGuids = (List<GUID>) p_Value;
					break;

				case 156129193:
					Asset3pGuid = (GUID) p_Value;
					break;

				case 412553787:
					Variation3pGuids = (List<GUID>) p_Value;
					break;

				case 474428220:
					CustomizedMaterials = (RefArray<CustomizedMaterialData>) p_Value;
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
				case 229660779:
					return Asset1pGuid;

				case 2848287545:
					return Variation1pGuids;

				case 1108630652:
					return Asset1pZoomGuid;

				case 2457058062:
					return Variation1pZoomGuids;

				case 156129193:
					return Asset3pGuid;

				case 412553787:
					return Variation3pGuids;

				case 474428220:
					return CustomizedMaterials;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229660779:
					return typeof(SocketObjectData).GetProperty(nameof(Asset1pGuid));

				case 2848287545:
					return typeof(SocketObjectData).GetProperty(nameof(Variation1pGuids));

				case 1108630652:
					return typeof(SocketObjectData).GetProperty(nameof(Asset1pZoomGuid));

				case 2457058062:
					return typeof(SocketObjectData).GetProperty(nameof(Variation1pZoomGuids));

				case 156129193:
					return typeof(SocketObjectData).GetProperty(nameof(Asset3pGuid));

				case 412553787:
					return typeof(SocketObjectData).GetProperty(nameof(Variation3pGuids));

				case 474428220:
					return typeof(SocketObjectData).GetProperty(nameof(CustomizedMaterials));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
