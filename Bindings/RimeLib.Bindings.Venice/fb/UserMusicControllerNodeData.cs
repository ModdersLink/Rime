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
	public class UserMusicControllerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Override { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Restore { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool RestoreOnDeactivated { get; set; } // 0x18 (24)
		
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
