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

namespace fb
{
	[ContainerType(4, 16)]
	public class EditableActionMap
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Id { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string NameId { get; set; } = string.Empty;
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<EntryInputActionMapsData> ActionMap { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public EditableActions ConfigurationLayout { get; set; } = new();
		
	}
}
