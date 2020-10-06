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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(368), ContainerClass]
	public class UILevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		protected string m_MPLoadingAssetPath = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2284244963)]
		public string MPLoadingAssetPath { get { return m_MPLoadingAssetPath; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(MPLoadingAssetPath), this, m_MPLoadingAssetPath, value)) m_MPLoadingAssetPath = value; } } // 0x8 (8)
		
		protected CtrRef<SoundAsset> m_LoadingMusic = new CtrRef<SoundAsset>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(918318562), ContainerCtrRef]
		public CtrRef<SoundAsset> LoadingMusic { get { return m_LoadingMusic; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(LoadingMusic), this, m_LoadingMusic, value)) m_LoadingMusic = value; } } // 0xC (12)
		
		protected string m_LoadingMusicPath = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(4182834255)]
		public string LoadingMusicPath { get { return m_LoadingMusicPath; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(LoadingMusicPath), this, m_LoadingMusicPath, value)) m_LoadingMusicPath = value; } } // 0x10 (16)
		
		protected string m_LevelImagePath = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2627470009)]
		public string LevelImagePath { get { return m_LevelImagePath; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(LevelImagePath), this, m_LevelImagePath, value)) m_LevelImagePath = value; } } // 0x14 (20)
		
		protected string m_LoadingImagePath = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2651193097)]
		public string LoadingImagePath { get { return m_LoadingImagePath; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(LoadingImagePath), this, m_LoadingImagePath, value)) m_LoadingImagePath = value; } } // 0x18 (24)
		
		protected string m_SPLoadingAssetPath = string.Empty;
		[ContainerField(28), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1500941885)]
		public string SPLoadingAssetPath { get { return m_SPLoadingAssetPath; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(SPLoadingAssetPath), this, m_SPLoadingAssetPath, value)) m_SPLoadingAssetPath = value; } } // 0x1C (28)
		
		protected UIGPSPosition m_GPSPosition = new UIGPSPosition();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(3271355416)]
		public UIGPSPosition GPSPosition { get { return m_GPSPosition; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(GPSPosition), this, m_GPSPosition, value)) m_GPSPosition = value; } } // 0x20 (32)
		
		protected CtrRef<GameTipAsset> m_HintAsset = new CtrRef<GameTipAsset>();
		[ContainerField(56), MemberInfoFlag(53), ContainerFieldNameHash(3476636846), ContainerCtrRef]
		public CtrRef<GameTipAsset> HintAsset { get { return m_HintAsset; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(HintAsset), this, m_HintAsset, value)) m_HintAsset = value; } } // 0x38 (56)
		
		protected RefArray<UICreditsAsset> m_CreditsAssets = new RefArray<UICreditsAsset>();
		[ContainerField(60), MemberInfoFlag(65), ContainerFieldNameHash(369483736), ContainerRefArray]
		public RefArray<UICreditsAsset> CreditsAssets { get { return m_CreditsAssets; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(CreditsAssets), this, m_CreditsAssets, value)) m_CreditsAssets = value; } } // 0x3C (60)
		
		protected UIMinimapData m_MinimapData = new UIMinimapData();
		[ContainerField(64), MemberInfoFlag(41), ContainerFieldNameHash(1722414122)]
		public UIMinimapData MinimapData { get { return m_MinimapData; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(MinimapData), this, m_MinimapData, value)) m_MinimapData = value; } } // 0x40 (64)
		
		protected UILevelStatData m_LevelCompledStatData = new UILevelStatData();
		[ContainerField(320), MemberInfoFlag(41), ContainerFieldNameHash(2252761805)]
		public UILevelStatData LevelCompledStatData { get { return m_LevelCompledStatData; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(LevelCompledStatData), this, m_LevelCompledStatData, value)) m_LevelCompledStatData = value; } } // 0x140 (320)
		
		protected UILevelStatData m_LevelScoreStatData = new UILevelStatData();
		[ContainerField(336), MemberInfoFlag(41), ContainerFieldNameHash(1941326521)]
		public UILevelStatData LevelScoreStatData { get { return m_LevelScoreStatData; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(LevelScoreStatData), this, m_LevelScoreStatData, value)) m_LevelScoreStatData = value; } } // 0x150 (336)
		
		protected int m_SortIndex = new int();
		[ContainerField(352), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1347637313)]
		public int SortIndex { get { return m_SortIndex; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(SortIndex), this, m_SortIndex, value)) m_SortIndex = value; } } // 0x160 (352)
		
		protected bool m_IsMenuLevel = new bool();
		[ContainerField(356), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2405916058)]
		public bool IsMenuLevel { get { return m_IsMenuLevel; } set { if (OnPropertyChanging("UILevelDescriptionComponent." + nameof(IsMenuLevel), this, m_IsMenuLevel, value)) m_IsMenuLevel = value; } } // 0x164 (356)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2284244963:
					MPLoadingAssetPath = (string) p_Value;
					break;

				case 918318562:
					LoadingMusic = (CtrRef<SoundAsset>) p_Value;
					break;

				case 4182834255:
					LoadingMusicPath = (string) p_Value;
					break;

				case 2627470009:
					LevelImagePath = (string) p_Value;
					break;

				case 2651193097:
					LoadingImagePath = (string) p_Value;
					break;

				case 1500941885:
					SPLoadingAssetPath = (string) p_Value;
					break;

				case 3271355416:
					GPSPosition = (UIGPSPosition) p_Value;
					break;

				case 3476636846:
					HintAsset = (CtrRef<GameTipAsset>) p_Value;
					break;

				case 369483736:
					CreditsAssets = (RefArray<UICreditsAsset>) p_Value;
					break;

				case 1722414122:
					MinimapData = (UIMinimapData) p_Value;
					break;

				case 2252761805:
					LevelCompledStatData = (UILevelStatData) p_Value;
					break;

				case 1941326521:
					LevelScoreStatData = (UILevelStatData) p_Value;
					break;

				case 1347637313:
					SortIndex = (int) p_Value;
					break;

				case 2405916058:
					IsMenuLevel = (bool) p_Value;
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
				case 2284244963:
					return MPLoadingAssetPath;

				case 918318562:
					return LoadingMusic;

				case 4182834255:
					return LoadingMusicPath;

				case 2627470009:
					return LevelImagePath;

				case 2651193097:
					return LoadingImagePath;

				case 1500941885:
					return SPLoadingAssetPath;

				case 3271355416:
					return GPSPosition;

				case 3476636846:
					return HintAsset;

				case 369483736:
					return CreditsAssets;

				case 1722414122:
					return MinimapData;

				case 2252761805:
					return LevelCompledStatData;

				case 1941326521:
					return LevelScoreStatData;

				case 1347637313:
					return SortIndex;

				case 2405916058:
					return IsMenuLevel;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2284244963:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(MPLoadingAssetPath));

				case 918318562:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(LoadingMusic));

				case 4182834255:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(LoadingMusicPath));

				case 2627470009:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(LevelImagePath));

				case 2651193097:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(LoadingImagePath));

				case 1500941885:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(SPLoadingAssetPath));

				case 3271355416:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(GPSPosition));

				case 3476636846:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(HintAsset));

				case 369483736:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(CreditsAssets));

				case 1722414122:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(MinimapData));

				case 2252761805:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(LevelCompledStatData));

				case 1941326521:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(LevelScoreStatData));

				case 1347637313:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(SortIndex));

				case 2405916058:
					return typeof(UILevelDescriptionComponent).GetProperty(nameof(IsMenuLevel));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
