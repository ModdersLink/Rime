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
	[ContainerType(4, 152)]
	public class FireLogicData
	{
		[ContainerField(0)]
		public HoldAndReleaseData HoldAndRelease { get; set; } = new();
		
		[ContainerField(28)]
		public BoltActionData BoltAction { get; set; } = new();
		
		[ContainerField(44)]
		public RecoilData Recoil { get; set; } = new();
		
		[ContainerField(80)]
		public EntryInputActionEnum FireInputAction { get; set; } = new();
		
		[ContainerField(84)]
		public EntryInputActionEnum ReloadInputAction { get; set; } = new();
		
		[ContainerField(88)]
		public EntryInputActionEnum CycleFireModeInputAction { get; set; } = new();
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float TriggerPullWeight { get; set; }
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float RateOfFire { get; set; }
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float RateOfFireForBurst { get; set; }
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float ClientFireRateMultiplier { get; set; }
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float ReloadDelay { get; set; }
		
		[ContainerField(112)]
		public List<FireLogicType> FireLogicTypeArray { get; set; } = new();
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float ReloadThreshold { get; set; }
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float PreFireDelay { get; set; }
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float ReloadTime { get; set; }
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float ReloadTimeBulletsLeft { get; set; }
		
		[ContainerField(132)]
		public FireLogicType FireLogicType { get; set; } = new();
		
		[ContainerField(136)]
		public ReloadLogic ReloadLogic { get; set; } = new();
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float AutomaticDelay { get; set; }
		
		[ContainerField(144)]
		public ReloadType ReloadType { get; set; } = new();
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool HoldOffReloadUntilZoomRelease { get; set; }
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool ForceReloadActionOnFireTrigger { get; set; }
		
		[ContainerField(150), LayoutImmutable, Blittable]
		public bool HoldOffReloadUntilFireRelease { get; set; }
		
		[ContainerField(151), LayoutImmutable, Blittable]
		public bool AlwaysAutoReload { get; set; }
		
		public static void Deserialize(FireLogicData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.HoldAndReleaseData.Deserialize(p_Instance.HoldAndRelease, p_Reader, p_Parser);
			fb.BoltActionData.Deserialize(p_Instance.BoltAction, p_Reader, p_Parser);
			fb.RecoilData.Deserialize(p_Instance.Recoil, p_Reader, p_Parser);
			p_Instance.FireInputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.ReloadInputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.CycleFireModeInputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.TriggerPullWeight = p_Reader.ReadSingle();
			p_Instance.RateOfFire = p_Reader.ReadSingle();
			p_Instance.RateOfFireForBurst = p_Reader.ReadSingle();
			p_Instance.ClientFireRateMultiplier = p_Reader.ReadSingle();
			p_Instance.ReloadDelay = p_Reader.ReadSingle();
			p_Instance.FireLogicTypeArray.Clear();
			(RimeReader Reader, uint Count) s_FireLogicTypeArray = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FireLogicTypeArray.Count; ++i)
			{
				var s_Value = (FireLogicType) s_FireLogicTypeArray.Reader.ReadInt32();
				p_Instance.FireLogicTypeArray.Add(s_Value);
			}
			
			s_FireLogicTypeArray.Reader.Dispose();
			p_Instance.ReloadThreshold = p_Reader.ReadSingle();
			p_Instance.PreFireDelay = p_Reader.ReadSingle();
			p_Instance.ReloadTime = p_Reader.ReadSingle();
			p_Instance.ReloadTimeBulletsLeft = p_Reader.ReadSingle();
			p_Instance.FireLogicType = (FireLogicType) p_Reader.ReadInt32();
			p_Instance.ReloadLogic = (ReloadLogic) p_Reader.ReadInt32();
			p_Instance.AutomaticDelay = p_Reader.ReadSingle();
			p_Instance.ReloadType = (ReloadType) p_Reader.ReadInt32();
			p_Instance.HoldOffReloadUntilZoomRelease = p_Reader.ReadBool();
			p_Instance.ForceReloadActionOnFireTrigger = p_Reader.ReadBool();
			p_Instance.HoldOffReloadUntilFireRelease = p_Reader.ReadBool();
			p_Instance.AlwaysAutoReload = p_Reader.ReadBool();
		}
	}
}
