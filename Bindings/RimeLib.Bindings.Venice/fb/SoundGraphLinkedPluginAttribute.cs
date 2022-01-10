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
	public class SoundGraphLinkedPluginAttribute
	{
		[ContainerField(0)]
		public SoundGraphPluginRef Plugin { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<AudioGraphNodeData> Node { get; set; } = new();
		
		[ContainerField(8)]
		public AudioGraphNodePort Port { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public sbyte AttributeIndex { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool AllowExtremeValues { get; set; }
		
		public static void Deserialize(SoundGraphLinkedPluginAttribute p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.SoundGraphPluginRef.Deserialize(p_Instance.Plugin, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.Node.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(1, SeekOrigin.Current);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Port, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.AttributeIndex = p_Reader.ReadSByte();
			p_Reader.Seek(1, SeekOrigin.Current);
			p_Instance.AllowExtremeValues = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
