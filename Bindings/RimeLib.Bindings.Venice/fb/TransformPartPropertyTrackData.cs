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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(44), ContainerClass]
	public class TransformPartPropertyTrackData : 
		PropertyTrackData
	{
		protected TransformPart m_TransformPart = new TransformPart();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(3623005534)]
		public TransformPart TransformPart { get { return m_TransformPart; } set { if (OnPropertyChanging("TransformPartPropertyTrackData." + nameof(TransformPart), this, m_TransformPart, value)) m_TransformPart = value; } } // 0x10 (16)
		
		protected CurveInfinityType m_PreInfinity = new CurveInfinityType();
		[ContainerField(20), MemberInfoFlag(137), ContainerFieldNameHash(887592928)]
		public CurveInfinityType PreInfinity { get { return m_PreInfinity; } set { if (OnPropertyChanging("TransformPartPropertyTrackData." + nameof(PreInfinity), this, m_PreInfinity, value)) m_PreInfinity = value; } } // 0x14 (20)
		
		protected CurveInfinityType m_PostInfinity = new CurveInfinityType();
		[ContainerField(24), MemberInfoFlag(137), ContainerFieldNameHash(1471303071)]
		public CurveInfinityType PostInfinity { get { return m_PostInfinity; } set { if (OnPropertyChanging("TransformPartPropertyTrackData." + nameof(PostInfinity), this, m_PostInfinity, value)) m_PostInfinity = value; } } // 0x18 (24)
		
		protected uint m_KeyStartIndex = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(331027820)]
		public uint KeyStartIndex { get { return m_KeyStartIndex; } set { if (OnPropertyChanging("TransformPartPropertyTrackData." + nameof(KeyStartIndex), this, m_KeyStartIndex, value)) m_KeyStartIndex = value; } } // 0x1C (28)
		
		protected string m_ResourceName = string.Empty;
		[ContainerField(32), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2980323592)]
		public string ResourceName { get { return m_ResourceName; } set { if (OnPropertyChanging("TransformPartPropertyTrackData." + nameof(ResourceName), this, m_ResourceName, value)) m_ResourceName = value; } } // 0x20 (32)
		
		protected uint m_KeyCount = new uint();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4061186033)]
		public uint KeyCount { get { return m_KeyCount; } set { if (OnPropertyChanging("TransformPartPropertyTrackData." + nameof(KeyCount), this, m_KeyCount, value)) m_KeyCount = value; } } // 0x24 (36)
		
		protected bool m_Weighted = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(222605828)]
		public bool Weighted { get { return m_Weighted; } set { if (OnPropertyChanging("TransformPartPropertyTrackData." + nameof(Weighted), this, m_Weighted, value)) m_Weighted = value; } } // 0x28 (40)
		
		protected bool m_IsStatic = new bool();
		[ContainerField(41), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(471816263)]
		public bool IsStatic { get { return m_IsStatic; } set { if (OnPropertyChanging("TransformPartPropertyTrackData." + nameof(IsStatic), this, m_IsStatic, value)) m_IsStatic = value; } } // 0x29 (41)
		
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
