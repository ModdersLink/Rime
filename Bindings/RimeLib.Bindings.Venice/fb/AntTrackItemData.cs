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
	[ContainerType(4, 28)]
	public class AntTrackItemData : 
		DataContainer
	{
		[ContainerField(8)]
		public AntRef Controller { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public int SequenceTrackIndex { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int StartTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint NumTicks { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool ResumeAtEnd { get; set; }

		public static void Deserialize(AntTrackItemData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.Controller, p_Reader, p_Parser);
			p_Instance.SequenceTrackIndex = p_Reader.ReadInt32();
			p_Instance.StartTime = p_Reader.ReadInt32();
			p_Instance.NumTicks = p_Reader.ReadUInt32();
			p_Instance.ResumeAtEnd = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
