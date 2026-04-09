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
	[ContainerType(4, 48)]
	public partial class DynamicAvoidanceEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private DynamicAvoidanceMode _RepelOthers = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private DynamicAvoidanceMode _ReportPredictedCollision = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _CollisionRadius;

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntDynamicAvoidanceBinding _AntBinding = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _AffectedByRepellingForce;

		[ObservableProperty]
		[property: ContainerField(45), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
		private bool _PredictedByOthers;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) RepelOthers);
			p_Writer.Write((int) ReportPredictedCollision);
			p_Writer.Write(CollisionRadius);
			p_Writer.Write((int) Realm);
			AntBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AffectedByRepellingForce);
			p_Writer.Write(PredictedByOthers);
			p_Writer.WriteNullBytes(2);
		}
	}
}
