using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolsDotNet.Utilities
{
    public class FileNameTreeNode<T> : IComparable<FileNameTreeNode<T>> where T : class
    {
        /// <summary>
        /// File or folder name of the node
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// DatumIndex of the file is this node represents a file, or DatumIndex.Unassigned if a folder
        /// </summary>
        public T FileDatum { get; set; } = null;
        /// <summary>
        /// True if the node's checkbox is checked, false otherwise.
        /// </summary>
        public bool Checked = false;
        /// <summary>
        /// True if the tree node is in an expanded state or false otherwise
        /// </summary>
        public bool Expanded { get; set; } = false;
        /// <summary>
        /// Child nodes
        /// </summary>
        public List<FileNameTreeNode<T>> Nodes { get; set; } = new List<FileNameTreeNode<T>>();
        /// <summary>
        /// Parent node
        /// </summary>
        public FileNameTreeNode<T> Parent { get; set; }

        /// <summary>
        /// Gets the full path of the node
        /// </summary>
        /// <returns>Full path of the node</returns>
        public string GetFullPath()
        {
            // If the parent node is not null prepend the parent path to the name of this node.
            if (this.Parent != null)
                return this.Parent.GetFullPath() + "\\" + this.Name;
            else
                return this.Name;
        }

        /// <summary>
        /// Gets a list of all child nodes, searching recursively through the tree.
        /// </summary>
        /// <returns></returns>
        public FileNameTreeNode<T>[] GetChildNodes()
        {
            // Return a recursive list of all child nodes.
            return GetChildNodes(this);
        }

        /// <summary>
        /// Recursively sorts the node collection using the default sorting algorithm
        /// </summary>
        public void Sort()
        {
            // Loop through all the nodes in the list and recursively sort nodes with child elements.
            for (int i = 0; i < this.Nodes.Count; i++)
            {
                // If the child node has children of its own then recursively sort it.
                if (this.Nodes[i].Nodes.Count > 0)
                    this.Nodes[i].Sort();
            }

            // Sort the children of this node.
            this.Nodes.Sort();
        }

        /// <summary>
        /// Recursively sorts the node collection using the comparer provided
        /// </summary>
        /// <param name="comparer"></param>
        public void Sort(IComparer<FileNameTreeNode<T>> comparer)
        {
            // Loop through all the nodes in the list and recursively sort nodes with child elements.
            for (int i = 0; i < this.Nodes.Count; i++)
            {
                // If the child node has children of its own then recursively sort it.
                if (this.Nodes[i].Nodes.Count > 0)
                    this.Nodes[i].Sort(comparer);
            }

            // Sort the children of this node.
            this.Nodes.Sort(comparer);
        }

        private FileNameTreeNode<T>[] GetChildNodes(FileNameTreeNode<T> node)
        {
            // Create a list to hold all child nodes.
            List<FileNameTreeNode<T>> nodeList = new List<FileNameTreeNode<T>>();

            // Loop through all the child nodes and add each one to the list.
            foreach (FileNameTreeNode<T> childNode in node.Nodes)
            {
                // Add it to the node list.
                nodeList.Add(childNode);

                // Recursively add all child nodes.
                nodeList.AddRange(GetChildNodes(childNode));
            }

            // Return the list of all child nodes.
            return nodeList.ToArray();
        }

        public int CompareTo(FileNameTreeNode<T> other)
        {
            // If both nodes have children or both nodes have no children then compare by name.
            if ((this.Nodes.Count > 0 && other.Nodes.Count > 0) || (this.Nodes.Count == 0 && other.Nodes.Count == 0))
            {
                // Second compare by file name.
                return this.Name.CompareTo(other.Name);
            }

            // Compare by child nodes.
            if (this.Nodes.Count > 0)
                return -1;
            else
                return 1;
        }
    }

    public class FileNameTree<T> : FileNameTreeNode<T> where T : class
    {
        public static FileNameTree<T> BuildFileNameTree(Dictionary<string, T> fileList)
        {
            // Sort the dictionary keys alphabetically.
            List<string> fileNames = fileList.Keys.ToList();

            // Build the file name tree.
            return BuildTreeFromNames(fileNames.ToArray(), fileList);
        }

        private static FileNameTree<T> BuildTreeFromNames(string[] fileNames, Dictionary<string, T> fileIds)
        {
            // TODO: This building algorithm could be optimized.

            // Loop through the list of files names and build the file name tree.
            FileNameTree<T> tree = new FileNameTree<T>();
            for (int i = 0; i < fileNames.Length; i++)
            {
                // Split the file name into pieces.
                string[] pieces = fileNames[i].Split('\\');

                // Loop and add nodes for each piece needed.
                FileNameTreeNode<T> parent = tree;
                for (int x = 0; x < pieces.Length; x++)
                {
                    // Check if there is a node for this file name piece.
                    bool found = false;
                    foreach (FileNameTreeNode<T> node in parent.Nodes)
                    {
                        // Check if the node name matches.
                        if (node.Name.Equals(pieces[x], StringComparison.InvariantCultureIgnoreCase) == true)
                        {
                            // Set the parent and continue.
                            parent = node;
                            found = true;
                            break;
                        }
                    }

                    // If no node was found create a new one.
                    if (found == false)
                    {
                        // Create a new node and set it as the parent.
                        FileNameTreeNode<T> node = new FileNameTreeNode<T>();
                        node.Name = pieces[x];
                        node.Parent = parent;
                        parent.Nodes.Add(node);
                        parent = node;
                    }
                }

                // The last node is the file name node, set the datum index for it.
                parent.FileDatum = fileIds[fileNames[i]];
            }

            // Return the file name tree.
            return tree;
        }
    }
}
