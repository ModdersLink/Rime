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
	public class PersistenceConfiguration : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<StatCategoryTreeCollection> StatCategoryTreeCollection { get; set; } = new CtrRef<StatCategoryTreeCollection>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<PlayerTypeProfile> MPProfile { get; set; } = new CtrRef<PlayerTypeProfile>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<PlayerTypeProfile> SPProfile { get; set; } = new CtrRef<PlayerTypeProfile>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<PlayerTypeProfile> CoopProfile { get; set; } = new CtrRef<PlayerTypeProfile>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<PointSystemParamsAsset> PointSystemParams { get; set; } = new CtrRef<PointSystemParamsAsset>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<LicenseConfiguration> LicenseConfig { get; set; } = new CtrRef<LicenseConfiguration>(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3707151255:
					StatCategoryTreeCollection = (CtrRef<StatCategoryTreeCollection>) p_Value;
					break;

				case 3634413939:
					MPProfile = (CtrRef<PlayerTypeProfile>) p_Value;
					break;

				case 1193421421:
					SPProfile = (CtrRef<PlayerTypeProfile>) p_Value;
					break;

				case 3202703933:
					CoopProfile = (CtrRef<PlayerTypeProfile>) p_Value;
					break;

				case 2854935248:
					PointSystemParams = (CtrRef<PointSystemParamsAsset>) p_Value;
					break;

				case 3061955380:
					LicenseConfig = (CtrRef<LicenseConfiguration>) p_Value;
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
				case 3707151255:
					return StatCategoryTreeCollection;

				case 3634413939:
					return MPProfile;

				case 1193421421:
					return SPProfile;

				case 3202703933:
					return CoopProfile;

				case 2854935248:
					return PointSystemParams;

				case 3061955380:
					return LicenseConfig;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3707151255:
					return typeof(PersistenceConfiguration).GetProperty(nameof(StatCategoryTreeCollection));

				case 3634413939:
					return typeof(PersistenceConfiguration).GetProperty(nameof(MPProfile));

				case 1193421421:
					return typeof(PersistenceConfiguration).GetProperty(nameof(SPProfile));

				case 3202703933:
					return typeof(PersistenceConfiguration).GetProperty(nameof(CoopProfile));

				case 2854935248:
					return typeof(PersistenceConfiguration).GetProperty(nameof(PointSystemParams));

				case 3061955380:
					return typeof(PersistenceConfiguration).GetProperty(nameof(LicenseConfig));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
