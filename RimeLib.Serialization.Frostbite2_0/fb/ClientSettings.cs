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
	[ContainerType(4, 156)]
	public partial class ClientSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _LoadedTimeout;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _OutgoingRate;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _LoadingTimeout;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _IncomingFrequency;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _IncomingRate;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _DuplicationChance;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _Team;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _MaxDropDuration;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _ReorderingChance;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _DropSpikeChance;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _MinDropDuration;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _MaxIncomingLatency;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _PacketDrops;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _MaxLatency;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _MinIncomingLatency;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _CorruptionChance;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, JsonProperty(Order = 76)]
		private string _ServerIp = string.Empty;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, JsonProperty(Order = 80)]
		private string _ScreenshotSuffix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private int _SpawnPointIndex;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _MinLatency;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, JsonProperty(Order = 92)]
		private string _ScreenshotFilename = string.Empty;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _IngameTimeout;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _AimScale;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, JsonProperty(Order = 104)]
		private string _SecondaryServerIp = string.Empty;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private bool _SkipFastLevelLoad;

		[ObservableProperty]
		[property: ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		private bool _ScreenshotToFile;

		[ObservableProperty]
		[property: ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		private bool _IgnoreClientFireRateMultiplier;

		[ObservableProperty]
		[property: ContainerField(111), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
		private bool _InputEnable;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private bool _LoadMenu;

		[ObservableProperty]
		[property: ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		private bool _PauseGameOnStartUp;

		[ObservableProperty]
		[property: ContainerField(114), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
		private bool _DebugMenuOnLThumb;

		[ObservableProperty]
		[property: ContainerField(115), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
		private bool _InvertPitch;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private bool _OccludersEnabled;

		[ObservableProperty]
		[property: ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		private bool _IsPresenceEnabled;

		[ObservableProperty]
		[property: ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		private bool _InvertFreeCamera;

		[ObservableProperty]
		[property: ContainerField(119), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
		private bool _Scheme2FlipY;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private bool _InvertYaw;

		[ObservableProperty]
		[property: ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		private bool _LipSyncEnabled;

		[ObservableProperty]
		[property: ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		private bool _IsInternetSimulationEnabled;

		[ObservableProperty]
		[property: ContainerField(123), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
		private bool _OnDamageSpottingEnabled;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _EmittersEnabled;

		[ObservableProperty]
		[property: ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		private bool _PadRumbleEnabled;

		[ObservableProperty]
		[property: ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		private bool _OvergrowthEnabled;

		[ObservableProperty]
		[property: ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		private bool _EffectsEnabled;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _TerrainEnabled;

		[ObservableProperty]
		[property: ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		private bool _WaterPhysicsEnabled;

		[ObservableProperty]
		[property: ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		private bool _VegetationEnabled;

		[ObservableProperty]
		[property: ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		private bool _WorldRenderEnabled;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private bool _RenderTags;

		[ObservableProperty]
		[property: ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		private bool _DebrisClusterEnabled;

		[ObservableProperty]
		[property: ContainerField(134), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
		private bool _HavokVisualDebugger;

		[ObservableProperty]
		[property: ContainerField(135), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
		private bool _HavokVDBShowsEffectsWorld;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private bool _HavokCaptureToFile;

		[ObservableProperty]
		[property: ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		private bool _UseMouseAndKeyboardSystem;

		[ObservableProperty]
		[property: ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		private bool _UseGlobalGamePadInput;

		[ObservableProperty]
		[property: ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		private bool _ThreadedLoadingEnable;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private bool _ShowBuildId;

		[ObservableProperty]
		[property: ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		private bool _ExtractPersistenceInformation;

		[ObservableProperty]
		[property: ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		private bool _EnableRestTool;

		[ObservableProperty]
		[property: ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		private bool _LocalVehicleSimulationEnabled;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private bool _AsyncClientBulletEntity;

		[ObservableProperty]
		[property: ContainerField(145), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
		private bool _AutoUnspawnDynamicObjects;

		[ObservableProperty]
		[property: ContainerField(146), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
		private bool _VsyncEnable;

		[ObservableProperty]
		[property: ContainerField(147), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
		private bool _VisualFrameInterpolation;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _InvertPadPcRightStick;

		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _Scheme0FlipY;

		[ObservableProperty]
		[property: ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		private bool _IsSpectator;

		[ObservableProperty]
		[property: ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		private bool _Scheme1FlipY;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _QuitGameOnServerDisconnect;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LoadedTimeout);
			p_Writer.Write(OutgoingRate);
			p_Writer.Write(LoadingTimeout);
			p_Writer.Write(IncomingFrequency);
			p_Writer.Write(IncomingRate);
			p_Writer.Write(DuplicationChance);
			p_Writer.Write(Team);
			p_Writer.Write(MaxDropDuration);
			p_Writer.Write(ReorderingChance);
			p_Writer.Write(DropSpikeChance);
			p_Writer.Write(MinDropDuration);
			p_Writer.Write(MaxIncomingLatency);
			p_Writer.Write(PacketDrops);
			p_Writer.Write(MaxLatency);
			p_Writer.Write(MinIncomingLatency);
			p_Writer.Write(CorruptionChance);
			p_Writer.Write(p_EbxWriter.WriteString(ServerIp));
			p_Writer.Write(p_EbxWriter.WriteString(ScreenshotSuffix));
			p_Writer.Write(SpawnPointIndex);
			p_Writer.Write(MinLatency);
			p_Writer.Write(p_EbxWriter.WriteString(ScreenshotFilename));
			p_Writer.Write(IngameTimeout);
			p_Writer.Write(AimScale);
			p_Writer.Write(p_EbxWriter.WriteString(SecondaryServerIp));
			p_Writer.Write(SkipFastLevelLoad);
			p_Writer.Write(ScreenshotToFile);
			p_Writer.Write(IgnoreClientFireRateMultiplier);
			p_Writer.Write(InputEnable);
			p_Writer.Write(LoadMenu);
			p_Writer.Write(PauseGameOnStartUp);
			p_Writer.Write(DebugMenuOnLThumb);
			p_Writer.Write(InvertPitch);
			p_Writer.Write(OccludersEnabled);
			p_Writer.Write(IsPresenceEnabled);
			p_Writer.Write(InvertFreeCamera);
			p_Writer.Write(Scheme2FlipY);
			p_Writer.Write(InvertYaw);
			p_Writer.Write(LipSyncEnabled);
			p_Writer.Write(IsInternetSimulationEnabled);
			p_Writer.Write(OnDamageSpottingEnabled);
			p_Writer.Write(EmittersEnabled);
			p_Writer.Write(PadRumbleEnabled);
			p_Writer.Write(OvergrowthEnabled);
			p_Writer.Write(EffectsEnabled);
			p_Writer.Write(TerrainEnabled);
			p_Writer.Write(WaterPhysicsEnabled);
			p_Writer.Write(VegetationEnabled);
			p_Writer.Write(WorldRenderEnabled);
			p_Writer.Write(RenderTags);
			p_Writer.Write(DebrisClusterEnabled);
			p_Writer.Write(HavokVisualDebugger);
			p_Writer.Write(HavokVDBShowsEffectsWorld);
			p_Writer.Write(HavokCaptureToFile);
			p_Writer.Write(UseMouseAndKeyboardSystem);
			p_Writer.Write(UseGlobalGamePadInput);
			p_Writer.Write(ThreadedLoadingEnable);
			p_Writer.Write(ShowBuildId);
			p_Writer.Write(ExtractPersistenceInformation);
			p_Writer.Write(EnableRestTool);
			p_Writer.Write(LocalVehicleSimulationEnabled);
			p_Writer.Write(AsyncClientBulletEntity);
			p_Writer.Write(AutoUnspawnDynamicObjects);
			p_Writer.Write(VsyncEnable);
			p_Writer.Write(VisualFrameInterpolation);
			p_Writer.Write(InvertPadPcRightStick);
			p_Writer.Write(Scheme0FlipY);
			p_Writer.Write(IsSpectator);
			p_Writer.Write(Scheme1FlipY);
			p_Writer.Write(QuitGameOnServerDisconnect);
			p_Writer.WriteNullBytes(3);
		}
	}
}
