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
	public class InterludeOrderEntityData : 
		BFOrderEntityData
	{
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool IsCutscene { get; set; } // 0x28 (40)
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool Crouch { get; set; } // 0x29 (41)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2932449315:
					IsCutscene = (bool) p_Value;
					break;

				case 2729602053:
					Crouch = (bool) p_Value;
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
				case 2932449315:
					return IsCutscene;

				case 2729602053:
					return Crouch;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2932449315:
					return typeof(InterludeOrderEntityData).GetProperty(nameof(IsCutscene));

				case 2729602053:
					return typeof(InterludeOrderEntityData).GetProperty(nameof(Crouch));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
