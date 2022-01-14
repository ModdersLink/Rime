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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 192)]
	public class EnlightenDbSystem :
		EbxSerializable
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public AxisAlignedBox BoundingBox { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public uint AtlasStartX { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint AtlasStartY { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint OutputWidth { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public uint OutputHeight { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public uint PixelCount { get; set; }
		
		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float PixelSize { get; set; }
		
		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public int SystemId { get; set; }
		
		[ContainerField(60), JsonProperty(Order = 60)]
		public List<EnlightenDbInstance> Instances { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public List<int> InputSystems { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public PrecomputeCache SystemCache { get; set; } = new();
		
		[ContainerField(92), JsonProperty(Order = 92)]
		public PrecomputeCache ClusteringCache { get; set; } = new();
		
		[ContainerField(116), JsonProperty(Order = 116)]
		public PrecomputeCache PreClusteringCache { get; set; } = new();
		
		[ContainerField(140), JsonProperty(Order = 140)]
		public PrecomputeCache LightTransportCache { get; set; } = new();
		
		[ContainerField(164), JsonProperty(Order = 164)]
		public PrecomputeCache VisibilityCache { get; set; } = new();
		
		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public bool TerrainSystem { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BoundingBox.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AtlasStartX);
			p_Writer.Write(AtlasStartY);
			p_Writer.Write(OutputWidth);
			p_Writer.Write(OutputHeight);
			p_Writer.Write(PixelCount);
			p_Writer.Write(PixelSize);
			p_Writer.Write(SystemId);
			(RimeWriter Writer, uint ArrayIndex) s_Instances = p_EbxWriter.GetArrayWriter(Instances.GetType(), Instances.Count);
			p_Writer.Write(s_Instances.ArrayIndex);
			foreach (var s_Entry in Instances)
			{
				s_Entry.Serialize(s_Instances.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_InputSystems = p_EbxWriter.GetArrayWriter(InputSystems.GetType(), InputSystems.Count);
			p_Writer.Write(s_InputSystems.ArrayIndex);
			foreach (var s_Entry in InputSystems)
			{
				s_InputSystems.Writer.Write(s_Entry);
			}
			SystemCache.Serialize(p_Writer, p_EbxWriter);
			ClusteringCache.Serialize(p_Writer, p_EbxWriter);
			PreClusteringCache.Serialize(p_Writer, p_EbxWriter);
			LightTransportCache.Serialize(p_Writer, p_EbxWriter);
			VisibilityCache.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TerrainSystem);
			p_Writer.WriteNullBytes(3);
		}
	}
}
