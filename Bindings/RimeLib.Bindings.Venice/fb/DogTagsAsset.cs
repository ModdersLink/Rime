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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class DogTagsAsset : 
		Asset
	{
		protected CtrRef<StatsCategoryWeaponData> m_MeleeKillWeapon = new CtrRef<StatsCategoryWeaponData>();
		[ContainerField(Name: "MeleeKillWeapon", Offset: 12, NameHash: 789892769, Flags: 53)]
		public CtrRef<StatsCategoryWeaponData> MeleeKillWeapon { get { return m_MeleeKillWeapon; } set { if (OnPropertyChanging("DogTagsAsset." + nameof(MeleeKillWeapon), this, m_MeleeKillWeapon, value)) m_MeleeKillWeapon = value; } } // 0xC (12)
		
		protected RefArray<BasicDogTagData> m_BasicDogTags = new RefArray<BasicDogTagData>();
		[ContainerField(Name: "BasicDogTags", Offset: 16, NameHash: 3176450162, Flags: 65)]
		public RefArray<BasicDogTagData> BasicDogTags { get { return m_BasicDogTags; } set { if (OnPropertyChanging("DogTagsAsset." + nameof(BasicDogTags), this, m_BasicDogTags, value)) m_BasicDogTags = value; } } // 0x10 (16)
		
		protected RefArray<AdvancedDogTagData> m_AdvancedDogTags = new RefArray<AdvancedDogTagData>();
		[ContainerField(Name: "AdvancedDogTags", Offset: 20, NameHash: 1447180982, Flags: 65)]
		public RefArray<AdvancedDogTagData> AdvancedDogTags { get { return m_AdvancedDogTags; } set { if (OnPropertyChanging("DogTagsAsset." + nameof(AdvancedDogTags), this, m_AdvancedDogTags, value)) m_AdvancedDogTags = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 789892769:
					MeleeKillWeapon = (CtrRef<StatsCategoryWeaponData>) p_Value;
					break;

				case 3176450162:
					BasicDogTags = (RefArray<BasicDogTagData>) p_Value;
					break;

				case 1447180982:
					AdvancedDogTags = (RefArray<AdvancedDogTagData>) p_Value;
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
				case 789892769:
					return MeleeKillWeapon;

				case 3176450162:
					return BasicDogTags;

				case 1447180982:
					return AdvancedDogTags;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 789892769:
					return typeof(DogTagsAsset).GetProperty(nameof(MeleeKillWeapon));

				case 3176450162:
					return typeof(DogTagsAsset).GetProperty(nameof(BasicDogTags));

				case 1447180982:
					return typeof(DogTagsAsset).GetProperty(nameof(AdvancedDogTags));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
