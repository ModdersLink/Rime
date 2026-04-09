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
	[ContainerType(4, 52)]
	public partial class DataSetNode :
		UINodeData
	{
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<UINodePort> _In = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<UINodePort> _Out = new();

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _Param = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private UIDataSourceInfo _DataSource = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private bool _SetToEmptyString;

		[ObservableProperty]
		[property: ContainerField(49), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
		private bool _ForceUpdate;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(In));
			p_Writer.Write(p_EbxWriter.WriteImport(Out));
			p_Writer.Write(p_EbxWriter.WriteString(Param));
			DataSource.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SetToEmptyString);
			p_Writer.Write(ForceUpdate);
			p_Writer.WriteNullBytes(2);
		}
	}
}
