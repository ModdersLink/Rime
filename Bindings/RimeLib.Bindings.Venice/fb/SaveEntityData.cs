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
	public class SaveEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<TextureAsset> SaveScreenTexture { get; set; } = new CtrRef<TextureAsset>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string LevelName { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string SaveFileName { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string SaveNameSID { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool CheckForHumanPlayer { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1992725143:
					SaveScreenTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 1599082292:
					LevelName = (string) p_Value;
					break;

				case 1526449829:
					SaveFileName = (string) p_Value;
					break;

				case 1206536541:
					SaveNameSID = (string) p_Value;
					break;

				case 2331597556:
					CheckForHumanPlayer = (bool) p_Value;
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
				case 1992725143:
					return SaveScreenTexture;

				case 1599082292:
					return LevelName;

				case 1526449829:
					return SaveFileName;

				case 1206536541:
					return SaveNameSID;

				case 2331597556:
					return CheckForHumanPlayer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1992725143:
					return typeof(SaveEntityData).GetProperty(nameof(SaveScreenTexture));

				case 1599082292:
					return typeof(SaveEntityData).GetProperty(nameof(LevelName));

				case 1526449829:
					return typeof(SaveEntityData).GetProperty(nameof(SaveFileName));

				case 1206536541:
					return typeof(SaveEntityData).GetProperty(nameof(SaveNameSID));

				case 2331597556:
					return typeof(SaveEntityData).GetProperty(nameof(CheckForHumanPlayer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
