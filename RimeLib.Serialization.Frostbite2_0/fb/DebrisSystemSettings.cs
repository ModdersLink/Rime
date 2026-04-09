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
	public partial class DebrisSystemSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _MeshDrawCountLimit;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _TimeScale;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _MeshCullingDistance;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _DrawStats;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _MeshBatchCountLimit;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _MeshStreamingPriorityMultiplier;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _MeshRenderingEnable;

		[ObservableProperty]
		[property: ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		private bool _EnableJobs;

		[ObservableProperty]
		[property: ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		private bool _MeshShadowEnable;

		[ObservableProperty]
		[property: ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		private bool _MeshViewCullingEnable;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _MeshHavokRenderingEnable;

		[ObservableProperty]
		[property: ContainerField(37), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
		private bool _MeshDrawTransforms;

		[ObservableProperty]
		[property: ContainerField(38), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
		private bool _Enable;

		[ObservableProperty]
		[property: ContainerField(39), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
		private bool _MeshDrawBoundingBoxes;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private bool _MeshDrawCullStats;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(MeshDrawCountLimit);
			p_Writer.Write(TimeScale);
			p_Writer.Write(MeshCullingDistance);
			p_Writer.Write(DrawStats);
			p_Writer.Write(MeshBatchCountLimit);
			p_Writer.Write(MeshStreamingPriorityMultiplier);
			p_Writer.Write(MeshRenderingEnable);
			p_Writer.Write(EnableJobs);
			p_Writer.Write(MeshShadowEnable);
			p_Writer.Write(MeshViewCullingEnable);
			p_Writer.Write(MeshHavokRenderingEnable);
			p_Writer.Write(MeshDrawTransforms);
			p_Writer.Write(Enable);
			p_Writer.Write(MeshDrawBoundingBoxes);
			p_Writer.Write(MeshDrawCullStats);
			p_Writer.WriteNullBytes(3);
		}
	}
}
