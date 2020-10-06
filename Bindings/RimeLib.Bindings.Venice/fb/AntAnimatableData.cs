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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(20), ContainerStruct]
	public class AntAnimatableData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public AntRef Actor { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<ProceduralAwarenessAntRefs> ProceduralAwareness { get; set; } = new CtrRef<ProceduralAwarenessAntRefs>(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(41)]
		public AntRef RightHandEffectorDisableOverride { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(41)]
		public AntRef LeftHandEffectorDisableOverride { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<MasterSkeletonAsset> MasterSkeletonAsset { get; set; } = new CtrRef<MasterSkeletonAsset>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205428846:
					Actor = (AntRef) p_Value;
					break;

				case 3096885739:
					ProceduralAwareness = (CtrRef<ProceduralAwarenessAntRefs>) p_Value;
					break;

				case 3621503884:
					RightHandEffectorDisableOverride = (AntRef) p_Value;
					break;

				case 2879725591:
					LeftHandEffectorDisableOverride = (AntRef) p_Value;
					break;

				case 2238702888:
					MasterSkeletonAsset = (CtrRef<MasterSkeletonAsset>) p_Value;
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
				case 205428846:
					return Actor;

				case 3096885739:
					return ProceduralAwareness;

				case 3621503884:
					return RightHandEffectorDisableOverride;

				case 2879725591:
					return LeftHandEffectorDisableOverride;

				case 2238702888:
					return MasterSkeletonAsset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 205428846:
					return typeof(AntAnimatableData).GetProperty(nameof(Actor));

				case 3096885739:
					return typeof(AntAnimatableData).GetProperty(nameof(ProceduralAwareness));

				case 3621503884:
					return typeof(AntAnimatableData).GetProperty(nameof(RightHandEffectorDisableOverride));

				case 2879725591:
					return typeof(AntAnimatableData).GetProperty(nameof(LeftHandEffectorDisableOverride));

				case 2238702888:
					return typeof(AntAnimatableData).GetProperty(nameof(MasterSkeletonAsset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
