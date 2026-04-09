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
	public partial class InspectEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _CenterOffset = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, JsonProperty(Order = 112)]
		private string _UIName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _MaxLookAtHeight;

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private List<InspectViewPointData> _ViewPoints = new();

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private RefArray<TargetCameraData> _Cameras = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _MinLookAtHeight;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _MinDistance;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _ZoomScrollSpeed;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _MaxDistance;

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private AntRef _AnimationSignal = new();

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _ZoomScrollAcceleration;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			CenterOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(UIName));
			p_Writer.Write(MaxLookAtHeight);
			(RimeWriter Writer, uint ArrayIndex) s_ViewPoints = p_EbxWriter.GetArrayWriter(ViewPoints.GetType(), ViewPoints.Count);
			p_Writer.Write(s_ViewPoints.ArrayIndex);
			foreach (var s_Entry in ViewPoints)
			{
				s_Entry.Serialize(s_ViewPoints.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_Cameras = p_EbxWriter.GetArrayWriter(Cameras.GetType(), Cameras.Count);
			p_Writer.Write(s_Cameras.ArrayIndex);
			foreach (var s_Entry in Cameras)
			{
				s_Cameras.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(MinLookAtHeight);
			p_Writer.Write(MinDistance);
			p_Writer.Write(ZoomScrollSpeed);
			p_Writer.Write(MaxDistance);
			AnimationSignal.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ZoomScrollAcceleration);
			p_Writer.WriteNullBytes(8);
		}
	}
}
