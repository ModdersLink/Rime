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
	[ContainerType(4)]
	public class UserMusicControllerNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Override = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(3718925169)]
		public AudioGraphNodePort Override { get { return m_Override; } set { if (OnPropertyChanging("UserMusicControllerNodeData." + nameof(Override), this, m_Override, value)) m_Override = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Restore = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(1303797069)]
		public AudioGraphNodePort Restore { get { return m_Restore; } set { if (OnPropertyChanging("UserMusicControllerNodeData." + nameof(Restore), this, m_Restore, value)) m_Restore = value; } } // 0x10 (16)
		
		protected bool m_RestoreOnDeactivated = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1844570608)]
		public bool RestoreOnDeactivated { get { return m_RestoreOnDeactivated; } set { if (OnPropertyChanging("UserMusicControllerNodeData." + nameof(RestoreOnDeactivated), this, m_RestoreOnDeactivated, value)) m_RestoreOnDeactivated = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3718925169:
					Override = (AudioGraphNodePort) p_Value;
					break;

				case 1303797069:
					Restore = (AudioGraphNodePort) p_Value;
					break;

				case 1844570608:
					RestoreOnDeactivated = (bool) p_Value;
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
				case 3718925169:
					return Override;

				case 1303797069:
					return Restore;

				case 1844570608:
					return RestoreOnDeactivated;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3718925169:
					return typeof(UserMusicControllerNodeData).GetProperty(nameof(Override));

				case 1303797069:
					return typeof(UserMusicControllerNodeData).GetProperty(nameof(Restore));

				case 1844570608:
					return typeof(UserMusicControllerNodeData).GetProperty(nameof(RestoreOnDeactivated));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
