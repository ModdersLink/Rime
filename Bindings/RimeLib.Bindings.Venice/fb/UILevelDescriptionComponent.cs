///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class UILevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		[ContainerField(8), LayoutImmutable]
		public string MPLoadingAssetPath { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<SoundAsset> LoadingMusic { get; set; } = new CtrRef<SoundAsset>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string LoadingMusicPath { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string LevelImagePath { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string LoadingImagePath { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string SPLoadingAssetPath { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public UIGPSPosition GPSPosition { get; set; } = new UIGPSPosition(); // 0x20 (32)
		
		[ContainerField(56)]
		public CtrRef<GameTipAsset> HintAsset { get; set; } = new CtrRef<GameTipAsset>(); // 0x38 (56)
		
		[ContainerField(60)]
		public RefArray<UICreditsAsset> CreditsAssets { get; set; } = new RefArray<UICreditsAsset>(); // 0x3C (60)
		
		[ContainerField(64)]
		public UIMinimapData MinimapData { get; set; } = new UIMinimapData(); // 0x40 (64)
		
		[ContainerField(320)]
		public UILevelStatData LevelCompledStatData { get; set; } = new UILevelStatData(); // 0x140 (320)
		
		[ContainerField(336)]
		public UILevelStatData LevelScoreStatData { get; set; } = new UILevelStatData(); // 0x150 (336)
		
		[ContainerField(352), LayoutImmutable, Blittable]
		public int SortIndex { get; set; } // 0x160 (352)
		
		[ContainerField(356), LayoutImmutable, Blittable]
		public bool IsMenuLevel { get; set; } // 0x164 (356)
		
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
