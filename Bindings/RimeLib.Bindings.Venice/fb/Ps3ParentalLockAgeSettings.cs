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
	public class Ps3ParentalLockAgeSettings : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string Region { get; set; } // 0x0 (0)
		
		[ContainerField(4)]
		public Ps3AgeLevels AgeLevels { get; set; } = new Ps3AgeLevels(); // 0x4 (4)
		
		[ContainerField(20)]
		public CtrRef<Ps3ParentalLockAgeSettingsOverrides> CountryOverrides { get; set; } = new CtrRef<Ps3ParentalLockAgeSettingsOverrides>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3293978493:
					Region = (string) p_Value;
					break;

				case 2470460131:
					AgeLevels = (Ps3AgeLevels) p_Value;
					break;

				case 3680217322:
					CountryOverrides = (CtrRef<Ps3ParentalLockAgeSettingsOverrides>) p_Value;
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
				case 3293978493:
					return Region;

				case 2470460131:
					return AgeLevels;

				case 3680217322:
					return CountryOverrides;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3293978493:
					return typeof(Ps3ParentalLockAgeSettings).GetProperty(nameof(Region));

				case 2470460131:
					return typeof(Ps3ParentalLockAgeSettings).GetProperty(nameof(AgeLevels));

				case 3680217322:
					return typeof(Ps3ParentalLockAgeSettings).GetProperty(nameof(CountryOverrides));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
