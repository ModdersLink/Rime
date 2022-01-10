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
	[ContainerType(4, 48)]
	public class ActionNode : 
		UINodeData
	{
		[ContainerField(20), LayoutImmutable, Blittable]
		public int ActionKey { get; set; }

		[ContainerField(24)]
		public List<string> Params { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<Asset> ActionAsset { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<UINodePort> Out { get; set; } = new();

		[ContainerField(40)]
		public List<CtrRef<UINodePort>> DataInputs { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool AppendIncomingParams { get; set; }

		public static void Deserialize(ActionNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ActionKey = p_Reader.ReadInt32();
			p_Instance.Params.Clear();
			(RimeReader Reader, uint Count) s_Params = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Params.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Params.Reader.ReadUInt32());
				p_Instance.Params.Add(s_Value);
			}
			
			s_Params.Reader.Dispose();
			p_Instance.ActionAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.In.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Out.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DataInputs.Clear();
			(RimeReader Reader, uint Count) s_DataInputs = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DataInputs.Count; ++i)
			{
				var s_CtrRef = new CtrRef<UINodePort>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_DataInputs.Reader.ReadUInt32()));
				p_Instance.DataInputs.Add(s_CtrRef);
			}
			
			s_DataInputs.Reader.Dispose();
			p_Instance.AppendIncomingParams = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
