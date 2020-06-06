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
	public class PointSystemParamsAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MultiKillTimeLimit { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float DnfTimeout { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint KillStreakX { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint NemesisKillX { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float FreefallHeight { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3857154606:
					MultiKillTimeLimit = (float) p_Value;
					break;

				case 478606706:
					DnfTimeout = (float) p_Value;
					break;

				case 2976281157:
					KillStreakX = (uint) p_Value;
					break;

				case 2569054453:
					NemesisKillX = (uint) p_Value;
					break;

				case 1685675721:
					FreefallHeight = (float) p_Value;
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
				case 3857154606:
					return MultiKillTimeLimit;

				case 478606706:
					return DnfTimeout;

				case 2976281157:
					return KillStreakX;

				case 2569054453:
					return NemesisKillX;

				case 1685675721:
					return FreefallHeight;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3857154606:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(MultiKillTimeLimit));

				case 478606706:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(DnfTimeout));

				case 2976281157:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(KillStreakX));

				case 2569054453:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(NemesisKillX));

				case 1685675721:
					return typeof(PointSystemParamsAsset).GetProperty(nameof(FreefallHeight));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
