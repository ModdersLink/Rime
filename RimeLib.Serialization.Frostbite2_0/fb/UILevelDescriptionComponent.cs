///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 368)]
	public class UILevelDescriptionComponent :
		LevelDescriptionComponent
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string MPLoadingAssetPath { get; set; } = string.Empty;

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<SoundAsset> LoadingMusic { get; set; } = new();

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string LoadingMusicPath { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string LevelImagePath { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string LoadingImagePath { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string SPLoadingAssetPath { get; set; } = string.Empty;

		[ContainerField(32), JsonProperty(Order = 32)]
		public UIGPSPosition GPSPosition { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public CtrRef<GameTipAsset> HintAsset { get; set; } = new();

		[ContainerField(60), JsonProperty(Order = 60)]
		public RefArray<UICreditsAsset> CreditsAssets { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public UIMinimapData MinimapData { get; set; } = new();

		[ContainerField(320), JsonProperty(Order = 320)]
		public UILevelStatData LevelCompledStatData { get; set; } = new();

		[ContainerField(336), JsonProperty(Order = 336)]
		public UILevelStatData LevelScoreStatData { get; set; } = new();

		[ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		public int SortIndex { get; set; }

		[ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		public bool IsMenuLevel { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(MPLoadingAssetPath));
			p_Writer.Write(p_EbxWriter.WriteImport(LoadingMusic));
			p_Writer.Write(p_EbxWriter.WriteString(LoadingMusicPath));
			p_Writer.Write(p_EbxWriter.WriteString(LevelImagePath));
			p_Writer.Write(p_EbxWriter.WriteString(LoadingImagePath));
			p_Writer.Write(p_EbxWriter.WriteString(SPLoadingAssetPath));
			GPSPosition.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(HintAsset));
			(RimeWriter Writer, uint ArrayIndex) s_CreditsAssets = p_EbxWriter.GetArrayWriter(CreditsAssets.GetType(), CreditsAssets.Count);
			p_Writer.Write(s_CreditsAssets.ArrayIndex);
			foreach (var s_Entry in CreditsAssets)
			{
				s_CreditsAssets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			MinimapData.Serialize(p_Writer, p_EbxWriter);
			LevelCompledStatData.Serialize(p_Writer, p_EbxWriter);
			LevelScoreStatData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SortIndex);
			p_Writer.Write(IsMenuLevel);
			p_Writer.WriteNullBytes(11);
		}
	}
}
