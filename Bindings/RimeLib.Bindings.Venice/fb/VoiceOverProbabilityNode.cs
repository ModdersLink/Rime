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
	[ContainerType(4, 20)]
	public class VoiceOverProbabilityNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValue> False { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValue> True { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float Probability { get; set; }

		public static void Deserialize(VoiceOverProbabilityNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.False.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.True.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Probability = p_Reader.ReadSingle();
		}

	}
}
