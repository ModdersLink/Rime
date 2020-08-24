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
	public class WorldPartData : 
		SpatialPrefabBlueprint
	{
		protected GUID m_HackToSolveRealTimeTweakingIssue = new GUID();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49501), ContainerFieldNameHash(1452521702)]
		public GUID HackToSolveRealTimeTweakingIssue { get { return m_HackToSolveRealTimeTweakingIssue; } set { if (OnPropertyChanging("WorldPartData." + nameof(HackToSolveRealTimeTweakingIssue), this, m_HackToSolveRealTimeTweakingIssue, value)) m_HackToSolveRealTimeTweakingIssue = value; } } // 0x24 (36)
		
		protected bool m_UseDeferredEntityCreation = new bool();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2224120471)]
		public bool UseDeferredEntityCreation { get { return m_UseDeferredEntityCreation; } set { if (OnPropertyChanging("WorldPartData." + nameof(UseDeferredEntityCreation), this, m_UseDeferredEntityCreation, value)) m_UseDeferredEntityCreation = value; } } // 0x34 (52)
		
		protected bool m_Enabled = new bool();
		[ContainerField(53), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("WorldPartData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x35 (53)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1452521702:
					HackToSolveRealTimeTweakingIssue = (GUID) p_Value;
					break;

				case 2224120471:
					UseDeferredEntityCreation = (bool) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 1452521702:
					return HackToSolveRealTimeTweakingIssue;

				case 2224120471:
					return UseDeferredEntityCreation;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1452521702:
					return typeof(WorldPartData).GetProperty(nameof(HackToSolveRealTimeTweakingIssue));

				case 2224120471:
					return typeof(WorldPartData).GetProperty(nameof(UseDeferredEntityCreation));

				case 2662400:
					return typeof(WorldPartData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
