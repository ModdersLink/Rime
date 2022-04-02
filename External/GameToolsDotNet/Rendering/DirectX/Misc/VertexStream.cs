using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolsDotNet.Rendering.DirectX.Misc
{
    public class VertexStreamSplice<T>
    {
        private T[] array;

        private int baseIndex;
        private int elementCount;

        public int Length { get { return this.elementCount; } }

        public VertexStreamSplice(T[] array, int baseIndex, int length)
        {
            // Make sure the base index and length are valid.
            if (baseIndex < 0 || baseIndex + length > array.Length)
                throw new ArgumentException("index + length are past the bounds of the array");

            // Initialize fields.
            this.array = array;
            this.baseIndex = baseIndex;
            this.elementCount = length;
        }

        public T this[int index]
        {
            get
            {
                // Make sure the index is valid.
                if (index >= this.elementCount)
                    throw new IndexOutOfRangeException("index is past the bounds of the array");

                // Return the element.
                return this.array[this.baseIndex + index];
            }
            set
            {
                // Make sure the index is valid.
                if (index >= this.elementCount)
                    throw new IndexOutOfRangeException("index is past the bounds of the array");

                // Set the element value.
                this.array[this.baseIndex + index] = value;
            }
        }

        public T[] ToArray()
        {
            // Create a new array to hold the spliced portion.
            T[] clone = new T[this.elementCount];
            Array.Copy(this.array, this.baseIndex, clone, 0, this.elementCount);

            return clone;
        }
    }

    public class VertexStream<V, I>
    {
        public V[] Vertices { get; private set; }
        public I[] Indices { get; private set; }

        public VertexStream(int vertexCount, int indexCount)
        {
            // Allocate vertex and index buffers.
            this.Vertices = new V[vertexCount];
            this.Indices = new I[indexCount];
        }

        public VertexStream(V[] vertices, I[] indices)
        {
            // Set initial vertex and index buffers.
            this.Vertices = vertices;
            this.Indices = indices;
        }

        ~VertexStream()
        {
            // TODO: Unpin and free the vertex and index buffers.
        }

        public VertexStreamSplice<V> SpliceVertexBuffer(int position, int length)
        {
            // Create a new vertex buffer splice that points to the specified elements in the array.
            return new VertexStreamSplice<V>(this.Vertices, position, length);
        }

        public VertexStreamSplice<I> SpliceIndexBuffer(int position, int length)
        {
            // Create a new index buffer splice that points to the specified elements in the array.
            return new VertexStreamSplice<I>(this.Indices, position, length);
        }

        public void ResizeVertexBuffer(int newLength)
        {
            // Make sure the new length is larger than the current length.
            if (newLength <= this.Vertices.Length)
                throw new ArgumentException("New vertex buffer length must be larger than the current length");

            // Create a new vertex buffer and copy the old vertex data into it.
            V[] newVertexBuffer = new V[newLength];
            Array.Copy(this.Vertices, newVertexBuffer, this.Vertices.Length);

            // Assign the new vertex buffer.
            this.Vertices = newVertexBuffer;
        }

        public void ResizeIndexBuffer(int newLength)
        {
            // Make sure the new length is larger than the current length.
            if (newLength <= this.Indices.Length)
                throw new ArgumentException("New index buffer length must be larger than the current length");

            // Create a new index buffer using the new length and copy the contents of the old buffer into it.
            I[] newIndexBuffer = new I[newLength];
            Array.Copy(this.Indices, newIndexBuffer, this.Indices.Length);

            // Assign the new index buffer.
            this.Indices = newIndexBuffer;
        }
    }
}
