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
	[ContainerType(4, 48)]
	public partial class ActionNode :
		UINodeData
	{
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private int _ActionKey;

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<string> _Params = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<Asset> _ActionAsset = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<UINodePort> _In = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<UINodePort> _Out = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private RefArray<UINodePort> _DataInputs = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private bool _AppendIncomingParams;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ActionKey);
			(RimeWriter Writer, uint ArrayIndex) s_Params = p_EbxWriter.GetArrayWriter(Params.GetType(), Params.Count);
			p_Writer.Write(s_Params.ArrayIndex);
			foreach (var s_Entry in Params)
			{
				s_Params.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(ActionAsset));
			p_Writer.Write(p_EbxWriter.WriteImport(In));
			p_Writer.Write(p_EbxWriter.WriteImport(Out));
			(RimeWriter Writer, uint ArrayIndex) s_DataInputs = p_EbxWriter.GetArrayWriter(DataInputs.GetType(), DataInputs.Count);
			p_Writer.Write(s_DataInputs.ArrayIndex);
			foreach (var s_Entry in DataInputs)
			{
				s_DataInputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(AppendIncomingParams);
			p_Writer.WriteNullBytes(3);
		}
	}
}
