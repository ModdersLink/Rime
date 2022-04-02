using GameToolsDotNet.Extensions;
using GameToolsDotNet.Utilities;
using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImVector2 = System.Numerics.Vector2;

namespace GameToolsDotNet.Rendering.ImGuiUI.Controls
{
    public delegate void OnResourceSelectionChangedEvent<T>(T old, T @new) where T : class;
    public delegate void OnTreeNodeCheckedChangedEvent<T>(FileNameTreeNode<T> node) where T : class;
    public delegate void OnTreeNodeDoubleClickedEvent<T>(FileNameTreeNode<T> node) where T : class;

    public delegate bool OnDrawContextMenu<T>(FileNameTreeNode<T> clickedNode) where T : class;

    public class ImGuiResourceSelectTree<T> : ImGuiControl where T : class
    {
        /// <summary>
        /// The selected file in the tree view.
        /// </summary>
        public T SelectedNode { get; protected set; } = null;
        /// <summary>
        /// Node that was right clicked in the tree view before the context menu was opened.
        /// </summary>
        public FileNameTreeNode<T> RightClickedNode { get; protected set; } = null;
        /// <summary>
        /// Gets or sets the size of the tree view control.
        /// </summary>
        public ImVector2 Size { get; set; } = new ImVector2(0, 0);
        /// <summary>
        /// Indicates if the control should be drawn with a border or not.
        /// </summary>
        public bool Border { get; set; } = true;
        /// <summary>
        /// True if the tree view nodes should have checkboxes.
        /// </summary>
        public bool Checkboxes { get; set; } = false;

        /// <summary>
        /// Event handler for when the tree view selection has changed.
        /// </summary>
        public OnResourceSelectionChangedEvent<T> OnResourceSelectionChanged { get; set; } = null;
        /// <summary>
        /// Event handler for when the checked state of a node has changed.
        /// </summary>
        public OnTreeNodeCheckedChangedEvent<T> OnTreeNodeCheckedChanged { get; set; } = null;
        /// <summary>
        /// Event handler for when a node is double clicked.
        /// </summary>
        public OnTreeNodeDoubleClickedEvent<T> OnTreeNodeDoubleClicked { get; set; } = null;
        /// <summary>
        /// Event handler for when the content menu should be draw.
        /// </summary>
        public OnDrawContextMenu<T> OnDrawContextMenu { get; set; } = null;

        // Tree of file names to display.
        protected FileNameTree<T> fileNameTree = new FileNameTree<T>();
        /// <summary>
        /// List of FileNameTreeNode nodes to be displayed in the tree
        /// </summary>
        public List<FileNameTreeNode<T>> Nodes { get { return this.fileNameTree.Nodes; } set { this.fileNameTree.Nodes = value; } }

        public ImGuiResourceSelectTree()
        {
        }

        public override void DrawControl()
        {
            // Create a tree view for the file names list.
            ImGui.BeginChild("FileTree", this.Size, this.Border);

            // Make sure the node collection is valid.
            if (this.fileNameTree.Nodes != null)
            {
                // Loop and create nodes for anything that is visible.
                foreach (FileNameTreeNode<T> node in this.fileNameTree.Nodes)
                    ProcessTreeNodes(node);
            }

            ImGui.EndChild();
        }

