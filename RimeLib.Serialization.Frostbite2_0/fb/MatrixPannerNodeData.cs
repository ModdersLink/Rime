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
	[ContainerType(4, 88)]
	public partial class MatrixPannerNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _In = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _FrontLeft = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _Center = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AudioGraphNodePort _FrontRight = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AudioGraphNodePort _RearLeft = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AudioGraphNodePort _Lfe = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AudioGraphNodePort _RearRight = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AudioGraphNodePort _FarRearLeft = new();

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private AudioGraphNodePort _FarRearRight = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private AudioGraphNodePort _Out = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			In.Serialize(p_Writer, p_EbxWriter);
			FrontLeft.Serialize(p_Writer, p_EbxWriter);
			Center.Serialize(p_Writer, p_EbxWriter);
			FrontRight.Serialize(p_Writer, p_EbxWriter);
			RearLeft.Serialize(p_Writer, p_EbxWriter);
			Lfe.Serialize(p_Writer, p_EbxWriter);
			RearRight.Serialize(p_Writer, p_EbxWriter);
			FarRearLeft.Serialize(p_Writer, p_EbxWriter);
			FarRearRight.Serialize(p_Writer, p_EbxWriter);
			Out.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
