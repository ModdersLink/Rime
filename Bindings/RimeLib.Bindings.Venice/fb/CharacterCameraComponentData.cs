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
	[ContainerType(16, 112)]
	public class CharacterCameraComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<CtrRef<TargetCameraData>> Cameras { get; set; } = new();

		[ContainerField(100), LayoutImmutable]
		public string CameraBoneName { get; set; } = string.Empty;

		public static void Deserialize(CharacterCameraComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Cameras.Clear();
			(RimeReader Reader, uint Count) s_Cameras = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Cameras.Count; ++i)
			{
				var s_CtrRef = new CtrRef<TargetCameraData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Cameras.Reader.ReadUInt32()));
				p_Instance.Cameras.Add(s_CtrRef);
			}
			
			s_Cameras.Reader.Dispose();
			p_Instance.CameraBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
