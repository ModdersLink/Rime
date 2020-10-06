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
	public enum WeaponOverrideValueType : int
	{
		OverrideValue_BulletEntity_DistributeDamageOverTime = 0,
		OverrideValue_BulletEntity_StartDamage = 1,
		OverrideValue_BulletEntity_EndDamage = 2,
		OverrideValue_BulletEntity_DamageFalloffStartDistance = 3,
		OverrideValue_BulletEntity_DamageFalloffEndDistance = 4
	}

}
