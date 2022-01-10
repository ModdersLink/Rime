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
	[ContainerType(16, 112)]
	public class SubWorldReferenceObjectData : 
		ReferenceObjectData
	{
		[ContainerField(96), LayoutImmutable]
		public string BundleName { get; set; } = string.Empty;

		[ContainerField(100)]
		public CtrRef<SubWorldInclusionSettings> InclusionSettings { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool AutoLoad { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool IsWin32SubLevel { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable]
		public bool IsXenonSubLevel { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable]
		public bool IsPs3SubLevel { get; set; }

		public static void Deserialize(SubWorldReferenceObjectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BundleName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.InclusionSettings.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.AutoLoad = p_Reader.ReadBool();
			p_Instance.IsWin32SubLevel = p_Reader.ReadBool();
			p_Instance.IsXenonSubLevel = p_Reader.ReadBool();
			p_Instance.IsPs3SubLevel = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
