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
	public class GroupHavokAsset : 
		HavokAsset
	{
		[ContainerField(20)]
		public List<AssetAabbs> Aabb { get; set; } = new();

		[ContainerField(24)]
		public List<ushort> ExternalAssetScaleIndex { get; set; } = new();

		public static void Deserialize(GroupHavokAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Aabb.Clear();
			(RimeReader Reader, uint Count) s_Aabb = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Aabb.Count; ++i)
			{
				var s_Value = new AssetAabbs();
				fb.AssetAabbs.Deserialize(s_Value, s_Aabb.Reader, p_Parser);
				p_Instance.Aabb.Add(s_Value);
			}
			
			s_Aabb.Reader.Dispose();
			p_Instance.ExternalAssetScaleIndex.Clear();
			(RimeReader Reader, uint Count) s_ExternalAssetScaleIndex = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ExternalAssetScaleIndex.Count; ++i)
			{
				var s_Value = s_ExternalAssetScaleIndex.Reader.ReadUInt16();
				p_Instance.ExternalAssetScaleIndex.Add(s_Value);
			}
			
			s_ExternalAssetScaleIndex.Reader.Dispose();
		}

	}
}
