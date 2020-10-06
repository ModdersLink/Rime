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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(160), ContainerClass]
	public class TonemapComponentData : 
		ComponentData
	{
		protected Vec3 m_BloomScale = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(4088580734)]
		public Vec3 BloomScale { get { return m_BloomScale; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(BloomScale), this, m_BloomScale, value)) m_BloomScale = value; } } // 0x60 (96)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(112), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x70 (112)
		
		protected TonemapMethod m_TonemapMethod = new TonemapMethod();
		[ContainerField(116), MemberInfoFlag(137), ContainerFieldNameHash(3755826422)]
		public TonemapMethod TonemapMethod { get { return m_TonemapMethod; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(TonemapMethod), this, m_TonemapMethod, value)) m_TonemapMethod = value; } } // 0x74 (116)
		
		protected float m_MinExposure = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1485398908)]
		public float MinExposure { get { return m_MinExposure; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(MinExposure), this, m_MinExposure, value)) m_MinExposure = value; } } // 0x78 (120)
		
		protected float m_MiddleGray = new float();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3985215205)]
		public float MiddleGray { get { return m_MiddleGray; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(MiddleGray), this, m_MiddleGray, value)) m_MiddleGray = value; } } // 0x7C (124)
		
		protected float m_ExposureAdjustTime = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(219629342)]
		public float ExposureAdjustTime { get { return m_ExposureAdjustTime; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(ExposureAdjustTime), this, m_ExposureAdjustTime, value)) m_ExposureAdjustTime = value; } } // 0x80 (128)
		
		protected float m_MaxExposure = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1313706850)]
		public float MaxExposure { get { return m_MaxExposure; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(MaxExposure), this, m_MaxExposure, value)) m_MaxExposure = value; } } // 0x84 (132)
		
		protected float m_ChromostereopsisOffset = new float();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2469845791)]
		public float ChromostereopsisOffset { get { return m_ChromostereopsisOffset; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(ChromostereopsisOffset), this, m_ChromostereopsisOffset, value)) m_ChromostereopsisOffset = value; } } // 0x88 (136)
		
		protected float m_ChromostereopsisScale = new float();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(952871242)]
		public float ChromostereopsisScale { get { return m_ChromostereopsisScale; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(ChromostereopsisScale), this, m_ChromostereopsisScale, value)) m_ChromostereopsisScale = value; } } // 0x8C (140)
		
		protected bool m_ChromostereopsisEnable = new bool();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2087966035)]
		public bool ChromostereopsisEnable { get { return m_ChromostereopsisEnable; } set { if (OnPropertyChanging("TonemapComponentData." + nameof(ChromostereopsisEnable), this, m_ChromostereopsisEnable, value)) m_ChromostereopsisEnable = value; } } // 0x90 (144)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4088580734:
					BloomScale = (Vec3) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3755826422:
					TonemapMethod = (TonemapMethod) Enum.ToObject(typeof(TonemapMethod), p_Value);
					break;

				case 1485398908:
					MinExposure = (float) p_Value;
					break;

				case 3985215205:
					MiddleGray = (float) p_Value;
					break;

				case 219629342:
					ExposureAdjustTime = (float) p_Value;
					break;

				case 1313706850:
					MaxExposure = (float) p_Value;
					break;

				case 2469845791:
					ChromostereopsisOffset = (float) p_Value;
					break;

				case 952871242:
					ChromostereopsisScale = (float) p_Value;
					break;

				case 2087966035:
					ChromostereopsisEnable = (bool) p_Value;
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
				case 4088580734:
					return BloomScale;

				case 229961746:
					return Realm;

				case 3755826422:
					return TonemapMethod;

				case 1485398908:
					return MinExposure;

				case 3985215205:
					return MiddleGray;

				case 219629342:
					return ExposureAdjustTime;

				case 1313706850:
					return MaxExposure;

				case 2469845791:
					return ChromostereopsisOffset;

				case 952871242:
					return ChromostereopsisScale;

				case 2087966035:
					return ChromostereopsisEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4088580734:
					return typeof(TonemapComponentData).GetProperty(nameof(BloomScale));

				case 229961746:
					return typeof(TonemapComponentData).GetProperty(nameof(Realm));

				case 3755826422:
					return typeof(TonemapComponentData).GetProperty(nameof(TonemapMethod));

				case 1485398908:
					return typeof(TonemapComponentData).GetProperty(nameof(MinExposure));

				case 3985215205:
					return typeof(TonemapComponentData).GetProperty(nameof(MiddleGray));

				case 219629342:
					return typeof(TonemapComponentData).GetProperty(nameof(ExposureAdjustTime));

				case 1313706850:
					return typeof(TonemapComponentData).GetProperty(nameof(MaxExposure));

				case 2469845791:
					return typeof(TonemapComponentData).GetProperty(nameof(ChromostereopsisOffset));

				case 952871242:
					return typeof(TonemapComponentData).GetProperty(nameof(ChromostereopsisScale));

				case 2087966035:
					return typeof(TonemapComponentData).GetProperty(nameof(ChromostereopsisEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
