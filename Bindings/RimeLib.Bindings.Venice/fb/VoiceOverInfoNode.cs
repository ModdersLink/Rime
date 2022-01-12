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
	[ContainerType(4, 24)]
	public class VoiceOverInfoNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> Object { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValue> Value { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverNamedValue> Field { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<VoiceOverObject> ExpectedType { get; set; } = new();

	}
}
