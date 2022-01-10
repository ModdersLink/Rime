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
	public class UIInterruptFlow : 
		Asset
	{
		[ContainerField(12)]
		public List<InterruptFlow> interruptFlow { get; set; } = new();

		public static void Deserialize(UIInterruptFlow p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.interruptFlow.Clear();
			(RimeReader Reader, uint Count) s_interruptFlow = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_interruptFlow.Count; ++i)
			{
				var s_Value = new InterruptFlow();
				fb.InterruptFlow.Deserialize(s_Value, s_interruptFlow.Reader, p_Parser);
				p_Instance.interruptFlow.Add(s_Value);
			}
			
			s_interruptFlow.Reader.Dispose();
		}

	}
}
