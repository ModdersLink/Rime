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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class MaterialRelationSoundData : 
		PhysicsMaterialRelationPropertyData
	{
		protected CtrRef<SoundAsset> m_ImpactSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "ImpactSound", Offset: 8, NameHash: 3986717348, Flags: 53)]
		public CtrRef<SoundAsset> ImpactSound { get { return m_ImpactSound; } set { if (OnPropertyChanging("MaterialRelationSoundData." + nameof(ImpactSound), this, m_ImpactSound, value)) m_ImpactSound = value; } } // 0x8 (8)
		
		protected CtrRef<SoundAsset> m_ScrapeSound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "ScrapeSound", Offset: 12, NameHash: 1279692944, Flags: 53)]
		public CtrRef<SoundAsset> ScrapeSound { get { return m_ScrapeSound; } set { if (OnPropertyChanging("MaterialRelationSoundData." + nameof(ScrapeSound), this, m_ScrapeSound, value)) m_ScrapeSound = value; } } // 0xC (12)
		
		protected float m_ScrapeLength = new float();
		[ContainerField(Name: "ScrapeLength", Offset: 16, NameHash: 544833071, Flags: 49469), LayoutImmutable, Blittable]
		public float ScrapeLength { get { return m_ScrapeLength; } set { if (OnPropertyChanging("MaterialRelationSoundData." + nameof(ScrapeLength), this, m_ScrapeLength, value)) m_ScrapeLength = value; } } // 0x10 (16)
		
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

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3986717348:
					return typeof(MaterialRelationSoundData).GetProperty(nameof(ImpactSound));

				case 1279692944:
					return typeof(MaterialRelationSoundData).GetProperty(nameof(ScrapeSound));

				case 544833071:
					return typeof(MaterialRelationSoundData).GetProperty(nameof(ScrapeLength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
