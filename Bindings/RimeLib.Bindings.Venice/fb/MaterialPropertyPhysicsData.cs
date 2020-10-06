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
	public class MaterialPropertyPhysicsData : 
		PhysicsMaterialRelationPropertyData
	{
		protected float m_DynamicFrictionModifier = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3684693189)]
		public float DynamicFrictionModifier { get { return m_DynamicFrictionModifier; } set { if (OnPropertyChanging("MaterialPropertyPhysicsData." + nameof(DynamicFrictionModifier), this, m_DynamicFrictionModifier, value)) m_DynamicFrictionModifier = value; } } // 0x8 (8)
		
		protected float m_StaticFrictionModifier = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1034015560)]
		public float StaticFrictionModifier { get { return m_StaticFrictionModifier; } set { if (OnPropertyChanging("MaterialPropertyPhysicsData." + nameof(StaticFrictionModifier), this, m_StaticFrictionModifier, value)) m_StaticFrictionModifier = value; } } // 0xC (12)
		
		protected float m_RestitutionModifier = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(459278038)]
		public float RestitutionModifier { get { return m_RestitutionModifier; } set { if (OnPropertyChanging("MaterialPropertyPhysicsData." + nameof(RestitutionModifier), this, m_RestitutionModifier, value)) m_RestitutionModifier = value; } } // 0x10 (16)
		
		protected float m_Resistance = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(61696806)]
		public float Resistance { get { return m_Resistance; } set { if (OnPropertyChanging("MaterialPropertyPhysicsData." + nameof(Resistance), this, m_Resistance, value)) m_Resistance = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3684693189:
					DynamicFrictionModifier = (float) p_Value;
					break;

				case 1034015560:
					StaticFrictionModifier = (float) p_Value;
					break;

				case 459278038:
					RestitutionModifier = (float) p_Value;
					break;

				case 61696806:
					Resistance = (float) p_Value;
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
				case 3684693189:
					return DynamicFrictionModifier;

				case 1034015560:
					return StaticFrictionModifier;

				case 459278038:
					return RestitutionModifier;

				case 61696806:
					return Resistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3684693189:
					return typeof(MaterialPropertyPhysicsData).GetProperty(nameof(DynamicFrictionModifier));

				case 1034015560:
					return typeof(MaterialPropertyPhysicsData).GetProperty(nameof(StaticFrictionModifier));

				case 459278038:
					return typeof(MaterialPropertyPhysicsData).GetProperty(nameof(RestitutionModifier));

				case 61696806:
					return typeof(MaterialPropertyPhysicsData).GetProperty(nameof(Resistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
