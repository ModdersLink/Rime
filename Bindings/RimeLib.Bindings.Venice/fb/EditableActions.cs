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
	[ContainerType(4, 4)]
	public class EditableActions
	{
		[ContainerField(0)]
		public List<CtrRef<EditableAction>> Actions { get; set; } = new();
		
		public static void Deserialize(EditableActions p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Actions.Clear();
			(RimeReader Reader, uint Count) s_Actions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Actions.Count; ++i)
			{
				var s_CtrRef = new CtrRef<EditableAction>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Actions.Reader.ReadUInt32()));
				p_Instance.Actions.Add(s_CtrRef);
			}
			
			s_Actions.Reader.Dispose();
		}
	}
}
