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
	public class MovementActionGroupData : 
		MovementActionData
	{
		[ContainerField(8)]
		public List<CtrRef<MovementActionData>> Actions { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool RunSimultaneously { get; set; }

		[ContainerField(13), LayoutImmutable, Blittable]
		public bool RestartChildren { get; set; }

		public static void Deserialize(MovementActionGroupData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Actions.Clear();
			(RimeReader Reader, uint Count) s_Actions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Actions.Count; ++i)
			{
				var s_CtrRef = new CtrRef<MovementActionData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Actions.Reader.ReadUInt32()));
				p_Instance.Actions.Add(s_CtrRef);
			}
			
			s_Actions.Reader.Dispose();
			p_Instance.RunSimultaneously = p_Reader.ReadBool();
			p_Instance.RestartChildren = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
