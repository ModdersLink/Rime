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
    [ContainerType(16)]
	public class TonemapComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BloomScale { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112)]
		public Realm Realm { get; set; } = new Realm(); // 0x70 (112)
		
		[ContainerField(116)]
		public TonemapMethod TonemapMethod { get; set; } = new TonemapMethod(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float MinExposure { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float MiddleGray { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float ExposureAdjustTime { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float MaxExposure { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float ChromostereopsisOffset { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float ChromostereopsisScale { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool ChromostereopsisEnable { get; set; } // 0x90 (144)
		
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
