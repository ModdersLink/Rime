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
	public class SoundEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80)]
		public CtrRef<SoundAsset> Sound { get; set; } = new CtrRef<SoundAsset>(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public int ObstructionHandle { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool PlayOnCreation { get; set; } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2253671389:
					ObstructionHandle = (int) p_Value;
					break;

				case 2168204873:
					PlayOnCreation = (bool) p_Value;
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
				case 2270319721:
					return Transform;

				case 231353798:
					return Sound;

				case 2253671389:
					return ObstructionHandle;

				case 2168204873:
					return PlayOnCreation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(SoundEntityData).GetProperty(nameof(Transform));

				case 231353798:
					return typeof(SoundEntityData).GetProperty(nameof(Sound));

				case 2253671389:
					return typeof(SoundEntityData).GetProperty(nameof(ObstructionHandle));

				case 2168204873:
					return typeof(SoundEntityData).GetProperty(nameof(PlayOnCreation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
