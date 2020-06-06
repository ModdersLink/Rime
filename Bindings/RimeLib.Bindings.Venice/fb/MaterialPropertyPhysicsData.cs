///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MaterialPropertyPhysicsData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DynamicFrictionModifier { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float StaticFrictionModifier { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float RestitutionModifier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Resistance { get; set; } // 0x14 (20)
		
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
