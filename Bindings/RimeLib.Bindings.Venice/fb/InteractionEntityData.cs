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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class InteractionEntityData : 
		GameEntityData
	{
		protected float m_UseWithinRadius = new float();
		[ContainerField(Name: "UseWithinRadius", Offset: 96, NameHash: 2619256891, Flags: 49469), LayoutImmutable, Blittable]
		public float UseWithinRadius { get { return m_UseWithinRadius; } set { if (OnPropertyChanging("InteractionEntityData." + nameof(UseWithinRadius), this, m_UseWithinRadius, value)) m_UseWithinRadius = value; } } // 0x60 (96)
		
		protected float m_UseWithinAngle = new float();
		[ContainerField(Name: "UseWithinAngle", Offset: 100, NameHash: 2931974274, Flags: 49469), LayoutImmutable, Blittable]
		public float UseWithinAngle { get { return m_UseWithinAngle; } set { if (OnPropertyChanging("InteractionEntityData." + nameof(UseWithinAngle), this, m_UseWithinAngle, value)) m_UseWithinAngle = value; } } // 0x64 (100)
		
		protected CtrRef<SoundAsset> m_PreInteractionSoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(Name: "PreInteractionSoundEffect", Offset: 104, NameHash: 3692764940, Flags: 53)]
		public CtrRef<SoundAsset> PreInteractionSoundEffect { get { return m_PreInteractionSoundEffect; } set { if (OnPropertyChanging("InteractionEntityData." + nameof(PreInteractionSoundEffect), this, m_PreInteractionSoundEffect, value)) m_PreInteractionSoundEffect = value; } } // 0x68 (104)
		
		protected uint m_MaxUses = new uint();
		[ContainerField(Name: "MaxUses", Offset: 108, NameHash: 1313728481, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxUses { get { return m_MaxUses; } set { if (OnPropertyChanging("InteractionEntityData." + nameof(MaxUses), this, m_MaxUses, value)) m_MaxUses = value; } } // 0x6C (108)
		
		protected bool m_AllowInteractionViaRemoteEntry = new bool();
		[ContainerField(Name: "AllowInteractionViaRemoteEntry", Offset: 112, NameHash: 1767691528, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowInteractionViaRemoteEntry { get { return m_AllowInteractionViaRemoteEntry; } set { if (OnPropertyChanging("InteractionEntityData." + nameof(AllowInteractionViaRemoteEntry), this, m_AllowInteractionViaRemoteEntry, value)) m_AllowInteractionViaRemoteEntry = value; } } // 0x70 (112)
		
		protected bool m_TestIfOccluded = new bool();
		[ContainerField(Name: "TestIfOccluded", Offset: 113, NameHash: 1300068079, Flags: 49325), LayoutImmutable, Blittable]
		public bool TestIfOccluded { get { return m_TestIfOccluded; } set { if (OnPropertyChanging("InteractionEntityData." + nameof(TestIfOccluded), this, m_TestIfOccluded, value)) m_TestIfOccluded = value; } } // 0x71 (113)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2619256891:
					UseWithinRadius = (float) p_Value;
					break;

				case 2931974274:
					UseWithinAngle = (float) p_Value;
					break;

				case 3692764940:
					PreInteractionSoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 1313728481:
					MaxUses = (uint) p_Value;
					break;

				case 1767691528:
					AllowInteractionViaRemoteEntry = (bool) p_Value;
					break;

				case 1300068079:
					TestIfOccluded = (bool) p_Value;
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
				case 2619256891:
					return UseWithinRadius;

				case 2931974274:
					return UseWithinAngle;

				case 3692764940:
					return PreInteractionSoundEffect;

				case 1313728481:
					return MaxUses;

				case 1767691528:
					return AllowInteractionViaRemoteEntry;

				case 1300068079:
					return TestIfOccluded;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2619256891:
					return typeof(InteractionEntityData).GetProperty(nameof(UseWithinRadius));

				case 2931974274:
					return typeof(InteractionEntityData).GetProperty(nameof(UseWithinAngle));

				case 3692764940:
					return typeof(InteractionEntityData).GetProperty(nameof(PreInteractionSoundEffect));

				case 1313728481:
					return typeof(InteractionEntityData).GetProperty(nameof(MaxUses));

				case 1767691528:
					return typeof(InteractionEntityData).GetProperty(nameof(AllowInteractionViaRemoteEntry));

				case 1300068079:
					return typeof(InteractionEntityData).GetProperty(nameof(TestIfOccluded));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
