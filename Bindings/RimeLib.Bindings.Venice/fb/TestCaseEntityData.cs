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
	[ContainerType(4, 28)]
	public class TestCaseEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TimeOut { get; set; }

		[ContainerField(16), LayoutImmutable]
		public string TestGroup { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string TestCaseName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool Stable { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(TestCaseEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TimeOut = p_Reader.ReadSingle();
			p_Instance.TestGroup = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.TestCaseName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Stable = p_Reader.ReadBool();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
