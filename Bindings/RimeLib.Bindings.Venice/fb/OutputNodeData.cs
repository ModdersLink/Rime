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
	[ContainerType(4, 80)]
	public class OutputNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort BypassHeadroom { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MinDistance { get; set; }

		[ContainerField(28)]
		public AudioCurve AttenuationCurve { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Gain { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float HFDampingDistance { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float HFDampingObstruction { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float HFDampingOcclusion { get; set; }

		[ContainerField(52)]
		public SoundGraphPluginRef MainSendPlugin { get; set; } = new();

		[ContainerField(56)]
		public CtrRef<SoundBusData> MainSend { get; set; } = new();

		[ContainerField(60), LayoutImmutable]
		public string OutputName { get; set; } = string.Empty;

		[ContainerField(64)]
		public OutputTransformSource TransformSource { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable]
		public uint OutputNameHash { get; set; }

		[ContainerField(72)]
		public SoundGraphPluginRef LowPassPlugin { get; set; } = new();

		[ContainerField(75)]
		public SoundGraphPluginRef VuPlugin { get; set; } = new();

		[ContainerField(78), LayoutImmutable, Blittable]
		public bool Solo { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable]
		public bool EnableHdr { get; set; }

		public static void Deserialize(OutputNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.In, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.BypassHeadroom, p_Reader, p_Parser);
			p_Instance.MinDistance = p_Reader.ReadSingle();
			fb.AudioCurve.Deserialize(p_Instance.AttenuationCurve, p_Reader, p_Parser);
			p_Instance.Gain = p_Reader.ReadSingle();
			p_Instance.HFDampingDistance = p_Reader.ReadSingle();
			p_Instance.HFDampingObstruction = p_Reader.ReadSingle();
			p_Instance.HFDampingOcclusion = p_Reader.ReadSingle();
			fb.SoundGraphPluginRef.Deserialize(p_Instance.MainSendPlugin, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.MainSend.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.OutputName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.TransformSource = (OutputTransformSource) p_Reader.ReadInt32();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.OutputNameHash = p_Reader.ReadUInt32();
			p_Reader.Seek(1, SeekOrigin.Current);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.LowPassPlugin, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.VuPlugin, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.Solo = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.EnableHdr = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
