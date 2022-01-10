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
	[ContainerType(4, 12)]
	public class EntityTransformData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<LinearTransform> EntityTransforms { get; set; } = new();

		public static void Deserialize(EntityTransformData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.EntityTransforms.Clear();
			(RimeReader Reader, uint Count) s_EntityTransforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EntityTransforms.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_EntityTransforms.Reader, p_Parser);
				p_Instance.EntityTransforms.Add(s_Value);
			}
			
			s_EntityTransforms.Reader.Dispose();
		}

	}
}
