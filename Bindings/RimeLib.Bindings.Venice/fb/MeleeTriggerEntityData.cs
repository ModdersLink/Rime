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
	[ContainerType(16, 96)]
	public class MeleeTriggerEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ConnectTransform { get; set; } = new();

		[ContainerField(80)]
		public CtrRef<AntEnumeration> MeleeType { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public bool MeleeEnabled { get; set; }

		public static void Deserialize(MeleeTriggerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.ConnectTransform, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MeleeType.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MeleeEnabled = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
