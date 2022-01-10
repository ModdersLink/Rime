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
	[ContainerType(4, 88)]
	public class DxDisplaySettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint FullscreenWidth { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint FullscreenHeight { get; set; }

		[ContainerField(20), LayoutImmutable]
		public string AmdMinDriverVersion { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint NvidiaMinDriverVersion { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float FullscreenRefreshRate { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float StereoSeparationScale { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float StereoDepth { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public int FullscreenOutputIndex { get; set; }

		[ContainerField(44)]
		public List<int> DebugBreakIgnoredIDs { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public float StereoConvergenceScale { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float StereoSoldierZoomConvergenceScale { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public int ForceRenderAheadLimit { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public int PresentInterval { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public bool DebugBreakOnWarningEnable { get; set; }

		[ContainerField(65), LayoutImmutable, Blittable]
		public bool DebugInfoEnable { get; set; }

		[ContainerField(66), LayoutImmutable, Blittable]
		public bool Fullscreen { get; set; }

		[ContainerField(67), LayoutImmutable, Blittable]
		public bool DebugBreakOnErrorEnable { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool CreateMinimalWindow { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable]
		public bool DriverInternalThreadingEnable { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable]
		public bool DebugBreakOnInfoEnable { get; set; }

		[ContainerField(71), LayoutImmutable, Blittable]
		public bool FullscreenModeEnable { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public bool VSyncEnable { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable]
		public bool TripleBufferingEnable { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable]
		public bool Dx10PlusEnable { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable]
		public bool NvApiEnable { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool NvPerfHudEnable { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable]
		public bool StereoEnable { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable]
		public bool Dx11Enable { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable]
		public bool Dx10Dot0Enable { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public bool RefDriverEnable { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable]
		public bool Dx10Dot1Enable { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable]
		public bool MinDriverRequired { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable]
		public bool WarpDriverEnable { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public bool NullDriverEnable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable]
		public bool MultiGpuValidationEnable { get; set; }

		public static void Deserialize(DxDisplaySettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FullscreenWidth = p_Reader.ReadUInt32();
			p_Instance.FullscreenHeight = p_Reader.ReadUInt32();
			p_Instance.AmdMinDriverVersion = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.NvidiaMinDriverVersion = p_Reader.ReadUInt32();
			p_Instance.FullscreenRefreshRate = p_Reader.ReadSingle();
			p_Instance.StereoSeparationScale = p_Reader.ReadSingle();
			p_Instance.StereoDepth = p_Reader.ReadSingle();
			p_Instance.FullscreenOutputIndex = p_Reader.ReadInt32();
			p_Instance.DebugBreakIgnoredIDs.Clear();
			(RimeReader Reader, uint Count) s_DebugBreakIgnoredIDs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DebugBreakIgnoredIDs.Count; ++i)
			{
				var s_Value = s_DebugBreakIgnoredIDs.Reader.ReadInt32();
				p_Instance.DebugBreakIgnoredIDs.Add(s_Value);
			}
			
			s_DebugBreakIgnoredIDs.Reader.Dispose();
			p_Instance.StereoConvergenceScale = p_Reader.ReadSingle();
			p_Instance.StereoSoldierZoomConvergenceScale = p_Reader.ReadSingle();
			p_Instance.ForceRenderAheadLimit = p_Reader.ReadInt32();
			p_Instance.PresentInterval = p_Reader.ReadInt32();
			p_Instance.DebugBreakOnWarningEnable = p_Reader.ReadBool();
			p_Instance.DebugInfoEnable = p_Reader.ReadBool();
			p_Instance.Fullscreen = p_Reader.ReadBool();
			p_Instance.DebugBreakOnErrorEnable = p_Reader.ReadBool();
			p_Instance.CreateMinimalWindow = p_Reader.ReadBool();
			p_Instance.DriverInternalThreadingEnable = p_Reader.ReadBool();
			p_Instance.DebugBreakOnInfoEnable = p_Reader.ReadBool();
			p_Instance.FullscreenModeEnable = p_Reader.ReadBool();
			p_Instance.VSyncEnable = p_Reader.ReadBool();
			p_Instance.TripleBufferingEnable = p_Reader.ReadBool();
			p_Instance.Dx10PlusEnable = p_Reader.ReadBool();
			p_Instance.NvApiEnable = p_Reader.ReadBool();
			p_Instance.NvPerfHudEnable = p_Reader.ReadBool();
			p_Instance.StereoEnable = p_Reader.ReadBool();
			p_Instance.Dx11Enable = p_Reader.ReadBool();
			p_Instance.Dx10Dot0Enable = p_Reader.ReadBool();
			p_Instance.RefDriverEnable = p_Reader.ReadBool();
			p_Instance.Dx10Dot1Enable = p_Reader.ReadBool();
			p_Instance.MinDriverRequired = p_Reader.ReadBool();
			p_Instance.WarpDriverEnable = p_Reader.ReadBool();
			p_Instance.NullDriverEnable = p_Reader.ReadBool();
			p_Instance.MultiGpuValidationEnable = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
