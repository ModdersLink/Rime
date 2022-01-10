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
	[ContainerType(8, 144)]
	public class SensingTemplateData : 
		GameSensingTemplateData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public double AwareForgetTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public double LostForgetTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public double TimeUntilUnseenIsLost { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaximumMergeDistance { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaximumAlertDistance { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float MaximumReadinessRaiseDistance { get; set; }

		[ContainerField(52)]
		public SensingLimits ReadyLimits { get; set; } = new();

		[ContainerField(80)]
		public SensingLimits RelaxedLimits { get; set; } = new();

		[ContainerField(108), LayoutImmutable]
		public string DebugText { get; set; } = string.Empty;

		[ContainerField(112)]
		public SensingLimits CombatLimits { get; set; } = new();

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool UseSenseSharing { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool NoticeBullets { get; set; }

		public static void Deserialize(SensingTemplateData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AwareForgetTime = p_Reader.ReadDouble();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.LostForgetTime = p_Reader.ReadDouble();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.TimeUntilUnseenIsLost = p_Reader.ReadDouble();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MaximumMergeDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MaximumAlertDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MaximumReadinessRaiseDistance = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.SensingLimits.Deserialize(p_Instance.ReadyLimits, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.SensingLimits.Deserialize(p_Instance.RelaxedLimits, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DebugText = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.SensingLimits.Deserialize(p_Instance.CombatLimits, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.UseSenseSharing = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.NoticeBullets = p_Reader.ReadBool();
			p_Reader.Seek(6, SeekOrigin.Current);
		}

	}
}
