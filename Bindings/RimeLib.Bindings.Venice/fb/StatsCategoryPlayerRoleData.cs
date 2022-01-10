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
	[ContainerType(4, 24)]
	public class StatsCategoryPlayerRoleData : 
		StatsCategoryBaseData
	{
		[ContainerField(20)]
		public List<PlayerRole> Roles { get; set; } = new();

		public static void Deserialize(StatsCategoryPlayerRoleData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Roles.Clear();
			(RimeReader Reader, uint Count) s_Roles = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Roles.Count; ++i)
			{
				var s_Value = (PlayerRole) s_Roles.Reader.ReadInt32();
				p_Instance.Roles.Add(s_Value);
			}
			
			s_Roles.Reader.Dispose();
		}

	}
}
