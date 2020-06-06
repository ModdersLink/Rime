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
	public class GameSoundEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<SoundAsset> Sound { get; set; } = new CtrRef<SoundAsset>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool PlayOnCreation { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
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
				case 231353798:
					return Sound;

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
				case 231353798:
					return typeof(GameSoundEntityData).GetProperty(nameof(Sound));

				case 2168204873:
					return typeof(GameSoundEntityData).GetProperty(nameof(PlayOnCreation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