        private void ProcessTreeNodes(FileNameTreeNode<T> node)
        {
            // Check if this node is a leaf or not.
            if (node.Nodes.Count == 0)
            {
                // Check if we should draw checkboxes or not.
                if (this.Checkboxes == true)
                {
                    // Draw a checkbox for the node.
                    if (ImGui.Checkbox("##chk_" + node.Name, ref node.Checked) == true)
                    {
                        // If there is a checked change event handler call it.
                        if (this.OnTreeNodeCheckedChanged != null)
                            this.OnTreeNodeCheckedChanged(node);
                    }
                    ImGui.SameLine();
                }

                // Create a node for the file.
                if (ImGui.Selectable(node.Name, this.SelectedNode == node.FileDatum, ImGuiSelectableFlags.AllowDoubleClick) == true)
                {
                    // Check if the item was double clicked or not.
                    if (ImGui.IsMouseDoubleClicked(ImGuiMouseButton.Left) == true)
                    {
                        // If there is a double click event handler call it.
                        if (this.OnTreeNodeDoubleClicked != null)
                            this.OnTreeNodeDoubleClicked(node);
                    }
                    else
                    {
                        // Save the old datum.
                        T oldDatum = this.SelectedNode;

                        // Set the selected file datum.
                        this.SelectedNode = node.FileDatum;

                        // If there is a selection changed handler call it.
                        if (this.OnResourceSelectionChanged != null)
                            this.OnResourceSelectionChanged(oldDatum, this.SelectedNode);
                    }
                }

                // Check if the node was right clicked.
                if (ImGui.IsItemHovered() == true && ImGui.IsMouseReleased(ImGuiMouseButton.Right) == true)
                {
                    // If a context menu is set open it and set the node as the right clicked node.
                    if (this.OnDrawContextMenu != null)
                    {
                        this.RightClickedNode = node;
                        ImGui.OpenPopup("file_tree_context_menu");
                    }
                }

                // If the right clicked node is this node draw the context menu.
                if (this.RightClickedNode == node)
                {
                    if (ImGui.BeginPopup("file_tree_context_menu") == true)
                    {
                        // Call the draw context menu handler.
                        if (this.OnDrawContextMenu != null)
                        {
                            // If the handler returns true close the pop up dialog.
                            if (this.OnDrawContextMenu(node) == true)
                                ImGui.CloseCurrentPopup();
                        }

                        ImGui.EndPopup();
                    }
                    else
                        this.RightClickedNode = null;
                }
            }
            else
            {
                // Check if we should draw checkboxes or not.
                if (this.Checkboxes == true)
                {
                    // Draw a checkbox for the node.
                    if (ImGui.Checkbox("##chk_" + node.Name, ref node.Checked) == true)
                    {
                        // Get a list of all child nodes and update the checked state for each one.
                        FileNameTreeNode<T>[] childNodes = node.GetChildNodes();
                        for (int i = 0; i < childNodes.Length; i++)
                        {
                            // Check if the node checked state is actually changing or not.
                            if (childNodes[i].Checked != node.Checked)
                            {
                                // Update the child node checked state.
                                childNodes[i].Checked = node.Checked;

                                // If there is a checked change event handler call it.
                                if (this.OnTreeNodeCheckedChanged != null)
                                    this.OnTreeNodeCheckedChanged(childNodes[i]);
                            }
                        }

                        // If there is a checked change event handler call it.
                        if (this.OnTreeNodeCheckedChanged != null)
                            this.OnTreeNodeCheckedChanged(node);
                    }
                    ImGui.SameLine();
                }

                // Create a tree node for this node.
                node.Expanded = ImGui.TreeNodeEx(node.Name, node.Expanded == true ? ImGuiTreeNodeFlags.DefaultOpen : ImGuiTreeNodeFlags.None);

                // Check if the node was right clicked.
                if (ImGui.IsItemHovered() == true && ImGui.IsMouseReleased(ImGuiMouseButton.Right) == true)
                {
                    // If a context menu is set open it and set the node as the right clicked node.
                    if (this.OnDrawContextMenu != null)
                    {
                        this.RightClickedNode = node;
                        ImGui.OpenPopup("file_tree_context_menu");
                    }
                }

                // If the right clicked node is this node draw the context menu.
                if (this.RightClickedNode == node)
                {
                    if (ImGui.BeginPopup("file_tree_context_menu") == true)
                    {
                        // Call the draw context menu handler.
                        if (this.OnDrawContextMenu != null)
                        {
                            // If the handler returns true close the pop up dialog.
                            if (this.OnDrawContextMenu(node) == true)
                                ImGui.CloseCurrentPopup();
                        }

                        ImGui.EndPopup();
                    }
                    else
                        this.RightClickedNode = null;
                }

                // If the tree node is expanded draw the child nodes.
                if (node.Expanded == true)
                {
                    // Loop through all the child nodes and process recursively.
                    foreach (FileNameTreeNode<T> child in node.Nodes)
                    {
                        // Recursively process the node.
                        ProcessTreeNodes(child);
                    }

                    ImGui.TreePop();
                }
            }
        }
    }
}
