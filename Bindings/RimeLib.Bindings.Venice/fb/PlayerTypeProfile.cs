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
	[ContainerType(4, 64)]
	public class PlayerTypeProfile : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<PersistenceData> Values { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<AwardDataTree> Awards { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<RankParamsAsset> RankParams { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<ScoringData> Scoring { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<DogTagsAsset> DogTags { get; set; } = new();

		[ContainerField(32)]
		public EloParameters EloParams { get; set; } = new();

		[ContainerField(52)]
		public CtrRef<StaticUnlockList> StaticUnlocks { get; set; } = new();

		[ContainerField(56)]
		public CtrRef<StatSpamSettings> SpamSettings { get; set; } = new();

		[ContainerField(60)]
		public List<string> OrderedUnlockNames { get; set; } = new();

		public static void Deserialize(PlayerTypeProfile p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Values.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Awards.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.RankParams.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Scoring.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DogTags.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.EloParameters.Deserialize(p_Instance.EloParams, p_Reader, p_Parser);
			p_Instance.StaticUnlocks.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SpamSettings.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.OrderedUnlockNames.Clear();
			(RimeReader Reader, uint Count) s_OrderedUnlockNames = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OrderedUnlockNames.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_OrderedUnlockNames.Reader.ReadUInt32());
				p_Instance.OrderedUnlockNames.Add(s_Value);
			}
			
			s_OrderedUnlockNames.Reader.Dispose();
		}

	}
}
