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
	[ContainerType(4, 36)]
	public class UIQueuedEventsCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float InitialQueueDelay { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool ShowUnlocksBecomingAvailable { get; set; }

		public static void Deserialize(UIQueuedEventsCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.InitialQueueDelay = p_Reader.ReadSingle();
			p_Instance.ShowUnlocksBecomingAvailable = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
