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
	public class WeaponSocketObjectData : 
		SocketObjectDataBase
	{
		[ContainerField(8)]
		public List<uint> ReferencedAssetHashes { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<Asset> Asset1p { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<Asset> Asset1pzoom { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<Asset> Asset3p { get; set; } = new();

		public static void Deserialize(WeaponSocketObjectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ReferencedAssetHashes.Clear();
			(RimeReader Reader, uint Count) s_ReferencedAssetHashes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ReferencedAssetHashes.Count; ++i)
			{
				var s_Value = s_ReferencedAssetHashes.Reader.ReadUInt32();
				p_Instance.ReferencedAssetHashes.Add(s_Value);
			}
			
			s_ReferencedAssetHashes.Reader.Dispose();
			p_Instance.Asset1p.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Asset1pzoom.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Asset3p.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
