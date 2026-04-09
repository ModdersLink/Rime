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
	[ContainerType(16, 160)]
	public partial class EnlightenLightProbeSet :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private LinearTransform _Transform = new();
		
		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private AxisAlignedBox _BoundingBox = new();
		
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private uint _SizeX;
		
		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private uint _SizeZ;
		
		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private uint _SizeY;
		
		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private int _SystemId;
		
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _BlendDistance;
		
		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private int _Priority;
		
		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private List<Vec3> _Positions = new();
		
		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private List<uint> _ValidIndices = new();
		
		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private List<int> _InputSystems = new();
		
		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private PrecomputeCache _Cache = new();
		
		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private bool _StaticProbeSet;
		
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
