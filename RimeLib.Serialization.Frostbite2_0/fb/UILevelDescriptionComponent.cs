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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 368)]
	public partial class UILevelDescriptionComponent :
		LevelDescriptionComponent
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _MPLoadingAssetPath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<SoundAsset> _LoadingMusic = new();

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _LoadingMusicPath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _LevelImagePath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _LoadingImagePath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _SPLoadingAssetPath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private UIGPSPosition _GPSPosition = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private CtrRef<GameTipAsset> _HintAsset = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private RefArray<UICreditsAsset> _CreditsAssets = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private UIMinimapData _MinimapData = new();

		[ObservableProperty]
		[property: ContainerField(320), JsonProperty(Order = 320)]
		private UILevelStatData _LevelCompledStatData = new();

		[ObservableProperty]
		[property: ContainerField(336), JsonProperty(Order = 336)]
		private UILevelStatData _LevelScoreStatData = new();

		[ObservableProperty]
		[property: ContainerField(352), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
		private int _SortIndex;

		[ObservableProperty]
		[property: ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		private bool _IsMenuLevel;

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
