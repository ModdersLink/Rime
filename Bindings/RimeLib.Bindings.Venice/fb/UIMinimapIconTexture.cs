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
	public class UIMinimapIconTexture
	{
		[ContainerField(0)]
		public UIHudIcon IconType { get; set; } = new();
		
		[ContainerField(4)]
		public List<UIMinimapIconTextureState> States { get; set; } = new();
		
		public static void Deserialize(UIMinimapIconTexture p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.IconType = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.States.Clear();
			(RimeReader Reader, uint Count) s_States = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_States.Count; ++i)
			{
				var s_Value = new UIMinimapIconTextureState();
				fb.UIMinimapIconTextureState.Deserialize(s_Value, s_States.Reader, p_Parser);
				p_Instance.States.Add(s_Value);
			}
			
			s_States.Reader.Dispose();
		}
	}
}
