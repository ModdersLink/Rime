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
	public class EntitySettings : 
		SystemSettings
	{
		protected uint m_OutOfEntityBusNetworkIdThreshold = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2379599769)]
		public uint OutOfEntityBusNetworkIdThreshold { get { return m_OutOfEntityBusNetworkIdThreshold; } set { if (OnPropertyChanging("EntitySettings." + nameof(OutOfEntityBusNetworkIdThreshold), this, m_OutOfEntityBusNetworkIdThreshold, value)) m_OutOfEntityBusNetworkIdThreshold = value; } } // 0xC (12)
		
		protected ExecutionModeType m_ExecutionMode = new ExecutionModeType();
		[ContainerField(16), ContainerFieldNameHash(3634549556)]
		public ExecutionModeType ExecutionMode { get { return m_ExecutionMode; } set { if (OnPropertyChanging("EntitySettings." + nameof(ExecutionMode), this, m_ExecutionMode, value)) m_ExecutionMode = value; } } // 0x10 (16)
		
		protected bool m_SpawnSubLevelsFromLogic = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1806867047)]
		public bool SpawnSubLevelsFromLogic { get { return m_SpawnSubLevelsFromLogic; } set { if (OnPropertyChanging("EntitySettings." + nameof(SpawnSubLevelsFromLogic), this, m_SpawnSubLevelsFromLogic, value)) m_SpawnSubLevelsFromLogic = value; } } // 0x14 (20)
		
		protected bool m_EditorGameViewEnable = new bool();
		[ContainerField(21), LayoutImmutable, Blittable, ContainerFieldNameHash(1497073094)]
		public bool EditorGameViewEnable { get { return m_EditorGameViewEnable; } set { if (OnPropertyChanging("EntitySettings." + nameof(EditorGameViewEnable), this, m_EditorGameViewEnable, value)) m_EditorGameViewEnable = value; } } // 0x15 (21)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2379599769:
					OutOfEntityBusNetworkIdThreshold = (uint) p_Value;
					break;

				case 3634549556:
					ExecutionMode = (ExecutionModeType) Enum.ToObject(typeof(ExecutionModeType), p_Value);
					break;

				case 1806867047:
					SpawnSubLevelsFromLogic = (bool) p_Value;
					break;

				case 1497073094:
					EditorGameViewEnable = (bool) p_Value;
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
				case 2379599769:
					return OutOfEntityBusNetworkIdThreshold;

				case 3634549556:
					return ExecutionMode;

				case 1806867047:
					return SpawnSubLevelsFromLogic;

				case 1497073094:
					return EditorGameViewEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2379599769:
					return typeof(EntitySettings).GetProperty(nameof(OutOfEntityBusNetworkIdThreshold));

				case 3634549556:
					return typeof(EntitySettings).GetProperty(nameof(ExecutionMode));

				case 1806867047:
					return typeof(EntitySettings).GetProperty(nameof(SpawnSubLevelsFromLogic));

				case 1497073094:
					return typeof(EntitySettings).GetProperty(nameof(EditorGameViewEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
