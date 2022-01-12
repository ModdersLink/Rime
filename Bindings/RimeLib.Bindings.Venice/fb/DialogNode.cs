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
	[ContainerType(4, 60)]
	public class DialogNode : 
		StateNode
	{
		[ContainerField(48), LayoutImmutable]
		public string DialogTitle { get; set; } = string.Empty;

		[ContainerField(52), LayoutImmutable]
		public string DialogText { get; set; } = string.Empty;

		[ContainerField(56)]
		public List<UIPopupButton> Buttons { get; set; } = new();

	}
}
