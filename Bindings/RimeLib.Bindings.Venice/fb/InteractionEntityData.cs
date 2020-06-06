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
	public class InteractionEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float UseWithinRadius { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float UseWithinAngle { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<SoundAsset> PreInteractionSoundEffect { get; set; } = new CtrRef<SoundAsset>(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public uint MaxUses { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool AllowInteractionViaRemoteEntry { get; set; } // 0x70 (112)
		
		[ContainerField(113), LayoutImmutable, Blittable]
		public bool TestIfOccluded { get; set; } // 0x71 (113)
		
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
