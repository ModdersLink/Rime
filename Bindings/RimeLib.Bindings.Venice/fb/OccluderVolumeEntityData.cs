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
	public class OccluderVolumeEntityData : 
		SpatialEntityData
	{
		protected bool m_OccluderHighPriority = new bool();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1133933052)]
		public bool OccluderHighPriority { get { return m_OccluderHighPriority; } set { if (OnPropertyChanging("OccluderVolumeEntityData." + nameof(OccluderHighPriority), this, m_OccluderHighPriority, value)) m_OccluderHighPriority = value; } } // 0x50 (80)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1133933052:
					OccluderHighPriority = (bool) p_Value;
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
				case 1133933052:
					return OccluderHighPriority;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1133933052:
					return typeof(OccluderVolumeEntityData).GetProperty(nameof(OccluderHighPriority));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
