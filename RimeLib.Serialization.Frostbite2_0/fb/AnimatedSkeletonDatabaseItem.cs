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
	[ContainerType(4, 32)]
	public partial class AnimatedSkeletonDatabaseItem :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private CtrRef<SkeletonAsset> _Asset = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private List<int> _Names = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<SkeletonCollisionData> _SoldierCollision = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<SkeletonCollisionData> _RagdollCollision = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<RagdollAsset> _Ragdoll = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<string> _SpecialBones = new();
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _HipBone = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _HeadBone = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Asset));
			(RimeWriter Writer, uint ArrayIndex) s_Names = p_EbxWriter.GetArrayWriter(Names.GetType(), Names.Count);
			p_Writer.Write(s_Names.ArrayIndex);
			foreach (var s_Entry in Names)
			{
				s_Names.Writer.Write(s_Entry);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(SoldierCollision));
			p_Writer.Write(p_EbxWriter.WriteImport(RagdollCollision));
			p_Writer.Write(p_EbxWriter.WriteImport(Ragdoll));
			(RimeWriter Writer, uint ArrayIndex) s_SpecialBones = p_EbxWriter.GetArrayWriter(SpecialBones.GetType(), SpecialBones.Count);
			p_Writer.Write(s_SpecialBones.ArrayIndex);
			foreach (var s_Entry in SpecialBones)
			{
				s_SpecialBones.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteString(HipBone));
			p_Writer.Write(p_EbxWriter.WriteString(HeadBone));
		}
	}
}
