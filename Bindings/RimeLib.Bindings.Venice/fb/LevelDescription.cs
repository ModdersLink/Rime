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
	[ContainerType(4, 16)]
	public class LevelDescription
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string Description { get; set; } = string.Empty;
		
		[ContainerField(8)]
		public List<CtrRef<LevelDescriptionComponent>> Components { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool IsCoop { get; set; }
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool IsMenu { get; set; }
		
		[ContainerField(14), LayoutImmutable, Blittable]
		public bool IsMultiplayer { get; set; }
		
		public static void Deserialize(LevelDescription p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Description = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Components.Clear();
			(RimeReader Reader, uint Count) s_Components = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Components.Count; ++i)
			{
				var s_CtrRef = new CtrRef<LevelDescriptionComponent>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Components.Reader.ReadUInt32()));
				p_Instance.Components.Add(s_CtrRef);
			}
			
			s_Components.Reader.Dispose();
			p_Instance.IsCoop = p_Reader.ReadBool();
			p_Instance.IsMenu = p_Reader.ReadBool();
			p_Instance.IsMultiplayer = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}
	}
}
