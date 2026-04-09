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
	[ContainerType(4, 24)]
	public partial class VoiceOverArithmeticNode :
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
		private CtrRef<VoiceOverValue> _Result = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private VoiceOverArithmeticExpressionType _Operation = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(A));
			p_Writer.Write(p_EbxWriter.WriteImport(B));
			p_Writer.Write(p_EbxWriter.WriteImport(Result));
			p_Writer.Write((int) Operation);
		}
	}
}
