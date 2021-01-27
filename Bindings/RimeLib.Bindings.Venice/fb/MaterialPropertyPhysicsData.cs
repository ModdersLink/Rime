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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class MaterialPropertyPhysicsData : 
		PhysicsMaterialRelationPropertyData
	{
		protected float m_DynamicFrictionModifier = new float();
		[ContainerField(Name: "DynamicFrictionModifier", Offset: 8, NameHash: 3684693189, Flags: 49469), LayoutImmutable, Blittable]
		public float DynamicFrictionModifier { get { return m_DynamicFrictionModifier; } set { if (OnPropertyChanging("MaterialPropertyPhysicsData." + nameof(DynamicFrictionModifier), this, m_DynamicFrictionModifier, value)) m_DynamicFrictionModifier = value; } } // 0x8 (8)
		
		protected float m_StaticFrictionModifier = new float();
		[ContainerField(Name: "StaticFrictionModifier", Offset: 12, NameHash: 1034015560, Flags: 49469), LayoutImmutable, Blittable]
		public float StaticFrictionModifier { get { return m_StaticFrictionModifier; } set { if (OnPropertyChanging("MaterialPropertyPhysicsData." + nameof(StaticFrictionModifier), this, m_StaticFrictionModifier, value)) m_StaticFrictionModifier = value; } } // 0xC (12)
		
		protected float m_RestitutionModifier = new float();
		[ContainerField(Name: "RestitutionModifier", Offset: 16, NameHash: 459278038, Flags: 49469), LayoutImmutable, Blittable]
		public float RestitutionModifier { get { return m_RestitutionModifier; } set { if (OnPropertyChanging("MaterialPropertyPhysicsData." + nameof(RestitutionModifier), this, m_RestitutionModifier, value)) m_RestitutionModifier = value; } } // 0x10 (16)
		
		protected float m_Resistance = new float();
		[ContainerField(Name: "Resistance", Offset: 20, NameHash: 61696806, Flags: 49469), LayoutImmutable, Blittable]
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
