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
	public class FriendZoneEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int EnemyWeight { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int FriendlyWeight { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int CorpsTimeout { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int CorpsWeight { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool CountCorpsesForAllTeams { get; set; } // 0x1C (28)
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool InitialZoneRandomized { get; set; } // 0x1D (29)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3888167615:
					EnemyWeight = (int) p_Value;
					break;

				case 365084578:
					FriendlyWeight = (int) p_Value;
					break;

				case 2096723555:
					CorpsTimeout = (int) p_Value;
					break;

				case 133234872:
					CorpsWeight = (int) p_Value;
					break;

				case 3473146361:
					CountCorpsesForAllTeams = (bool) p_Value;
					break;

				case 1766807212:
					InitialZoneRandomized = (bool) p_Value;
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
				case 3888167615:
					return EnemyWeight;

				case 365084578:
					return FriendlyWeight;

				case 2096723555:
					return CorpsTimeout;

				case 133234872:
					return CorpsWeight;

				case 3473146361:
					return CountCorpsesForAllTeams;

				case 1766807212:
					return InitialZoneRandomized;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3888167615:
					return typeof(FriendZoneEntityData).GetProperty(nameof(EnemyWeight));

				case 365084578:
					return typeof(FriendZoneEntityData).GetProperty(nameof(FriendlyWeight));

				case 2096723555:
					return typeof(FriendZoneEntityData).GetProperty(nameof(CorpsTimeout));

				case 133234872:
					return typeof(FriendZoneEntityData).GetProperty(nameof(CorpsWeight));

				case 3473146361:
					return typeof(FriendZoneEntityData).GetProperty(nameof(CountCorpsesForAllTeams));

				case 1766807212:
					return typeof(FriendZoneEntityData).GetProperty(nameof(InitialZoneRandomized));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
