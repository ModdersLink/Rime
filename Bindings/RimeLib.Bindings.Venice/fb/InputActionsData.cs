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
	[ContainerType(4, 28)]
	public class InputActionsData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(12)]
		public InputConceptIdentifiers ConceptIdentifier { get; set; } = new();

		[ContainerField(16)]
		public InputConceptIdentifiers CopyKeyBindingFrom { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<InputActionData>> InputActions { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool HideInKeyBindings { get; set; }

		public static void Deserialize(InputActionsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.NameSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ConceptIdentifier = (InputConceptIdentifiers) p_Reader.ReadInt32();
			p_Instance.CopyKeyBindingFrom = (InputConceptIdentifiers) p_Reader.ReadInt32();
			p_Instance.InputActions.Clear();
			(RimeReader Reader, uint Count) s_InputActions = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputActions.Count; ++i)
			{
				var s_CtrRef = new CtrRef<InputActionData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_InputActions.Reader.ReadUInt32()));
				p_Instance.InputActions.Add(s_CtrRef);
			}
			
			s_InputActions.Reader.Dispose();
			p_Instance.HideInKeyBindings = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
