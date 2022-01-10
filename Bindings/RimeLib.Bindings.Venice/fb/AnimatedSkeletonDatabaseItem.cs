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
	public class AnimatedSkeletonDatabaseItem
	{
		[ContainerField(0)]
		public CtrRef<SkeletonAsset> Asset { get; set; } = new();
		
		[ContainerField(4)]
		public List<int> Names { get; set; } = new();
		
		[ContainerField(8)]
		public CtrRef<SkeletonCollisionData> SoldierCollision { get; set; } = new();
		
		[ContainerField(12)]
		public CtrRef<SkeletonCollisionData> RagdollCollision { get; set; } = new();
		
		[ContainerField(16)]
		public CtrRef<RagdollAsset> Ragdoll { get; set; } = new();
		
		[ContainerField(20)]
		public List<string> SpecialBones { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable]
		public string HipBone { get; set; } = string.Empty;
		
		[ContainerField(28), LayoutImmutable]
		public string HeadBone { get; set; } = string.Empty;
		
		public static void Deserialize(AnimatedSkeletonDatabaseItem p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Asset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Names.Clear();
			(RimeReader Reader, uint Count) s_Names = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Names.Count; ++i)
			{
				var s_Value = s_Names.Reader.ReadInt32();
				p_Instance.Names.Add(s_Value);
			}
			
			s_Names.Reader.Dispose();
			p_Instance.SoldierCollision.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.RagdollCollision.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Ragdoll.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SpecialBones.Clear();
			(RimeReader Reader, uint Count) s_SpecialBones = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SpecialBones.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_SpecialBones.Reader.ReadUInt32());
				p_Instance.SpecialBones.Add(s_Value);
			}
			
			s_SpecialBones.Reader.Dispose();
			p_Instance.HipBone = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.HeadBone = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
