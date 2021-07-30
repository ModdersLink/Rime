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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 176)]
	public class SocketData : 
		DataContainer
	{
		protected LinearTransform m_BoneRigidTransform = new LinearTransform();
		[ContainerField(Name: "BoneRigidTransform", Offset: 16, NameHash: 774814302, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform BoneRigidTransform { get { return m_BoneRigidTransform; } set { if (OnPropertyChanging("SocketData." + nameof(BoneRigidTransform), this, m_BoneRigidTransform, value)) m_BoneRigidTransform = value; } } // 0x10 (16)
		
		protected LinearTransform m_Transform = new LinearTransform();
		[ContainerField(Name: "Transform", Offset: 80, NameHash: 2270319721, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get { return m_Transform; } set { if (OnPropertyChanging("SocketData." + nameof(Transform), this, m_Transform, value)) m_Transform = value; } } // 0x50 (80)
		
		protected CtrRef<UnlockAssetBase> m_UnlockAsset = new CtrRef<UnlockAssetBase>();
		[ContainerField(Name: "UnlockAsset", Offset: 144, NameHash: 4135652293, Flags: 53)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get { return m_UnlockAsset; } set { if (OnPropertyChanging("SocketData." + nameof(UnlockAsset), this, m_UnlockAsset, value)) m_UnlockAsset = value; } } // 0x90 (144)
		
		protected int m_BoneId = new int();
		[ContainerField(Name: "BoneId", Offset: 148, NameHash: 2679406126, Flags: 49405), LayoutImmutable, Blittable]
		public int BoneId { get { return m_BoneId; } set { if (OnPropertyChanging("SocketData." + nameof(BoneId), this, m_BoneId, value)) m_BoneId = value; } } // 0x94 (148)
		
		protected string m_BoneName = string.Empty;
		[ContainerField(Name: "BoneName", Offset: 152, NameHash: 1590647844, Flags: 16509), LayoutImmutable]
		public string BoneName { get { return m_BoneName; } set { if (OnPropertyChanging("SocketData." + nameof(BoneName), this, m_BoneName, value)) m_BoneName = value; } } // 0x98 (152)
		
		protected RefArray<SocketObjectDataBase> m_AvailableObjects = new RefArray<SocketObjectDataBase>();
		[ContainerField(Name: "AvailableObjects", Offset: 156, NameHash: 1171714522, Flags: 65)]
		public RefArray<SocketObjectDataBase> AvailableObjects { get { return m_AvailableObjects; } set { if (OnPropertyChanging("SocketData." + nameof(AvailableObjects), this, m_AvailableObjects, value)) m_AvailableObjects = value; } } // 0x9C (156)
		
		protected GearSlot m_GearSlot = new GearSlot();
		[ContainerField(Name: "GearSlot", Offset: 160, NameHash: 930851280, Flags: 137)]
		public GearSlot GearSlot { get { return m_GearSlot; } set { if (OnPropertyChanging("SocketData." + nameof(GearSlot), this, m_GearSlot, value)) m_GearSlot = value; } } // 0xA0 (160)
		
		protected SocketType m_SocketType = new SocketType();
		[ContainerField(Name: "SocketType", Offset: 164, NameHash: 648312824, Flags: 137)]
		public SocketType SocketType { get { return m_SocketType; } set { if (OnPropertyChanging("SocketData." + nameof(SocketType), this, m_SocketType, value)) m_SocketType = value; } } // 0xA4 (164)
		
		protected bool m_UsesDefaultObject = new bool();
		[ContainerField(Name: "UsesDefaultObject", Offset: 168, NameHash: 1952973611, Flags: 49325), LayoutImmutable, Blittable]
		public bool UsesDefaultObject { get { return m_UsesDefaultObject; } set { if (OnPropertyChanging("SocketData." + nameof(UsesDefaultObject), this, m_UsesDefaultObject, value)) m_UsesDefaultObject = value; } } // 0xA8 (168)
		
		protected bool m_Excluded = new bool();
		[ContainerField(Name: "Excluded", Offset: 169, NameHash: 755715367, Flags: 49325), LayoutImmutable, Blittable]
		public bool Excluded { get { return m_Excluded; } set { if (OnPropertyChanging("SocketData." + nameof(Excluded), this, m_Excluded, value)) m_Excluded = value; } } // 0xA9 (169)
		
		protected bool m_DefaultEnableSocketEntities = new bool();
		[ContainerField(Name: "DefaultEnableSocketEntities", Offset: 170, NameHash: 851092279, Flags: 49325), LayoutImmutable, Blittable]
		public bool DefaultEnableSocketEntities { get { return m_DefaultEnableSocketEntities; } set { if (OnPropertyChanging("SocketData." + nameof(DefaultEnableSocketEntities), this, m_DefaultEnableSocketEntities, value)) m_DefaultEnableSocketEntities = value; } } // 0xAA (170)
		
		protected bool m_ForceSocketEntitiesEnabled = new bool();
		[ContainerField(Name: "ForceSocketEntitiesEnabled", Offset: 171, NameHash: 1026441125, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceSocketEntitiesEnabled { get { return m_ForceSocketEntitiesEnabled; } set { if (OnPropertyChanging("SocketData." + nameof(ForceSocketEntitiesEnabled), this, m_ForceSocketEntitiesEnabled, value)) m_ForceSocketEntitiesEnabled = value; } } // 0xAB (171)
		
		protected bool m_HideByZoomTransition = new bool();
		[ContainerField(Name: "HideByZoomTransition", Offset: 172, NameHash: 568486406, Flags: 49325), LayoutImmutable, Blittable]
		public bool HideByZoomTransition { get { return m_HideByZoomTransition; } set { if (OnPropertyChanging("SocketData." + nameof(HideByZoomTransition), this, m_HideByZoomTransition, value)) m_HideByZoomTransition = value; } } // 0xAC (172)
		
		protected bool m_HideByLightToggle = new bool();
		[ContainerField(Name: "HideByLightToggle", Offset: 173, NameHash: 1655750130, Flags: 49325), LayoutImmutable, Blittable]
		public bool HideByLightToggle { get { return m_HideByLightToggle; } set { if (OnPropertyChanging("SocketData." + nameof(HideByLightToggle), this, m_HideByLightToggle, value)) m_HideByLightToggle = value; } } // 0xAD (173)
		
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
