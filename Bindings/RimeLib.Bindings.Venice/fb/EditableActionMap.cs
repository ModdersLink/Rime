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
	public class EditableActionMap
	{
		[ContainerField(0), LayoutImmutable]
		public string Id { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string NameId { get; set; } = string.Empty;
		
		[ContainerField(8)]
		public CtrRef<EntryInputActionMapsData> ActionMap { get; set; } = new();
		
		[ContainerField(12)]
		public EditableActions ConfigurationLayout { get; set; } = new();
		
		public static void Deserialize(EditableActionMap p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Id = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.NameId = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ActionMap.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			fb.EditableActions.Deserialize(p_Instance.ConfigurationLayout, p_Reader, p_Parser);
		}
	}
}
