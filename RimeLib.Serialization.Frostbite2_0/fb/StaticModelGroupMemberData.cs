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
	[ContainerType(4, 56)]
	public partial class StaticModelGroupMemberData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private List<LinearTransform> _InstanceTransforms = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private List<float> _InstanceScale = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<uint> _InstanceObjectVariation = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<bool> _InstanceCastSunShadow = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<GamePhysicsEntityData> _MemberType = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<EntityData> _MeshEntityType = new();
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _InstanceCount;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _HealthStateEntityManagerId;
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private IndexRange _PhysicsPartRange = new();
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _PhysicsPartCountPerInstance;
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private IndexRange _NetworkIdRange = new();
		
		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private uint _NetworkIdCountPerInstance;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_InstanceTransforms = p_EbxWriter.GetArrayWriter(InstanceTransforms.GetType(), InstanceTransforms.Count);
			p_Writer.Write(s_InstanceTransforms.ArrayIndex);
			foreach (var s_Entry in InstanceTransforms)
			{
				s_Entry.Serialize(s_InstanceTransforms.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_InstanceScale = p_EbxWriter.GetArrayWriter(InstanceScale.GetType(), InstanceScale.Count);
			p_Writer.Write(s_InstanceScale.ArrayIndex);
			foreach (var s_Entry in InstanceScale)
			{
				s_InstanceScale.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_InstanceObjectVariation = p_EbxWriter.GetArrayWriter(InstanceObjectVariation.GetType(), InstanceObjectVariation.Count);
			p_Writer.Write(s_InstanceObjectVariation.ArrayIndex);
			foreach (var s_Entry in InstanceObjectVariation)
			{
				s_InstanceObjectVariation.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_InstanceCastSunShadow = p_EbxWriter.GetArrayWriter(InstanceCastSunShadow.GetType(), InstanceCastSunShadow.Count);
			p_Writer.Write(s_InstanceCastSunShadow.ArrayIndex);
			foreach (var s_Entry in InstanceCastSunShadow)
			{
				s_InstanceCastSunShadow.Writer.Write(s_Entry);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(MemberType));
			p_Writer.Write(p_EbxWriter.WriteImport(MeshEntityType));
			p_Writer.Write(InstanceCount);
			p_Writer.Write(HealthStateEntityManagerId);
			PhysicsPartRange.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(PhysicsPartCountPerInstance);
			NetworkIdRange.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(NetworkIdCountPerInstance);
		}
	}
}
