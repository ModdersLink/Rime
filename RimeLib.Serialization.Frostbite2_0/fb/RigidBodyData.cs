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
	public partial class RigidBodyData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _InertiaModifier = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private RigidBodyType _RigidBodyType = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _Mass;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _Restitution;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _Friction;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _AngularVelocityDamping;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _LinearVelocityDamping;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private uint _InteractionToolkitCollisionVolumeId;

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private RigidBodyMotionType _MotionType = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private RigidBodyQualityType _QualityType = new();

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private RigidBodyCollisionLayer _CollisionLayer = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private CtrRef<FloatPhysicsData> _FloatPhysics = new();

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private RefArray<RigidBodyConstraintData> _Constraints = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			InertiaModifier.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) RigidBodyType);
			p_Writer.Write(Mass);
			p_Writer.Write(Restitution);
			p_Writer.Write(Friction);
			p_Writer.Write(AngularVelocityDamping);
			p_Writer.Write(LinearVelocityDamping);
			p_Writer.Write(InteractionToolkitCollisionVolumeId);
			p_Writer.Write((int) MotionType);
			p_Writer.Write((int) QualityType);
			p_Writer.Write((int) CollisionLayer);
			p_Writer.Write(p_EbxWriter.WriteImport(FloatPhysics));
			(RimeWriter Writer, uint ArrayIndex) s_Constraints = p_EbxWriter.GetArrayWriter(Constraints.GetType(), Constraints.Count);
			p_Writer.Write(s_Constraints.ArrayIndex);
			foreach (var s_Entry in Constraints)
			{
				s_Constraints.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
		}
	}
}
