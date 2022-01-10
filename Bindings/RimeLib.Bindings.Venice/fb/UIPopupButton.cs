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
	public class UIPopupButton
	{
		[ContainerField(0)]
		public UIInputAction InputConcept { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable]
		public string Label { get; set; } = string.Empty;
		
		public static void Deserialize(UIPopupButton p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.InputConcept = (UIInputAction) p_Reader.ReadInt32();
			p_Instance.Label = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
		}
	}
}
