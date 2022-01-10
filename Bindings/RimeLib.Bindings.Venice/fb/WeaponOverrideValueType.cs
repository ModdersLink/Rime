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
	[ContainerType(4, 4)]
	public enum WeaponOverrideValueType : int
	{
		OverrideValue_BulletEntity_DistributeDamageOverTime = 0,
		OverrideValue_BulletEntity_StartDamage = 1,
		OverrideValue_BulletEntity_EndDamage = 2,
		OverrideValue_BulletEntity_DamageFalloffStartDistance = 3,
		OverrideValue_BulletEntity_DamageFalloffEndDistance = 4
	}

}
