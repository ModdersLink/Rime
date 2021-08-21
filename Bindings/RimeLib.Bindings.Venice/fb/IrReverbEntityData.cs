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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class IrReverbEntityData : 
		EntityData
	{
		protected CtrRef<ImpulseResponseAsset> m_ImpulseResponse = new CtrRef<ImpulseResponseAsset>();
		[ContainerField(Name: "ImpulseResponse", Offset: 12, NameHash: 182557405, Flags: 53)]
		public CtrRef<ImpulseResponseAsset> ImpulseResponse { get { return m_ImpulseResponse; } set { if (OnPropertyChanging("IrReverbEntityData." + nameof(ImpulseResponse), this, m_ImpulseResponse, value)) m_ImpulseResponse = value; } } // 0xC (12)
		
		protected float m_Gain = new float();
		[ContainerField(Name: "Gain", Offset: 16, NameHash: 2088703076, Flags: 49469), LayoutImmutable, Blittable]
		public float Gain { get { return m_Gain; } set { if (OnPropertyChanging("IrReverbEntityData." + nameof(Gain), this, m_Gain, value)) m_Gain = value; } } // 0x10 (16)
		
		protected float m_Volume = new float();
		[ContainerField(Name: "Volume", Offset: 20, NameHash: 3158011725, Flags: 49469), LayoutImmutable, Blittable]
		public float Volume { get { return m_Volume; } set { if (OnPropertyChanging("IrReverbEntityData." + nameof(Volume), this, m_Volume, value)) m_Volume = value; } } // 0x14 (20)
		
		protected FadeCurveType m_FadeCurve = new FadeCurveType();
		[ContainerField(Name: "FadeCurve", Offset: 24, NameHash: 3162123636, Flags: 137)]
		public FadeCurveType FadeCurve { get { return m_FadeCurve; } set { if (OnPropertyChanging("IrReverbEntityData." + nameof(FadeCurve), this, m_FadeCurve, value)) m_FadeCurve = value; } } // 0x18 (24)
		
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
