///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UISettings : 
		SystemSettings
	{
		[ContainerField(12)]
		public UISystemType System { get; set; } = new UISystemType(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<UIBundlesAsset> Bundles { get; set; } = new CtrRef<UIBundlesAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<ProfileOptionsAsset> ProfileOptions { get; set; } = new CtrRef<ProfileOptionsAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public LanguageFormat Language { get; set; } = new LanguageFormat(); // 0x18 (24)
		
		[ContainerField(28)]
		public DataCopSettings DataCop { get; set; } = new DataCopSettings(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool OneBundlePerGraph { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool DrawEnable { get; set; } // 0x21 (33)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3333232768:
					System = (UISystemType) Enum.ToObject(typeof(UISystemType), p_Value);
					break;

				case 2774764642:
					Bundles = (CtrRef<UIBundlesAsset>) p_Value;
					break;

				case 1140566110:
					ProfileOptions = (CtrRef<ProfileOptionsAsset>) p_Value;
					break;

				case 3872303031:
					Language = (LanguageFormat) Enum.ToObject(typeof(LanguageFormat), p_Value);
					break;

				case 3872848489:
					DataCop = (DataCopSettings) p_Value;
					break;

				case 1787189790:
					OneBundlePerGraph = (bool) p_Value;
					break;

				case 1347356004:
					DrawEnable = (bool) p_Value;
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
				case 3333232768:
					return System;

				case 2774764642:
					return Bundles;

				case 1140566110:
					return ProfileOptions;

				case 3872303031:
					return Language;

				case 3872848489:
					return DataCop;

				case 1787189790:
					return OneBundlePerGraph;

				case 1347356004:
					return DrawEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3333232768:
					return typeof(UISettings).GetProperty(nameof(System));

				case 2774764642:
					return typeof(UISettings).GetProperty(nameof(Bundles));

				case 1140566110:
					return typeof(UISettings).GetProperty(nameof(ProfileOptions));

				case 3872303031:
					return typeof(UISettings).GetProperty(nameof(Language));

				case 3872848489:
					return typeof(UISettings).GetProperty(nameof(DataCop));

				case 1787189790:
					return typeof(UISettings).GetProperty(nameof(OneBundlePerGraph));

				case 1347356004:
					return typeof(UISettings).GetProperty(nameof(DrawEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
