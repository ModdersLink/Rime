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
	[ContainerType(4, 20)]
	public partial class UINodeData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _Name = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<UIGraphAsset> _ParentGraph = new();

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private bool _IsRootNode;

		[ObservableProperty]
		[property: ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		private bool _ParentIsScreen;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteImport(ParentGraph));
			p_Writer.Write(IsRootNode);
			p_Writer.Write(ParentIsScreen);
			p_Writer.WriteNullBytes(2);
		}
	}
}
