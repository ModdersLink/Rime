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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class CustomizeCharacterData :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<CustomizeVisual> VisualGroups { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float OverrideCriticalHealthThreshold { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<UnlockAssetBase> Unlocks { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float OverrideMaxHealth { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool ClearVisualState { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		public bool RestoreToOriginalVisualState { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_VisualGroups = p_EbxWriter.GetArrayWriter(VisualGroups.GetType(), VisualGroups.Count);
			p_Writer.Write(s_VisualGroups.ArrayIndex);
			foreach (var s_Entry in VisualGroups)
			{
				s_Entry.Serialize(s_VisualGroups.Writer, p_EbxWriter);
			}
			p_Writer.Write(OverrideCriticalHealthThreshold);
			(RimeWriter Writer, uint ArrayIndex) s_Unlocks = p_EbxWriter.GetArrayWriter(Unlocks.GetType(), Unlocks.Count);
			p_Writer.Write(s_Unlocks.ArrayIndex);
			foreach (var s_Entry in Unlocks)
			{
				s_Unlocks.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(OverrideMaxHealth);
			p_Writer.Write(ClearVisualState);
			p_Writer.Write(RestoreToOriginalVisualState);
			p_Writer.WriteNullBytes(2);
		}
	}
}
