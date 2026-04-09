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
	[ContainerType(16, 128)]
	public partial class PhantomComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _BoxSize = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private AntRef _AsyncQueryPointerAsset = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private AntRef _EnableTrajectoryOverride = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private AntRef _TrajectoryOverride = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BoxSize.Serialize(p_Writer, p_EbxWriter);
			AsyncQueryPointerAsset.Serialize(p_Writer, p_EbxWriter);
			EnableTrajectoryOverride.Serialize(p_Writer, p_EbxWriter);
			TrajectoryOverride.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
		}
	}
}
