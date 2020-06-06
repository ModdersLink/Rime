///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class RecoilData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MaxRecoilAngleX { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MinRecoilAngleX { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxRecoilAngleY { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinRecoilAngleY { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxRecoilAngleZ { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinRecoilAngleZ { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxRecoilFov { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinRecoilFov { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool RecoilFollowsDispersion { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1566215510:
					MaxRecoilAngleX = (float) p_Value;
					break;

				case 2010820808:
					MinRecoilAngleX = (float) p_Value;
					break;

				case 1566215511:
					MaxRecoilAngleY = (float) p_Value;
					break;

				case 2010820809:
					MinRecoilAngleY = (float) p_Value;
					break;

				case 1566215508:
					MaxRecoilAngleZ = (float) p_Value;
					break;

				case 2010820810:
					MinRecoilAngleZ = (float) p_Value;
					break;

				case 2812200304:
					MaxRecoilFov = (float) p_Value;
					break;

				case 3551417774:
					MinRecoilFov = (float) p_Value;
					break;

				case 4254392955:
					RecoilFollowsDispersion = (bool) p_Value;
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
				case 1566215510:
					return MaxRecoilAngleX;

				case 2010820808:
					return MinRecoilAngleX;

				case 1566215511:
					return MaxRecoilAngleY;

				case 2010820809:
					return MinRecoilAngleY;

				case 1566215508:
					return MaxRecoilAngleZ;

				case 2010820810:
					return MinRecoilAngleZ;

				case 2812200304:
					return MaxRecoilFov;

				case 3551417774:
					return MinRecoilFov;

				case 4254392955:
					return RecoilFollowsDispersion;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1566215510:
					return typeof(RecoilData).GetProperty(nameof(MaxRecoilAngleX));

				case 2010820808:
					return typeof(RecoilData).GetProperty(nameof(MinRecoilAngleX));

				case 1566215511:
					return typeof(RecoilData).GetProperty(nameof(MaxRecoilAngleY));

				case 2010820809:
					return typeof(RecoilData).GetProperty(nameof(MinRecoilAngleY));

				case 1566215508:
					return typeof(RecoilData).GetProperty(nameof(MaxRecoilAngleZ));

				case 2010820810:
					return typeof(RecoilData).GetProperty(nameof(MinRecoilAngleZ));

				case 2812200304:
					return typeof(RecoilData).GetProperty(nameof(MaxRecoilFov));

				case 3551417774:
					return typeof(RecoilData).GetProperty(nameof(MinRecoilFov));

				case 4254392955:
					return typeof(RecoilData).GetProperty(nameof(RecoilFollowsDispersion));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
