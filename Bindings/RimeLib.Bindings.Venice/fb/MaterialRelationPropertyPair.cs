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
	public class MaterialRelationPropertyPair : FrostbiteContainer
	{
		[ContainerField(0)]
		public RefArray<PhysicsMaterialRelationPropertyData> PhysicsMaterialProperties { get; set; } = new RefArray<PhysicsMaterialRelationPropertyData>(); // 0x0 (0)
		
		[ContainerField(4)]
		public RefArray<PhysicsPropertyRelationPropertyData> PhysicsPropertyProperties { get; set; } = new RefArray<PhysicsPropertyRelationPropertyData>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1069720196:
					PhysicsMaterialProperties = (RefArray<PhysicsMaterialRelationPropertyData>) p_Value;
					break;

				case 1287888840:
					PhysicsPropertyProperties = (RefArray<PhysicsPropertyRelationPropertyData>) p_Value;
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
				case 1069720196:
					return PhysicsMaterialProperties;

				case 1287888840:
					return PhysicsPropertyProperties;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1069720196:
					return typeof(MaterialRelationPropertyPair).GetProperty(nameof(PhysicsMaterialProperties));

				case 1287888840:
					return typeof(MaterialRelationPropertyPair).GetProperty(nameof(PhysicsPropertyProperties));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
