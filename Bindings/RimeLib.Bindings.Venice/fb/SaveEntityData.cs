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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class SaveEntityData : 
		EntityData
	{
		protected CtrRef<TextureAsset> m_SaveScreenTexture = new CtrRef<TextureAsset>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(1992725143), ContainerCtrRef]
		public CtrRef<TextureAsset> SaveScreenTexture { get { return m_SaveScreenTexture; } set { if (OnPropertyChanging("SaveEntityData." + nameof(SaveScreenTexture), this, m_SaveScreenTexture, value)) m_SaveScreenTexture = value; } } // 0xC (12)
		
		protected string m_LevelName = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1599082292)]
		public string LevelName { get { return m_LevelName; } set { if (OnPropertyChanging("SaveEntityData." + nameof(LevelName), this, m_LevelName, value)) m_LevelName = value; } } // 0x10 (16)
		
		protected string m_SaveFileName = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1526449829)]
		public string SaveFileName { get { return m_SaveFileName; } set { if (OnPropertyChanging("SaveEntityData." + nameof(SaveFileName), this, m_SaveFileName, value)) m_SaveFileName = value; } } // 0x14 (20)
		
		protected string m_SaveNameSID = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1206536541)]
		public string SaveNameSID { get { return m_SaveNameSID; } set { if (OnPropertyChanging("SaveEntityData." + nameof(SaveNameSID), this, m_SaveNameSID, value)) m_SaveNameSID = value; } } // 0x18 (24)
		
		protected bool m_CheckForHumanPlayer = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2331597556)]
		public bool CheckForHumanPlayer { get { return m_CheckForHumanPlayer; } set { if (OnPropertyChanging("SaveEntityData." + nameof(CheckForHumanPlayer), this, m_CheckForHumanPlayer, value)) m_CheckForHumanPlayer = value; } } // 0x1C (28)
		
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
