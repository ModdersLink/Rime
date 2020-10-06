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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class RouteNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("RouteNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected RefArray<RouteEntry> m_Routes = new RefArray<RouteEntry>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(3305059247), ContainerRefArray]
		public RefArray<RouteEntry> Routes { get { return m_Routes; } set { if (OnPropertyChanging("RouteNodeData." + nameof(Routes), this, m_Routes, value)) m_Routes = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3305059247:
					Routes = (RefArray<RouteEntry>) p_Value;
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
				case 5862146:
					return In;

				case 3305059247:
					return Routes;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(RouteNodeData).GetProperty(nameof(In));

				case 3305059247:
					return typeof(RouteNodeData).GetProperty(nameof(Routes));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
