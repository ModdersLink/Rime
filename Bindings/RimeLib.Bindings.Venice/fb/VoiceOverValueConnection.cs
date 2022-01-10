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
	[ContainerType(4, 16)]
	public class VoiceOverValueConnection : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverExpressionNode> TargetNode { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValue> TargetValue { get; set; } = new();

		public static void Deserialize(VoiceOverValueConnection p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TargetNode.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TargetValue.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
