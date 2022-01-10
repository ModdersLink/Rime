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
	[ContainerType(4, 28)]
	public class VoiceOverDialogClip : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Offset { get; set; }

		[ContainerField(12)]
		public List<VoiceOverDialogTake> Takes { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<VoiceOverDialogClip>> OffsetReferences { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<VoiceOverDialogClipEvents> Events { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public sbyte SequenceIndex { get; set; }

		public static void Deserialize(VoiceOverDialogClip p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Offset = p_Reader.ReadSingle();
			p_Instance.Takes.Clear();
			(RimeReader Reader, uint Count) s_Takes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Takes.Count; ++i)
			{
				var s_Value = new VoiceOverDialogTake();
				fb.VoiceOverDialogTake.Deserialize(s_Value, s_Takes.Reader, p_Parser);
				p_Instance.Takes.Add(s_Value);
			}
			
			s_Takes.Reader.Dispose();
			p_Instance.OffsetReferences.Clear();
			(RimeReader Reader, uint Count) s_OffsetReferences = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OffsetReferences.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverDialogClip>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_OffsetReferences.Reader.ReadUInt32()));
				p_Instance.OffsetReferences.Add(s_CtrRef);
			}
			
			s_OffsetReferences.Reader.Dispose();
			p_Instance.Events.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SequenceIndex = p_Reader.ReadSByte();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
