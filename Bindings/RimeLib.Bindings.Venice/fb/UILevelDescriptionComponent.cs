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
		public List<CtrRef<UICreditsAsset>> CreditsAssets { get; set; } = new();

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

		public static void Deserialize(UILevelDescriptionComponent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MPLoadingAssetPath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.LoadingMusic.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LoadingMusicPath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.LevelImagePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.LoadingImagePath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SPLoadingAssetPath = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.UIGPSPosition.Deserialize(p_Instance.GPSPosition, p_Reader, p_Parser);
			p_Instance.HintAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CreditsAssets.Clear();
			(RimeReader Reader, uint Count) s_CreditsAssets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_CreditsAssets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UICreditsAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_CreditsAssets.Reader.ReadUInt32()));
				p_Instance.CreditsAssets.Add(s_CtrRef);
			}
			
			s_CreditsAssets.Reader.Dispose();
			fb.UIMinimapData.Deserialize(p_Instance.MinimapData, p_Reader, p_Parser);
			fb.UILevelStatData.Deserialize(p_Instance.LevelCompledStatData, p_Reader, p_Parser);
			fb.UILevelStatData.Deserialize(p_Instance.LevelScoreStatData, p_Reader, p_Parser);
			p_Instance.SortIndex = p_Reader.ReadInt32();
			p_Instance.IsMenuLevel = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
