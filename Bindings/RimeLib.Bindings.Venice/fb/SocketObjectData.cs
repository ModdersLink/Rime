///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SocketObjectData : 
		SocketObjectDataBase
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public GUID Asset1pGuid { get; set; } // 0x8 (8)
		
		[ContainerField(24)]
		public List<GUID> Variation1pGuids { get; set; } = new List<GUID>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public GUID Asset1pZoomGuid { get; set; } // 0x1C (28)
		
		[ContainerField(44)]
		public List<GUID> Variation1pZoomGuids { get; set; } = new List<GUID>(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public GUID Asset3pGuid { get; set; } // 0x30 (48)
		
		[ContainerField(64)]
		public List<GUID> Variation3pGuids { get; set; } = new List<GUID>(); // 0x40 (64)
		
		[ContainerField(68)]
		public RefArray<CustomizedMaterialData> CustomizedMaterials { get; set; } = new RefArray<CustomizedMaterialData>(); // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229660779:
					Asset1pGuid = (GUID) p_Value;
					break;

				case 2848287545:
					Variation1pGuids = (List<GUID>) p_Value;
					break;

				case 1108630652:
					Asset1pZoomGuid = (GUID) p_Value;
					break;

				case 2457058062:
					Variation1pZoomGuids = (List<GUID>) p_Value;
					break;

				case 156129193:
					Asset3pGuid = (GUID) p_Value;
					break;

				case 412553787:
					Variation3pGuids = (List<GUID>) p_Value;
					break;

				case 474428220:
					CustomizedMaterials = (RefArray<CustomizedMaterialData>) p_Value;
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
				case 229660779:
					return Asset1pGuid;

				case 2848287545:
					return Variation1pGuids;

				case 1108630652:
					return Asset1pZoomGuid;

				case 2457058062:
					return Variation1pZoomGuids;

				case 156129193:
					return Asset3pGuid;

				case 412553787:
					return Variation3pGuids;

				case 474428220:
					return CustomizedMaterials;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229660779:
					return typeof(SocketObjectData).GetProperty(nameof(Asset1pGuid));

				case 2848287545:
					return typeof(SocketObjectData).GetProperty(nameof(Variation1pGuids));

				case 1108630652:
					return typeof(SocketObjectData).GetProperty(nameof(Asset1pZoomGuid));

				case 2457058062:
					return typeof(SocketObjectData).GetProperty(nameof(Variation1pZoomGuids));

				case 156129193:
					return typeof(SocketObjectData).GetProperty(nameof(Asset3pGuid));

				case 412553787:
					return typeof(SocketObjectData).GetProperty(nameof(Variation3pGuids));

				case 474428220:
					return typeof(SocketObjectData).GetProperty(nameof(CustomizedMaterials));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
