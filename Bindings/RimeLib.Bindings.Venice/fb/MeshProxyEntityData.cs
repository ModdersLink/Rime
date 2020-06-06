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
    [ContainerType(16)]
	public class MeshProxyEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x50 (80)
		
		[ContainerField(84)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new List<LinearTransform>(); // 0x54 (84)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 2949884966:
					BasePoseTransforms = (List<LinearTransform>) p_Value;
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
				case 2088783990:
					return Mesh;

				case 2949884966:
					return BasePoseTransforms;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088783990:
					return typeof(MeshProxyEntityData).GetProperty(nameof(Mesh));

				case 2949884966:
					return typeof(MeshProxyEntityData).GetProperty(nameof(BasePoseTransforms));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
