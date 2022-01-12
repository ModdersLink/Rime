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
	public class AILocoVaultBinding
	{
		[ContainerField(0)]
		public AntRef Vault { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef DistanceBeforeVault { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef HeightBeforeVault { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef LengthOfVaultableObject { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef HeightAfterVault { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef DistanceAfterVault { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef VaultType { get; set; } = new();
		
	}
}
