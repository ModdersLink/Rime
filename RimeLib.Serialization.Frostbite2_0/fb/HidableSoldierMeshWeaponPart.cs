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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 16)]
	public partial class HidableSoldierMeshWeaponPart :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private CtrRef<SkinnedMeshAsset> _WeaponMesh = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private CtrRef<ObjectBlueprint> _WeaponMeshBlueprint = new();
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _BoneName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private bool _HideAlways;
		
		[ObservableProperty]
		[property: ContainerField(13), LayoutImmutable, Blittable, JsonProperty(Order = 13)]
		private bool _HideInVehicleEntries;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponMesh));
			p_Writer.Write(p_EbxWriter.WriteImport(WeaponMeshBlueprint));
			p_Writer.Write(p_EbxWriter.WriteString(BoneName));
			p_Writer.Write(HideAlways);
			p_Writer.Write(HideInVehicleEntries);
			p_Writer.WriteNullBytes(2);
		}
	}
}
