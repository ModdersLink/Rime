///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class PersistenceConfiguration : 
		Asset
	{
		protected CtrRef<StatCategoryTreeCollection> m_StatCategoryTreeCollection = new CtrRef<StatCategoryTreeCollection>();
		[ContainerField(12), ContainerFieldNameHash(3707151255)]
		public CtrRef<StatCategoryTreeCollection> StatCategoryTreeCollection { get { return m_StatCategoryTreeCollection; } set { if (OnPropertyChanging("PersistenceConfiguration." + nameof(StatCategoryTreeCollection), this, m_StatCategoryTreeCollection, value)) m_StatCategoryTreeCollection = value; } } // 0xC (12)
		
		protected CtrRef<PlayerTypeProfile> m_MPProfile = new CtrRef<PlayerTypeProfile>();
		[ContainerField(16), ContainerFieldNameHash(3634413939)]
		public CtrRef<PlayerTypeProfile> MPProfile { get { return m_MPProfile; } set { if (OnPropertyChanging("PersistenceConfiguration." + nameof(MPProfile), this, m_MPProfile, value)) m_MPProfile = value; } } // 0x10 (16)
		
		protected CtrRef<PlayerTypeProfile> m_SPProfile = new CtrRef<PlayerTypeProfile>();
		[ContainerField(20), ContainerFieldNameHash(1193421421)]
		public CtrRef<PlayerTypeProfile> SPProfile { get { return m_SPProfile; } set { if (OnPropertyChanging("PersistenceConfiguration." + nameof(SPProfile), this, m_SPProfile, value)) m_SPProfile = value; } } // 0x14 (20)
		
		protected CtrRef<PlayerTypeProfile> m_CoopProfile = new CtrRef<PlayerTypeProfile>();
		[ContainerField(24), ContainerFieldNameHash(3202703933)]
		public CtrRef<PlayerTypeProfile> CoopProfile { get { return m_CoopProfile; } set { if (OnPropertyChanging("PersistenceConfiguration." + nameof(CoopProfile), this, m_CoopProfile, value)) m_CoopProfile = value; } } // 0x18 (24)
		
		protected CtrRef<PointSystemParamsAsset> m_PointSystemParams = new CtrRef<PointSystemParamsAsset>();
		[ContainerField(28), ContainerFieldNameHash(2854935248)]
		public CtrRef<PointSystemParamsAsset> PointSystemParams { get { return m_PointSystemParams; } set { if (OnPropertyChanging("PersistenceConfiguration." + nameof(PointSystemParams), this, m_PointSystemParams, value)) m_PointSystemParams = value; } } // 0x1C (28)
		
		protected CtrRef<LicenseConfiguration> m_LicenseConfig = new CtrRef<LicenseConfiguration>();
		[ContainerField(32), ContainerFieldNameHash(3061955380)]
		public CtrRef<LicenseConfiguration> LicenseConfig { get { return m_LicenseConfig; } set { if (OnPropertyChanging("PersistenceConfiguration." + nameof(LicenseConfig), this, m_LicenseConfig, value)) m_LicenseConfig = value; } } // 0x20 (32)
		
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
