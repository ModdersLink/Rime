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
	public class ComponentData : 
		GameObjectData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new();

		[ContainerField(80)]
		public List<CtrRef<GameObjectData>> Components { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public bool Excluded { get; set; }

		public static void Deserialize(ComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.Transform, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Components.Clear();
			(RimeReader Reader, uint Count) s_Components = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Components.Count; ++i)
			{
				var s_CtrRef = new CtrRef<GameObjectData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Components.Reader.ReadUInt32()));
				p_Instance.Components.Add(s_CtrRef);
			}
			
			s_Components.Reader.Dispose();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Excluded = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
