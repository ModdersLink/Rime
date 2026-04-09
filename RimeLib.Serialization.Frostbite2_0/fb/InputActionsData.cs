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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 28)]
	public partial class InputActionsData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _NameSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private InputConceptIdentifiers _ConceptIdentifier = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private InputConceptIdentifiers _CopyKeyBindingFrom = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<InputActionData> _InputActions = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _HideInKeyBindings;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
			p_Writer.Write((int) ConceptIdentifier);
			p_Writer.Write((int) CopyKeyBindingFrom);
			(RimeWriter Writer, uint ArrayIndex) s_InputActions = p_EbxWriter.GetArrayWriter(InputActions.GetType(), InputActions.Count);
			p_Writer.Write(s_InputActions.ArrayIndex);
			foreach (var s_Entry in InputActions)
			{
				s_InputActions.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(HideInKeyBindings);
			p_Writer.WriteNullBytes(3);
		}
	}
}
