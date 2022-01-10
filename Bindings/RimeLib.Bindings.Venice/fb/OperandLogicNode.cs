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
	[ContainerType(8, 80)]
	public class OperandLogicNode : 
		UINodeData
	{
		[ContainerField(20)]
		public UIDataSourceInfo LeftDataSourceInfo { get; set; } = new();

		[ContainerField(36)]
		public UILogicOperator Operator { get; set; } = new();

		[ContainerField(40)]
		public UIDataSourceInfo RightDataSourceInfo { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public double RightLiteralOperand { get; set; }

		[ContainerField(64)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(68)]
		public CtrRef<UINodePort> True { get; set; } = new();

		[ContainerField(72)]
		public CtrRef<UINodePort> False { get; set; } = new();

		public static void Deserialize(OperandLogicNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.UIDataSourceInfo.Deserialize(p_Instance.LeftDataSourceInfo, p_Reader, p_Parser);
			p_Instance.Operator = (UILogicOperator) p_Reader.ReadInt32();
			fb.UIDataSourceInfo.Deserialize(p_Instance.RightDataSourceInfo, p_Reader, p_Parser);
			p_Instance.RightLiteralOperand = p_Reader.ReadDouble();
			p_Instance.In.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.True.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.False.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
