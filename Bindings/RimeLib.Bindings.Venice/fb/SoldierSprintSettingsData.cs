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
	[ContainerType(4, 40)]
	public class SoldierSprintSettingsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Fov { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float FovInDelay { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float FovInTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FovOutDelay { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float FovOutTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float RecoverTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float SprintToProneRecoverTime { get; set; }

		[ContainerField(36)]
		public List<EntryInputActionEnum> InterruptingActions { get; set; } = new();

		public static void Deserialize(SoldierSprintSettingsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Fov = p_Reader.ReadSingle();
			p_Instance.FovInDelay = p_Reader.ReadSingle();
			p_Instance.FovInTime = p_Reader.ReadSingle();
			p_Instance.FovOutDelay = p_Reader.ReadSingle();
			p_Instance.FovOutTime = p_Reader.ReadSingle();
			p_Instance.RecoverTime = p_Reader.ReadSingle();
			p_Instance.SprintToProneRecoverTime = p_Reader.ReadSingle();
			p_Instance.InterruptingActions.Clear();
			(RimeReader Reader, uint Count) s_InterruptingActions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InterruptingActions.Count; ++i)
			{
				var s_Value = (EntryInputActionEnum) s_InterruptingActions.Reader.ReadInt32();
				p_Instance.InterruptingActions.Add(s_Value);
			}
			
			s_InterruptingActions.Reader.Dispose();
		}

	}
}
