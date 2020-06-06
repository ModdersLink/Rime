///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VisualEnvironmentEffectEntityData : 
		EffectEntityData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 LifetimeCurve { get; set; } = new Vec4(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 CullDistanceCurve { get; set; } = new Vec4(); // 0x80 (128)
		
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 CullAngleCurve { get; set; } = new Vec4(); // 0x90 (144)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float Lifetime { get; set; } // 0xA0 (160)
		
		[ContainerField(164)]
		public CtrRef<VisualEnvironmentBlueprint> VisualEnvironment { get; set; } = new CtrRef<VisualEnvironmentBlueprint>(); // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public bool SampleOnStartOnly { get; set; } // 0xA8 (168)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1623248993:
					LifetimeCurve = (Vec4) p_Value;
					break;

				case 3239208743:
					CullDistanceCurve = (Vec4) p_Value;
					break;

				case 3589421957:
					CullAngleCurve = (Vec4) p_Value;
					break;

				case 2450521238:
					Lifetime = (float) p_Value;
					break;

				case 1724714788:
					VisualEnvironment = (CtrRef<VisualEnvironmentBlueprint>) p_Value;
					break;

				case 3530277558:
					SampleOnStartOnly = (bool) p_Value;
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
				case 1623248993:
					return LifetimeCurve;

				case 3239208743:
					return CullDistanceCurve;

				case 3589421957:
					return CullAngleCurve;

				case 2450521238:
					return Lifetime;

				case 1724714788:
					return VisualEnvironment;

				case 3530277558:
					return SampleOnStartOnly;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1623248993:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(LifetimeCurve));

				case 3239208743:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(CullDistanceCurve));

				case 3589421957:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(CullAngleCurve));

				case 2450521238:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(Lifetime));

				case 1724714788:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(VisualEnvironment));

				case 3530277558:
					return typeof(VisualEnvironmentEffectEntityData).GetProperty(nameof(SampleOnStartOnly));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
