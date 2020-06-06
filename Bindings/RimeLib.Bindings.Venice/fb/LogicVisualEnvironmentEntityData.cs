///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class LogicVisualEnvironmentEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<VisualEnvironmentBlueprint> VisualEnvironment { get; set; } = new CtrRef<VisualEnvironmentBlueprint>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Visibility { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1724714788:
					VisualEnvironment = (CtrRef<VisualEnvironmentBlueprint>) p_Value;
					break;

				case 1708270083:
					Visibility = (float) p_Value;
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
				case 1724714788:
					return VisualEnvironment;

				case 1708270083:
					return Visibility;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1724714788:
					return typeof(LogicVisualEnvironmentEntityData).GetProperty(nameof(VisualEnvironment));

				case 1708270083:
					return typeof(LogicVisualEnvironmentEntityData).GetProperty(nameof(Visibility));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
