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
	public class ConeOutputNodeData : 
		OutputNodeData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Direction { get; set; } = new();

		[ContainerField(96)]
		public AudioGraphNodePort PositionY { get; set; } = new();

		[ContainerField(104)]
		public AudioGraphNodePort PositionX { get; set; } = new();

		[ContainerField(112)]
		public AudioGraphNodePort PositionZ { get; set; } = new();

		[ContainerField(120)]
		public AudioGraphNodePort OuterAngle { get; set; } = new();

		[ContainerField(128)]
		public AudioGraphNodePort InnerAngle { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public float OutsideGain { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float PanSize { get; set; }

		[ContainerField(144)]
		public AudioGraphNodePort CenterLevel { get; set; } = new();

		[ContainerField(152)]
		public AudioGraphNodePort LfeLevel { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public float HFDampingAngle { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float ReverbGain { get; set; }

		[ContainerField(168)]
		public CtrRef<SoundBusData> ReverbSend { get; set; } = new();

		[ContainerField(172)]
		public SoundGraphPluginRef PanPlugin { get; set; } = new();

		[ContainerField(175)]
		public SoundGraphPluginRef ReverbSendPlugin { get; set; } = new();

	}
}
