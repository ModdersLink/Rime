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
	[ContainerType(16), MemberInfoFlag(41), ContainerStruct]
	public class VehicleHudData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec3 CustomizationOffset { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<VehicleCustomizationAsset> Customization { get; set; } = new CtrRef<VehicleCustomizationAsset>(); // 0x10 (16)
		
		[ContainerField(20), MemberInfoFlag(137)]
		public UIHudIcon MinimapIcon { get; set; } = new UIHudIcon(); // 0x14 (20)
		
		[ContainerField(24), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<TextureAsset> Texture { get; set; } = new CtrRef<TextureAsset>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint VehicleItemHash { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2069977717:
					CustomizationOffset = (Vec3) p_Value;
					break;

				case 1998291608:
					Customization = (CtrRef<VehicleCustomizationAsset>) p_Value;
					break;

				case 1721945905:
						MinimapIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 3185041626:
					Texture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 1208512666:
					VehicleItemHash = (uint) p_Value;
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
				case 2069977717:
					return CustomizationOffset;

				case 1998291608:
					return Customization;

				case 1721945905:
					return MinimapIcon;

				case 3185041626:
					return Texture;

				case 1208512666:
					return VehicleItemHash;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2069977717:
					return typeof(VehicleHudData).GetProperty(nameof(CustomizationOffset));

				case 1998291608:
					return typeof(VehicleHudData).GetProperty(nameof(Customization));

				case 1721945905:
					return typeof(VehicleHudData).GetProperty(nameof(MinimapIcon));

				case 3185041626:
					return typeof(VehicleHudData).GetProperty(nameof(Texture));

				case 1208512666:
					return typeof(VehicleHudData).GetProperty(nameof(VehicleItemHash));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
