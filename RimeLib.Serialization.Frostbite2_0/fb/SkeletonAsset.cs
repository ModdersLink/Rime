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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 44)]
	public partial class SkeletonAsset :
		BaseSkeletonAsset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<string> _BoneNames = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<int> _Hierarchy = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<LinearTransform> _LocalPose = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<LinearTransform> _ModelPose = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _WeaponBoneName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _HeadBoneName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _HipBoneName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		private string _CameraBoneName = string.Empty;

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
