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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class WeaponData : 
		ToolData
	{
		protected bool m_ShowLaserPaintedVehicles = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3679743847)]
		public bool ShowLaserPaintedVehicles { get { return m_ShowLaserPaintedVehicles; } set { if (OnPropertyChanging("WeaponData." + nameof(ShowLaserPaintedVehicles), this, m_ShowLaserPaintedVehicles, value)) m_ShowLaserPaintedVehicles = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3679743847:
					ShowLaserPaintedVehicles = (bool) p_Value;
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
				case 3679743847:
					return ShowLaserPaintedVehicles;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3679743847:
					return typeof(WeaponData).GetProperty(nameof(ShowLaserPaintedVehicles));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
