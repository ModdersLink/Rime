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
		
		public static void Deserialize(AILocoVaultBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.Vault, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.DistanceBeforeVault, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.HeightBeforeVault, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.LengthOfVaultableObject, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.HeightAfterVault, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.DistanceAfterVault, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.VaultType, p_Reader, p_Parser);
		}
	}
}
