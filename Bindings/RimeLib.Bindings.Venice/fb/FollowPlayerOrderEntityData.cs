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
	public class FollowPlayerOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40)]
		public CtrRef<FormationData> Formation { get; set; } = new CtrRef<FormationData>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool CombatForbidden { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3135990414:
					Formation = (CtrRef<FormationData>) p_Value;
					break;

				case 2646993448:
					CombatForbidden = (bool) p_Value;
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
				case 3135990414:
					return Formation;

				case 2646993448:
					return CombatForbidden;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3135990414:
					return typeof(FollowPlayerOrderEntityData).GetProperty(nameof(Formation));

				case 2646993448:
					return typeof(FollowPlayerOrderEntityData).GetProperty(nameof(CombatForbidden));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
