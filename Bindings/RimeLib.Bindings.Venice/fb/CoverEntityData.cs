///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class CoverEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public float Width { get; set; } // 0x50 (80)
		
		[ContainerField(84)]
		public CoverType CoverType { get; set; } = new CoverType(); // 0x54 (84)
		
		[ContainerField(88)]
		public List<CoverSlot> Slots { get; set; } = new List<CoverSlot>(); // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public bool RightEdgeBlocked { get; set; } // 0x5C (92)
		
		[ContainerField(93), LayoutImmutable, Blittable]
		public bool TopBlocked { get; set; } // 0x5D (93)
		
		[ContainerField(94), LayoutImmutable, Blittable]
		public bool LeftEdgeBlocked { get; set; } // 0x5E (94)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 226981187:
					Width = (float) p_Value;
					break;

				case 2741637520:
					CoverType = (CoverType) Enum.ToObject(typeof(CoverType), p_Value);
					break;

				case 231607282:
					Slots = (List<CoverSlot>) p_Value;
					break;

				case 1465616558:
					RightEdgeBlocked = (bool) p_Value;
					break;

				case 121893062:
					TopBlocked = (bool) p_Value;
					break;

				case 1700814261:
					LeftEdgeBlocked = (bool) p_Value;
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
				case 226981187:
					return Width;

				case 2741637520:
					return CoverType;

				case 231607282:
					return Slots;

				case 1465616558:
					return RightEdgeBlocked;

				case 121893062:
					return TopBlocked;

				case 1700814261:
					return LeftEdgeBlocked;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 226981187:
					return typeof(CoverEntityData).GetProperty(nameof(Width));

				case 2741637520:
					return typeof(CoverEntityData).GetProperty(nameof(CoverType));

				case 231607282:
					return typeof(CoverEntityData).GetProperty(nameof(Slots));

				case 1465616558:
					return typeof(CoverEntityData).GetProperty(nameof(RightEdgeBlocked));

				case 121893062:
					return typeof(CoverEntityData).GetProperty(nameof(TopBlocked));

				case 1700814261:
					return typeof(CoverEntityData).GetProperty(nameof(LeftEdgeBlocked));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
