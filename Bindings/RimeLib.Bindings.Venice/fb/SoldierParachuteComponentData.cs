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
	public class SoldierParachuteComponentData : 
		ComponentData
	{
		protected SoldierParachuteBinding m_Binding = new SoldierParachuteBinding();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(2590060228)]
		public SoldierParachuteBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("SoldierParachuteComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x60 (96)
		
		protected AimingConstraintsData m_AimingConstraints = new AimingConstraintsData();
		[ContainerField(116), MemberInfoFlag(41), ContainerFieldNameHash(1523178198)]
		public AimingConstraintsData AimingConstraints { get { return m_AimingConstraints; } set { if (OnPropertyChanging("SoldierParachuteComponentData." + nameof(AimingConstraints), this, m_AimingConstraints, value)) m_AimingConstraints = value; } } // 0x74 (116)
		
		protected float m_UndeployTime = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1689758176)]
		public float UndeployTime { get { return m_UndeployTime; } set { if (OnPropertyChanging("SoldierParachuteComponentData." + nameof(UndeployTime), this, m_UndeployTime, value)) m_UndeployTime = value; } } // 0x84 (132)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (SoldierParachuteBinding) p_Value;
					break;

				case 1523178198:
					AimingConstraints = (AimingConstraintsData) p_Value;
					break;

				case 1689758176:
					UndeployTime = (float) p_Value;
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
				case 2590060228:
					return Binding;

				case 1523178198:
					return AimingConstraints;

				case 1689758176:
					return UndeployTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(SoldierParachuteComponentData).GetProperty(nameof(Binding));

				case 1523178198:
					return typeof(SoldierParachuteComponentData).GetProperty(nameof(AimingConstraints));

				case 1689758176:
					return typeof(SoldierParachuteComponentData).GetProperty(nameof(UndeployTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
