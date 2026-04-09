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
	[ContainerType(16, 224)]
	public partial class SoldierEntryComponentData :
		EntryComponentData
	{
		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private AimingConstraintsData _AimingConstraints = new();

		[ObservableProperty]
		[property: ContainerField(208), JsonProperty(Order = 208)]
		private CtrRef<AntEnumeration> _AntEntryEnumeration = new();

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private bool _AlignConstraintsToEntity;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AimingConstraints.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(AntEntryEnumeration));
			p_Writer.Write(AlignConstraintsToEntity);
			p_Writer.WriteNullBytes(11);
		}
	}
}
