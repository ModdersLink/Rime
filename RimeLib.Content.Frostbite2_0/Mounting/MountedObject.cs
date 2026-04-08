using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Content.Mounting;

namespace RimeLib.Content.Frostbite2_0.Mounting
{
    internal class MountedObject<T> : IMountedObject<T> where T : IObjectVariant
    {
        public IEnumerable<T> Variants
        {
            get
            {
                lock (m_SyncRoot)
                    return m_Variants.ToArray();
            }
        }

        public T FirstVariant
        {
            get
            {
                lock (m_SyncRoot)
                    return m_Variants.First();
            }
        }
        public string OriginalName { get; }

        private readonly object m_SyncRoot = new();
        protected List<T> m_Variants = new List<T>();

        internal MountedObject(T p_Variant, string p_OriginalName)
        {
            m_Variants.Add(p_Variant);
            OriginalName = p_OriginalName;
        }

        internal void AddVariant(T p_Variant)
        {
            lock (m_SyncRoot)
                m_Variants.Add(p_Variant);
        }

        internal void RemoveVariant(T p_Variant)
        {
            lock (m_SyncRoot)
                m_Variants.RemoveAll(p_OtherVariant => p_OtherVariant.Equals(p_Variant));
        }

        internal void AddOrUpdateVariant(Func<T, bool> p_Match, T p_NewVariant)
        {
            lock (m_SyncRoot)
            {
                var s_Index = m_Variants.FindIndex(p_Match.Invoke);

                if (s_Index >= 0)
                    m_Variants[s_Index] = p_NewVariant;
                else
                    m_Variants.Add(p_NewVariant);
            }
        }
    }

    internal class MountedObject : IMountedObject
    {
        public IEnumerable<IObjectVariant> Variants
        {
            get
            {
                lock (m_SyncRoot)
                    return m_Variants.ToArray();
            }
        }

        public IObjectVariant FirstVariant
        {
            get
            {
                lock (m_SyncRoot)
                    return m_Variants.First();
            }
        }
        public string OriginalName { get; }

        private readonly object m_SyncRoot = new();
        protected List<IObjectVariant> m_Variants = new List<IObjectVariant>();

        internal MountedObject(IObjectVariant p_Variant, string p_OriginalName)
        {
            m_Variants.Add(p_Variant);
            OriginalName = p_OriginalName;
        }

        internal void AddVariant(IObjectVariant p_Variant)
        {
            lock (m_SyncRoot)
                m_Variants.Add(p_Variant);
        }

        internal void RemoveVariant(IObjectVariant p_Variant)
        {
            lock (m_SyncRoot)
                m_Variants.RemoveAll(p_OtherVariant => p_OtherVariant.Equals(p_Variant));
        }

        internal void AddOrUpdateVariant(Func<IObjectVariant, bool> p_Match, IObjectVariant p_NewVariant)
        {
            lock (m_SyncRoot)
            {
                var s_Index = m_Variants.FindIndex(p_Match.Invoke);

                if (s_Index >= 0)
                    m_Variants[s_Index] = p_NewVariant;
                else
                    m_Variants.Add(p_NewVariant);
            }
        }
    }
}
