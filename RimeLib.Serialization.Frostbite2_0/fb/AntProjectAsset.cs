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

namespace fb
{
	[ContainerType(4, 28)]
	public class AntProjectAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<AntPackageAsset> PackageAssets { get; set; } = new();

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string AntNativeProjectName { get; set; } = string.Empty;

		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef SceneOp { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int ProjectId { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_PackageAssets = p_EbxWriter.GetArrayWriter(PackageAssets.GetType(), PackageAssets.Count);
			p_Writer.Write(s_PackageAssets.ArrayIndex);
			foreach (var s_Entry in PackageAssets)
			{
				s_PackageAssets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(AntNativeProjectName));
			SceneOp.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ProjectId);
		}
	}
}
