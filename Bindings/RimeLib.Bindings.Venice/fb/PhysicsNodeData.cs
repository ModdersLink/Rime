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
	[ContainerType(4, 52)]
	public class PhysicsNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Distance { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Velocity { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort RelativeVelocity { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Azimuth { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort ElevationAngle { get; set; } = new();

		[ContainerField(48)]
		public List<CtrRef<PhysicsEntry>> Entries { get; set; } = new();

		public static void Deserialize(PhysicsNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Distance, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Velocity, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.RelativeVelocity, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Azimuth, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.ElevationAngle, p_Reader, p_Parser);
			p_Instance.Entries.Clear();
			(RimeReader Reader, uint Count) s_Entries = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Entries.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PhysicsEntry>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Entries.Reader.ReadUInt32()));
				p_Instance.Entries.Add(s_CtrRef);
			}
			
			s_Entries.Reader.Dispose();
		}

	}
}
