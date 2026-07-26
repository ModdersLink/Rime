using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RimeLib.Utils
{
    /// <summary>
    /// Insertion-order-preserving IDictionary. Used for EBX partition instance maps, where the
    /// original DICE instance order must survive read -> JSON -> write round trips byte-identically
    /// (a SortedDictionary re-sorts by guid and permanently destroys the original payload order).
    /// Json.NET serializes/deserializes it through IDictionary&lt;TKey, TValue&gt; in document order.
    /// </summary>
    public class OrderedDictionary<TKey, TValue> : IDictionary<TKey, TValue> where TKey : notnull
    {
        private readonly Dictionary<TKey, TValue> m_Map = new();
        private readonly List<TKey> m_Order = new();

        public int Count => m_Map.Count;
        public bool IsReadOnly => false;

        public ICollection<TKey> Keys => m_Order.ToList();
        public ICollection<TValue> Values => m_Order.Select(p_Key => m_Map[p_Key]).ToList();

        public TValue this[TKey p_Key]
        {
            get => m_Map[p_Key];
            set
            {
                if (!m_Map.ContainsKey(p_Key))
                    m_Order.Add(p_Key);

                m_Map[p_Key] = value;
            }
        }

        public void Add(TKey p_Key, TValue p_Value)
        {
            m_Map.Add(p_Key, p_Value);
            m_Order.Add(p_Key);
        }

        public void Add(KeyValuePair<TKey, TValue> p_Item)
        {
            Add(p_Item.Key, p_Item.Value);
        }

        public bool Remove(TKey p_Key)
        {
            if (!m_Map.Remove(p_Key))
                return false;

            m_Order.Remove(p_Key);
            return true;
        }

        public bool Remove(KeyValuePair<TKey, TValue> p_Item)
        {
            if (!m_Map.TryGetValue(p_Item.Key, out var s_Value) || !EqualityComparer<TValue>.Default.Equals(s_Value, p_Item.Value))
                return false;

            return Remove(p_Item.Key);
        }

        public void Clear()
        {
            m_Map.Clear();
            m_Order.Clear();
        }

        public bool ContainsKey(TKey p_Key) => m_Map.ContainsKey(p_Key);

        public bool Contains(KeyValuePair<TKey, TValue> p_Item) =>
            m_Map.TryGetValue(p_Item.Key, out var s_Value) && EqualityComparer<TValue>.Default.Equals(s_Value, p_Item.Value);

        public bool TryGetValue(TKey p_Key, out TValue p_Value) => m_Map.TryGetValue(p_Key, out p_Value!);

        public void CopyTo(KeyValuePair<TKey, TValue>[] p_Array, int p_ArrayIndex)
        {
            foreach (var s_Pair in this)
                p_Array[p_ArrayIndex++] = s_Pair;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var s_Key in m_Order)
                yield return new KeyValuePair<TKey, TValue>(s_Key, m_Map[s_Key]);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
