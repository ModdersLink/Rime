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
	[ContainerType(4, 20)]
	public class SoldierMovementSequenceData : 
		MovementActionData
	{
		[ContainerField(8)]
		public CtrRef<RecordedInputData> RecordedInput { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public int InputRecordingIndex { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IgnoreRecordingIndexFilter { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable]
		public bool ReportWhenFinished { get; set; }

		public static void Deserialize(SoldierMovementSequenceData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RecordedInput.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.InputRecordingIndex = p_Reader.ReadInt32();
			p_Instance.IgnoreRecordingIndexFilter = p_Reader.ReadBool();
			p_Instance.ReportWhenFinished = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
