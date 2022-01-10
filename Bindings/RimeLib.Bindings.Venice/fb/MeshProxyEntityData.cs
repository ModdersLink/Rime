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
	public class MeshProxyEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(84)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new();

		public static void Deserialize(MeshProxyEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BasePoseTransforms.Clear();
			(RimeReader Reader, uint Count) s_BasePoseTransforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BasePoseTransforms.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_BasePoseTransforms.Reader, p_Parser);
				p_Instance.BasePoseTransforms.Add(s_Value);
			}
			
			s_BasePoseTransforms.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
