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
	public class SyncedGameSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxAllowedLatency { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ManDownTimeModifier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float BulletDamageModifier { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint DifficultyIndex { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool DisableRegenerateHealth { get; set; } // 0x1C (28)
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool EnableFriendlyFire { get; set; } // 0x1D (29)
		
		[ContainerField(30), LayoutImmutable, Blittable]
		public bool AllowClientSideDamageArbitration { get; set; } // 0x1E (30)
		
		[ContainerField(31), LayoutImmutable, Blittable]
		public bool DisableToggleEntryCamera { get; set; } // 0x1F (31)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 57128033:
					MaxAllowedLatency = (float) p_Value;
					break;

				case 2134954807:
					ManDownTimeModifier = (float) p_Value;
					break;

				case 204218335:
					BulletDamageModifier = (float) p_Value;
					break;

				case 302070728:
					DifficultyIndex = (uint) p_Value;
					break;

				case 1264747441:
					DisableRegenerateHealth = (bool) p_Value;
					break;

				case 362696539:
					EnableFriendlyFire = (bool) p_Value;
					break;

				case 1990831926:
					AllowClientSideDamageArbitration = (bool) p_Value;
					break;

				case 1613644462:
					DisableToggleEntryCamera = (bool) p_Value;
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
				case 57128033:
					return MaxAllowedLatency;

				case 2134954807:
					return ManDownTimeModifier;

				case 204218335:
					return BulletDamageModifier;

				case 302070728:
					return DifficultyIndex;

				case 1264747441:
					return DisableRegenerateHealth;

				case 362696539:
					return EnableFriendlyFire;

				case 1990831926:
					return AllowClientSideDamageArbitration;

				case 1613644462:
					return DisableToggleEntryCamera;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 57128033:
					return typeof(SyncedGameSettings).GetProperty(nameof(MaxAllowedLatency));

				case 2134954807:
					return typeof(SyncedGameSettings).GetProperty(nameof(ManDownTimeModifier));

				case 204218335:
					return typeof(SyncedGameSettings).GetProperty(nameof(BulletDamageModifier));

				case 302070728:
					return typeof(SyncedGameSettings).GetProperty(nameof(DifficultyIndex));

				case 1264747441:
					return typeof(SyncedGameSettings).GetProperty(nameof(DisableRegenerateHealth));

				case 362696539:
					return typeof(SyncedGameSettings).GetProperty(nameof(EnableFriendlyFire));

				case 1990831926:
					return typeof(SyncedGameSettings).GetProperty(nameof(AllowClientSideDamageArbitration));

				case 1613644462:
					return typeof(SyncedGameSettings).GetProperty(nameof(DisableToggleEntryCamera));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
