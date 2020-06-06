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
	public class CharacterSocketListAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<SocketData> GameplaySockets { get; set; } = new RefArray<SocketData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<SocketData> RigidVisualSockets { get; set; } = new RefArray<SocketData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<SocketData> SkinnedVisualSockets { get; set; } = new RefArray<SocketData>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 790257145:
					GameplaySockets = (RefArray<SocketData>) p_Value;
					break;

				case 2894846550:
					RigidVisualSockets = (RefArray<SocketData>) p_Value;
					break;

				case 2310136503:
					SkinnedVisualSockets = (RefArray<SocketData>) p_Value;
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
				case 790257145:
					return GameplaySockets;

				case 2894846550:
					return RigidVisualSockets;

				case 2310136503:
					return SkinnedVisualSockets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 790257145:
					return typeof(CharacterSocketListAsset).GetProperty(nameof(GameplaySockets));

				case 2894846550:
					return typeof(CharacterSocketListAsset).GetProperty(nameof(RigidVisualSockets));

				case 2310136503:
					return typeof(CharacterSocketListAsset).GetProperty(nameof(SkinnedVisualSockets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
