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
	public class RegistryContainer : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<DataContainer>> EntityRegistry { get; set; } = new();

		[ContainerField(12)]
		public List<CtrRef<DataContainer>> AssetRegistry { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<DataContainer>> BlueprintRegistry { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<DataContainer>> ReferenceObjectRegistry { get; set; } = new();

		public static void Deserialize(RegistryContainer p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EntityRegistry.Clear();
			(RimeReader Reader, uint Count) s_EntityRegistry = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EntityRegistry.Count; ++i)
			{
				var s_CtrRef = new CtrRef<DataContainer>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_EntityRegistry.Reader.ReadUInt32()));
				p_Instance.EntityRegistry.Add(s_CtrRef);
			}
			
			s_EntityRegistry.Reader.Dispose();
			p_Instance.AssetRegistry.Clear();
			(RimeReader Reader, uint Count) s_AssetRegistry = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AssetRegistry.Count; ++i)
			{
				var s_CtrRef = new CtrRef<DataContainer>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_AssetRegistry.Reader.ReadUInt32()));
				p_Instance.AssetRegistry.Add(s_CtrRef);
			}
			
			s_AssetRegistry.Reader.Dispose();
			p_Instance.BlueprintRegistry.Clear();
			(RimeReader Reader, uint Count) s_BlueprintRegistry = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BlueprintRegistry.Count; ++i)
			{
				var s_CtrRef = new CtrRef<DataContainer>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_BlueprintRegistry.Reader.ReadUInt32()));
				p_Instance.BlueprintRegistry.Add(s_CtrRef);
			}
			
			s_BlueprintRegistry.Reader.Dispose();
			p_Instance.ReferenceObjectRegistry.Clear();
			(RimeReader Reader, uint Count) s_ReferenceObjectRegistry = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ReferenceObjectRegistry.Count; ++i)
			{
				var s_CtrRef = new CtrRef<DataContainer>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ReferenceObjectRegistry.Reader.ReadUInt32()));
				p_Instance.ReferenceObjectRegistry.Add(s_CtrRef);
			}
			
			s_ReferenceObjectRegistry.Reader.Dispose();
		}

	}
}
