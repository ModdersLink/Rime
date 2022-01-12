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
	[ContainerType(16, 128)]
	public class FaceposerComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public AntRef FacePoserEnabled { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float LodDistance { get; set; }

		[ContainerField(104)]
		public AntRef FacePoseLibraryReference { get; set; } = new();

		[ContainerField(108)]
		public List<AntRef> FacePoseLibrary { get; set; } = new();

		[ContainerField(112), LayoutImmutable]
		public string FacePoserDofSetName { get; set; } = string.Empty;

		[ContainerField(116)]
		public List<string> ShaderExposedValues { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public int FacePoseLibraryIndex { get; set; }

	}
}
