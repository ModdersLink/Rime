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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[MemberInfoFlag(137), ContainerSize(4), ContainerEnum]
	public enum MinimapIconInteractionConcept : int
	{
		MinimapIconInteractionConcept_None = 0,
		MinimapIconInteractionConcept_SelectSpawnPoint = 1,
		MinimapIconInteractionConcept_RemoveOrder = 2,
		MinimapIconInteractionConcept_AttackDefendCapturePoint = 3
	}

}
