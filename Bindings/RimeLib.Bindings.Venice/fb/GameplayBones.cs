///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum GameplayBones : int
	{
		GameplayBones_UndefinedBone = 0,
		GameplayBones_HeadBone = 1,
		GameplayBones_AimBone = 2,
		GameplayBones_RootBone = 3,
		GameplayBones_WeaponBone = 4,
		GameplayBones_ConnectBone = 5,
		GameplayBones_RootMeshBone = 6,
		GameplayBones_MagazineBone = 7,
		GameplayBones_Count = 8
	}

}
