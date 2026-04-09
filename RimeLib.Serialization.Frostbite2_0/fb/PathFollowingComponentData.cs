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
	[ContainerType(16, 112)]
	public partial class PathFollowingComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _UpdatePathAtDistancePercent;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private uint _PreferredPathfindingIndex;

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private List<uint> _AlternatePathfindingIndices = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _MovementCorridorRadius;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UpdatePathAtDistancePercent);
			p_Writer.Write(PreferredPathfindingIndex);
			(RimeWriter Writer, uint ArrayIndex) s_AlternatePathfindingIndices = p_EbxWriter.GetArrayWriter(AlternatePathfindingIndices.GetType(), AlternatePathfindingIndices.Count);
			p_Writer.Write(s_AlternatePathfindingIndices.ArrayIndex);
			foreach (var s_Entry in AlternatePathfindingIndices)
			{
				s_AlternatePathfindingIndices.Writer.Write(s_Entry);
			}
			p_Writer.Write(MovementCorridorRadius);
		}
	}
}
