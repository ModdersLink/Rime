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
	public class SoundTestSuite : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12)]
		public List<CtrRef<SoundAsset>> Assets { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<SoundTestSpec>> Tests { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool ProfileTests { get; set; }

		public static void Deserialize(SoundTestSuite p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Assets.Clear();
			(RimeReader Reader, uint Count) s_Assets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Assets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Assets.Reader.ReadUInt32()));
				p_Instance.Assets.Add(s_CtrRef);
			}
			
			s_Assets.Reader.Dispose();
			p_Instance.Tests.Clear();
			(RimeReader Reader, uint Count) s_Tests = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Tests.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundTestSpec>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Tests.Reader.ReadUInt32()));
				p_Instance.Tests.Add(s_CtrRef);
			}
			
			s_Tests.Reader.Dispose();
			p_Instance.ProfileTests = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
