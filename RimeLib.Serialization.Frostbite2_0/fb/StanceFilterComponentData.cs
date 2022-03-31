///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class StanceFilterComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public List<int> ValidStances { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float StanceChangeTime { get; set; }

		[ContainerField(104), JsonProperty(Order = 104)]
		public List<ActionSuppressor> ActionsToFilter { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool FilterSpecificActions { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool UndoParentStanceFilter { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_ValidStances = p_EbxWriter.GetArrayWriter(ValidStances.GetType(), ValidStances.Count);
			p_Writer.Write(s_ValidStances.ArrayIndex);
			foreach (var s_Entry in ValidStances)
			{
				s_ValidStances.Writer.Write(s_Entry);
			}
			p_Writer.Write(StanceChangeTime);
			(RimeWriter Writer, uint ArrayIndex) s_ActionsToFilter = p_EbxWriter.GetArrayWriter(ActionsToFilter.GetType(), ActionsToFilter.Count);
			p_Writer.Write(s_ActionsToFilter.ArrayIndex);
			foreach (var s_Entry in ActionsToFilter)
			{
				s_Entry.Serialize(s_ActionsToFilter.Writer, p_EbxWriter);
			}
			p_Writer.Write(FilterSpecificActions);
			p_Writer.Write(UndoParentStanceFilter);
			p_Writer.WriteNullBytes(2);
		}
	}
}
