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
	public class FPSCameraData : 
		TargetCameraData
	{
		[ContainerField(160)]
		public TurnEffectData TurnEffectSettings { get; set; } = new TurnEffectData(); // 0xA0 (160)
		
		[ContainerField(192)]
		public BlurEffectData BlurEffectSettings { get; set; } = new BlurEffectData(); // 0xC0 (192)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float FOV { get; set; } // 0xD8 (216)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 76337482:
					TurnEffectSettings = (TurnEffectData) p_Value;
					break;

				case 2488763390:
					BlurEffectSettings = (BlurEffectData) p_Value;
					break;

				case 193442778:
					FOV = (float) p_Value;
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
				case 76337482:
					return TurnEffectSettings;

				case 2488763390:
					return BlurEffectSettings;

				case 193442778:
					return FOV;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 76337482:
					return typeof(FPSCameraData).GetProperty(nameof(TurnEffectSettings));

				case 2488763390:
					return typeof(FPSCameraData).GetProperty(nameof(BlurEffectSettings));

				case 193442778:
					return typeof(FPSCameraData).GetProperty(nameof(FOV));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
