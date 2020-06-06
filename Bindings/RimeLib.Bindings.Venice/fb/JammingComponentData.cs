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
	public class JammingComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SmokeJammingData SmokeJamming { get; set; } = new SmokeJammingData(); // 0x60 (96)
		
		[ContainerField(116)]
		public AirMissileJammingData AirMissileJamming { get; set; } = new AirMissileJammingData(); // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1348728305:
					SmokeJamming = (SmokeJammingData) p_Value;
					break;

				case 3537349392:
					AirMissileJamming = (AirMissileJammingData) p_Value;
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
				case 1348728305:
					return SmokeJamming;

				case 3537349392:
					return AirMissileJamming;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1348728305:
					return typeof(JammingComponentData).GetProperty(nameof(SmokeJamming));

				case 3537349392:
					return typeof(JammingComponentData).GetProperty(nameof(AirMissileJamming));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
