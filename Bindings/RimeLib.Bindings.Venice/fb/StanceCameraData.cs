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
	[ContainerType(4, 8)]
	public class StanceCameraData
	{
		[ContainerField(0)]
		public List<int> ValidStances { get; set; } = new();
		
		[ContainerField(4)]
		public List<int> DefaultCameraForStances { get; set; } = new();
		
		public static void Deserialize(StanceCameraData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ValidStances.Clear();
			(RimeReader Reader, uint Count) s_ValidStances = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ValidStances.Count; ++i)
			{
				var s_Value = s_ValidStances.Reader.ReadInt32();
				p_Instance.ValidStances.Add(s_Value);
			}
			
			s_ValidStances.Reader.Dispose();
			p_Instance.DefaultCameraForStances.Clear();
			(RimeReader Reader, uint Count) s_DefaultCameraForStances = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DefaultCameraForStances.Count; ++i)
			{
				var s_Value = s_DefaultCameraForStances.Reader.ReadInt32();
				p_Instance.DefaultCameraForStances.Add(s_Value);
			}
			
			s_DefaultCameraForStances.Reader.Dispose();
		}
	}
}
