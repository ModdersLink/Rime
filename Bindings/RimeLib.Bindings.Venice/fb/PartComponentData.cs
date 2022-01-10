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
	public class PartComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<CtrRef<HealthStateData>> HealthStates { get; set; } = new();

		[ContainerField(100)]
		public List<CtrRef<PartLinkData>> PartLinks { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool IsSupported { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool IsFragile { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable]
		public bool IsNetworkable { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable]
		public bool IsWindow { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool AnimatePhysics { get; set; }

		public static void Deserialize(PartComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HealthStates.Clear();
			(RimeReader Reader, uint Count) s_HealthStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_HealthStates.Count; ++i)
			{
				var s_CtrRef = new CtrRef<HealthStateData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_HealthStates.Reader.ReadUInt32()));
				p_Instance.HealthStates.Add(s_CtrRef);
			}
			
			s_HealthStates.Reader.Dispose();
			p_Instance.PartLinks.Clear();
			(RimeReader Reader, uint Count) s_PartLinks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PartLinks.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PartLinkData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PartLinks.Reader.ReadUInt32()));
				p_Instance.PartLinks.Add(s_CtrRef);
			}
			
			s_PartLinks.Reader.Dispose();
			p_Instance.IsSupported = p_Reader.ReadBool();
			p_Instance.IsFragile = p_Reader.ReadBool();
			p_Instance.IsNetworkable = p_Reader.ReadBool();
			p_Instance.IsWindow = p_Reader.ReadBool();
			p_Instance.AnimatePhysics = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
