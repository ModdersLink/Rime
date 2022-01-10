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
	[ContainerType(16, 144)]
	public class RagdollComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<RagdollAsset> RagdollAsset { get; set; } = new();

		[ContainerField(104)]
		public CtrRef<SkeletonCollisionData> SkeletonCollisionData { get; set; } = new();

		[ContainerField(108)]
		public RagdollBinding Binding { get; set; } = new();

		[ContainerField(128), LayoutImmutable]
		public string LeftLegBoneName { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable]
		public string RightLegBoneName { get; set; } = string.Empty;

		public static void Deserialize(RagdollComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SkeletonAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.RagdollAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SkeletonCollisionData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.RagdollBinding.Deserialize(p_Instance.Binding, p_Reader, p_Parser);
			p_Instance.LeftLegBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.RightLegBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
