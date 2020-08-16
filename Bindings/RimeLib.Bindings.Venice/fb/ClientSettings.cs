///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class ClientSettings : 
		SystemSettings
	{
		protected float m_LoadedTimeout = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(1689787417)]
		public float LoadedTimeout { get { return m_LoadedTimeout; } set { if (OnPropertyChanging("ClientSettings." + nameof(LoadedTimeout), this, m_LoadedTimeout, value)) m_LoadedTimeout = value; } } // 0xC (12)
		
		protected uint m_OutgoingRate = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3079887233)]
		public uint OutgoingRate { get { return m_OutgoingRate; } set { if (OnPropertyChanging("ClientSettings." + nameof(OutgoingRate), this, m_OutgoingRate, value)) m_OutgoingRate = value; } } // 0x10 (16)
		
		protected float m_LoadingTimeout = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1203409176)]
		public float LoadingTimeout { get { return m_LoadingTimeout; } set { if (OnPropertyChanging("ClientSettings." + nameof(LoadingTimeout), this, m_LoadingTimeout, value)) m_LoadingTimeout = value; } } // 0x14 (20)
		
		protected float m_IncomingFrequency = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1185543623)]
		public float IncomingFrequency { get { return m_IncomingFrequency; } set { if (OnPropertyChanging("ClientSettings." + nameof(IncomingFrequency), this, m_IncomingFrequency, value)) m_IncomingFrequency = value; } } // 0x18 (24)
		
		protected uint m_IncomingRate = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(2958796769)]
		public uint IncomingRate { get { return m_IncomingRate; } set { if (OnPropertyChanging("ClientSettings." + nameof(IncomingRate), this, m_IncomingRate, value)) m_IncomingRate = value; } } // 0x1C (28)
		
		protected float m_DuplicationChance = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(4025157277)]
		public float DuplicationChance { get { return m_DuplicationChance; } set { if (OnPropertyChanging("ClientSettings." + nameof(DuplicationChance), this, m_DuplicationChance, value)) m_DuplicationChance = value; } } // 0x20 (32)
		
		protected uint m_Team = new uint();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(2089309528)]
		public uint Team { get { return m_Team; } set { if (OnPropertyChanging("ClientSettings." + nameof(Team), this, m_Team, value)) m_Team = value; } } // 0x24 (36)
		
		protected float m_MaxDropDuration = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(3255041222)]
		public float MaxDropDuration { get { return m_MaxDropDuration; } set { if (OnPropertyChanging("ClientSettings." + nameof(MaxDropDuration), this, m_MaxDropDuration, value)) m_MaxDropDuration = value; } } // 0x28 (40)
		
		protected float m_ReorderingChance = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(3536539614)]
		public float ReorderingChance { get { return m_ReorderingChance; } set { if (OnPropertyChanging("ClientSettings." + nameof(ReorderingChance), this, m_ReorderingChance, value)) m_ReorderingChance = value; } } // 0x2C (44)
		
		protected float m_DropSpikeChance = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(2554650602)]
		public float DropSpikeChance { get { return m_DropSpikeChance; } set { if (OnPropertyChanging("ClientSettings." + nameof(DropSpikeChance), this, m_DropSpikeChance, value)) m_DropSpikeChance = value; } } // 0x30 (48)
		
		protected float m_MinDropDuration = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(32856408)]
		public float MinDropDuration { get { return m_MinDropDuration; } set { if (OnPropertyChanging("ClientSettings." + nameof(MinDropDuration), this, m_MinDropDuration, value)) m_MinDropDuration = value; } } // 0x34 (52)
		
		protected float m_MaxIncomingLatency = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(762506527)]
		public float MaxIncomingLatency { get { return m_MaxIncomingLatency; } set { if (OnPropertyChanging("ClientSettings." + nameof(MaxIncomingLatency), this, m_MaxIncomingLatency, value)) m_MaxIncomingLatency = value; } } // 0x38 (56)
		
		protected float m_PacketDrops = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(2325561751)]
		public float PacketDrops { get { return m_PacketDrops; } set { if (OnPropertyChanging("ClientSettings." + nameof(PacketDrops), this, m_PacketDrops, value)) m_PacketDrops = value; } } // 0x3C (60)
		
		protected float m_MaxLatency = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(92818329)]
		public float MaxLatency { get { return m_MaxLatency; } set { if (OnPropertyChanging("ClientSettings." + nameof(MaxLatency), this, m_MaxLatency, value)) m_MaxLatency = value; } } // 0x40 (64)
		
		protected float m_MinIncomingLatency = new float();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(886818113)]
		public float MinIncomingLatency { get { return m_MinIncomingLatency; } set { if (OnPropertyChanging("ClientSettings." + nameof(MinIncomingLatency), this, m_MinIncomingLatency, value)) m_MinIncomingLatency = value; } } // 0x44 (68)
		
		protected float m_CorruptionChance = new float();
		[ContainerField(72), LayoutImmutable, Blittable, ContainerFieldNameHash(2028383634)]
		public float CorruptionChance { get { return m_CorruptionChance; } set { if (OnPropertyChanging("ClientSettings." + nameof(CorruptionChance), this, m_CorruptionChance, value)) m_CorruptionChance = value; } } // 0x48 (72)
		
		protected string m_ServerIp = string.Empty;
		[ContainerField(76), LayoutImmutable, ContainerFieldNameHash(269843833)]
		public string ServerIp { get { return m_ServerIp; } set { if (OnPropertyChanging("ClientSettings." + nameof(ServerIp), this, m_ServerIp, value)) m_ServerIp = value; } } // 0x4C (76)
		
		protected string m_ScreenshotSuffix = string.Empty;
		[ContainerField(80), LayoutImmutable, ContainerFieldNameHash(2399091550)]
		public string ScreenshotSuffix { get { return m_ScreenshotSuffix; } set { if (OnPropertyChanging("ClientSettings." + nameof(ScreenshotSuffix), this, m_ScreenshotSuffix, value)) m_ScreenshotSuffix = value; } } // 0x50 (80)
		
		protected int m_SpawnPointIndex = new int();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(2235435532)]
		public int SpawnPointIndex { get { return m_SpawnPointIndex; } set { if (OnPropertyChanging("ClientSettings." + nameof(SpawnPointIndex), this, m_SpawnPointIndex, value)) m_SpawnPointIndex = value; } } // 0x54 (84)
		
		protected float m_MinLatency = new float();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(715003463)]
		public float MinLatency { get { return m_MinLatency; } set { if (OnPropertyChanging("ClientSettings." + nameof(MinLatency), this, m_MinLatency, value)) m_MinLatency = value; } } // 0x58 (88)
		
		protected string m_ScreenshotFilename = string.Empty;
		[ContainerField(92), LayoutImmutable, ContainerFieldNameHash(3330296424)]
		public string ScreenshotFilename { get { return m_ScreenshotFilename; } set { if (OnPropertyChanging("ClientSettings." + nameof(ScreenshotFilename), this, m_ScreenshotFilename, value)) m_ScreenshotFilename = value; } } // 0x5C (92)
		
		protected float m_IngameTimeout = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(178921847)]
		public float IngameTimeout { get { return m_IngameTimeout; } set { if (OnPropertyChanging("ClientSettings." + nameof(IngameTimeout), this, m_IngameTimeout, value)) m_IngameTimeout = value; } } // 0x60 (96)
		
		protected float m_AimScale = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(2680888952)]
		public float AimScale { get { return m_AimScale; } set { if (OnPropertyChanging("ClientSettings." + nameof(AimScale), this, m_AimScale, value)) m_AimScale = value; } } // 0x64 (100)
		
		protected string m_SecondaryServerIp = string.Empty;
		[ContainerField(104), LayoutImmutable, ContainerFieldNameHash(3819727747)]
		public string SecondaryServerIp { get { return m_SecondaryServerIp; } set { if (OnPropertyChanging("ClientSettings." + nameof(SecondaryServerIp), this, m_SecondaryServerIp, value)) m_SecondaryServerIp = value; } } // 0x68 (104)
		
		protected bool m_SkipFastLevelLoad = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(531296308)]
		public bool SkipFastLevelLoad { get { return m_SkipFastLevelLoad; } set { if (OnPropertyChanging("ClientSettings." + nameof(SkipFastLevelLoad), this, m_SkipFastLevelLoad, value)) m_SkipFastLevelLoad = value; } } // 0x6C (108)
		
		protected bool m_ScreenshotToFile = new bool();
		[ContainerField(109), LayoutImmutable, Blittable, ContainerFieldNameHash(2288081012)]
		public bool ScreenshotToFile { get { return m_ScreenshotToFile; } set { if (OnPropertyChanging("ClientSettings." + nameof(ScreenshotToFile), this, m_ScreenshotToFile, value)) m_ScreenshotToFile = value; } } // 0x6D (109)
		
		protected bool m_IgnoreClientFireRateMultiplier = new bool();
		[ContainerField(110), LayoutImmutable, Blittable, ContainerFieldNameHash(3144762037)]
		public bool IgnoreClientFireRateMultiplier { get { return m_IgnoreClientFireRateMultiplier; } set { if (OnPropertyChanging("ClientSettings." + nameof(IgnoreClientFireRateMultiplier), this, m_IgnoreClientFireRateMultiplier, value)) m_IgnoreClientFireRateMultiplier = value; } } // 0x6E (110)
		
		protected bool m_InputEnable = new bool();
		[ContainerField(111), LayoutImmutable, Blittable, ContainerFieldNameHash(1570773874)]
		public bool InputEnable { get { return m_InputEnable; } set { if (OnPropertyChanging("ClientSettings." + nameof(InputEnable), this, m_InputEnable, value)) m_InputEnable = value; } } // 0x6F (111)
		
		protected bool m_LoadMenu = new bool();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(2201383312)]
		public bool LoadMenu { get { return m_LoadMenu; } set { if (OnPropertyChanging("ClientSettings." + nameof(LoadMenu), this, m_LoadMenu, value)) m_LoadMenu = value; } } // 0x70 (112)
		
		protected bool m_PauseGameOnStartUp = new bool();
		[ContainerField(113), LayoutImmutable, Blittable, ContainerFieldNameHash(1660343261)]
		public bool PauseGameOnStartUp { get { return m_PauseGameOnStartUp; } set { if (OnPropertyChanging("ClientSettings." + nameof(PauseGameOnStartUp), this, m_PauseGameOnStartUp, value)) m_PauseGameOnStartUp = value; } } // 0x71 (113)
		
		protected bool m_DebugMenuOnLThumb = new bool();
		[ContainerField(114), LayoutImmutable, Blittable, ContainerFieldNameHash(3134005900)]
		public bool DebugMenuOnLThumb { get { return m_DebugMenuOnLThumb; } set { if (OnPropertyChanging("ClientSettings." + nameof(DebugMenuOnLThumb), this, m_DebugMenuOnLThumb, value)) m_DebugMenuOnLThumb = value; } } // 0x72 (114)
		
		protected bool m_InvertPitch = new bool();
		[ContainerField(115), LayoutImmutable, Blittable, ContainerFieldNameHash(3593098353)]
		public bool InvertPitch { get { return m_InvertPitch; } set { if (OnPropertyChanging("ClientSettings." + nameof(InvertPitch), this, m_InvertPitch, value)) m_InvertPitch = value; } } // 0x73 (115)
		
		protected bool m_OccludersEnabled = new bool();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(109794326)]
		public bool OccludersEnabled { get { return m_OccludersEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(OccludersEnabled), this, m_OccludersEnabled, value)) m_OccludersEnabled = value; } } // 0x74 (116)
		
		protected bool m_IsPresenceEnabled = new bool();
		[ContainerField(117), LayoutImmutable, Blittable, ContainerFieldNameHash(343956131)]
		public bool IsPresenceEnabled { get { return m_IsPresenceEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(IsPresenceEnabled), this, m_IsPresenceEnabled, value)) m_IsPresenceEnabled = value; } } // 0x75 (117)
		
		protected bool m_InvertFreeCamera = new bool();
		[ContainerField(118), LayoutImmutable, Blittable, ContainerFieldNameHash(962025594)]
		public bool InvertFreeCamera { get { return m_InvertFreeCamera; } set { if (OnPropertyChanging("ClientSettings." + nameof(InvertFreeCamera), this, m_InvertFreeCamera, value)) m_InvertFreeCamera = value; } } // 0x76 (118)
		
		protected bool m_Scheme2FlipY = new bool();
		[ContainerField(119), LayoutImmutable, Blittable, ContainerFieldNameHash(79057320)]
		public bool Scheme2FlipY { get { return m_Scheme2FlipY; } set { if (OnPropertyChanging("ClientSettings." + nameof(Scheme2FlipY), this, m_Scheme2FlipY, value)) m_Scheme2FlipY = value; } } // 0x77 (119)
		
		protected bool m_InvertYaw = new bool();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(1935838488)]
		public bool InvertYaw { get { return m_InvertYaw; } set { if (OnPropertyChanging("ClientSettings." + nameof(InvertYaw), this, m_InvertYaw, value)) m_InvertYaw = value; } } // 0x78 (120)
		
		protected bool m_LipSyncEnabled = new bool();
		[ContainerField(121), LayoutImmutable, Blittable, ContainerFieldNameHash(2236175698)]
		public bool LipSyncEnabled { get { return m_LipSyncEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(LipSyncEnabled), this, m_LipSyncEnabled, value)) m_LipSyncEnabled = value; } } // 0x79 (121)
		
		protected bool m_IsInternetSimulationEnabled = new bool();
		[ContainerField(122), LayoutImmutable, Blittable, ContainerFieldNameHash(1270028082)]
		public bool IsInternetSimulationEnabled { get { return m_IsInternetSimulationEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(IsInternetSimulationEnabled), this, m_IsInternetSimulationEnabled, value)) m_IsInternetSimulationEnabled = value; } } // 0x7A (122)
		
		protected bool m_OnDamageSpottingEnabled = new bool();
		[ContainerField(123), LayoutImmutable, Blittable, ContainerFieldNameHash(2052923782)]
		public bool OnDamageSpottingEnabled { get { return m_OnDamageSpottingEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(OnDamageSpottingEnabled), this, m_OnDamageSpottingEnabled, value)) m_OnDamageSpottingEnabled = value; } } // 0x7B (123)
		
		protected bool m_EmittersEnabled = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(4002372997)]
		public bool EmittersEnabled { get { return m_EmittersEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(EmittersEnabled), this, m_EmittersEnabled, value)) m_EmittersEnabled = value; } } // 0x7C (124)
		
		protected bool m_PadRumbleEnabled = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, ContainerFieldNameHash(166005908)]
		public bool PadRumbleEnabled { get { return m_PadRumbleEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(PadRumbleEnabled), this, m_PadRumbleEnabled, value)) m_PadRumbleEnabled = value; } } // 0x7D (125)
		
		protected bool m_OvergrowthEnabled = new bool();
		[ContainerField(126), LayoutImmutable, Blittable, ContainerFieldNameHash(686776479)]
		public bool OvergrowthEnabled { get { return m_OvergrowthEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(OvergrowthEnabled), this, m_OvergrowthEnabled, value)) m_OvergrowthEnabled = value; } } // 0x7E (126)
		
		protected bool m_EffectsEnabled = new bool();
		[ContainerField(127), LayoutImmutable, Blittable, ContainerFieldNameHash(1039031940)]
		public bool EffectsEnabled { get { return m_EffectsEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(EffectsEnabled), this, m_EffectsEnabled, value)) m_EffectsEnabled = value; } } // 0x7F (127)
		
		protected bool m_TerrainEnabled = new bool();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(3348002903)]
		public bool TerrainEnabled { get { return m_TerrainEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(TerrainEnabled), this, m_TerrainEnabled, value)) m_TerrainEnabled = value; } } // 0x80 (128)
		
		protected bool m_WaterPhysicsEnabled = new bool();
		[ContainerField(129), LayoutImmutable, Blittable, ContainerFieldNameHash(4150371006)]
		public bool WaterPhysicsEnabled { get { return m_WaterPhysicsEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(WaterPhysicsEnabled), this, m_WaterPhysicsEnabled, value)) m_WaterPhysicsEnabled = value; } } // 0x81 (129)
		
		protected bool m_VegetationEnabled = new bool();
		[ContainerField(130), LayoutImmutable, Blittable, ContainerFieldNameHash(1260276984)]
		public bool VegetationEnabled { get { return m_VegetationEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(VegetationEnabled), this, m_VegetationEnabled, value)) m_VegetationEnabled = value; } } // 0x82 (130)
		
		protected bool m_WorldRenderEnabled = new bool();
		[ContainerField(131), LayoutImmutable, Blittable, ContainerFieldNameHash(1601841480)]
		public bool WorldRenderEnabled { get { return m_WorldRenderEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(WorldRenderEnabled), this, m_WorldRenderEnabled, value)) m_WorldRenderEnabled = value; } } // 0x83 (131)
		
		protected bool m_RenderTags = new bool();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(604878030)]
		public bool RenderTags { get { return m_RenderTags; } set { if (OnPropertyChanging("ClientSettings." + nameof(RenderTags), this, m_RenderTags, value)) m_RenderTags = value; } } // 0x84 (132)
		
		protected bool m_DebrisClusterEnabled = new bool();
		[ContainerField(133), LayoutImmutable, Blittable, ContainerFieldNameHash(3885754465)]
		public bool DebrisClusterEnabled { get { return m_DebrisClusterEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(DebrisClusterEnabled), this, m_DebrisClusterEnabled, value)) m_DebrisClusterEnabled = value; } } // 0x85 (133)
		
		protected bool m_HavokVisualDebugger = new bool();
		[ContainerField(134), LayoutImmutable, Blittable, ContainerFieldNameHash(1929453227)]
		public bool HavokVisualDebugger { get { return m_HavokVisualDebugger; } set { if (OnPropertyChanging("ClientSettings." + nameof(HavokVisualDebugger), this, m_HavokVisualDebugger, value)) m_HavokVisualDebugger = value; } } // 0x86 (134)
		
		protected bool m_HavokVDBShowsEffectsWorld = new bool();
		[ContainerField(135), LayoutImmutable, Blittable, ContainerFieldNameHash(2962925720)]
		public bool HavokVDBShowsEffectsWorld { get { return m_HavokVDBShowsEffectsWorld; } set { if (OnPropertyChanging("ClientSettings." + nameof(HavokVDBShowsEffectsWorld), this, m_HavokVDBShowsEffectsWorld, value)) m_HavokVDBShowsEffectsWorld = value; } } // 0x87 (135)
		
		protected bool m_HavokCaptureToFile = new bool();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(199879943)]
		public bool HavokCaptureToFile { get { return m_HavokCaptureToFile; } set { if (OnPropertyChanging("ClientSettings." + nameof(HavokCaptureToFile), this, m_HavokCaptureToFile, value)) m_HavokCaptureToFile = value; } } // 0x88 (136)
		
		protected bool m_UseMouseAndKeyboardSystem = new bool();
		[ContainerField(137), LayoutImmutable, Blittable, ContainerFieldNameHash(1086358628)]
		public bool UseMouseAndKeyboardSystem { get { return m_UseMouseAndKeyboardSystem; } set { if (OnPropertyChanging("ClientSettings." + nameof(UseMouseAndKeyboardSystem), this, m_UseMouseAndKeyboardSystem, value)) m_UseMouseAndKeyboardSystem = value; } } // 0x89 (137)
		
		protected bool m_UseGlobalGamePadInput = new bool();
		[ContainerField(138), LayoutImmutable, Blittable, ContainerFieldNameHash(2939773824)]
		public bool UseGlobalGamePadInput { get { return m_UseGlobalGamePadInput; } set { if (OnPropertyChanging("ClientSettings." + nameof(UseGlobalGamePadInput), this, m_UseGlobalGamePadInput, value)) m_UseGlobalGamePadInput = value; } } // 0x8A (138)
		
		protected bool m_ThreadedLoadingEnable = new bool();
		[ContainerField(139), LayoutImmutable, Blittable, ContainerFieldNameHash(1104410157)]
		public bool ThreadedLoadingEnable { get { return m_ThreadedLoadingEnable; } set { if (OnPropertyChanging("ClientSettings." + nameof(ThreadedLoadingEnable), this, m_ThreadedLoadingEnable, value)) m_ThreadedLoadingEnable = value; } } // 0x8B (139)
		
		protected bool m_ShowBuildId = new bool();
		[ContainerField(140), LayoutImmutable, Blittable, ContainerFieldNameHash(3678869853)]
		public bool ShowBuildId { get { return m_ShowBuildId; } set { if (OnPropertyChanging("ClientSettings." + nameof(ShowBuildId), this, m_ShowBuildId, value)) m_ShowBuildId = value; } } // 0x8C (140)
		
		protected bool m_ExtractPersistenceInformation = new bool();
		[ContainerField(141), LayoutImmutable, Blittable, ContainerFieldNameHash(2413057907)]
		public bool ExtractPersistenceInformation { get { return m_ExtractPersistenceInformation; } set { if (OnPropertyChanging("ClientSettings." + nameof(ExtractPersistenceInformation), this, m_ExtractPersistenceInformation, value)) m_ExtractPersistenceInformation = value; } } // 0x8D (141)
		
		protected bool m_EnableRestTool = new bool();
		[ContainerField(142), LayoutImmutable, Blittable, ContainerFieldNameHash(1964416300)]
		public bool EnableRestTool { get { return m_EnableRestTool; } set { if (OnPropertyChanging("ClientSettings." + nameof(EnableRestTool), this, m_EnableRestTool, value)) m_EnableRestTool = value; } } // 0x8E (142)
		
		protected bool m_LocalVehicleSimulationEnabled = new bool();
		[ContainerField(143), LayoutImmutable, Blittable, ContainerFieldNameHash(1639847270)]
		public bool LocalVehicleSimulationEnabled { get { return m_LocalVehicleSimulationEnabled; } set { if (OnPropertyChanging("ClientSettings." + nameof(LocalVehicleSimulationEnabled), this, m_LocalVehicleSimulationEnabled, value)) m_LocalVehicleSimulationEnabled = value; } } // 0x8F (143)
		
		protected bool m_AsyncClientBulletEntity = new bool();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(2407735079)]
		public bool AsyncClientBulletEntity { get { return m_AsyncClientBulletEntity; } set { if (OnPropertyChanging("ClientSettings." + nameof(AsyncClientBulletEntity), this, m_AsyncClientBulletEntity, value)) m_AsyncClientBulletEntity = value; } } // 0x90 (144)
		
		protected bool m_AutoUnspawnDynamicObjects = new bool();
		[ContainerField(145), LayoutImmutable, Blittable, ContainerFieldNameHash(854342937)]
		public bool AutoUnspawnDynamicObjects { get { return m_AutoUnspawnDynamicObjects; } set { if (OnPropertyChanging("ClientSettings." + nameof(AutoUnspawnDynamicObjects), this, m_AutoUnspawnDynamicObjects, value)) m_AutoUnspawnDynamicObjects = value; } } // 0x91 (145)
		
		protected bool m_VsyncEnable = new bool();
		[ContainerField(146), LayoutImmutable, Blittable, ContainerFieldNameHash(26434229)]
		public bool VsyncEnable { get { return m_VsyncEnable; } set { if (OnPropertyChanging("ClientSettings." + nameof(VsyncEnable), this, m_VsyncEnable, value)) m_VsyncEnable = value; } } // 0x92 (146)
		
		protected bool m_VisualFrameInterpolation = new bool();
		[ContainerField(147), LayoutImmutable, Blittable, ContainerFieldNameHash(400957222)]
		public bool VisualFrameInterpolation { get { return m_VisualFrameInterpolation; } set { if (OnPropertyChanging("ClientSettings." + nameof(VisualFrameInterpolation), this, m_VisualFrameInterpolation, value)) m_VisualFrameInterpolation = value; } } // 0x93 (147)
		
		protected bool m_InvertPadPcRightStick = new bool();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(2944881719)]
		public bool InvertPadPcRightStick { get { return m_InvertPadPcRightStick; } set { if (OnPropertyChanging("ClientSettings." + nameof(InvertPadPcRightStick), this, m_InvertPadPcRightStick, value)) m_InvertPadPcRightStick = value; } } // 0x94 (148)
		
		protected bool m_Scheme0FlipY = new bool();
		[ContainerField(149), LayoutImmutable, Blittable, ContainerFieldNameHash(157467626)]
		public bool Scheme0FlipY { get { return m_Scheme0FlipY; } set { if (OnPropertyChanging("ClientSettings." + nameof(Scheme0FlipY), this, m_Scheme0FlipY, value)) m_Scheme0FlipY = value; } } // 0x95 (149)
		
		protected bool m_IsSpectator = new bool();
		[ContainerField(150), LayoutImmutable, Blittable, ContainerFieldNameHash(1656349510)]
		public bool IsSpectator { get { return m_IsSpectator; } set { if (OnPropertyChanging("ClientSettings." + nameof(IsSpectator), this, m_IsSpectator, value)) m_IsSpectator = value; } } // 0x96 (150)
		
		protected bool m_Scheme1FlipY = new bool();
		[ContainerField(151), LayoutImmutable, Blittable, ContainerFieldNameHash(192070603)]
		public bool Scheme1FlipY { get { return m_Scheme1FlipY; } set { if (OnPropertyChanging("ClientSettings." + nameof(Scheme1FlipY), this, m_Scheme1FlipY, value)) m_Scheme1FlipY = value; } } // 0x97 (151)
		
		protected bool m_QuitGameOnServerDisconnect = new bool();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(491704118)]
		public bool QuitGameOnServerDisconnect { get { return m_QuitGameOnServerDisconnect; } set { if (OnPropertyChanging("ClientSettings." + nameof(QuitGameOnServerDisconnect), this, m_QuitGameOnServerDisconnect, value)) m_QuitGameOnServerDisconnect = value; } } // 0x98 (152)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1689787417:
					LoadedTimeout = (float) p_Value;
					break;

				case 3079887233:
					OutgoingRate = (uint) p_Value;
					break;

				case 1203409176:
					LoadingTimeout = (float) p_Value;
					break;

				case 1185543623:
					IncomingFrequency = (float) p_Value;
					break;

				case 2958796769:
					IncomingRate = (uint) p_Value;
					break;

				case 4025157277:
					DuplicationChance = (float) p_Value;
					break;

				case 2089309528:
					Team = (uint) p_Value;
					break;

				case 3255041222:
					MaxDropDuration = (float) p_Value;
					break;

				case 3536539614:
					ReorderingChance = (float) p_Value;
					break;

				case 2554650602:
					DropSpikeChance = (float) p_Value;
					break;

				case 32856408:
					MinDropDuration = (float) p_Value;
					break;

				case 762506527:
					MaxIncomingLatency = (float) p_Value;
					break;

				case 2325561751:
					PacketDrops = (float) p_Value;
					break;

				case 92818329:
					MaxLatency = (float) p_Value;
					break;

				case 886818113:
					MinIncomingLatency = (float) p_Value;
					break;

				case 2028383634:
					CorruptionChance = (float) p_Value;
					break;

				case 269843833:
					ServerIp = (string) p_Value;
					break;

				case 2399091550:
					ScreenshotSuffix = (string) p_Value;
					break;

				case 2235435532:
					SpawnPointIndex = (int) p_Value;
					break;

				case 715003463:
					MinLatency = (float) p_Value;
					break;

				case 3330296424:
					ScreenshotFilename = (string) p_Value;
					break;

				case 178921847:
					IngameTimeout = (float) p_Value;
					break;

				case 2680888952:
					AimScale = (float) p_Value;
					break;

				case 3819727747:
					SecondaryServerIp = (string) p_Value;
					break;

				case 531296308:
					SkipFastLevelLoad = (bool) p_Value;
					break;

				case 2288081012:
					ScreenshotToFile = (bool) p_Value;
					break;

				case 3144762037:
					IgnoreClientFireRateMultiplier = (bool) p_Value;
					break;

				case 1570773874:
					InputEnable = (bool) p_Value;
					break;

				case 2201383312:
					LoadMenu = (bool) p_Value;
					break;

				case 1660343261:
					PauseGameOnStartUp = (bool) p_Value;
					break;

				case 3134005900:
					DebugMenuOnLThumb = (bool) p_Value;
					break;

				case 3593098353:
					InvertPitch = (bool) p_Value;
					break;

				case 109794326:
					OccludersEnabled = (bool) p_Value;
					break;

				case 343956131:
					IsPresenceEnabled = (bool) p_Value;
					break;

				case 962025594:
					InvertFreeCamera = (bool) p_Value;
					break;

				case 79057320:
					Scheme2FlipY = (bool) p_Value;
					break;

				case 1935838488:
					InvertYaw = (bool) p_Value;
					break;

				case 2236175698:
					LipSyncEnabled = (bool) p_Value;
					break;

				case 1270028082:
					IsInternetSimulationEnabled = (bool) p_Value;
					break;

				case 2052923782:
					OnDamageSpottingEnabled = (bool) p_Value;
					break;

				case 4002372997:
					EmittersEnabled = (bool) p_Value;
					break;

				case 166005908:
					PadRumbleEnabled = (bool) p_Value;
					break;

				case 686776479:
					OvergrowthEnabled = (bool) p_Value;
					break;

				case 1039031940:
					EffectsEnabled = (bool) p_Value;
					break;

				case 3348002903:
					TerrainEnabled = (bool) p_Value;
					break;

				case 4150371006:
					WaterPhysicsEnabled = (bool) p_Value;
					break;

				case 1260276984:
					VegetationEnabled = (bool) p_Value;
					break;

				case 1601841480:
					WorldRenderEnabled = (bool) p_Value;
					break;

				case 604878030:
					RenderTags = (bool) p_Value;
					break;

				case 3885754465:
					DebrisClusterEnabled = (bool) p_Value;
					break;

				case 1929453227:
					HavokVisualDebugger = (bool) p_Value;
					break;

				case 2962925720:
					HavokVDBShowsEffectsWorld = (bool) p_Value;
					break;

				case 199879943:
					HavokCaptureToFile = (bool) p_Value;
					break;

				case 1086358628:
					UseMouseAndKeyboardSystem = (bool) p_Value;
					break;

				case 2939773824:
					UseGlobalGamePadInput = (bool) p_Value;
					break;

				case 1104410157:
					ThreadedLoadingEnable = (bool) p_Value;
					break;

				case 3678869853:
					ShowBuildId = (bool) p_Value;
					break;

				case 2413057907:
					ExtractPersistenceInformation = (bool) p_Value;
					break;

				case 1964416300:
					EnableRestTool = (bool) p_Value;
					break;

				case 1639847270:
					LocalVehicleSimulationEnabled = (bool) p_Value;
					break;

				case 2407735079:
					AsyncClientBulletEntity = (bool) p_Value;
					break;

				case 854342937:
					AutoUnspawnDynamicObjects = (bool) p_Value;
					break;

				case 26434229:
					VsyncEnable = (bool) p_Value;
					break;

				case 400957222:
					VisualFrameInterpolation = (bool) p_Value;
					break;

				case 2944881719:
					InvertPadPcRightStick = (bool) p_Value;
					break;

				case 157467626:
					Scheme0FlipY = (bool) p_Value;
					break;

				case 1656349510:
					IsSpectator = (bool) p_Value;
					break;

				case 192070603:
					Scheme1FlipY = (bool) p_Value;
					break;

				case 491704118:
					QuitGameOnServerDisconnect = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1689787417:
					return LoadedTimeout;

				case 3079887233:
					return OutgoingRate;

				case 1203409176:
					return LoadingTimeout;

				case 1185543623:
					return IncomingFrequency;

				case 2958796769:
					return IncomingRate;

				case 4025157277:
					return DuplicationChance;

				case 2089309528:
					return Team;

				case 3255041222:
					return MaxDropDuration;

				case 3536539614:
					return ReorderingChance;

				case 2554650602:
					return DropSpikeChance;

				case 32856408:
					return MinDropDuration;

				case 762506527:
					return MaxIncomingLatency;

				case 2325561751:
					return PacketDrops;

				case 92818329:
					return MaxLatency;

				case 886818113:
					return MinIncomingLatency;

				case 2028383634:
					return CorruptionChance;

				case 269843833:
					return ServerIp;

				case 2399091550:
					return ScreenshotSuffix;

				case 2235435532:
					return SpawnPointIndex;

				case 715003463:
					return MinLatency;

				case 3330296424:
					return ScreenshotFilename;

				case 178921847:
					return IngameTimeout;

				case 2680888952:
					return AimScale;

				case 3819727747:
					return SecondaryServerIp;

				case 531296308:
					return SkipFastLevelLoad;

				case 2288081012:
					return ScreenshotToFile;

				case 3144762037:
					return IgnoreClientFireRateMultiplier;

				case 1570773874:
					return InputEnable;

				case 2201383312:
					return LoadMenu;

				case 1660343261:
					return PauseGameOnStartUp;

				case 3134005900:
					return DebugMenuOnLThumb;

				case 3593098353:
					return InvertPitch;

				case 109794326:
					return OccludersEnabled;

				case 343956131:
					return IsPresenceEnabled;

				case 962025594:
					return InvertFreeCamera;

				case 79057320:
					return Scheme2FlipY;

				case 1935838488:
					return InvertYaw;

				case 2236175698:
					return LipSyncEnabled;

				case 1270028082:
					return IsInternetSimulationEnabled;

				case 2052923782:
					return OnDamageSpottingEnabled;

				case 4002372997:
					return EmittersEnabled;

				case 166005908:
					return PadRumbleEnabled;

				case 686776479:
					return OvergrowthEnabled;

				case 1039031940:
					return EffectsEnabled;

				case 3348002903:
					return TerrainEnabled;

				case 4150371006:
					return WaterPhysicsEnabled;

				case 1260276984:
					return VegetationEnabled;

				case 1601841480:
					return WorldRenderEnabled;

				case 604878030:
					return RenderTags;

				case 3885754465:
					return DebrisClusterEnabled;

				case 1929453227:
					return HavokVisualDebugger;

				case 2962925720:
					return HavokVDBShowsEffectsWorld;

				case 199879943:
					return HavokCaptureToFile;

				case 1086358628:
					return UseMouseAndKeyboardSystem;

				case 2939773824:
					return UseGlobalGamePadInput;

				case 1104410157:
					return ThreadedLoadingEnable;

				case 3678869853:
					return ShowBuildId;

				case 2413057907:
					return ExtractPersistenceInformation;

				case 1964416300:
					return EnableRestTool;

				case 1639847270:
					return LocalVehicleSimulationEnabled;

				case 2407735079:
					return AsyncClientBulletEntity;

				case 854342937:
					return AutoUnspawnDynamicObjects;

				case 26434229:
					return VsyncEnable;

				case 400957222:
					return VisualFrameInterpolation;

				case 2944881719:
					return InvertPadPcRightStick;

				case 157467626:
					return Scheme0FlipY;

				case 1656349510:
					return IsSpectator;

				case 192070603:
					return Scheme1FlipY;

				case 491704118:
					return QuitGameOnServerDisconnect;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1689787417:
					return typeof(ClientSettings).GetProperty(nameof(LoadedTimeout));

				case 3079887233:
					return typeof(ClientSettings).GetProperty(nameof(OutgoingRate));

				case 1203409176:
					return typeof(ClientSettings).GetProperty(nameof(LoadingTimeout));

				case 1185543623:
					return typeof(ClientSettings).GetProperty(nameof(IncomingFrequency));

				case 2958796769:
					return typeof(ClientSettings).GetProperty(nameof(IncomingRate));

				case 4025157277:
					return typeof(ClientSettings).GetProperty(nameof(DuplicationChance));

				case 2089309528:
					return typeof(ClientSettings).GetProperty(nameof(Team));

				case 3255041222:
					return typeof(ClientSettings).GetProperty(nameof(MaxDropDuration));

				case 3536539614:
					return typeof(ClientSettings).GetProperty(nameof(ReorderingChance));

				case 2554650602:
					return typeof(ClientSettings).GetProperty(nameof(DropSpikeChance));

				case 32856408:
					return typeof(ClientSettings).GetProperty(nameof(MinDropDuration));

				case 762506527:
					return typeof(ClientSettings).GetProperty(nameof(MaxIncomingLatency));

				case 2325561751:
					return typeof(ClientSettings).GetProperty(nameof(PacketDrops));

				case 92818329:
					return typeof(ClientSettings).GetProperty(nameof(MaxLatency));

				case 886818113:
					return typeof(ClientSettings).GetProperty(nameof(MinIncomingLatency));

				case 2028383634:
					return typeof(ClientSettings).GetProperty(nameof(CorruptionChance));

				case 269843833:
					return typeof(ClientSettings).GetProperty(nameof(ServerIp));

				case 2399091550:
					return typeof(ClientSettings).GetProperty(nameof(ScreenshotSuffix));

				case 2235435532:
					return typeof(ClientSettings).GetProperty(nameof(SpawnPointIndex));

				case 715003463:
					return typeof(ClientSettings).GetProperty(nameof(MinLatency));

				case 3330296424:
					return typeof(ClientSettings).GetProperty(nameof(ScreenshotFilename));

				case 178921847:
					return typeof(ClientSettings).GetProperty(nameof(IngameTimeout));

				case 2680888952:
					return typeof(ClientSettings).GetProperty(nameof(AimScale));

				case 3819727747:
					return typeof(ClientSettings).GetProperty(nameof(SecondaryServerIp));

				case 531296308:
					return typeof(ClientSettings).GetProperty(nameof(SkipFastLevelLoad));

				case 2288081012:
					return typeof(ClientSettings).GetProperty(nameof(ScreenshotToFile));

				case 3144762037:
					return typeof(ClientSettings).GetProperty(nameof(IgnoreClientFireRateMultiplier));

				case 1570773874:
					return typeof(ClientSettings).GetProperty(nameof(InputEnable));

				case 2201383312:
					return typeof(ClientSettings).GetProperty(nameof(LoadMenu));

				case 1660343261:
					return typeof(ClientSettings).GetProperty(nameof(PauseGameOnStartUp));

				case 3134005900:
					return typeof(ClientSettings).GetProperty(nameof(DebugMenuOnLThumb));

				case 3593098353:
					return typeof(ClientSettings).GetProperty(nameof(InvertPitch));

				case 109794326:
					return typeof(ClientSettings).GetProperty(nameof(OccludersEnabled));

				case 343956131:
					return typeof(ClientSettings).GetProperty(nameof(IsPresenceEnabled));

				case 962025594:
					return typeof(ClientSettings).GetProperty(nameof(InvertFreeCamera));

				case 79057320:
					return typeof(ClientSettings).GetProperty(nameof(Scheme2FlipY));

				case 1935838488:
					return typeof(ClientSettings).GetProperty(nameof(InvertYaw));

				case 2236175698:
					return typeof(ClientSettings).GetProperty(nameof(LipSyncEnabled));

				case 1270028082:
					return typeof(ClientSettings).GetProperty(nameof(IsInternetSimulationEnabled));

				case 2052923782:
					return typeof(ClientSettings).GetProperty(nameof(OnDamageSpottingEnabled));

				case 4002372997:
					return typeof(ClientSettings).GetProperty(nameof(EmittersEnabled));

				case 166005908:
					return typeof(ClientSettings).GetProperty(nameof(PadRumbleEnabled));

				case 686776479:
					return typeof(ClientSettings).GetProperty(nameof(OvergrowthEnabled));

				case 1039031940:
					return typeof(ClientSettings).GetProperty(nameof(EffectsEnabled));

				case 3348002903:
					return typeof(ClientSettings).GetProperty(nameof(TerrainEnabled));

				case 4150371006:
					return typeof(ClientSettings).GetProperty(nameof(WaterPhysicsEnabled));

				case 1260276984:
					return typeof(ClientSettings).GetProperty(nameof(VegetationEnabled));

				case 1601841480:
					return typeof(ClientSettings).GetProperty(nameof(WorldRenderEnabled));

				case 604878030:
					return typeof(ClientSettings).GetProperty(nameof(RenderTags));

				case 3885754465:
					return typeof(ClientSettings).GetProperty(nameof(DebrisClusterEnabled));

				case 1929453227:
					return typeof(ClientSettings).GetProperty(nameof(HavokVisualDebugger));

				case 2962925720:
					return typeof(ClientSettings).GetProperty(nameof(HavokVDBShowsEffectsWorld));

				case 199879943:
					return typeof(ClientSettings).GetProperty(nameof(HavokCaptureToFile));

				case 1086358628:
					return typeof(ClientSettings).GetProperty(nameof(UseMouseAndKeyboardSystem));

				case 2939773824:
					return typeof(ClientSettings).GetProperty(nameof(UseGlobalGamePadInput));

				case 1104410157:
					return typeof(ClientSettings).GetProperty(nameof(ThreadedLoadingEnable));

				case 3678869853:
					return typeof(ClientSettings).GetProperty(nameof(ShowBuildId));

				case 2413057907:
					return typeof(ClientSettings).GetProperty(nameof(ExtractPersistenceInformation));

				case 1964416300:
					return typeof(ClientSettings).GetProperty(nameof(EnableRestTool));

				case 1639847270:
					return typeof(ClientSettings).GetProperty(nameof(LocalVehicleSimulationEnabled));

				case 2407735079:
					return typeof(ClientSettings).GetProperty(nameof(AsyncClientBulletEntity));

				case 854342937:
					return typeof(ClientSettings).GetProperty(nameof(AutoUnspawnDynamicObjects));

				case 26434229:
					return typeof(ClientSettings).GetProperty(nameof(VsyncEnable));

				case 400957222:
					return typeof(ClientSettings).GetProperty(nameof(VisualFrameInterpolation));

				case 2944881719:
					return typeof(ClientSettings).GetProperty(nameof(InvertPadPcRightStick));

				case 157467626:
					return typeof(ClientSettings).GetProperty(nameof(Scheme0FlipY));

				case 1656349510:
					return typeof(ClientSettings).GetProperty(nameof(IsSpectator));

				case 192070603:
					return typeof(ClientSettings).GetProperty(nameof(Scheme1FlipY));

				case 491704118:
					return typeof(ClientSettings).GetProperty(nameof(QuitGameOnServerDisconnect));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
