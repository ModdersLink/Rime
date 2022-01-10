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
	public class StanceFilterComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<int> ValidStances { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float StanceChangeTime { get; set; }

		[ContainerField(104)]
		public List<ActionSuppressor> ActionsToFilter { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool FilterSpecificActions { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool UndoParentStanceFilter { get; set; }

		public static void Deserialize(StanceFilterComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ValidStances.Clear();
			(RimeReader Reader, uint Count) s_ValidStances = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ValidStances.Count; ++i)
			{
				var s_Value = s_ValidStances.Reader.ReadInt32();
				p_Instance.ValidStances.Add(s_Value);
			}
			
			s_ValidStances.Reader.Dispose();
			p_Instance.StanceChangeTime = p_Reader.ReadSingle();
			p_Instance.ActionsToFilter.Clear();
			(RimeReader Reader, uint Count) s_ActionsToFilter = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ActionsToFilter.Count; ++i)
			{
				var s_Value = new ActionSuppressor();
				fb.ActionSuppressor.Deserialize(s_Value, s_ActionsToFilter.Reader, p_Parser);
				p_Instance.ActionsToFilter.Add(s_Value);
			}
			
			s_ActionsToFilter.Reader.Dispose();
			p_Instance.FilterSpecificActions = p_Reader.ReadBool();
			p_Instance.UndoParentStanceFilter = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
