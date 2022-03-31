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
	[ContainerType(16, 160)]
	public class EnlightenLightProbeSet :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public LinearTransform Transform { get; set; } = new();
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public AxisAlignedBox BoundingBox { get; set; } = new();
		
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public uint SizeX { get; set; }
		
		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public uint SizeZ { get; set; }
		
		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public uint SizeY { get; set; }
		
		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public int SystemId { get; set; }
		
		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float BlendDistance { get; set; }
		
		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public int Priority { get; set; }
		
		[ContainerField(120), JsonProperty(Order = 120)]
		public List<Vec3> Positions { get; set; } = new();
		
		[ContainerField(124), JsonProperty(Order = 124)]
		public List<uint> ValidIndices { get; set; } = new();
		
		[ContainerField(128), JsonProperty(Order = 128)]
		public List<int> InputSystems { get; set; } = new();
		
		[ContainerField(132), JsonProperty(Order = 132)]
		public PrecomputeCache Cache { get; set; } = new();
		
		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool StaticProbeSet { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Transform.Serialize(p_Writer, p_EbxWriter);
			BoundingBox.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SizeX);
			p_Writer.Write(SizeZ);
			p_Writer.Write(SizeY);
			p_Writer.Write(SystemId);
			p_Writer.Write(BlendDistance);
			p_Writer.Write(Priority);
			(RimeWriter Writer, uint ArrayIndex) s_Positions = p_EbxWriter.GetArrayWriter(Positions.GetType(), Positions.Count);
			p_Writer.Write(s_Positions.ArrayIndex);
			foreach (var s_Entry in Positions)
			{
				s_Entry.Serialize(s_Positions.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ValidIndices = p_EbxWriter.GetArrayWriter(ValidIndices.GetType(), ValidIndices.Count);
			p_Writer.Write(s_ValidIndices.ArrayIndex);
			foreach (var s_Entry in ValidIndices)
			{
				s_ValidIndices.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_InputSystems = p_EbxWriter.GetArrayWriter(InputSystems.GetType(), InputSystems.Count);
			p_Writer.Write(s_InputSystems.ArrayIndex);
			foreach (var s_Entry in InputSystems)
			{
				s_InputSystems.Writer.Write(s_Entry);
			}
			Cache.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StaticProbeSet);
			p_Writer.WriteNullBytes(3);
		}
	}
}
