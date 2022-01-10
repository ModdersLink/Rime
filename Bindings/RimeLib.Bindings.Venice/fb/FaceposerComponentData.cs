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
	[ContainerType(16, 128)]
	public class FaceposerComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public AntRef FacePoserEnabled { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float LodDistance { get; set; }

		[ContainerField(104)]
		public AntRef FacePoseLibraryReference { get; set; } = new();

		[ContainerField(108)]
		public List<AntRef> FacePoseLibrary { get; set; } = new();

		[ContainerField(112), LayoutImmutable]
		public string FacePoserDofSetName { get; set; } = string.Empty;

		[ContainerField(116)]
		public List<string> ShaderExposedValues { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public int FacePoseLibraryIndex { get; set; }

		public static void Deserialize(FaceposerComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.FacePoserEnabled, p_Reader, p_Parser);
			p_Instance.LodDistance = p_Reader.ReadSingle();
			fb.AntRef.Deserialize(p_Instance.FacePoseLibraryReference, p_Reader, p_Parser);
			p_Instance.FacePoseLibrary.Clear();
			(RimeReader Reader, uint Count) s_FacePoseLibrary = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_FacePoseLibrary.Count; ++i)
			{
				var s_Value = new AntRef();
				fb.AntRef.Deserialize(s_Value, s_FacePoseLibrary.Reader, p_Parser);
				p_Instance.FacePoseLibrary.Add(s_Value);
			}
			
			s_FacePoseLibrary.Reader.Dispose();
			p_Instance.FacePoserDofSetName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ShaderExposedValues.Clear();
			(RimeReader Reader, uint Count) s_ShaderExposedValues = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ShaderExposedValues.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_ShaderExposedValues.Reader.ReadUInt32());
				p_Instance.ShaderExposedValues.Add(s_Value);
			}
			
			s_ShaderExposedValues.Reader.Dispose();
			p_Instance.FacePoseLibraryIndex = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
