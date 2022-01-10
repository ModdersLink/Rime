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
	public class CameraActionData : 
		SimpleMovementActionBaseData
	{
		[ContainerField(24)]
		public CameraMovementActionMode ActionMode { get; set; } = new();

		public static void Deserialize(CameraActionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ActionMode = (CameraMovementActionMode) p_Reader.ReadInt32();
		}

	}
}
