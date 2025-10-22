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

using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 32)]
public class EditableActionMap
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string Id { get; set; } = string.Empty;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public string NameId { get; set; } = string.Empty;
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<EntryInputActionMapsData> ActionMap { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public EditableActions ConfigurationLayout { get; set; } = new();
	
}

