///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 24)]
	public class VoiceOverArithmeticNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> A { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValueConnection> B { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverValue> Result { get; set; } = new();

		[ContainerField(20)]
		public VoiceOverArithmeticExpressionType Operation { get; set; } = new();

		public static void Deserialize(VoiceOverArithmeticNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.A.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.B.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Result.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Operation = (VoiceOverArithmeticExpressionType) p_Reader.ReadInt32();
		}

	}
}
