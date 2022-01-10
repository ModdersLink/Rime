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
	[ContainerType(16, 128)]
	public class UIMinimapZoomConfig
	{
		[ContainerField(0)]
		public UIMinimapZoomState State { get; set; } = new();
		
		[ContainerField(16)]
		public MinimapData Data { get; set; } = new();
		
		public static void Deserialize(UIMinimapZoomConfig p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.State = (UIMinimapZoomState) p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
			fb.MinimapData.Deserialize(p_Instance.Data, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
		}
	}
}
