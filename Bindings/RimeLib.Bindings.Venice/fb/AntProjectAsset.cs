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
	[ContainerType(4, 28)]
	public class AntProjectAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<AntPackageAsset>> PackageAssets { get; set; } = new();

		[ContainerField(16), LayoutImmutable]
		public string AntNativeProjectName { get; set; } = string.Empty;

		[ContainerField(20)]
		public AntRef SceneOp { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public int ProjectId { get; set; }

		public static void Deserialize(AntProjectAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PackageAssets.Clear();
			(RimeReader Reader, uint Count) s_PackageAssets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PackageAssets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AntPackageAsset>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PackageAssets.Reader.ReadUInt32()));
				p_Instance.PackageAssets.Add(s_CtrRef);
			}
			
			s_PackageAssets.Reader.Dispose();
			p_Instance.AntNativeProjectName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.AntRef.Deserialize(p_Instance.SceneOp, p_Reader, p_Parser);
			p_Instance.ProjectId = p_Reader.ReadInt32();
		}

	}
}
