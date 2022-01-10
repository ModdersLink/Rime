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
	[ContainerType(4, 32)]
	public class SoundTestSpec : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable]
		public string Description { get; set; } = string.Empty;

		[ContainerField(16)]
		public CtrRef<SoundTestTask> MainStartTask { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<SoundTestTask> MainStopTask { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Duration { get; set; }

		[ContainerField(28)]
		public List<CtrRef<SoundTestTask>> Tasks { get; set; } = new();

		public static void Deserialize(SoundTestSpec p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Description = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.MainStartTask.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MainStopTask.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Duration = p_Reader.ReadSingle();
			p_Instance.Tasks.Clear();
			(RimeReader Reader, uint Count) s_Tasks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Tasks.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SoundTestTask>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Tasks.Reader.ReadUInt32()));
				p_Instance.Tasks.Add(s_CtrRef);
			}
			
			s_Tasks.Reader.Dispose();
		}

	}
}
