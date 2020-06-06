///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class GrenadeEntityData : 
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable]
		public float CollisionSpeedMultiplier { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float Gravity { get; set; } // 0xC4 (196)
		
		[ContainerField(200)]
		public GrenadeType GrenadeType { get; set; } = new GrenadeType(); // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float MinBounceSpeed { get; set; } // 0xCC (204)
		
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
