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
	public class PlayFromHereAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<Blueprint> Soldier { get; set; } = new CtrRef<Blueprint>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<AnimatedSkeletonDatabase> AnimatedSkeletonDatabase { get; set; } = new CtrRef<AnimatedSkeletonDatabase>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<AntProjectAsset> AntProject { get; set; } = new CtrRef<AntProjectAsset>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2844639087:
					Soldier = (CtrRef<Blueprint>) p_Value;
					break;

				case 3542888158:
					AnimatedSkeletonDatabase = (CtrRef<AnimatedSkeletonDatabase>) p_Value;
					break;

				case 1712291019:
					AntProject = (CtrRef<AntProjectAsset>) p_Value;
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
				case 2844639087:
					return Soldier;

				case 3542888158:
					return AnimatedSkeletonDatabase;

				case 1712291019:
					return AntProject;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2844639087:
					return typeof(PlayFromHereAsset).GetProperty(nameof(Soldier));

				case 3542888158:
					return typeof(PlayFromHereAsset).GetProperty(nameof(AnimatedSkeletonDatabase));

				case 1712291019:
					return typeof(PlayFromHereAsset).GetProperty(nameof(AntProject));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
