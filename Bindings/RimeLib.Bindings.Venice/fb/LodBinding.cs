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
	public class LodBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef DisableControllerUpdate { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef DisablePoseUpdate { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef DistanceFromCamera { get; set; } = new AntRef(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089791388:
					DisableControllerUpdate = (AntRef) p_Value;
					break;

				case 605526569:
					DisablePoseUpdate = (AntRef) p_Value;
					break;

				case 621427369:
					DistanceFromCamera = (AntRef) p_Value;
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
				case 2089791388:
					return DisableControllerUpdate;

				case 605526569:
					return DisablePoseUpdate;

				case 621427369:
					return DistanceFromCamera;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089791388:
					return typeof(LodBinding).GetProperty(nameof(DisableControllerUpdate));

				case 605526569:
					return typeof(LodBinding).GetProperty(nameof(DisablePoseUpdate));

				case 621427369:
					return typeof(LodBinding).GetProperty(nameof(DistanceFromCamera));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
