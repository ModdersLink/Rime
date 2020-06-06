///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class EntryComponentSoundData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<StanceSwitchSoundData> StanceSounds { get; set; } = new List<StanceSwitchSoundData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<SoundAsset> StanceSwitchSound { get; set; } = new CtrRef<SoundAsset>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3318640379:
					StanceSounds = (List<StanceSwitchSoundData>) p_Value;
					break;

				case 865104730:
					StanceSwitchSound = (CtrRef<SoundAsset>) p_Value;
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
				case 3318640379:
					return StanceSounds;

				case 865104730:
					return StanceSwitchSound;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3318640379:
					return typeof(EntryComponentSoundData).GetProperty(nameof(StanceSounds));

				case 865104730:
					return typeof(EntryComponentSoundData).GetProperty(nameof(StanceSwitchSound));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
