///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SocketData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform BoneRigidTransform { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x50 (80)
		
		[ContainerField(144)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new CtrRef<UnlockAssetBase>(); // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public int BoneId { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable]
		public string BoneName { get; set; } // 0x98 (152)
		
		[ContainerField(156)]
		public RefArray<SocketObjectDataBase> AvailableObjects { get; set; } = new RefArray<SocketObjectDataBase>(); // 0x9C (156)
		
		[ContainerField(160)]
		public GearSlot GearSlot { get; set; } = new GearSlot(); // 0xA0 (160)
		
		[ContainerField(164)]
		public SocketType SocketType { get; set; } = new SocketType(); // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public bool UsesDefaultObject { get; set; } // 0xA8 (168)
		
		[ContainerField(169), LayoutImmutable, Blittable]
		public bool Excluded { get; set; } // 0xA9 (169)
		
		[ContainerField(170), LayoutImmutable, Blittable]
		public bool DefaultEnableSocketEntities { get; set; } // 0xAA (170)
		
		[ContainerField(171), LayoutImmutable, Blittable]
		public bool ForceSocketEntitiesEnabled { get; set; } // 0xAB (171)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public bool HideByZoomTransition { get; set; } // 0xAC (172)
		
		[ContainerField(173), LayoutImmutable, Blittable]
		public bool HideByLightToggle { get; set; } // 0xAD (173)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 774814302:
					BoneRigidTransform = (LinearTransform) p_Value;
					break;

				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 4135652293:
					UnlockAsset = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				case 2679406126:
					BoneId = (int) p_Value;
					break;

				case 1590647844:
					BoneName = (string) p_Value;
					break;

				case 1171714522:
					AvailableObjects = (RefArray<SocketObjectDataBase>) p_Value;
					break;

				case 930851280:
					GearSlot = (GearSlot) Enum.ToObject(typeof(GearSlot), p_Value);
					break;

				case 648312824:
					SocketType = (SocketType) Enum.ToObject(typeof(SocketType), p_Value);
					break;

				case 1952973611:
					UsesDefaultObject = (bool) p_Value;
					break;

				case 755715367:
					Excluded = (bool) p_Value;
					break;

				case 851092279:
					DefaultEnableSocketEntities = (bool) p_Value;
					break;

				case 1026441125:
					ForceSocketEntitiesEnabled = (bool) p_Value;
					break;

				case 568486406:
					HideByZoomTransition = (bool) p_Value;
					break;

				case 1655750130:
					HideByLightToggle = (bool) p_Value;
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
				case 774814302:
					return BoneRigidTransform;

				case 2270319721:
					return Transform;

				case 4135652293:
					return UnlockAsset;

				case 2679406126:
					return BoneId;

				case 1590647844:
					return BoneName;

				case 1171714522:
					return AvailableObjects;

				case 930851280:
					return GearSlot;

				case 648312824:
					return SocketType;

				case 1952973611:
					return UsesDefaultObject;

				case 755715367:
					return Excluded;

				case 851092279:
					return DefaultEnableSocketEntities;

				case 1026441125:
					return ForceSocketEntitiesEnabled;

				case 568486406:
					return HideByZoomTransition;

				case 1655750130:
					return HideByLightToggle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 774814302:
					return typeof(SocketData).GetProperty(nameof(BoneRigidTransform));

				case 2270319721:
					return typeof(SocketData).GetProperty(nameof(Transform));

				case 4135652293:
					return typeof(SocketData).GetProperty(nameof(UnlockAsset));

				case 2679406126:
					return typeof(SocketData).GetProperty(nameof(BoneId));

				case 1590647844:
					return typeof(SocketData).GetProperty(nameof(BoneName));

				case 1171714522:
					return typeof(SocketData).GetProperty(nameof(AvailableObjects));

				case 930851280:
					return typeof(SocketData).GetProperty(nameof(GearSlot));

				case 648312824:
					return typeof(SocketData).GetProperty(nameof(SocketType));

				case 1952973611:
					return typeof(SocketData).GetProperty(nameof(UsesDefaultObject));

				case 755715367:
					return typeof(SocketData).GetProperty(nameof(Excluded));

				case 851092279:
					return typeof(SocketData).GetProperty(nameof(DefaultEnableSocketEntities));

				case 1026441125:
					return typeof(SocketData).GetProperty(nameof(ForceSocketEntitiesEnabled));

				case 568486406:
					return typeof(SocketData).GetProperty(nameof(HideByZoomTransition));

				case 1655750130:
					return typeof(SocketData).GetProperty(nameof(HideByLightToggle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
