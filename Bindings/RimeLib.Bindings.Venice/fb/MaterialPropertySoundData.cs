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
	public class MaterialPropertySoundData : 
		PhysicsMaterialRelationPropertyData
	{
		protected CtrRef<SoundAsset> m_ImpactSound = new CtrRef<SoundAsset>();
		[ContainerField(8), ContainerFieldNameHash(3986717348)]
		public CtrRef<SoundAsset> ImpactSound { get { return m_ImpactSound; } set { if (OnPropertyChanging("MaterialPropertySoundData." + nameof(ImpactSound), this, m_ImpactSound, value)) m_ImpactSound = value; } } // 0x8 (8)
		
		protected CtrRef<SoundAsset> m_ScrapeSound = new CtrRef<SoundAsset>();
		[ContainerField(12), ContainerFieldNameHash(1279692944)]
		public CtrRef<SoundAsset> ScrapeSound { get { return m_ScrapeSound; } set { if (OnPropertyChanging("MaterialPropertySoundData." + nameof(ScrapeSound), this, m_ScrapeSound, value)) m_ScrapeSound = value; } } // 0xC (12)
		
		protected float m_ScrapeLength = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(544833071)]
		public float ScrapeLength { get { return m_ScrapeLength; } set { if (OnPropertyChanging("MaterialPropertySoundData." + nameof(ScrapeLength), this, m_ScrapeLength, value)) m_ScrapeLength = value; } } // 0x10 (16)
		
		protected CtrRef<MaterialSoldierSoundSettings> m_SoldierSettings = new CtrRef<MaterialSoldierSoundSettings>();
		[ContainerField(20), ContainerFieldNameHash(4066272810)]
		public CtrRef<MaterialSoldierSoundSettings> SoldierSettings { get { return m_SoldierSettings; } set { if (OnPropertyChanging("MaterialPropertySoundData." + nameof(SoldierSettings), this, m_SoldierSettings, value)) m_SoldierSettings = value; } } // 0x14 (20)
		
		protected float m_Softness = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(3898807136)]
		public float Softness { get { return m_Softness; } set { if (OnPropertyChanging("MaterialPropertySoundData." + nameof(Softness), this, m_Softness, value)) m_Softness = value; } } // 0x18 (24)
		
		protected float m_MaterialSoundId = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(2481569024)]
		public float MaterialSoundId { get { return m_MaterialSoundId; } set { if (OnPropertyChanging("MaterialPropertySoundData." + nameof(MaterialSoundId), this, m_MaterialSoundId, value)) m_MaterialSoundId = value; } } // 0x1C (28)
		
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
