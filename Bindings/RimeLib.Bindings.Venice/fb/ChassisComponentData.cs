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
	[ContainerType(16, 144)]
	public class ChassisComponentData : 
		PartComponentData
	{
		[ContainerField(112)]
		public CtrRef<VehicleConfigData> VehicleConfig { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<GearboxConfigData> GearboxConfig { get; set; } = new();

		[ContainerField(120)]
		public List<CtrRef<VehicleWaterEffectData>> WaterStreakEffects { get; set; } = new();

		[ContainerField(124)]
		public List<CtrRef<VehicleWaterEffectData>> WaterEffects { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float TriggerGroundEffectImpulse { get; set; }

		[ContainerField(132)]
		public CtrRef<LandingGearLogicData> LandingGearLogic { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool AlwaysFullThrottle { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool ForceLandingGearsRetract { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool AllowNegativeThrottle { get; set; }

		public static void Deserialize(ChassisComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.VehicleConfig.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.GearboxConfig.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WaterStreakEffects.Clear();
			(RimeReader Reader, uint Count) s_WaterStreakEffects = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_WaterStreakEffects.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VehicleWaterEffectData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_WaterStreakEffects.Reader.ReadUInt32()));
				p_Instance.WaterStreakEffects.Add(s_CtrRef);
			}
			
			s_WaterStreakEffects.Reader.Dispose();
			p_Instance.WaterEffects.Clear();
			(RimeReader Reader, uint Count) s_WaterEffects = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_WaterEffects.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VehicleWaterEffectData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_WaterEffects.Reader.ReadUInt32()));
				p_Instance.WaterEffects.Add(s_CtrRef);
			}
			
			s_WaterEffects.Reader.Dispose();
			p_Instance.TriggerGroundEffectImpulse = p_Reader.ReadSingle();
			p_Instance.LandingGearLogic.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AlwaysFullThrottle = p_Reader.ReadBool();
			p_Instance.ForceLandingGearsRetract = p_Reader.ReadBool();
			p_Instance.AllowNegativeThrottle = p_Reader.ReadBool();
			p_Reader.Seek(5, SeekOrigin.Current);
		}

	}
}
