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
	[ContainerType(4, 32)]
	public class ProfileOptionsAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string FileName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable]
		public string ContentName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint FileSize { get; set; }

		[ContainerField(24)]
		public List<CtrRef<ProfileOptionData>> Options { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool AutoSaveOnQuit { get; set; }

		public static void Deserialize(ProfileOptionsAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FileName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ContentName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.FileSize = p_Reader.ReadUInt32();
			p_Instance.Options.Clear();
			(RimeReader Reader, uint Count) s_Options = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Options.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ProfileOptionData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Options.Reader.ReadUInt32()));
				p_Instance.Options.Add(s_CtrRef);
			}
			
			s_Options.Reader.Dispose();
			p_Instance.AutoSaveOnQuit = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
