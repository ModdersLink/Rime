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
	[ContainerType(4)]
	public class GunSwayBaseMoveData : FrostbiteContainer
	{
		[ContainerField(0)]
		public GunSwayDispersionData BaseValue { get; set; } = new GunSwayDispersionData(); // 0x0 (0)
		
		[ContainerField(16)]
		public GunSwayDispersionData Moving { get; set; } = new GunSwayDispersionData(); // 0x10 (16)
		
		[ContainerField(32)]
		public GunSwayRecoilData Recoil { get; set; } = new GunSwayRecoilData(); // 0x20 (32)
		
		[ContainerField(56)]
		public GunSwayLagData GunSwayLag { get; set; } = new GunSwayLagData(); // 0x38 (56)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1681448475:
					BaseValue = (GunSwayDispersionData) p_Value;
					break;

				case 2636043921:
					Moving = (GunSwayDispersionData) p_Value;
					break;

				case 3293845435:
					Recoil = (GunSwayRecoilData) p_Value;
					break;

				case 938474159:
					GunSwayLag = (GunSwayLagData) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1681448475:
					return BaseValue;

				case 2636043921:
					return Moving;

				case 3293845435:
					return Recoil;

				case 938474159:
					return GunSwayLag;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1681448475:
					return typeof(GunSwayBaseMoveData).GetProperty(nameof(BaseValue));

				case 2636043921:
					return typeof(GunSwayBaseMoveData).GetProperty(nameof(Moving));

				case 3293845435:
					return typeof(GunSwayBaseMoveData).GetProperty(nameof(Recoil));

				case 938474159:
					return typeof(GunSwayBaseMoveData).GetProperty(nameof(GunSwayLag));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
