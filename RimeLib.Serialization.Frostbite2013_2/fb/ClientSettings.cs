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

using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 264)]
public class ClientSettings
	: fb.Core.SystemSettings
{
	public ClientSettings()
	{
		//SystemSettings
		Name = @"Client";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float JuiceDistanceThreshold { get; set; } = 18.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float JuiceTimeThreshold { get; set; } = 20.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float JuiceVehicleDistanceThreshold { get; set; } = 50.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float JuiceVehicleTimeThreshold { get; set; } = 10.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string ScreenshotFilename { get; set; } = @"screenshot";
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string ScreenshotSuffix { get; set; } = @"_SCR";
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint Team { get; set; } = 0;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public int SpawnPointIndex { get; set; } = -1;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string ServerIp { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string SecondaryServerIp { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float AimScale { get; set; } = 1.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float MouseSensitivityMin { get; set; } = 0.010f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float MouseSensitivitySliderRange { get; set; } = 0.100f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float MouseSensitivityFactor { get; set; } = 2.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float MouseSensitivityPower { get; set; } = 1.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float XenonGamepadDeadZoneCenter { get; set; } = 0.220f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float XenonGamepadDeadZoneAxis { get; set; } = 0.150f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float XenonGamepadDeadZoneOffsetAxis { get; set; } = 0.500f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float PS3GamepadDeadZoneCenter { get; set; } = 0.220f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float PS3GamepadDeadZoneAxis { get; set; } = 0.150f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float PS3GamepadDeadZoneOffsetAxis { get; set; } = 0.500f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float PCGamepadDeadZoneCenter { get; set; } = 0.220f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float PCGamepadDeadZoneAxis { get; set; } = 0.150f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float PCGamepadDeadZoneOffsetAxis { get; set; } = 0.500f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float Gen4aGamepadDeadZoneCenter { get; set; } = 0.220f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float Gen4aGamepadDeadZoneAxis { get; set; } = 0.150f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float Gen4aGamepadDeadZoneOffsetAxis { get; set; } = 0.500f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float Gen4bGamepadDeadZoneCenter { get; set; } = 0.220f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float Gen4bGamepadDeadZoneAxis { get; set; } = 0.150f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float Gen4bGamepadDeadZoneOffsetAxis { get; set; } = 0.500f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string GamepadGuid { get; set; } = string.Empty;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float IncomingFrequency { get; set; } = 10.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float IncomingHighFrequency { get; set; } = 30.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public uint IncomingRate { get; set; } = 80000;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public uint OutgoingRate { get; set; } = 30000;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public uint IncomingHighFrequencyRate { get; set; } = 100000;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float LoadingTimeout { get; set; } = 15.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float LoadedTimeout { get; set; } = 15.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float IngameTimeout { get; set; } = 15.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public bool IsSpectator { get; set; } = false;
	
	[ContainerField(0xd1), LayoutImmutable, Blittable, JsonProperty(Order = 209)]
	public bool VsyncEnable { get; set; } = false;
	
	[ContainerField(0xd2), LayoutImmutable, Blittable, JsonProperty(Order = 210)]
	public bool VisualFrameInterpolation { get; set; } = false;
	
	[ContainerField(0xd3), LayoutImmutable, Blittable, JsonProperty(Order = 211)]
	public bool DebrisClusterEnabled { get; set; } = true;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public bool VegetationEnabled { get; set; } = true;
	
	[ContainerField(0xd5), LayoutImmutable, Blittable, JsonProperty(Order = 213)]
	public bool ForceEnabled { get; set; } = true;
	
	[ContainerField(0xd6), LayoutImmutable, Blittable, JsonProperty(Order = 214)]
	public bool WorldRenderEnabled { get; set; } = true;
	
	[ContainerField(0xd7), LayoutImmutable, Blittable, JsonProperty(Order = 215)]
	public bool TerrainEnabled { get; set; } = true;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public bool WaterPhysicsEnabled { get; set; } = true;
	
	[ContainerField(0xd9), LayoutImmutable, Blittable, JsonProperty(Order = 217)]
	public bool OvergrowthEnabled { get; set; } = true;
	
	[ContainerField(0xda), LayoutImmutable, Blittable, JsonProperty(Order = 218)]
	public bool EffectsEnabled { get; set; } = true;
	
	[ContainerField(0xdb), LayoutImmutable, Blittable, JsonProperty(Order = 219)]
	public bool EmittersEnabled { get; set; } = true;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public bool PadRumbleEnabled { get; set; } = true;
	
	[ContainerField(0xdd), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
	public bool JuicePlayerReportPositionEnabled { get; set; } = false;
	
	[ContainerField(0xde), LayoutImmutable, Blittable, JsonProperty(Order = 222)]
	public bool LipSyncEnabled { get; set; } = true;
	
	[ContainerField(0xdf), LayoutImmutable, Blittable, JsonProperty(Order = 223)]
	public bool OnDamageSpottingEnabled { get; set; } = true;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public bool IgnoreClientFireRateMultiplier { get; set; } = false;
	
	[ContainerField(0xe1), LayoutImmutable, Blittable, JsonProperty(Order = 225)]
	public bool PauseGameOnStartUp { get; set; } = false;
	
	[ContainerField(0xe2), LayoutImmutable, Blittable, JsonProperty(Order = 226)]
	public bool SkipFirstFastLevelLoad { get; set; } = false;
	
	[ContainerField(0xe3), LayoutImmutable, Blittable, JsonProperty(Order = 227)]
	public bool SkipFastLevelLoad { get; set; } = false;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public bool InputEnable { get; set; } = true;
	
	[ContainerField(0xe5), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
	public bool ScreenshotToFile { get; set; } = false;
	
	[ContainerField(0xe6), LayoutImmutable, Blittable, JsonProperty(Order = 230)]
	public bool LoadMenu { get; set; } = true;
	
	[ContainerField(0xe7), LayoutImmutable, Blittable, JsonProperty(Order = 231)]
	public bool DebugMenuOnLThumb { get; set; } = false;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public bool InvertFreeCamera { get; set; } = false;
	
	[ContainerField(0xe9), LayoutImmutable, Blittable, JsonProperty(Order = 233)]
	public bool RenderTags { get; set; } = false;
	
	[ContainerField(0xea), LayoutImmutable, Blittable, JsonProperty(Order = 234)]
	public bool InvertPitch { get; set; } = false;
	
	[ContainerField(0xeb), LayoutImmutable, Blittable, JsonProperty(Order = 235)]
	public bool InvertPadPcRightStick { get; set; } = false;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public bool Scheme0FlipY { get; set; } = false;
	
	[ContainerField(0xed), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
	public bool Scheme1FlipY { get; set; } = false;
	
	[ContainerField(0xee), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
	public bool Scheme2FlipY { get; set; } = false;
	
	[ContainerField(0xef), LayoutImmutable, Blittable, JsonProperty(Order = 239)]
	public bool InvertYaw { get; set; } = false;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public bool ConsoleInputEmulation { get; set; } = false;
	
	[ContainerField(0xf1), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
	public bool SampleInputEveryVisualFrame { get; set; } = false;
	
	[ContainerField(0xf2), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
	public bool HavokVisualDebugger { get; set; } = false;
	
	[ContainerField(0xf3), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
	public bool HavokVDBShowsEffectsWorld { get; set; } = false;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public bool HavokCaptureToFile { get; set; } = false;
	
	[ContainerField(0xf5), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
	public bool UseMouseAndKeyboardSystem { get; set; } = true;
	
	[ContainerField(0xf6), LayoutImmutable, Blittable, JsonProperty(Order = 246)]
	public bool UseGlobalGamePadInput { get; set; } = true;
	
	[ContainerField(0xf7), LayoutImmutable, Blittable, JsonProperty(Order = 247)]
	public bool ShowBuildId { get; set; } = false;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public bool ExtractPersistenceInformation { get; set; } = false;
	
	[ContainerField(0xf9), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
	public bool EnableRestTool { get; set; } = false;
	
	[ContainerField(0xfa), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
	public bool LocalVehicleSimulationEnabled { get; set; } = true;
	
	[ContainerField(0xfb), LayoutImmutable, Blittable, JsonProperty(Order = 251)]
	public bool AsyncClientBulletEntity { get; set; } = true;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public bool AutoUnspawnDynamicObjects { get; set; } = true;
	
	[ContainerField(0xfd), LayoutImmutable, Blittable, JsonProperty(Order = 253)]
	public bool QuitGameOnServerDisconnect { get; set; } = false;
	
	[ContainerField(0xfe), LayoutImmutable, Blittable, JsonProperty(Order = 254)]
	public bool DebugTrackAllPlayersInSpawnScreen { get; set; } = false;
	
	[ContainerField(0xff), LayoutImmutable, Blittable, JsonProperty(Order = 255)]
	public bool UseOldKillerCamera { get; set; } = false;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public bool LuaOptionSetEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(JuiceDistanceThreshold);
		p_Writer.Write(JuiceTimeThreshold);
		p_Writer.Write(JuiceVehicleDistanceThreshold);
		p_Writer.Write(JuiceVehicleTimeThreshold);
		p_Writer.Write(p_EbxWriter.WriteString(ScreenshotFilename));
		p_Writer.Write(p_EbxWriter.WriteString(ScreenshotSuffix));
		p_Writer.Write(Team);
		p_Writer.Write(SpawnPointIndex);
		p_Writer.Write(p_EbxWriter.WriteString(ServerIp));
		p_Writer.Write(p_EbxWriter.WriteString(SecondaryServerIp));
		p_Writer.Write(AimScale);
		p_Writer.Write(MouseSensitivityMin);
		p_Writer.Write(MouseSensitivitySliderRange);
		p_Writer.Write(MouseSensitivityFactor);
		p_Writer.Write(MouseSensitivityPower);
		p_Writer.Write(XenonGamepadDeadZoneCenter);
		p_Writer.Write(XenonGamepadDeadZoneAxis);
		p_Writer.Write(XenonGamepadDeadZoneOffsetAxis);
		p_Writer.Write(PS3GamepadDeadZoneCenter);
		p_Writer.Write(PS3GamepadDeadZoneAxis);
		p_Writer.Write(PS3GamepadDeadZoneOffsetAxis);
		p_Writer.Write(PCGamepadDeadZoneCenter);
		p_Writer.Write(PCGamepadDeadZoneAxis);
		p_Writer.Write(PCGamepadDeadZoneOffsetAxis);
		p_Writer.Write(Gen4aGamepadDeadZoneCenter);
		p_Writer.Write(Gen4aGamepadDeadZoneAxis);
		p_Writer.Write(Gen4aGamepadDeadZoneOffsetAxis);
		p_Writer.Write(Gen4bGamepadDeadZoneCenter);
		p_Writer.Write(Gen4bGamepadDeadZoneAxis);
		p_Writer.Write(Gen4bGamepadDeadZoneOffsetAxis);
		p_Writer.Write(p_EbxWriter.WriteString(GamepadGuid));
		p_Writer.Write(IncomingFrequency);
		p_Writer.Write(IncomingHighFrequency);
		p_Writer.Write(IncomingRate);
		p_Writer.Write(OutgoingRate);
		p_Writer.Write(IncomingHighFrequencyRate);
		p_Writer.Write(LoadingTimeout);
		p_Writer.Write(LoadedTimeout);
		p_Writer.Write(IngameTimeout);
		p_Writer.Write(IsSpectator);
		p_Writer.Write(VsyncEnable);
		p_Writer.Write(VisualFrameInterpolation);
		p_Writer.Write(DebrisClusterEnabled);
		p_Writer.Write(VegetationEnabled);
		p_Writer.Write(ForceEnabled);
		p_Writer.Write(WorldRenderEnabled);
		p_Writer.Write(TerrainEnabled);
		p_Writer.Write(WaterPhysicsEnabled);
		p_Writer.Write(OvergrowthEnabled);
		p_Writer.Write(EffectsEnabled);
		p_Writer.Write(EmittersEnabled);
		p_Writer.Write(PadRumbleEnabled);
		p_Writer.Write(JuicePlayerReportPositionEnabled);
		p_Writer.Write(LipSyncEnabled);
		p_Writer.Write(OnDamageSpottingEnabled);
		p_Writer.Write(IgnoreClientFireRateMultiplier);
		p_Writer.Write(PauseGameOnStartUp);
		p_Writer.Write(SkipFirstFastLevelLoad);
		p_Writer.Write(SkipFastLevelLoad);
		p_Writer.Write(InputEnable);
		p_Writer.Write(ScreenshotToFile);
		p_Writer.Write(LoadMenu);
		p_Writer.Write(DebugMenuOnLThumb);
		p_Writer.Write(InvertFreeCamera);
		p_Writer.Write(RenderTags);
		p_Writer.Write(InvertPitch);
		p_Writer.Write(InvertPadPcRightStick);
		p_Writer.Write(Scheme0FlipY);
		p_Writer.Write(Scheme1FlipY);
		p_Writer.Write(Scheme2FlipY);
		p_Writer.Write(InvertYaw);
		p_Writer.Write(ConsoleInputEmulation);
		p_Writer.Write(SampleInputEveryVisualFrame);
		p_Writer.Write(HavokVisualDebugger);
		p_Writer.Write(HavokVDBShowsEffectsWorld);
		p_Writer.Write(HavokCaptureToFile);
		p_Writer.Write(UseMouseAndKeyboardSystem);
		p_Writer.Write(UseGlobalGamePadInput);
		p_Writer.Write(ShowBuildId);
		p_Writer.Write(ExtractPersistenceInformation);
		p_Writer.Write(EnableRestTool);
		p_Writer.Write(LocalVehicleSimulationEnabled);
		p_Writer.Write(AsyncClientBulletEntity);
		p_Writer.Write(AutoUnspawnDynamicObjects);
		p_Writer.Write(QuitGameOnServerDisconnect);
		p_Writer.Write(DebugTrackAllPlayersInSpawnScreen);
		p_Writer.Write(UseOldKillerCamera);
		p_Writer.Write(LuaOptionSetEnable);
		p_Writer.WriteNullBytes(7);
	}
}

