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
	public partial class DataField :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _Value = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private CtrRef<DataContainer> _ValueRef = new();
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private int _Id;
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private FieldAccessType _AccessType = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Value));
			p_Writer.Write(p_EbxWriter.WriteImport(ValueRef));
			p_Writer.Write(Id);
			p_Writer.Write((int) AccessType);
		}
	}
}
