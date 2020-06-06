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
	public class LensFlareComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<LensFlareEntityData> LensFlare { get; set; } = new CtrRef<LensFlareEntityData>(); // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 890070093:
					LensFlare = (CtrRef<LensFlareEntityData>) p_Value;
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
				case 890070093:
					return LensFlare;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 890070093:
					return typeof(LensFlareComponentData).GetProperty(nameof(LensFlare));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
