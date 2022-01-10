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
	[ContainerType(16, 192)]
	public class EntryComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SoldierOffset { get; set; } = new();

		[ContainerField(112)]
		public CtrRef<GameAIEntryData> AIData { get; set; } = new();

		[ContainerField(116)]
		public EntryClass EntryClass { get; set; } = new();

		[ContainerField(120)]
		public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get; set; } = new();

		[ContainerField(124)]
		public CtrRef<InputActionMappingsData> InputMapping { get; set; } = new();

		[ContainerField(128)]
		public List<CtrRef<InputCurveData>> InputCurves { get; set; } = new();

		[ContainerField(132)]
		public EntryComponentHudData HudData { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public int EntryOrderNumber { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float EnterImpulse { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float EntryRadius { get; set; }

		[ContainerField(156)]
		public EntryInputActionEnum TriggerEventOnKey { get; set; } = new();

		[ContainerField(160)]
		public EntrySpottingSettings EntrySpottingSettings { get; set; } = new();

		[ContainerField(164)]
		public PoseConstraintsData PoseConstraints { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable]
		public float SoldierTransitionInvisbleTime { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public int NumberOfStances { get; set; }

		[ContainerField(176)]
		public CtrRef<EntryComponentSoundData> EntryComponentSound { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool LockSoldierAimingToEntry { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable]
		public bool IsAllowedToExitInAir { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable]
		public bool Show1pSoldierInEntry { get; set; }

		[ContainerField(183), LayoutImmutable, Blittable]
		public bool StancesEnabled { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public bool Show1pSoldierInEntryForPlayerOnly { get; set; }

		[ContainerField(185), LayoutImmutable, Blittable]
		public bool HideSoldierForPassengers { get; set; }

		[ContainerField(186), LayoutImmutable, Blittable]
		public bool Show3pSoldierWeaponInEntry { get; set; }

		[ContainerField(187), LayoutImmutable, Blittable]
		public bool ShowSoldierGearInEntry { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public bool IsShielded { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable]
		public bool ForbiddenForHuman { get; set; }

		[ContainerField(190), LayoutImmutable, Blittable]
		public bool ShowSoldierWeaponInEntry { get; set; }

		[ContainerField(191), LayoutImmutable, Blittable]
		public bool ShowSoldierInEntry { get; set; }

		public static void Deserialize(EntryComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.SoldierOffset, p_Reader, p_Parser);
			p_Instance.AIData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.EntryClass = (EntryClass) p_Reader.ReadInt32();
			p_Instance.InputConceptDefinition.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.InputMapping.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.InputCurves.Clear();
			(RimeReader Reader, uint Count) s_InputCurves = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputCurves.Count; ++i)
			{
				var s_CtrRef = new CtrRef<InputCurveData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_InputCurves.Reader.ReadUInt32()));
				p_Instance.InputCurves.Add(s_CtrRef);
			}
			
			s_InputCurves.Reader.Dispose();
			fb.EntryComponentHudData.Deserialize(p_Instance.HudData, p_Reader, p_Parser);
			p_Instance.EntryOrderNumber = p_Reader.ReadInt32();
			p_Instance.EnterImpulse = p_Reader.ReadSingle();
			p_Instance.EntryRadius = p_Reader.ReadSingle();
			p_Instance.TriggerEventOnKey = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.EntrySpottingSettings = (EntrySpottingSettings) p_Reader.ReadInt32();
			fb.PoseConstraintsData.Deserialize(p_Instance.PoseConstraints, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.SoldierTransitionInvisbleTime = p_Reader.ReadSingle();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.NumberOfStances = p_Reader.ReadInt32();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.EntryComponentSound.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.LockSoldierAimingToEntry = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.IsAllowedToExitInAir = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.Show1pSoldierInEntry = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.StancesEnabled = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.Show1pSoldierInEntryForPlayerOnly = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.HideSoldierForPassengers = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.Show3pSoldierWeaponInEntry = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.ShowSoldierGearInEntry = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.IsShielded = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.ForbiddenForHuman = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.ShowSoldierWeaponInEntry = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.ShowSoldierInEntry = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
