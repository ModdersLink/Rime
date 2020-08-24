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
	public class GrenadeEntityData : 
		MeshProjectileEntityData
	{
		protected float m_CollisionSpeedMultiplier = new float();
		[ContainerField(192), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2944457815)]
		public float CollisionSpeedMultiplier { get { return m_CollisionSpeedMultiplier; } set { if (OnPropertyChanging("GrenadeEntityData." + nameof(CollisionSpeedMultiplier), this, m_CollisionSpeedMultiplier, value)) m_CollisionSpeedMultiplier = value; } } // 0xC0 (192)
		
		protected float m_Gravity = new float();
		[ContainerField(196), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3295092963)]
		public float Gravity { get { return m_Gravity; } set { if (OnPropertyChanging("GrenadeEntityData." + nameof(Gravity), this, m_Gravity, value)) m_Gravity = value; } } // 0xC4 (196)
		
		protected GrenadeType m_GrenadeType = new GrenadeType();
		[ContainerField(200), MemberInfoFlag(137), ContainerFieldNameHash(265649539)]
		public GrenadeType GrenadeType { get { return m_GrenadeType; } set { if (OnPropertyChanging("GrenadeEntityData." + nameof(GrenadeType), this, m_GrenadeType, value)) m_GrenadeType = value; } } // 0xC8 (200)
		
		protected float m_MinBounceSpeed = new float();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3229149176)]
		public float MinBounceSpeed { get { return m_MinBounceSpeed; } set { if (OnPropertyChanging("GrenadeEntityData." + nameof(MinBounceSpeed), this, m_MinBounceSpeed, value)) m_MinBounceSpeed = value; } } // 0xCC (204)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2944457815:
					CollisionSpeedMultiplier = (float) p_Value;
					break;

				case 3295092963:
					Gravity = (float) p_Value;
					break;

				case 265649539:
					GrenadeType = (GrenadeType) Enum.ToObject(typeof(GrenadeType), p_Value);
					break;

				case 3229149176:
					MinBounceSpeed = (float) p_Value;
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
				case 2944457815:
					return CollisionSpeedMultiplier;

				case 3295092963:
					return Gravity;

				case 265649539:
					return GrenadeType;

				case 3229149176:
					return MinBounceSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2944457815:
					return typeof(GrenadeEntityData).GetProperty(nameof(CollisionSpeedMultiplier));

				case 3295092963:
					return typeof(GrenadeEntityData).GetProperty(nameof(Gravity));

				case 265649539:
					return typeof(GrenadeEntityData).GetProperty(nameof(GrenadeType));

				case 3229149176:
					return typeof(GrenadeEntityData).GetProperty(nameof(MinBounceSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
