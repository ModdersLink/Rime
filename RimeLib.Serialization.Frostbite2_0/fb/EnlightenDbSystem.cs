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
	[ContainerType(16, 192)]
	public partial class EnlightenDbSystem :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private AxisAlignedBox _BoundingBox = new();
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private uint _AtlasStartX;
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _AtlasStartY;
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private uint _OutputWidth;
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private uint _OutputHeight;
		
		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private uint _PixelCount;
		
		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _PixelSize;
		
		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private int _SystemId;
		
		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private List<EnlightenDbInstance> _Instances = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private List<int> _InputSystems = new();
		
		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private PrecomputeCache _SystemCache = new();
		
		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private PrecomputeCache _ClusteringCache = new();
		
		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private PrecomputeCache _PreClusteringCache = new();
		
		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private PrecomputeCache _LightTransportCache = new();
		
		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private PrecomputeCache _VisibilityCache = new();
		
		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private bool _TerrainSystem;
		
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
