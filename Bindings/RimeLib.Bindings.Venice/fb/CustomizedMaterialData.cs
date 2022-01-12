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
	public class CustomizedMaterialData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<string> MaterialNames { get; set; } = new();

		[ContainerField(12)]
		public RefArray<UnlockableColorCollection> ColorParameters { get; set; } = new();

		[ContainerField(16)]
		public RefArray<UnlockableTextureCollection> TextureParameters { get; set; } = new();

		[ContainerField(20)]
		public RefArray<UnlockableTextureSliceCollection> TextureSliceParameters { get; set; } = new();

	}
}
