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

namespace fb
{
	[ContainerType(4, 48)]
	public class BinaryLogicNode :
		UINodeData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<UINodePort> True { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<UINodePort> False { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public UIDataSourceInfo DataSourceInfo { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(In));
			p_Writer.Write(p_EbxWriter.WriteImport(True));
			p_Writer.Write(p_EbxWriter.WriteImport(False));
			DataSourceInfo.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
