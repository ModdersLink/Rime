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
	[ContainerType(4, 24)]
	public class DogTagsAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<StatsCategoryWeaponData> MeleeKillWeapon { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<BasicDogTagData>> BasicDogTags { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<AdvancedDogTagData>> AdvancedDogTags { get; set; } = new();

		public static void Deserialize(DogTagsAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MeleeKillWeapon.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BasicDogTags.Clear();
			(RimeReader Reader, uint Count) s_BasicDogTags = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BasicDogTags.Count; ++i)
			{
				var s_CtrRef = new CtrRef<BasicDogTagData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_BasicDogTags.Reader.ReadUInt32()));
				p_Instance.BasicDogTags.Add(s_CtrRef);
			}
			
			s_BasicDogTags.Reader.Dispose();
			p_Instance.AdvancedDogTags.Clear();
			(RimeReader Reader, uint Count) s_AdvancedDogTags = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AdvancedDogTags.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AdvancedDogTagData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_AdvancedDogTags.Reader.ReadUInt32()));
				p_Instance.AdvancedDogTags.Add(s_CtrRef);
			}
			
			s_AdvancedDogTags.Reader.Dispose();
		}

	}
}
