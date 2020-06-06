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
	public class CameraComponentSoundData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> SwitchToAlternateViewSound { get; set; } = new CtrRef<SoundAsset>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<SoundAsset> SwitchToNormalViewSound { get; set; } = new CtrRef<SoundAsset>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1181169106:
					SwitchToAlternateViewSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3067038865:
					SwitchToNormalViewSound = (CtrRef<SoundAsset>) p_Value;
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
				case 1181169106:
					return SwitchToAlternateViewSound;

				case 3067038865:
					return SwitchToNormalViewSound;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1181169106:
					return typeof(CameraComponentSoundData).GetProperty(nameof(SwitchToAlternateViewSound));

				case 3067038865:
					return typeof(CameraComponentSoundData).GetProperty(nameof(SwitchToNormalViewSound));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
