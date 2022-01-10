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
	[ContainerType(4, 44)]
	public class SkeletonAsset : 
		BaseSkeletonAsset
	{
		[ContainerField(12)]
		public List<string> BoneNames { get; set; } = new();

		[ContainerField(16)]
		public List<int> Hierarchy { get; set; } = new();

		[ContainerField(20)]
		public List<LinearTransform> LocalPose { get; set; } = new();

		[ContainerField(24)]
		public List<LinearTransform> ModelPose { get; set; } = new();

		[ContainerField(28), LayoutImmutable]
		public string WeaponBoneName { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string HeadBoneName { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable]
		public string HipBoneName { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable]
		public string CameraBoneName { get; set; } = string.Empty;

		public static void Deserialize(SkeletonAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BoneNames.Clear();
			(RimeReader Reader, uint Count) s_BoneNames = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BoneNames.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_BoneNames.Reader.ReadUInt32());
				p_Instance.BoneNames.Add(s_Value);
			}
			
			s_BoneNames.Reader.Dispose();
			p_Instance.Hierarchy.Clear();
			(RimeReader Reader, uint Count) s_Hierarchy = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Hierarchy.Count; ++i)
			{
				var s_Value = s_Hierarchy.Reader.ReadInt32();
				p_Instance.Hierarchy.Add(s_Value);
			}
			
			s_Hierarchy.Reader.Dispose();
			p_Instance.LocalPose.Clear();
			(RimeReader Reader, uint Count) s_LocalPose = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LocalPose.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_LocalPose.Reader, p_Parser);
				p_Instance.LocalPose.Add(s_Value);
			}
			
			s_LocalPose.Reader.Dispose();
			p_Instance.ModelPose.Clear();
			(RimeReader Reader, uint Count) s_ModelPose = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ModelPose.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_ModelPose.Reader, p_Parser);
				p_Instance.ModelPose.Add(s_Value);
			}
			
			s_ModelPose.Reader.Dispose();
			p_Instance.WeaponBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.HeadBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.HipBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.CameraBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
