///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ClientSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LoadedTimeout { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint OutgoingRate { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float LoadingTimeout { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float IncomingFrequency { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint IncomingRate { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float DuplicationChance { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint Team { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxDropDuration { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float ReorderingChance { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float DropSpikeChance { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float MinDropDuration { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float MaxIncomingLatency { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float PacketDrops { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float MaxLatency { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float MinIncomingLatency { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float CorruptionChance { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable]
		public string ServerIp { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable]
		public string ScreenshotSuffix { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public int SpawnPointIndex { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float MinLatency { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable]
		public string ScreenshotFilename { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float IngameTimeout { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float AimScale { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable]
		public string SecondaryServerIp { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool SkipFastLevelLoad { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool ScreenshotToFile { get; set; } // 0x6D (109)
		
		[ContainerField(110), LayoutImmutable, Blittable]
		public bool IgnoreClientFireRateMultiplier { get; set; } // 0x6E (110)
		
		[ContainerField(111), LayoutImmutable, Blittable]
		public bool InputEnable { get; set; } // 0x6F (111)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool LoadMenu { get; set; } // 0x70 (112)
		
		[ContainerField(113), LayoutImmutable, Blittable]
		public bool PauseGameOnStartUp { get; set; } // 0x71 (113)
		
		[ContainerField(114), LayoutImmutable, Blittable]
		public bool DebugMenuOnLThumb { get; set; } // 0x72 (114)
		
		[ContainerField(115), LayoutImmutable, Blittable]
		public bool InvertPitch { get; set; } // 0x73 (115)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool OccludersEnabled { get; set; } // 0x74 (116)
		
		[ContainerField(117), LayoutImmutable, Blittable]
		public bool IsPresenceEnabled { get; set; } // 0x75 (117)
		
		[ContainerField(118), LayoutImmutable, Blittable]
		public bool InvertFreeCamera { get; set; } // 0x76 (118)
		
		[ContainerField(119), LayoutImmutable, Blittable]
		public bool Scheme2FlipY { get; set; } // 0x77 (119)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public bool InvertYaw { get; set; } // 0x78 (120)
		
		[ContainerField(121), LayoutImmutable, Blittable]
		public bool LipSyncEnabled { get; set; } // 0x79 (121)
		
		[ContainerField(122), LayoutImmutable, Blittable]
		public bool IsInternetSimulationEnabled { get; set; } // 0x7A (122)
		
		[ContainerField(123), LayoutImmutable, Blittable]
		public bool OnDamageSpottingEnabled { get; set; } // 0x7B (123)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool EmittersEnabled { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool PadRumbleEnabled { get; set; } // 0x7D (125)
		
		[ContainerField(126), LayoutImmutable, Blittable]
		public bool OvergrowthEnabled { get; set; } // 0x7E (126)
		
		[ContainerField(127), LayoutImmutable, Blittable]
		public bool EffectsEnabled { get; set; } // 0x7F (127)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool TerrainEnabled { get; set; } // 0x80 (128)
		
		[ContainerField(129), LayoutImmutable, Blittable]
		public bool WaterPhysicsEnabled { get; set; } // 0x81 (129)
		
		[ContainerField(130), LayoutImmutable, Blittable]
		public bool VegetationEnabled { get; set; } // 0x82 (130)
		
		[ContainerField(131), LayoutImmutable, Blittable]
		public bool WorldRenderEnabled { get; set; } // 0x83 (131)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public bool RenderTags { get; set; } // 0x84 (132)
		
		[ContainerField(133), LayoutImmutable, Blittable]
		public bool DebrisClusterEnabled { get; set; } // 0x85 (133)
		
		[ContainerField(134), LayoutImmutable, Blittable]
		public bool HavokVisualDebugger { get; set; } // 0x86 (134)
		
		[ContainerField(135), LayoutImmutable, Blittable]
		public bool HavokVDBShowsEffectsWorld { get; set; } // 0x87 (135)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public bool HavokCaptureToFile { get; set; } // 0x88 (136)
		
		[ContainerField(137), LayoutImmutable, Blittable]
		public bool UseMouseAndKeyboardSystem { get; set; } // 0x89 (137)
		
		[ContainerField(138), LayoutImmutable, Blittable]
		public bool UseGlobalGamePadInput { get; set; } // 0x8A (138)
		
		[ContainerField(139), LayoutImmutable, Blittable]
		public bool ThreadedLoadingEnable { get; set; } // 0x8B (139)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool ShowBuildId { get; set; } // 0x8C (140)
		
		[ContainerField(141), LayoutImmutable, Blittable]
		public bool ExtractPersistenceInformation { get; set; } // 0x8D (141)
		
		[ContainerField(142), LayoutImmutable, Blittable]
		public bool EnableRestTool { get; set; } // 0x8E (142)
		
		[ContainerField(143), LayoutImmutable, Blittable]
		public bool LocalVehicleSimulationEnabled { get; set; } // 0x8F (143)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool AsyncClientBulletEntity { get; set; } // 0x90 (144)
		
		[ContainerField(145), LayoutImmutable, Blittable]
		public bool AutoUnspawnDynamicObjects { get; set; } // 0x91 (145)
		
		[ContainerField(146), LayoutImmutable, Blittable]
		public bool VsyncEnable { get; set; } // 0x92 (146)
		
		[ContainerField(147), LayoutImmutable, Blittable]
		public bool VisualFrameInterpolation { get; set; } // 0x93 (147)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool InvertPadPcRightStick { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool Scheme0FlipY { get; set; } // 0x95 (149)
		
		[ContainerField(150), LayoutImmutable, Blittable]
		public bool IsSpectator { get; set; } // 0x96 (150)
		
		[ContainerField(151), LayoutImmutable, Blittable]
		public bool Scheme1FlipY { get; set; } // 0x97 (151)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool QuitGameOnServerDisconnect { get; set; } // 0x98 (152)
		
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
