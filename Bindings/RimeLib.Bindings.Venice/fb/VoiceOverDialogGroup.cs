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
	public class VoiceOverDialogGroup : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> Sound { get; set; } = new CtrRef<SoundAsset>(); // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<VoiceOverDialogTrack> Tracks { get; set; } = new RefArray<VoiceOverDialogTrack>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3202301561:
					Tracks = (RefArray<VoiceOverDialogTrack>) p_Value;
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

				case 3202301561:
					return Tracks;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231353798:
					return typeof(VoiceOverDialogGroup).GetProperty(nameof(Sound));

				case 3202301561:
					return typeof(VoiceOverDialogGroup).GetProperty(nameof(Tracks));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
