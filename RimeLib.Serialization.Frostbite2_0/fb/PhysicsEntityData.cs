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
	[ContainerType(16, 80)]
	public partial class PhysicsEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _InertiaModifier = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private RefArray<HavokAsset> _ScaledAssets = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private RefArray<RigidBodyData> _RigidBodies = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private CtrRef<HavokAsset> _Asset = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private CtrRef<FloatPhysicsData> _FloatPhysics = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _Mass;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _Restitution;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _Friction;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _LinearVelocityDamping;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _AngularVelocityDamping;

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private CtrRef<ProximityData> _Proximity = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private RefArray<RigidBodyConstraintData> _Constraints = new();

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private bool _EncapsulatePartsInLists;

		[ObservableProperty]
		[property: ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		private bool _MovableParts;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			InertiaModifier.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ScaledAssets = p_EbxWriter.GetArrayWriter(ScaledAssets.GetType(), ScaledAssets.Count);
			p_Writer.Write(s_ScaledAssets.ArrayIndex);
			foreach (var s_Entry in ScaledAssets)
			{
				s_ScaledAssets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_RigidBodies = p_EbxWriter.GetArrayWriter(RigidBodies.GetType(), RigidBodies.Count);
			p_Writer.Write(s_RigidBodies.ArrayIndex);
			foreach (var s_Entry in RigidBodies)
			{
				s_RigidBodies.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Asset));
			p_Writer.Write(p_EbxWriter.WriteImport(FloatPhysics));
			p_Writer.Write(Mass);
			p_Writer.Write(Restitution);
			p_Writer.Write(Friction);
			p_Writer.Write(LinearVelocityDamping);
			p_Writer.Write(AngularVelocityDamping);
			p_Writer.Write(p_EbxWriter.WriteImport(Proximity));
			(RimeWriter Writer, uint ArrayIndex) s_Constraints = p_EbxWriter.GetArrayWriter(Constraints.GetType(), Constraints.Count);
			p_Writer.Write(s_Constraints.ArrayIndex);
			foreach (var s_Entry in Constraints)
			{
				s_Constraints.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(EncapsulatePartsInLists);
			p_Writer.Write(MovableParts);
			p_Writer.WriteNullBytes(2);
		}
	}
}
