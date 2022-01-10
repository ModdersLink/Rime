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
	[ContainerType(16, 176)]
	public class JammingComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SmokeJammingData SmokeJamming { get; set; } = new();

		[ContainerField(116)]
		public AirMissileJammingData AirMissileJamming { get; set; } = new();

		public static void Deserialize(JammingComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.SmokeJammingData.Deserialize(p_Instance.SmokeJamming, p_Reader, p_Parser);
			fb.AirMissileJammingData.Deserialize(p_Instance.AirMissileJamming, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
