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
	[ContainerType(4, 52)]
	public class BlazeServerBackendData : 
		ServerBackendData
	{
		[ContainerField(16)]
		public BlazeCreateGameParameters CreateParameters { get; set; } = new();

		[ContainerField(48)]
		public OnlineEnvironmentConsoleUrl ConfigUrl { get; set; } = new();

		public static void Deserialize(BlazeServerBackendData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.BlazeCreateGameParameters.Deserialize(p_Instance.CreateParameters, p_Reader, p_Parser);
			fb.OnlineEnvironmentConsoleUrl.Deserialize(p_Instance.ConfigUrl, p_Reader, p_Parser);
		}

	}
}
