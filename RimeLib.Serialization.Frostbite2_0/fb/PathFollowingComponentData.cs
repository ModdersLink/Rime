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

namespace fb
{
	[ContainerType(16, 112)]
	public class PathFollowingComponentData :
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float UpdatePathAtDistancePercent { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public uint PreferredPathfindingIndex { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public List<uint> AlternatePathfindingIndices { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float MovementCorridorRadius { get; set; }

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
