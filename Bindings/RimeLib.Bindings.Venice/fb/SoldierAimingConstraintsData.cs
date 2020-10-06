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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class SoldierAimingConstraintsData : 
		DataContainer
	{
		protected AimingConstraintsData m_SwimmingConstraints = new AimingConstraintsData();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(2106853822)]
		public AimingConstraintsData SwimmingConstraints { get { return m_SwimmingConstraints; } set { if (OnPropertyChanging("SoldierAimingConstraintsData." + nameof(SwimmingConstraints), this, m_SwimmingConstraints, value)) m_SwimmingConstraints = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2106853822:
					SwimmingConstraints = (AimingConstraintsData) p_Value;
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
				case 2106853822:
					return SwimmingConstraints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2106853822:
					return typeof(SoldierAimingConstraintsData).GetProperty(nameof(SwimmingConstraints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
