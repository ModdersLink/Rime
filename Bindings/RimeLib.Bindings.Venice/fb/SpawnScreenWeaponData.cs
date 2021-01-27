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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class SpawnScreenWeaponData : FrostbiteContainer
	{
		[ContainerField(Name: "WeaponName", Offset: 0, NameHash: 932725504, Flags: 16509), LayoutImmutable]
		public string WeaponName { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Texture", Offset: 4, NameHash: 3185041626, Flags: 53)]
		public CtrRef<TextureAsset> Texture { get; set; } = new CtrRef<TextureAsset>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 932725504:
					WeaponName = (string) p_Value;
					break;

				case 3185041626:
					Texture = (CtrRef<TextureAsset>) p_Value;
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
				case 932725504:
					return WeaponName;

				case 3185041626:
					return Texture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 932725504:
					return typeof(SpawnScreenWeaponData).GetProperty(nameof(WeaponName));

				case 3185041626:
					return typeof(SpawnScreenWeaponData).GetProperty(nameof(Texture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
