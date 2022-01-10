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
	public class WeaponRegularSocketObjectData : 
		WeaponSocketObjectData
	{
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new();

		[ContainerField(96)]
		public List<LinearTransform> Mesh3pTransforms { get; set; } = new();

		public static void Deserialize(WeaponRegularSocketObjectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.Transform, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Mesh3pTransforms.Clear();
			(RimeReader Reader, uint Count) s_Mesh3pTransforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Mesh3pTransforms.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_Mesh3pTransforms.Reader, p_Parser);
				p_Instance.Mesh3pTransforms.Add(s_Value);
			}
			
			s_Mesh3pTransforms.Reader.Dispose();
			p_Reader.Seek(20, SeekOrigin.Current);
		}

	}
}
