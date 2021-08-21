///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
	public enum AntAttentionStateEnum : int
	{
		AntAttentionStateEnum_Relaxed = 0,
		AntAttentionStateEnum_Ready = 1,
		AntAttentionStateEnum_Combat = 2,
		AntAttentionStateEnum_Evasive = 3,
		AntAttentionStateEnum_AntEnumCount = 4,
		AntAttentionStateEnum_NoChange = 5,
		AntAttentionStateEnum_Count = 6,
		AntAttentionStateEnum_Dummy1 = 7
	}

}
