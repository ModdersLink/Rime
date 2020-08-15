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
	public class UIMinimapIconTextureState : FrostbiteContainer
	{
		[ContainerField(0)]
		public UIIconState State { get; set; } = new UIIconState(); // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float FrameRate { get; set; } // 0x4 (4)
		
		[ContainerField(8)]
		public List<UIMinimapIconUv> TextureInfos { get; set; } = new List<UIMinimapIconUv>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool ShouldRotate { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230748402:
						State = (UIIconState) Enum.ToObject(typeof(UIIconState), p_Value);
					break;

				case 21928954:
					FrameRate = (float) p_Value;
					break;

				case 2154121191:
					TextureInfos = (List<UIMinimapIconUv>) p_Value;
					break;

				case 1996765845:
					ShouldRotate = (bool) p_Value;
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
				case 230748402:
					return State;

				case 21928954:
					return FrameRate;

				case 2154121191:
					return TextureInfos;

				case 1996765845:
					return ShouldRotate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230748402:
					return typeof(UIMinimapIconTextureState).GetProperty(nameof(State));

				case 21928954:
					return typeof(UIMinimapIconTextureState).GetProperty(nameof(FrameRate));

				case 2154121191:
					return typeof(UIMinimapIconTextureState).GetProperty(nameof(TextureInfos));

				case 1996765845:
					return typeof(UIMinimapIconTextureState).GetProperty(nameof(ShouldRotate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
