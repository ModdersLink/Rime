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
		public RefArray<InputActionData> InputActions { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool HideInKeyBindings { get; set; }

	}
}
