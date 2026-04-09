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
	[ContainerType(4, 36)]
	public partial class VoiceOverDistanceNode :
		VoiceOverExpressionNode
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<VoiceOverValueConnection> _A = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<VoiceOverValueConnection> _B = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<VoiceOverValueConnection> _Threshold = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<VoiceOverValue> _Distance = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<VoiceOverValue> _False = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<VoiceOverValue> _True = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private VoiceOverCompareExpressionType _Operation = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(A));
			p_Writer.Write(p_EbxWriter.WriteImport(B));
			p_Writer.Write(p_EbxWriter.WriteImport(Threshold));
			p_Writer.Write(p_EbxWriter.WriteImport(Distance));
			p_Writer.Write(p_EbxWriter.WriteImport(False));
			p_Writer.Write(p_EbxWriter.WriteImport(True));
			p_Writer.Write((int) Operation);
		}
	}
}
