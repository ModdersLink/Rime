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
	[ContainerType(4, 28)]
	public partial class EntitlementData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _License = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _EntitlementTag = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _GroupName = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _ProductId = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _ProjectId = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private EntitlementType _UsageType = new();
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _VerifyOwnership;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(License));
			p_Writer.Write(p_EbxWriter.WriteString(EntitlementTag));
			p_Writer.Write(p_EbxWriter.WriteString(GroupName));
			p_Writer.Write(p_EbxWriter.WriteString(ProductId));
			p_Writer.Write(p_EbxWriter.WriteString(ProjectId));
			p_Writer.Write((int) UsageType);
			p_Writer.Write(VerifyOwnership);
			p_Writer.WriteNullBytes(3);
		}
	}
}
