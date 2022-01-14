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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class SkeletonAsset :
		BaseSkeletonAsset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<string> BoneNames { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<int> Hierarchy { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<LinearTransform> LocalPose { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<LinearTransform> ModelPose { get; set; } = new();

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string WeaponBoneName { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string HeadBoneName { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string HipBoneName { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string CameraBoneName { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_BoneNames = p_EbxWriter.GetArrayWriter(BoneNames.GetType(), BoneNames.Count);
			p_Writer.Write(s_BoneNames.ArrayIndex);
			foreach (var s_Entry in BoneNames)
			{
				s_BoneNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Hierarchy = p_EbxWriter.GetArrayWriter(Hierarchy.GetType(), Hierarchy.Count);
			p_Writer.Write(s_Hierarchy.ArrayIndex);
			foreach (var s_Entry in Hierarchy)
			{
				s_Hierarchy.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_LocalPose = p_EbxWriter.GetArrayWriter(LocalPose.GetType(), LocalPose.Count);
			p_Writer.Write(s_LocalPose.ArrayIndex);
			foreach (var s_Entry in LocalPose)
			{
				s_Entry.Serialize(s_LocalPose.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ModelPose = p_EbxWriter.GetArrayWriter(ModelPose.GetType(), ModelPose.Count);
			p_Writer.Write(s_ModelPose.ArrayIndex);
			foreach (var s_Entry in ModelPose)
			{
				s_Entry.Serialize(s_ModelPose.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteString(WeaponBoneName));
			p_Writer.Write(p_EbxWriter.WriteString(HeadBoneName));
			p_Writer.Write(p_EbxWriter.WriteString(HipBoneName));
			p_Writer.Write(p_EbxWriter.WriteString(CameraBoneName));
		}
	}
}
