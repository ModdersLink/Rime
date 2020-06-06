///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class TransformPartPropertyTrackData : 
		PropertyTrackData
	{
		[ContainerField(16)]
		public TransformPart TransformPart { get; set; } = new TransformPart(); // 0x10 (16)
		
		[ContainerField(20)]
		public CurveInfinityType PreInfinity { get; set; } = new CurveInfinityType(); // 0x14 (20)
		
		[ContainerField(24)]
		public CurveInfinityType PostInfinity { get; set; } = new CurveInfinityType(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint KeyStartIndex { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable]
		public string ResourceName { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint KeyCount { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool Weighted { get; set; } // 0x28 (40)
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool IsStatic { get; set; } // 0x29 (41)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3623005534:
					TransformPart = (TransformPart) Enum.ToObject(typeof(TransformPart), p_Value);
					break;

				case 887592928:
					PreInfinity = (CurveInfinityType) Enum.ToObject(typeof(CurveInfinityType), p_Value);
					break;

				case 1471303071:
					PostInfinity = (CurveInfinityType) Enum.ToObject(typeof(CurveInfinityType), p_Value);
					break;

				case 331027820:
					KeyStartIndex = (uint) p_Value;
					break;

				case 2980323592:
					ResourceName = (string) p_Value;
					break;

				case 4061186033:
					KeyCount = (uint) p_Value;
					break;

				case 222605828:
					Weighted = (bool) p_Value;
					break;

				case 471816263:
					IsStatic = (bool) p_Value;
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
				case 3623005534:
					return TransformPart;

				case 887592928:
					return PreInfinity;

				case 1471303071:
					return PostInfinity;

				case 331027820:
					return KeyStartIndex;

				case 2980323592:
					return ResourceName;

				case 4061186033:
					return KeyCount;

				case 222605828:
					return Weighted;

				case 471816263:
					return IsStatic;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3623005534:
					return typeof(TransformPartPropertyTrackData).GetProperty(nameof(TransformPart));

				case 887592928:
					return typeof(TransformPartPropertyTrackData).GetProperty(nameof(PreInfinity));

				case 1471303071:
					return typeof(TransformPartPropertyTrackData).GetProperty(nameof(PostInfinity));

				case 331027820:
					return typeof(TransformPartPropertyTrackData).GetProperty(nameof(KeyStartIndex));

				case 2980323592:
					return typeof(TransformPartPropertyTrackData).GetProperty(nameof(ResourceName));

				case 4061186033:
					return typeof(TransformPartPropertyTrackData).GetProperty(nameof(KeyCount));

				case 222605828:
					return typeof(TransformPartPropertyTrackData).GetProperty(nameof(Weighted));

				case 471816263:
					return typeof(TransformPartPropertyTrackData).GetProperty(nameof(IsStatic));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
