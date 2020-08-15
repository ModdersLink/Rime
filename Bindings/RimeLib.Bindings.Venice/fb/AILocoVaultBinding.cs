///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class AILocoVaultBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef Vault { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef DistanceBeforeVault { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef HeightBeforeVault { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef LengthOfVaultableObject { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
		public AntRef HeightAfterVault { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef DistanceAfterVault { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24)]
		public AntRef VaultType { get; set; } = new AntRef(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225348511:
					Vault = (AntRef) p_Value;
					break;

				case 3862494437:
					DistanceBeforeVault = (AntRef) p_Value;
					break;

				case 3431098489:
					HeightBeforeVault = (AntRef) p_Value;
					break;

				case 1652501653:
					LengthOfVaultableObject = (AntRef) p_Value;
					break;

				case 2025884548:
					HeightAfterVault = (AntRef) p_Value;
					break;

				case 1369021080:
					DistanceAfterVault = (AntRef) p_Value;
					break;

				case 4073516007:
					VaultType = (AntRef) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225348511:
					return Vault;

				case 3862494437:
					return DistanceBeforeVault;

				case 3431098489:
					return HeightBeforeVault;

				case 1652501653:
					return LengthOfVaultableObject;

				case 2025884548:
					return HeightAfterVault;

				case 1369021080:
					return DistanceAfterVault;

				case 4073516007:
					return VaultType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225348511:
					return typeof(AILocoVaultBinding).GetProperty(nameof(Vault));

				case 3862494437:
					return typeof(AILocoVaultBinding).GetProperty(nameof(DistanceBeforeVault));

				case 3431098489:
					return typeof(AILocoVaultBinding).GetProperty(nameof(HeightBeforeVault));

				case 1652501653:
					return typeof(AILocoVaultBinding).GetProperty(nameof(LengthOfVaultableObject));

				case 2025884548:
					return typeof(AILocoVaultBinding).GetProperty(nameof(HeightAfterVault));

				case 1369021080:
					return typeof(AILocoVaultBinding).GetProperty(nameof(DistanceAfterVault));

				case 4073516007:
					return typeof(AILocoVaultBinding).GetProperty(nameof(VaultType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
