#pragma once

#include <cstdint>

namespace Sdk
{

	namespace eastl
	{
		// sorted vector? uses binary search to look up 
		template<typename T1, typename T2>
		class vector_map
		{
		public:
			template<typename T1, typename T2>
			class entry
			{
			public:
				T1 first;
				T2 second;
			};

			entry<T1, T2>* m_pBegin; //0x0000
			entry<T1, T2>* m_pEnd; //0x0004
			entry<T1, T2>* m_pAllocationEnd; //0x0008
			void* m_pAllocator; //0x000C


			entry<T1, T2>* begin()
			{
				return m_pBegin;
			}

			entry<T1, T2>* end()
			{
				return m_pEnd;
			}

			size_t size()
			{
				return (m_pEnd - m_pBegin);
			}
		}; //0x0010
	}

	namespace GD
	{
		template <typename T>
		class Ptr64
		{
		public:
			// this is kinda like relocptr in bf3


#ifdef _WIN64
			T* m_pPtr;
#else
			T* m_pPtr;
			char _0x0004[0x4];
#endif
		}; //0x0008



		enum LayoutType
			: uint32_t
		{
			Invalid = 0,
			Bool = 1,
			Int8 = 2,
			UInt8 = 3,
			Int16 = 4,
			UInt16 = 5,
			Int32 = 6,
			UInt32 = 7,
			Int64 = 8,
			UInt64 = 9,
			Float = 10,
			Vector2 = 11,
			Vector3 = 12,
			Vector4 = 13,
			Quaternion = 14,
			Matrix44 = 15,
			Guid = 16,
			String = 17,
			DataRef = 18,
			LayoutTypeCount = 19,
		};

		class Layout;

		class Entry
		{
		public:
			uint32_t m_LayoutHash; //0x0000
			uint32_t m_ElementSize; //0x0004
			uint32_t m_Offset; //0x0008
			uint32_t m_NameOffset; //0x000C

			uint16_t m_Count; //0x0010
			uint16_t m_Flags; //0x0012
			uint16_t m_ElementAlign; //0x0014
			
			int16_t m_RLE; //0x0016

			Ptr64<Layout> m_Layout; //0x0018


			bool IsBasicType()
			{
				return m_LayoutHash < LayoutType::LayoutTypeCount;
			}

			LayoutType GetType()
			{
				return (LayoutType)m_LayoutHash;
			}
		}; //0x0020

		class Layout
		{
		public:
			int32_t m_MinSlot; //0x0000
			int32_t m_MaxSlot; //0x0004

			uint32_t m_DataSize; //0x0008
			uint32_t m_Alignment; //0x000C

			uint32_t m_StringTableOffset; //0x0010
			uint32_t m_StringTableLength; //0x0014
			
			bool m_Reordered; //0x0018
			bool m_Native; //0x0019

			char _0x001A[0x2];
			
			uint32_t m_Hash; //0x001C

			int32_t TotalSlotCount()
			{
				return (m_MaxSlot - m_MinSlot + 1);
			}


			LayoutType GetType()
			{
				return (LayoutType)m_Hash;
			}


			Entry* GetEntry(uint32_t index)
			{
				auto SlotSize = TotalSlotCount();

				if (index >= SlotSize)
					return nullptr;

				auto* pData = reinterpret_cast<Entry*>(this + 1);

				return pData + index;
			}


			const char* GetString(uint32_t offset)
			{
				if (offset >= m_StringTableLength)
					return nullptr;

				auto* pStringTable = reinterpret_cast<char*>(this) + m_StringTableOffset;

				return pStringTable + offset;
			}

			std::string GetLayoutName()
			{
				std::string Name = GetString(1);

				std::replace(Name.begin(), Name.end(), ':', '_');
				return Name;
			}

		}; //0x0020
	}

	namespace Ant::Generics
	{
		class Schema
		{
		public:
			GD::Layout* m_pLayout; //0x0000
			void* m_pFactory; //0x0004
		};


		class SchemaRegistry
		{
		public:
			eastl::vector_map<uint32_t, Schema*> m_mRegistryByName; //0x0000
			char _0x0010[0x4];
			eastl::vector_map<uint32_t, Schema*> m_mRegistryByHash; //0x0000



			static SchemaRegistry* GetInstance()
			{
				return *reinterpret_cast<SchemaRegistry**>(0x2376A8C);
			}
		};
	}
}