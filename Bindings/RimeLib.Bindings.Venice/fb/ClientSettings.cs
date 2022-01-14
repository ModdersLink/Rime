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

namespace fb
{
	[ContainerType(4, 156)]
	public class ClientSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float LoadedTimeout { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint OutgoingRate { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float LoadingTimeout { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float IncomingFrequency { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint IncomingRate { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float DuplicationChance { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public uint Team { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float MaxDropDuration { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float ReorderingChance { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float DropSpikeChance { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float MinDropDuration { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float MaxIncomingLatency { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float PacketDrops { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float MaxLatency { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float MinIncomingLatency { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float CorruptionChance { get; set; }

		[ContainerField(76), LayoutImmutable, JsonProperty(Order = 76)]
		public string ServerIp { get; set; } = string.Empty;

		[ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		public string ScreenshotSuffix { get; set; } = string.Empty;

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public int SpawnPointIndex { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float MinLatency { get; set; }

		[ContainerField(92), LayoutImmutable, JsonProperty(Order = 92)]
		public string ScreenshotFilename { get; set; } = string.Empty;

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float IngameTimeout { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float AimScale { get; set; }

		[ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		public string SecondaryServerIp { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool SkipFastLevelLoad { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool ScreenshotToFile { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		public bool IgnoreClientFireRateMultiplier { get; set; }

		[ContainerField(111), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
		public bool InputEnable { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public bool LoadMenu { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		public bool PauseGameOnStartUp { get; set; }

		[ContainerField(114), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
		public bool DebugMenuOnLThumb { get; set; }

		[ContainerField(115), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
		public bool InvertPitch { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public bool OccludersEnabled { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		public bool IsPresenceEnabled { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		public bool InvertFreeCamera { get; set; }

		[ContainerField(119), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
		public bool Scheme2FlipY { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public bool InvertYaw { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		public bool LipSyncEnabled { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		public bool IsInternetSimulationEnabled { get; set; }

		[ContainerField(123), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
		public bool OnDamageSpottingEnabled { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public bool EmittersEnabled { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		public bool PadRumbleEnabled { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		public bool OvergrowthEnabled { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		public bool EffectsEnabled { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool TerrainEnabled { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		public bool WaterPhysicsEnabled { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		public bool VegetationEnabled { get; set; }

		[ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		public bool WorldRenderEnabled { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public bool RenderTags { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		public bool DebrisClusterEnabled { get; set; }

		[ContainerField(134), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
		public bool HavokVisualDebugger { get; set; }

		[ContainerField(135), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
		public bool HavokVDBShowsEffectsWorld { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public bool HavokCaptureToFile { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		public bool UseMouseAndKeyboardSystem { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		public bool UseGlobalGamePadInput { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		public bool ThreadedLoadingEnable { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public bool ShowBuildId { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		public bool ExtractPersistenceInformation { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		public bool EnableRestTool { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		public bool LocalVehicleSimulationEnabled { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool AsyncClientBulletEntity { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		public bool AutoUnspawnDynamicObjects { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		public bool VsyncEnable { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		public bool VisualFrameInterpolation { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool InvertPadPcRightStick { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		public bool Scheme0FlipY { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		public bool IsSpectator { get; set; }

		[ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		public bool Scheme1FlipY { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool QuitGameOnServerDisconnect { get; set; }

	}
}
