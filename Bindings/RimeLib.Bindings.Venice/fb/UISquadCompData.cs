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
	[ContainerType(4, 160)]
	public class UISquadCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable]
		public string Squad15 { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string Squad32 { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable]
		public string Squad1 { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable]
		public string Squad2 { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable]
		public string Squad3 { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable]
		public string Squad4 { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable]
		public string Squad5 { get; set; } = string.Empty;

		[ContainerField(56), LayoutImmutable]
		public string Squad6 { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable]
		public string Squad7 { get; set; } = string.Empty;

		[ContainerField(64), LayoutImmutable]
		public string Squad8 { get; set; } = string.Empty;

		[ContainerField(68), LayoutImmutable]
		public string Squad9 { get; set; } = string.Empty;

		[ContainerField(72), LayoutImmutable]
		public string Squad10 { get; set; } = string.Empty;

		[ContainerField(76), LayoutImmutable]
		public string Squad11 { get; set; } = string.Empty;

		[ContainerField(80), LayoutImmutable]
		public string Squad12 { get; set; } = string.Empty;

		[ContainerField(84), LayoutImmutable]
		public string Squad13 { get; set; } = string.Empty;

		[ContainerField(88), LayoutImmutable]
		public string Squad14 { get; set; } = string.Empty;

		[ContainerField(92), LayoutImmutable]
		public string Squad16 { get; set; } = string.Empty;

		[ContainerField(96), LayoutImmutable]
		public string Squad24 { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable]
		public string Squad17 { get; set; } = string.Empty;

		[ContainerField(104), LayoutImmutable]
		public string Squad18 { get; set; } = string.Empty;

		[ContainerField(108), LayoutImmutable]
		public string Squad19 { get; set; } = string.Empty;

		[ContainerField(112), LayoutImmutable]
		public string Squad20 { get; set; } = string.Empty;

		[ContainerField(116), LayoutImmutable]
		public string Squad21 { get; set; } = string.Empty;

		[ContainerField(120), LayoutImmutable]
		public string Squad22 { get; set; } = string.Empty;

		[ContainerField(124), LayoutImmutable]
		public string Squad23 { get; set; } = string.Empty;

		[ContainerField(128), LayoutImmutable]
		public string Squad31 { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable]
		public string Squad25 { get; set; } = string.Empty;

		[ContainerField(136), LayoutImmutable]
		public string Squad26 { get; set; } = string.Empty;

		[ContainerField(140), LayoutImmutable]
		public string Squad27 { get; set; } = string.Empty;

		[ContainerField(144), LayoutImmutable]
		public string Squad28 { get; set; } = string.Empty;

		[ContainerField(148), LayoutImmutable]
		public string Squad29 { get; set; } = string.Empty;

		[ContainerField(152), LayoutImmutable]
		public string Squad30 { get; set; } = string.Empty;

		[ContainerField(156), LayoutImmutable, Blittable]
		public bool HideLocalSquadBoostData { get; set; }

		public static void Deserialize(UISquadCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Squad15 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad32 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad1 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad2 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad3 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad4 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad5 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad6 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad7 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad8 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad9 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad10 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad11 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad12 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad13 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad14 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad16 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad24 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad17 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad18 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad19 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad20 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad21 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad22 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad23 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad31 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad25 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad26 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad27 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad28 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad29 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Squad30 = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.HideLocalSquadBoostData = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
