using System.Collections.Generic;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Loose implementation of eastl::basic_array
    /// </summary>
    /// <typeparam name="T">Type that this array contains</typeparam>
    public class Array<T>
    {
        /// <summary>
        /// Default constructor
        /// TODO: Finish Implementing/Override List
        /// </summary>
        public Array()
        {
            AsList = new List<T>();
        }

        /// <summary>
        /// Assigns an array containing type T array to this local array
        /// </summary>
        /// <param name="p_Array">Array of type T</param>
        public Array(List<T> p_Array)
        {
            AsList = p_Array;
        }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="p_Index">Index inside the array to return the value of type T</param>
        /// <returns>Type T</returns>
        public T this[int p_Index]
        {
            get => AsList[p_Index];
            set => AsList[p_Index] = value;
        }

        /// <summary>
        /// Count of array
        /// </summary>
        public int Count => AsList.Count;

        /// <summary>
        /// Returns the array as a list
        /// </summary>
        public List<T> AsList { get; }

        /// <summary>
        /// Returns the array as an raw array
        /// </summary>
        public T[] AsArray => AsList.ToArray();

        /// <summary>
        /// Adds a value of type T to the array
        /// </summary>
        /// <param name="p_Value">Item to add to the array</param>
        public void Add(T p_Value)
        {
            AsList.Add(p_Value);
        }

        /// <summary>
        /// Clears all elements from the array
        /// </summary>
        public void Clear()
        {
            AsList.Clear();
        }
    }
}
