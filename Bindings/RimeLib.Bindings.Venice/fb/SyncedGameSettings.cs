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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class SyncedGameSettings : 
		SystemSettings
	{
		protected float m_MaxAllowedLatency = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(57128033)]
		public float MaxAllowedLatency { get { return m_MaxAllowedLatency; } set { if (OnPropertyChanging("SyncedGameSettings." + nameof(MaxAllowedLatency), this, m_MaxAllowedLatency, value)) m_MaxAllowedLatency = value; } } // 0xC (12)
		
		protected float m_ManDownTimeModifier = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2134954807)]
		public float ManDownTimeModifier { get { return m_ManDownTimeModifier; } set { if (OnPropertyChanging("SyncedGameSettings." + nameof(ManDownTimeModifier), this, m_ManDownTimeModifier, value)) m_ManDownTimeModifier = value; } } // 0x10 (16)
		
		protected float m_BulletDamageModifier = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(204218335)]
		public float BulletDamageModifier { get { return m_BulletDamageModifier; } set { if (OnPropertyChanging("SyncedGameSettings." + nameof(BulletDamageModifier), this, m_BulletDamageModifier, value)) m_BulletDamageModifier = value; } } // 0x14 (20)
		
		protected uint m_DifficultyIndex = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(302070728)]
		public uint DifficultyIndex { get { return m_DifficultyIndex; } set { if (OnPropertyChanging("SyncedGameSettings." + nameof(DifficultyIndex), this, m_DifficultyIndex, value)) m_DifficultyIndex = value; } } // 0x18 (24)
		
		protected bool m_DisableRegenerateHealth = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1264747441)]
		public bool DisableRegenerateHealth { get { return m_DisableRegenerateHealth; } set { if (OnPropertyChanging("SyncedGameSettings." + nameof(DisableRegenerateHealth), this, m_DisableRegenerateHealth, value)) m_DisableRegenerateHealth = value; } } // 0x1C (28)
		
		protected bool m_EnableFriendlyFire = new bool();
		[ContainerField(29), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(362696539)]
		public bool EnableFriendlyFire { get { return m_EnableFriendlyFire; } set { if (OnPropertyChanging("SyncedGameSettings." + nameof(EnableFriendlyFire), this, m_EnableFriendlyFire, value)) m_EnableFriendlyFire = value; } } // 0x1D (29)
		
		protected bool m_AllowClientSideDamageArbitration = new bool();
		[ContainerField(30), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1990831926)]
		public bool AllowClientSideDamageArbitration { get { return m_AllowClientSideDamageArbitration; } set { if (OnPropertyChanging("SyncedGameSettings." + nameof(AllowClientSideDamageArbitration), this, m_AllowClientSideDamageArbitration, value)) m_AllowClientSideDamageArbitration = value; } } // 0x1E (30)
		
		protected bool m_DisableToggleEntryCamera = new bool();
		[ContainerField(31), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1613644462)]
		public bool DisableToggleEntryCamera { get { return m_DisableToggleEntryCamera; } set { if (OnPropertyChanging("SyncedGameSettings." + nameof(DisableToggleEntryCamera), this, m_DisableToggleEntryCamera, value)) m_DisableToggleEntryCamera = value; } } // 0x1F (31)
		
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
