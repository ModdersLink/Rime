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
	public class DogTagsAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<StatsCategoryWeaponData> MeleeKillWeapon { get; set; } = new CtrRef<StatsCategoryWeaponData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<BasicDogTagData> BasicDogTags { get; set; } = new RefArray<BasicDogTagData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<AdvancedDogTagData> AdvancedDogTags { get; set; } = new RefArray<AdvancedDogTagData>(); // 0x14 (20)
		
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
