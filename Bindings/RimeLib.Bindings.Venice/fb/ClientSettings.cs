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
	[ContainerType(4, 156)]
	public class ClientSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LoadedTimeout { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint OutgoingRate { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float LoadingTimeout { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float IncomingFrequency { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint IncomingRate { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float DuplicationChance { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint Team { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxDropDuration { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float ReorderingChance { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float DropSpikeChance { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float MinDropDuration { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float MaxIncomingLatency { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float PacketDrops { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float MaxLatency { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float MinIncomingLatency { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float CorruptionChance { get; set; }

		[ContainerField(76), LayoutImmutable]
		public string ServerIp { get; set; } = string.Empty;

		[ContainerField(80), LayoutImmutable]
		public string ScreenshotSuffix { get; set; } = string.Empty;

		[ContainerField(84), LayoutImmutable, Blittable]
		public int SpawnPointIndex { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float MinLatency { get; set; }

		[ContainerField(92), LayoutImmutable]
		public string ScreenshotFilename { get; set; } = string.Empty;

		[ContainerField(96), LayoutImmutable, Blittable]
		public float IngameTimeout { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float AimScale { get; set; }

		[ContainerField(104), LayoutImmutable]
		public string SecondaryServerIp { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool SkipFastLevelLoad { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool ScreenshotToFile { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable]
		public bool IgnoreClientFireRateMultiplier { get; set; }

		[ContainerField(111), LayoutImmutable, Blittable]
		public bool InputEnable { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool LoadMenu { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable]
		public bool PauseGameOnStartUp { get; set; }

		[ContainerField(114), LayoutImmutable, Blittable]
		public bool DebugMenuOnLThumb { get; set; }

		[ContainerField(115), LayoutImmutable, Blittable]
		public bool InvertPitch { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool OccludersEnabled { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable]
		public bool IsPresenceEnabled { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable]
		public bool InvertFreeCamera { get; set; }

		[ContainerField(119), LayoutImmutable, Blittable]
		public bool Scheme2FlipY { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public bool InvertYaw { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable]
		public bool LipSyncEnabled { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable]
		public bool IsInternetSimulationEnabled { get; set; }

		[ContainerField(123), LayoutImmutable, Blittable]
		public bool OnDamageSpottingEnabled { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool EmittersEnabled { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool PadRumbleEnabled { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable]
		public bool OvergrowthEnabled { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable]
		public bool EffectsEnabled { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool TerrainEnabled { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable]
		public bool WaterPhysicsEnabled { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable]
		public bool VegetationEnabled { get; set; }

		[ContainerField(131), LayoutImmutable, Blittable]
		public bool WorldRenderEnabled { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool RenderTags { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable]
		public bool DebrisClusterEnabled { get; set; }

		[ContainerField(134), LayoutImmutable, Blittable]
		public bool HavokVisualDebugger { get; set; }

		[ContainerField(135), LayoutImmutable, Blittable]
		public bool HavokVDBShowsEffectsWorld { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool HavokCaptureToFile { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool UseMouseAndKeyboardSystem { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool UseGlobalGamePadInput { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable]
		public bool ThreadedLoadingEnable { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool ShowBuildId { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool ExtractPersistenceInformation { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable]
		public bool EnableRestTool { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable]
		public bool LocalVehicleSimulationEnabled { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool AsyncClientBulletEntity { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable]
		public bool AutoUnspawnDynamicObjects { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable]
		public bool VsyncEnable { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable]
		public bool VisualFrameInterpolation { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool InvertPadPcRightStick { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable]
		public bool Scheme0FlipY { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable]
		public bool IsSpectator { get; set; }

		[ContainerField(151), LayoutImmutable, Blittable]
		public bool Scheme1FlipY { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool QuitGameOnServerDisconnect { get; set; }

		public static void Deserialize(ClientSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LoadedTimeout = p_Reader.ReadSingle();
			p_Instance.OutgoingRate = p_Reader.ReadUInt32();
			p_Instance.LoadingTimeout = p_Reader.ReadSingle();
			p_Instance.IncomingFrequency = p_Reader.ReadSingle();
			p_Instance.IncomingRate = p_Reader.ReadUInt32();
			p_Instance.DuplicationChance = p_Reader.ReadSingle();
			p_Instance.Team = p_Reader.ReadUInt32();
			p_Instance.MaxDropDuration = p_Reader.ReadSingle();
			p_Instance.ReorderingChance = p_Reader.ReadSingle();
			p_Instance.DropSpikeChance = p_Reader.ReadSingle();
			p_Instance.MinDropDuration = p_Reader.ReadSingle();
			p_Instance.MaxIncomingLatency = p_Reader.ReadSingle();
			p_Instance.PacketDrops = p_Reader.ReadSingle();
			p_Instance.MaxLatency = p_Reader.ReadSingle();
			p_Instance.MinIncomingLatency = p_Reader.ReadSingle();
			p_Instance.CorruptionChance = p_Reader.ReadSingle();
			p_Instance.ServerIp = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ScreenshotSuffix = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SpawnPointIndex = p_Reader.ReadInt32();
			p_Instance.MinLatency = p_Reader.ReadSingle();
			p_Instance.ScreenshotFilename = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.IngameTimeout = p_Reader.ReadSingle();
			p_Instance.AimScale = p_Reader.ReadSingle();
			p_Instance.SecondaryServerIp = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SkipFastLevelLoad = p_Reader.ReadBool();
			p_Instance.ScreenshotToFile = p_Reader.ReadBool();
			p_Instance.IgnoreClientFireRateMultiplier = p_Reader.ReadBool();
			p_Instance.InputEnable = p_Reader.ReadBool();
			p_Instance.LoadMenu = p_Reader.ReadBool();
			p_Instance.PauseGameOnStartUp = p_Reader.ReadBool();
			p_Instance.DebugMenuOnLThumb = p_Reader.ReadBool();
			p_Instance.InvertPitch = p_Reader.ReadBool();
			p_Instance.OccludersEnabled = p_Reader.ReadBool();
			p_Instance.IsPresenceEnabled = p_Reader.ReadBool();
			p_Instance.InvertFreeCamera = p_Reader.ReadBool();
			p_Instance.Scheme2FlipY = p_Reader.ReadBool();
			p_Instance.InvertYaw = p_Reader.ReadBool();
			p_Instance.LipSyncEnabled = p_Reader.ReadBool();
			p_Instance.IsInternetSimulationEnabled = p_Reader.ReadBool();
			p_Instance.OnDamageSpottingEnabled = p_Reader.ReadBool();
			p_Instance.EmittersEnabled = p_Reader.ReadBool();
			p_Instance.PadRumbleEnabled = p_Reader.ReadBool();
			p_Instance.OvergrowthEnabled = p_Reader.ReadBool();
			p_Instance.EffectsEnabled = p_Reader.ReadBool();
			p_Instance.TerrainEnabled = p_Reader.ReadBool();
			p_Instance.WaterPhysicsEnabled = p_Reader.ReadBool();
			p_Instance.VegetationEnabled = p_Reader.ReadBool();
			p_Instance.WorldRenderEnabled = p_Reader.ReadBool();
			p_Instance.RenderTags = p_Reader.ReadBool();
			p_Instance.DebrisClusterEnabled = p_Reader.ReadBool();
			p_Instance.HavokVisualDebugger = p_Reader.ReadBool();
			p_Instance.HavokVDBShowsEffectsWorld = p_Reader.ReadBool();
			p_Instance.HavokCaptureToFile = p_Reader.ReadBool();
			p_Instance.UseMouseAndKeyboardSystem = p_Reader.ReadBool();
			p_Instance.UseGlobalGamePadInput = p_Reader.ReadBool();
			p_Instance.ThreadedLoadingEnable = p_Reader.ReadBool();
			p_Instance.ShowBuildId = p_Reader.ReadBool();
			p_Instance.ExtractPersistenceInformation = p_Reader.ReadBool();
			p_Instance.EnableRestTool = p_Reader.ReadBool();
			p_Instance.LocalVehicleSimulationEnabled = p_Reader.ReadBool();
			p_Instance.AsyncClientBulletEntity = p_Reader.ReadBool();
			p_Instance.AutoUnspawnDynamicObjects = p_Reader.ReadBool();
			p_Instance.VsyncEnable = p_Reader.ReadBool();
			p_Instance.VisualFrameInterpolation = p_Reader.ReadBool();
			p_Instance.InvertPadPcRightStick = p_Reader.ReadBool();
			p_Instance.Scheme0FlipY = p_Reader.ReadBool();
			p_Instance.IsSpectator = p_Reader.ReadBool();
			p_Instance.Scheme1FlipY = p_Reader.ReadBool();
			p_Instance.QuitGameOnServerDisconnect = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
