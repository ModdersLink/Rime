///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 368)]
	public class UILevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		[ContainerField(8), LayoutImmutable]
		public string MPLoadingAssetPath { get; set; } = string.Empty;

		[ContainerField(12)]
		public CtrRef<SoundAsset> LoadingMusic { get; set; } = new();

		[ContainerField(16), LayoutImmutable]
		public string LoadingMusicPath { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string LevelImagePath { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string LoadingImagePath { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string SPLoadingAssetPath { get; set; } = string.Empty;

		[ContainerField(32)]
		public UIGPSPosition GPSPosition { get; set; } = new();

		[ContainerField(56)]
		public CtrRef<GameTipAsset> HintAsset { get; set; } = new();

		[ContainerField(60)]
		public RefArray<UICreditsAsset> CreditsAssets { get; set; } = new();

		[ContainerField(64)]
		public UIMinimapData MinimapData { get; set; } = new();

		[ContainerField(320)]
		public UILevelStatData LevelCompledStatData { get; set; } = new();

		[ContainerField(336)]
		public UILevelStatData LevelScoreStatData { get; set; } = new();

		[ContainerField(352), LayoutImmutable, Blittable]
		public int SortIndex { get; set; }

		[ContainerField(356), LayoutImmutable, Blittable]
		public bool IsMenuLevel { get; set; }

	}
}
