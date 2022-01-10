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
	[ContainerType(4, 16)]
	public class FormationData : 
		GameDataContainer
	{
		[ContainerField(8)]
		public List<Vec3> Positions { get; set; } = new();

		[ContainerField(12), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		public static void Deserialize(FormationData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Positions.Clear();
			(RimeReader Reader, uint Count) s_Positions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Positions.Count; ++i)
			{
				var s_Value = new Vec3();
				fb.Vec3.Deserialize(s_Value, s_Positions.Reader, p_Parser);
				p_Instance.Positions.Add(s_Value);
			}
			
			s_Positions.Reader.Dispose();
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}

	}
}
