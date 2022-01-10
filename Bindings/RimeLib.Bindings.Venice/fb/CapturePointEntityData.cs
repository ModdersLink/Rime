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
	public class CapturePointEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int EnemyTicketLossWhenCaptured { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public int MinNrToTakeControl { get; set; }

		[ContainerField(104)]
		public List<CtrRef<ObjectBlueprint>> FlagTemplates { get; set; } = new();

		[ContainerField(108)]
		public CtrRef<ObjectBlueprint> CapturePoint { get; set; } = new();

		[ContainerField(112)]
		public TeamId InitialOwnerTeam { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float CaptureRadius { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public int MaxCaptureMultiplier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public int AreaValue { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public uint SpawnMenuListOrdinal { get; set; }

		[ContainerField(132)]
		public List<AreaValueTeam> AreaValues { get; set; } = new();

		[ContainerField(136), LayoutImmutable, Blittable]
		public int TimeToGetControl { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public int TimeToLoseControl { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float ReturnMultiplier { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public int OnlyTakeableByTeam { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float ShowRadius { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float HideRadius { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float AddedMultiplierPerPlayer { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float Modify3DIconVerticalOffset { get; set; }

		[ContainerField(168)]
		public CapturableType CapturableType { get; set; } = new();

		[ContainerField(172), LayoutImmutable]
		public string IntruderWarningSID { get; set; } = string.Empty;

		[ContainerField(176), LayoutImmutable, Blittable]
		public bool IsCapturedInUpperSphere { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable]
		public bool DisableWhenLosingControl { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable]
		public bool LoseControlWhenNotClose { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable]
		public bool DisableIfEnemyInside { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool IsVisible { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable]
		public bool ForceSnap { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable]
		public bool UseAreaValuesPerTeam { get; set; }

		[ContainerField(183), LayoutImmutable, Blittable]
		public bool IntruderWarning { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public bool ShowOnMinimap { get; set; }

		[ContainerField(185), LayoutImmutable, Blittable]
		public bool HoistFlag { get; set; }

		[ContainerField(186), LayoutImmutable, Blittable]
		public bool StartAtBottom { get; set; }

		[ContainerField(187), LayoutImmutable, Blittable]
		public bool RemoveWhenCaptured { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public bool SeesawCapturing { get; set; }

		public static void Deserialize(CapturePointEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EnemyTicketLossWhenCaptured = p_Reader.ReadInt32();
			p_Instance.MinNrToTakeControl = p_Reader.ReadInt32();
			p_Instance.FlagTemplates.Clear();
			(RimeReader Reader, uint Count) s_FlagTemplates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FlagTemplates.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ObjectBlueprint>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_FlagTemplates.Reader.ReadUInt32()));
				p_Instance.FlagTemplates.Add(s_CtrRef);
			}
			
			s_FlagTemplates.Reader.Dispose();
			p_Instance.CapturePoint.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.InitialOwnerTeam = (TeamId) p_Reader.ReadInt32();
			p_Instance.CaptureRadius = p_Reader.ReadSingle();
			p_Instance.MaxCaptureMultiplier = p_Reader.ReadInt32();
			p_Instance.AreaValue = p_Reader.ReadInt32();
			p_Instance.SpawnMenuListOrdinal = p_Reader.ReadUInt32();
			p_Instance.AreaValues.Clear();
			(RimeReader Reader, uint Count) s_AreaValues = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AreaValues.Count; ++i)
			{
				var s_Value = new AreaValueTeam();
				fb.AreaValueTeam.Deserialize(s_Value, s_AreaValues.Reader, p_Parser);
				p_Instance.AreaValues.Add(s_Value);
			}
			
			s_AreaValues.Reader.Dispose();
			p_Instance.TimeToGetControl = p_Reader.ReadInt32();
			p_Instance.TimeToLoseControl = p_Reader.ReadInt32();
			p_Instance.ReturnMultiplier = p_Reader.ReadSingle();
			p_Instance.OnlyTakeableByTeam = p_Reader.ReadInt32();
			p_Instance.ShowRadius = p_Reader.ReadSingle();
			p_Instance.HideRadius = p_Reader.ReadSingle();
			p_Instance.AddedMultiplierPerPlayer = p_Reader.ReadSingle();
			p_Instance.Modify3DIconVerticalOffset = p_Reader.ReadSingle();
			p_Instance.CapturableType = (CapturableType) p_Reader.ReadInt32();
			p_Instance.IntruderWarningSID = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.IsCapturedInUpperSphere = p_Reader.ReadBool();
			p_Instance.DisableWhenLosingControl = p_Reader.ReadBool();
			p_Instance.LoseControlWhenNotClose = p_Reader.ReadBool();
			p_Instance.DisableIfEnemyInside = p_Reader.ReadBool();
			p_Instance.IsVisible = p_Reader.ReadBool();
			p_Instance.ForceSnap = p_Reader.ReadBool();
			p_Instance.UseAreaValuesPerTeam = p_Reader.ReadBool();
			p_Instance.IntruderWarning = p_Reader.ReadBool();
			p_Instance.ShowOnMinimap = p_Reader.ReadBool();
			p_Instance.HoistFlag = p_Reader.ReadBool();
			p_Instance.StartAtBottom = p_Reader.ReadBool();
			p_Instance.RemoveWhenCaptured = p_Reader.ReadBool();
			p_Instance.SeesawCapturing = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
