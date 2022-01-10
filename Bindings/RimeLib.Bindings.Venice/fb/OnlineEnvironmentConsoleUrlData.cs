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
	public class OnlineEnvironmentConsoleUrlData
	{
		[ContainerField(0)]
		public GamePlatform Platform { get; set; } = new();
		
		[ContainerField(4)]
		public OnlineEnvironmentUrl Url { get; set; } = new();
		
		public static void Deserialize(OnlineEnvironmentConsoleUrlData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Platform = (GamePlatform) p_Reader.ReadInt32();
			fb.OnlineEnvironmentUrl.Deserialize(p_Instance.Url, p_Reader, p_Parser);
		}
	}
}
