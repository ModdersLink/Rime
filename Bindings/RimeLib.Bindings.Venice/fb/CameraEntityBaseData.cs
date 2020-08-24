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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class CameraEntityBaseData : 
		SpatialEntityData
	{
		protected string m_NameId = string.Empty;
		[ContainerField(80), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2828728719)]
		public string NameId { get { return m_NameId; } set { if (OnPropertyChanging("CameraEntityBaseData." + nameof(NameId), this, m_NameId, value)) m_NameId = value; } } // 0x50 (80)
		
		protected int m_Priority = new int();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3062102871)]
		public int Priority { get { return m_Priority; } set { if (OnPropertyChanging("CameraEntityBaseData." + nameof(Priority), this, m_Priority, value)) m_Priority = value; } } // 0x54 (84)
		
		protected bool m_Enabled = new bool();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("CameraEntityBaseData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2828728719:
					NameId = (string) p_Value;
					break;

				case 3062102871:
					Priority = (int) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 2828728719:
					return NameId;

				case 3062102871:
					return Priority;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2828728719:
					return typeof(CameraEntityBaseData).GetProperty(nameof(NameId));

				case 3062102871:
					return typeof(CameraEntityBaseData).GetProperty(nameof(Priority));

				case 2662400:
					return typeof(CameraEntityBaseData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
