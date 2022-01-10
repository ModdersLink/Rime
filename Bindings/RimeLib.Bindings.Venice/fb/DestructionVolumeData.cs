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
	[ContainerType(16, 64)]
	public class DestructionVolumeData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox BoundingBox { get; set; } = new();

		[ContainerField(48)]
		public CtrRef<DestructionVolumeAsset> Asset { get; set; } = new();

		[ContainerField(52)]
		public List<Vec4> Impacts { get; set; } = new();

		[ContainerField(56)]
		public List<uint> PartToImpactIndices { get; set; } = new();

		public static void Deserialize(DestructionVolumeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.AxisAlignedBox.Deserialize(p_Instance.BoundingBox, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Asset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Impacts.Clear();
			(RimeReader Reader, uint Count) s_Impacts = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Impacts.Count; ++i)
			{
				var s_Value = new Vec4();
				fb.Vec4.Deserialize(s_Value, s_Impacts.Reader, p_Parser);
				p_Instance.Impacts.Add(s_Value);
			}
			
			s_Impacts.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.PartToImpactIndices.Clear();
			(RimeReader Reader, uint Count) s_PartToImpactIndices = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PartToImpactIndices.Count; ++i)
			{
				var s_Value = s_PartToImpactIndices.Reader.ReadUInt32();
				p_Instance.PartToImpactIndices.Add(s_Value);
			}
			
			s_PartToImpactIndices.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
