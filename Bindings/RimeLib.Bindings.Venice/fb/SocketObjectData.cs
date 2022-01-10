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
	[ContainerType(4, 72)]
	public class SocketObjectData : 
		SocketObjectDataBase
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public GUID Asset1pGuid { get; set; }

		[ContainerField(24)]
		public List<GUID> Variation1pGuids { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public GUID Asset1pZoomGuid { get; set; }

		[ContainerField(44)]
		public List<GUID> Variation1pZoomGuids { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable]
		public GUID Asset3pGuid { get; set; }

		[ContainerField(64)]
		public List<GUID> Variation3pGuids { get; set; } = new();

		[ContainerField(68)]
		public List<CtrRef<CustomizedMaterialData>> CustomizedMaterials { get; set; } = new();

		public static void Deserialize(SocketObjectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Asset1pGuid = new GUID(p_Reader);
			p_Instance.Variation1pGuids.Clear();
			(RimeReader Reader, uint Count) s_Variation1pGuids = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Variation1pGuids.Count; ++i)
			{
				var s_Value = new GUID(s_Variation1pGuids.Reader);
				p_Instance.Variation1pGuids.Add(s_Value);
			}
			
			s_Variation1pGuids.Reader.Dispose();
			p_Instance.Asset1pZoomGuid = new GUID(p_Reader);
			p_Instance.Variation1pZoomGuids.Clear();
			(RimeReader Reader, uint Count) s_Variation1pZoomGuids = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Variation1pZoomGuids.Count; ++i)
			{
				var s_Value = new GUID(s_Variation1pZoomGuids.Reader);
				p_Instance.Variation1pZoomGuids.Add(s_Value);
			}
			
			s_Variation1pZoomGuids.Reader.Dispose();
			p_Instance.Asset3pGuid = new GUID(p_Reader);
			p_Instance.Variation3pGuids.Clear();
			(RimeReader Reader, uint Count) s_Variation3pGuids = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Variation3pGuids.Count; ++i)
			{
				var s_Value = new GUID(s_Variation3pGuids.Reader);
				p_Instance.Variation3pGuids.Add(s_Value);
			}
			
			s_Variation3pGuids.Reader.Dispose();
			p_Instance.CustomizedMaterials.Clear();
			(RimeReader Reader, uint Count) s_CustomizedMaterials = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_CustomizedMaterials.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CustomizedMaterialData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_CustomizedMaterials.Reader.ReadUInt32()));
				p_Instance.CustomizedMaterials.Add(s_CtrRef);
			}
			
			s_CustomizedMaterials.Reader.Dispose();
		}

	}
}
