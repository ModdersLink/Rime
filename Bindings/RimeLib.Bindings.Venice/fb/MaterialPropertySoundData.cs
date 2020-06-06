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
	public class MaterialPropertySoundData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8)]
		public CtrRef<SoundAsset> ImpactSound { get; set; } = new CtrRef<SoundAsset>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<SoundAsset> ScrapeSound { get; set; } = new CtrRef<SoundAsset>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ScrapeLength { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<MaterialSoldierSoundSettings> SoldierSettings { get; set; } = new CtrRef<MaterialSoldierSoundSettings>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Softness { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaterialSoundId { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3986717348:
					ImpactSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 1279692944:
					ScrapeSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 544833071:
					ScrapeLength = (float) p_Value;
					break;

				case 4066272810:
					SoldierSettings = (CtrRef<MaterialSoldierSoundSettings>) p_Value;
					break;

				case 3898807136:
					Softness = (float) p_Value;
					break;

				case 2481569024:
					MaterialSoundId = (float) p_Value;
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
				case 3986717348:
					return ImpactSound;

				case 1279692944:
					return ScrapeSound;

				case 544833071:
					return ScrapeLength;

				case 4066272810:
					return SoldierSettings;

				case 3898807136:
					return Softness;

				case 2481569024:
					return MaterialSoundId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3986717348:
					return typeof(MaterialPropertySoundData).GetProperty(nameof(ImpactSound));

				case 1279692944:
					return typeof(MaterialPropertySoundData).GetProperty(nameof(ScrapeSound));

				case 544833071:
					return typeof(MaterialPropertySoundData).GetProperty(nameof(ScrapeLength));

				case 4066272810:
					return typeof(MaterialPropertySoundData).GetProperty(nameof(SoldierSettings));

				case 3898807136:
					return typeof(MaterialPropertySoundData).GetProperty(nameof(Softness));

				case 2481569024:
					return typeof(MaterialPropertySoundData).GetProperty(nameof(MaterialSoundId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
