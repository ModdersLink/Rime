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
	[ContainerType(4, 32)]
	public class CharacterCustomizationAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string LabelSid { get; set; } = string.Empty;

		[ContainerField(16)]
		public UIHudIcon UIHudIcon { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<VoiceOverLabel>> VoiceOverLabels { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<CustomizationTable> VisualTable { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<CustomizationTable> SpecializationTable { get; set; } = new();

		public static void Deserialize(CharacterCustomizationAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LabelSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.UIHudIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.VoiceOverLabels.Clear();
			(RimeReader Reader, uint Count) s_VoiceOverLabels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_VoiceOverLabels.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverLabel>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_VoiceOverLabels.Reader.ReadUInt32()));
				p_Instance.VoiceOverLabels.Add(s_CtrRef);
			}
			
			s_VoiceOverLabels.Reader.Dispose();
			p_Instance.VisualTable.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SpecializationTable.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
