///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 192)]
	public class EnlightenDbSystem
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox BoundingBox { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint AtlasStartX { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint AtlasStartY { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint OutputWidth { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public uint OutputHeight { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint PixelCount { get; set; }
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float PixelSize { get; set; }
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public int SystemId { get; set; }
		
		[ContainerField(60)]
		public List<EnlightenDbInstance> Instances { get; set; } = new();
		
		[ContainerField(64)]
		public List<int> InputSystems { get; set; } = new();
		
		[ContainerField(68)]
		public PrecomputeCache SystemCache { get; set; } = new();
		
		[ContainerField(92)]
		public PrecomputeCache ClusteringCache { get; set; } = new();
		
		[ContainerField(116)]
		public PrecomputeCache PreClusteringCache { get; set; } = new();
		
		[ContainerField(140)]
		public PrecomputeCache LightTransportCache { get; set; } = new();
		
		[ContainerField(164)]
		public PrecomputeCache VisibilityCache { get; set; } = new();
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public bool TerrainSystem { get; set; }
		
		public static void Deserialize(EnlightenDbSystem p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AxisAlignedBox.Deserialize(p_Instance.BoundingBox, p_Reader, p_Parser);
			p_Instance.AtlasStartX = p_Reader.ReadUInt32();
			p_Instance.AtlasStartY = p_Reader.ReadUInt32();
			p_Instance.OutputWidth = p_Reader.ReadUInt32();
			p_Instance.OutputHeight = p_Reader.ReadUInt32();
			p_Instance.PixelCount = p_Reader.ReadUInt32();
			p_Instance.PixelSize = p_Reader.ReadSingle();
			p_Instance.SystemId = p_Reader.ReadInt32();
			p_Instance.Instances.Clear();
			(RimeReader Reader, uint Count) s_Instances = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Instances.Count; ++i)
			{
				var s_Value = new EnlightenDbInstance();
				fb.EnlightenDbInstance.Deserialize(s_Value, s_Instances.Reader, p_Parser);
				p_Instance.Instances.Add(s_Value);
			}
			
			s_Instances.Reader.Dispose();
			p_Instance.InputSystems.Clear();
			(RimeReader Reader, uint Count) s_InputSystems = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputSystems.Count; ++i)
			{
				var s_Value = s_InputSystems.Reader.ReadInt32();
				p_Instance.InputSystems.Add(s_Value);
			}
			
			s_InputSystems.Reader.Dispose();
			fb.PrecomputeCache.Deserialize(p_Instance.SystemCache, p_Reader, p_Parser);
			fb.PrecomputeCache.Deserialize(p_Instance.ClusteringCache, p_Reader, p_Parser);
			fb.PrecomputeCache.Deserialize(p_Instance.PreClusteringCache, p_Reader, p_Parser);
			fb.PrecomputeCache.Deserialize(p_Instance.LightTransportCache, p_Reader, p_Parser);
			fb.PrecomputeCache.Deserialize(p_Instance.VisibilityCache, p_Reader, p_Parser);
			p_Instance.TerrainSystem = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
