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
	public class EdgeModelComponentData : 
		DestructionEdgeModelComponentData
	{
		[ContainerField(96)]
		public RefArray<RigidMeshAsset> RigidMeshes { get; set; } = new RefArray<RigidMeshAsset>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint MaxInstanceCount { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3208409265:
					RigidMeshes = (RefArray<RigidMeshAsset>) p_Value;
					break;

				case 3587631771:
					MaxInstanceCount = (uint) p_Value;
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
				case 3208409265:
					return RigidMeshes;

				case 3587631771:
					return MaxInstanceCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3208409265:
					return typeof(EdgeModelComponentData).GetProperty(nameof(RigidMeshes));

				case 3587631771:
					return typeof(EdgeModelComponentData).GetProperty(nameof(MaxInstanceCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
