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
	public class LogicalExpressionNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public RefArray<LogicalExpressionEntry> Inputs { get; set; } = new();

		[ContainerField(12)]
		public AudioGraphNodePort Trigger { get; set; } = new();

		[ContainerField(20)]
		public LogicalExpressionOperator Operator { get; set; } = new();

	}
}
