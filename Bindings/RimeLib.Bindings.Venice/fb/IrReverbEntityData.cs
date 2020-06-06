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
	public class IrReverbEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<ImpulseResponseAsset> ImpulseResponse { get; set; } = new CtrRef<ImpulseResponseAsset>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Gain { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Volume { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public FadeCurveType FadeCurve { get; set; } = new FadeCurveType(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 182557405:
					ImpulseResponse = (CtrRef<ImpulseResponseAsset>) p_Value;
					break;

				case 2088703076:
					Gain = (float) p_Value;
					break;

				case 3158011725:
					Volume = (float) p_Value;
					break;

				case 3162123636:
					FadeCurve = (FadeCurveType) Enum.ToObject(typeof(FadeCurveType), p_Value);
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
				case 182557405:
					return ImpulseResponse;

				case 2088703076:
					return Gain;

				case 3158011725:
					return Volume;

				case 3162123636:
					return FadeCurve;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 182557405:
					return typeof(IrReverbEntityData).GetProperty(nameof(ImpulseResponse));

				case 2088703076:
					return typeof(IrReverbEntityData).GetProperty(nameof(Gain));

				case 3158011725:
					return typeof(IrReverbEntityData).GetProperty(nameof(Volume));

				case 3162123636:
					return typeof(IrReverbEntityData).GetProperty(nameof(FadeCurve));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
