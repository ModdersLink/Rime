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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 28)]
	public class AILocoVaultBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef Vault { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef DistanceBeforeVault { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef HeightBeforeVault { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef LengthOfVaultableObject { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef HeightAfterVault { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef DistanceAfterVault { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef VaultType { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Vault.Serialize(p_Writer, p_EbxWriter);
			DistanceBeforeVault.Serialize(p_Writer, p_EbxWriter);
			HeightBeforeVault.Serialize(p_Writer, p_EbxWriter);
			LengthOfVaultableObject.Serialize(p_Writer, p_EbxWriter);
			HeightAfterVault.Serialize(p_Writer, p_EbxWriter);
			DistanceAfterVault.Serialize(p_Writer, p_EbxWriter);
			VaultType.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
