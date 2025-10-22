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


namespace fb.Entity;

[ContainerType(1, 4)]
public enum GameplayBones : int
{
	GameplayBones_UndefinedBone = -1,
	GameplayBones_RootBone = 0,
	GameplayBones_RootMeshBone = 1,
	GameplayBones_ConnectBone = 2,
	GameplayBones_HeadBone = 3,
	GameplayBones_CameraBone = 4,
	GameplayBones_AimBone = 5,
	GameplayBones_WeaponBone = 6,
	GameplayBones_WeaponAux1Bone = 7,
	GameplayBones_LeftArmBone = 8,
	GameplayBones_Count = 9,
}

