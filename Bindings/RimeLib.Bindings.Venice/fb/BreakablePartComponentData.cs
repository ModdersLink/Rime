///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class BreakablePartComponentData : 
		DestructionPartComponentData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint HealthPercentage { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool Collapsable { get; set; } // 0x74 (116)
		
		[ContainerField(117), LayoutImmutable, Blittable]
		public bool DestroyNearbyStaticEntities { get; set; } // 0x75 (117)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3168756705:
					HealthPercentage = (uint) p_Value;
					break;

				case 3767665825:
					Collapsable = (bool) p_Value;
					break;

				case 986094273:
					DestroyNearbyStaticEntities = (bool) p_Value;
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
				case 3168756705:
					return HealthPercentage;

				case 3767665825:
					return Collapsable;

				case 986094273:
					return DestroyNearbyStaticEntities;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3168756705:
					return typeof(BreakablePartComponentData).GetProperty(nameof(HealthPercentage));

				case 3767665825:
					return typeof(BreakablePartComponentData).GetProperty(nameof(Collapsable));

				case 986094273:
					return typeof(BreakablePartComponentData).GetProperty(nameof(DestroyNearbyStaticEntities));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
