///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class PlayFromHereAsset : 
		Asset
	{
		protected CtrRef<Blueprint> m_Soldier = new CtrRef<Blueprint>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(2844639087), ContainerCtrRef]
		public CtrRef<Blueprint> Soldier { get { return m_Soldier; } set { if (OnPropertyChanging("PlayFromHereAsset." + nameof(Soldier), this, m_Soldier, value)) m_Soldier = value; } } // 0xC (12)
		
		protected CtrRef<AnimatedSkeletonDatabase> m_AnimatedSkeletonDatabase = new CtrRef<AnimatedSkeletonDatabase>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(3542888158), ContainerCtrRef]
		public CtrRef<AnimatedSkeletonDatabase> AnimatedSkeletonDatabase { get { return m_AnimatedSkeletonDatabase; } set { if (OnPropertyChanging("PlayFromHereAsset." + nameof(AnimatedSkeletonDatabase), this, m_AnimatedSkeletonDatabase, value)) m_AnimatedSkeletonDatabase = value; } } // 0x10 (16)
		
		protected CtrRef<AntProjectAsset> m_AntProject = new CtrRef<AntProjectAsset>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(1712291019), ContainerCtrRef]
		public CtrRef<AntProjectAsset> AntProject { get { return m_AntProject; } set { if (OnPropertyChanging("PlayFromHereAsset." + nameof(AntProject), this, m_AntProject, value)) m_AntProject = value; } } // 0x14 (20)
		
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
