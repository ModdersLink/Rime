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
	public class EngineComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<EngineConfigData> Config { get; set; } = new CtrRef<EngineConfigData>(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<SoundAsset> SoundEffect { get; set; } = new CtrRef<SoundAsset>(); // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<SoundAsset> SurfaceSoundEffect { get; set; } = new CtrRef<SoundAsset>(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool UseFirstPersonSounds { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool OutputIsEngineInWater { get; set; } // 0x6D (109)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2713732399:
					Config = (CtrRef<EngineConfigData>) p_Value;
					break;

				case 3556609201:
					SoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3348100644:
					SurfaceSoundEffect = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2865323833:
					UseFirstPersonSounds = (bool) p_Value;
					break;

				case 844188796:
					OutputIsEngineInWater = (bool) p_Value;
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
				case 2713732399:
					return Config;

				case 3556609201:
					return SoundEffect;

				case 3348100644:
					return SurfaceSoundEffect;

				case 2865323833:
					return UseFirstPersonSounds;

				case 844188796:
					return OutputIsEngineInWater;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2713732399:
					return typeof(EngineComponentData).GetProperty(nameof(Config));

				case 3556609201:
					return typeof(EngineComponentData).GetProperty(nameof(SoundEffect));

				case 3348100644:
					return typeof(EngineComponentData).GetProperty(nameof(SurfaceSoundEffect));

				case 2865323833:
					return typeof(EngineComponentData).GetProperty(nameof(UseFirstPersonSounds));

				case 844188796:
					return typeof(EngineComponentData).GetProperty(nameof(OutputIsEngineInWater));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
