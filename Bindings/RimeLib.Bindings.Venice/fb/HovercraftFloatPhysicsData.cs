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
	public class HovercraftFloatPhysicsData : 
		HullFloatPhysicsData
	{
		protected Vec3 m_LandResistanceAxisMod = new Vec3();
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3707997700)]
		public Vec3 LandResistanceAxisMod { get { return m_LandResistanceAxisMod; } set { if (OnPropertyChanging("HovercraftFloatPhysicsData." + nameof(LandResistanceAxisMod), this, m_LandResistanceAxisMod, value)) m_LandResistanceAxisMod = value; } } // 0x80 (128)
		
		protected Vec3 m_LandFrictionAxisMod = new Vec3();
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3677552229)]
		public Vec3 LandFrictionAxisMod { get { return m_LandFrictionAxisMod; } set { if (OnPropertyChanging("HovercraftFloatPhysicsData." + nameof(LandFrictionAxisMod), this, m_LandFrictionAxisMod, value)) m_LandFrictionAxisMod = value; } } // 0x90 (144)
		
		protected float m_FrontLength = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2116152088)]
		public float FrontLength { get { return m_FrontLength; } set { if (OnPropertyChanging("HovercraftFloatPhysicsData." + nameof(FrontLength), this, m_FrontLength, value)) m_FrontLength = value; } } // 0xA0 (160)
		
		protected float m_SideLength = new float();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(45904162)]
		public float SideLength { get { return m_SideLength; } set { if (OnPropertyChanging("HovercraftFloatPhysicsData." + nameof(SideLength), this, m_SideLength, value)) m_SideLength = value; } } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3707997700:
					LandResistanceAxisMod = (Vec3) p_Value;
					break;

				case 3677552229:
					LandFrictionAxisMod = (Vec3) p_Value;
					break;

				case 2116152088:
					FrontLength = (float) p_Value;
					break;

				case 45904162:
					SideLength = (float) p_Value;
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
				case 3707997700:
					return LandResistanceAxisMod;

				case 3677552229:
					return LandFrictionAxisMod;

				case 2116152088:
					return FrontLength;

				case 45904162:
					return SideLength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3707997700:
					return typeof(HovercraftFloatPhysicsData).GetProperty(nameof(LandResistanceAxisMod));

				case 3677552229:
					return typeof(HovercraftFloatPhysicsData).GetProperty(nameof(LandFrictionAxisMod));

				case 2116152088:
					return typeof(HovercraftFloatPhysicsData).GetProperty(nameof(FrontLength));

				case 45904162:
					return typeof(HovercraftFloatPhysicsData).GetProperty(nameof(SideLength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
