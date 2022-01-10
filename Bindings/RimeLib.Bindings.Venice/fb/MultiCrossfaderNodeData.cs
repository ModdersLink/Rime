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
	public class MultiCrossfaderNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public List<CtrRef<MultiCrossfaderGroup>> CrossfaderGroups { get; set; } = new();

		[ContainerField(12)]
		public AudioGraphNodePort Start { get; set; } = new();

		[ContainerField(20)]
		public AudioGraphNodePort Stop { get; set; } = new();

		[ContainerField(28)]
		public AudioGraphNodePort Control { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool LockControlValue { get; set; }

		public static void Deserialize(MultiCrossfaderNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CrossfaderGroups.Clear();
			(RimeReader Reader, uint Count) s_CrossfaderGroups = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_CrossfaderGroups.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MultiCrossfaderGroup>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_CrossfaderGroups.Reader.ReadUInt32()));
				p_Instance.CrossfaderGroups.Add(s_CtrRef);
			}
			
			s_CrossfaderGroups.Reader.Dispose();
			fb.AudioGraphNodePort.Deserialize(p_Instance.Start, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Stop, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Control, p_Reader, p_Parser);
			p_Instance.LockControlValue = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
