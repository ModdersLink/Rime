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
	public class DebugEventInput : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort E { get; set; } = new();

		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool RequireTriggeredAndSet { get; set; }

		public static void Deserialize(DebugEventInput p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.E, p_Reader, p_Parser);
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.RequireTriggeredAndSet = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
