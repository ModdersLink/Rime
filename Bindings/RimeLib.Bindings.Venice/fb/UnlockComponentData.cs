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
	public class UnlockComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint UnlockDataKey { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool UnlockableFromAllEntries { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool InvertUnlockTest { get; set; }

		public static void Deserialize(UnlockComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UnlockAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.UnlockDataKey = p_Reader.ReadUInt32();
			p_Instance.UnlockableFromAllEntries = p_Reader.ReadBool();
			p_Instance.InvertUnlockTest = p_Reader.ReadBool();
			p_Reader.Seek(6, SeekOrigin.Current);
		}

	}
}
