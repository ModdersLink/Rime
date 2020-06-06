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
	public class SoundPatchConfigurationAsset : 
		SoundAsset
	{
		[ContainerField(16)]
		public CtrRef<SoundPatchAsset> Sound { get; set; } = new CtrRef<SoundPatchAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<SoundPatchConfigurationEntry> Entries { get; set; } = new RefArray<SoundPatchConfigurationEntry>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Loudness { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231353798:
					Sound = (CtrRef<SoundPatchAsset>) p_Value;
					break;

				case 8238103:
					Entries = (RefArray<SoundPatchConfigurationEntry>) p_Value;
					break;

				case 2678891068:
					Loudness = (float) p_Value;
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

				case 8238103:
					return Entries;

				case 2678891068:
					return Loudness;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231353798:
					return typeof(SoundPatchConfigurationAsset).GetProperty(nameof(Sound));

				case 8238103:
					return typeof(SoundPatchConfigurationAsset).GetProperty(nameof(Entries));

				case 2678891068:
					return typeof(SoundPatchConfigurationAsset).GetProperty(nameof(Loudness));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
