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
	public class MaterialSoldierSoundSettings : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> FootStepSound { get; set; } = new CtrRef<SoundAsset>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<SoundAsset> ProneSound { get; set; } = new CtrRef<SoundAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<SoundAsset> LandSound { get; set; } = new CtrRef<SoundAsset>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 556404134:
					FootStepSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 130192352:
					ProneSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3226502081:
					LandSound = (CtrRef<SoundAsset>) p_Value;
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
				case 556404134:
					return FootStepSound;

				case 130192352:
					return ProneSound;

				case 3226502081:
					return LandSound;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 556404134:
					return typeof(MaterialSoldierSoundSettings).GetProperty(nameof(FootStepSound));

				case 130192352:
					return typeof(MaterialSoldierSoundSettings).GetProperty(nameof(ProneSound));

				case 3226502081:
					return typeof(MaterialSoldierSoundSettings).GetProperty(nameof(LandSound));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
