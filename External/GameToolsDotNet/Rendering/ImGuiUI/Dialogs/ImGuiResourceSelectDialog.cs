using GameToolsDotNet.Extensions;
using ImGuiNET;
using ImVector2 = System.Numerics.Vector2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameToolsDotNet.Utilities;

namespace GameToolsDotNet.Rendering.ImGuiUI.Dialogs
{
    public class ImGuiResourceSelectDialog<T> : ImGuiDialogBox where T : class
    {
        private List<FileNameTreeNode<T>> selectedFiles = new List<FileNameTreeNode<T>>();
        /// <summary>
        /// DatumIndex for the file that was selected
        /// </summary>
        public T[] SelectedFiles { get { return this.selectedFiles.Select(node => node.FileDatum).ToArray(); } }
        /// <summary>
        /// True if multiple files may be selected, or false to only allow one file to be selected.
        /// </summary>
        public bool MultiSelect { get; set; } = false;

        public delegate bool OnResourceSelectedHandler(T[] datums, out string errorMessage);
        /// <summary>
        /// Callback for when a file is selected and the ok button is pressed, returns true if the resource
        /// is acceptible, or false otherwise.
        /// </summary>
        public OnResourceSelectedHandler OnResourceSelected { get; set; } = null;

        public delegate bool FileTreeFilterHandler(FileNameTreeNode<T> node);
        /// <summary>
        /// Callback used to filter nodes that should or shouldn't be displayed. Returns true if the tree node
        /// should be displayed, or false if it should be hidden. If no callback is set all nodes are displayed.
        /// </summary>
        public FileTreeFilterHandler TreeNodeFilter { get; set; } = null;

        // File names to display in the treeview.
        private FileNameTree<T> fileTree;

        // Used to display errors to the user.
        private ImGuiMessageBox errorDialog;

        public ImGuiResourceSelectDialog(string title, FileNameTree<T> fileTree) : base(title)
        {
            // Initialize fields.
            this.fileTree = fileTree;
        }

        public override bool DrawDialog()
        {
            // If the dialog result has been set then bail out.
            if (this.Result != ImGuiDialogBoxResult.None)
                return true;

            // Always center the window when appearing.
            ImVector2 center = new ImVector2(ImGui.GetIO().DisplaySize.X * 0.5f, ImGui.GetIO().DisplaySize.Y * 0.5f);
            ImGui.SetNextWindowPos(center, ImGuiCond.Appearing, new ImVector2(0.5f, 0.5f));
            ImGui.SetNextWindowSize(new ImVector2(600, 420), ImGuiCond.Appearing);

            // Show the file selection dialog.
            if (ImGui.BeginPopupModal(this.Title) == true)
            {
                // Create a tree view for the file names list.
                ImGui.BeginChild("FileTree", new ImVector2(0, 360), true);
                foreach (FileNameTreeNode<T> node in this.fileTree.Nodes)
                    ProcessTreeNodes(node);
                ImGui.EndChild();

                // Center the buttons in the dialog.
                ImGui.SetCursorPosX((ImGui.GetWindowSize().X - ((120f * 2f) + 10f)) / 2f);

                // Create the cancel and okay buttons.
                if (ImGui.Button("Cancel", new ImVector2(120, 0)) == true)
                {
                    // Close the dialog and clear the file name list.
                    this.Result = ImGuiDialogBoxResult.Cancel;
                    CloseDialog();
                    this.fileTree = null;
                }

                // If there is no selected file in the treeview, disable the okay button.
                if (this.selectedFiles.Count == 0)
                {
                    ImGui.PushItemFlag(ImGuiItemFlags.Disabled, true);
                    ImGui.PushStyleVar(ImGuiStyleVar.Alpha, ImGui.GetStyle().Alpha * 0.5f);
                }

                ImGui.SameLine();
                if (ImGui.Button("Ok", new ImVector2(120, 0)) == true)
                {
                    // If there is a callback set for datum index approval, call it.
                    if (this.OnResourceSelected != null)
                    {
                        // Call the callback with the selected file datum.
                        string errorMessage = null;
                        if (this.OnResourceSelected(this.SelectedFiles, out errorMessage) == true)
                        {
                            // Close the dialog and clear the file name list.
                            this.Result = ImGuiDialogBoxResult.Ok;
                            CloseDialog();
                            this.fileTree = null;
                        }
                        else if (errorMessage != null)
                        {
                            // Create a new dialog to display the error to the user.
                            this.errorDialog = new ImGuiMessageBox("File select error", errorMessage, ImGuiMessageBoxOptions.Ok);
                            this.errorDialog.ShowDialog();
                        }
                    }
                    else
                    {
                        // Assume the datum is fine.
                        this.Result = ImGuiDialogBoxResult.Ok;
                        CloseDialog();
                        this.fileTree = null;
                    }
                }

                // Restore style if needed.
                if (this.selectedFiles.Count == 0)
                {
                    ImGui.PopItemFlag();
                    ImGui.PopStyleVar();
                }

                // Check if we need to draw the error dialog.
                if (this.errorDialog != null)
                {
                    // Draw the dialog.
                    if (this.errorDialog.DrawDialog() == true)
                    {
                        // Destroy the dialog instance.
                        this.errorDialog = null;
                    }
                }

                ImGui.EndPopup();
            }
            else
            {
                // TODO:
            }

            // Return the draw result.
            return this.Result != ImGuiDialogBoxResult.None;
        }

        private void ProcessTreeNodes(FileNameTreeNode<T> node)
        {
            // If the filter callback is set call it to determine if this node should be drawn.
            if (this.TreeNodeFilter != null && this.TreeNodeFilter(node) == false)
                return;

            // Check if this node is a leaf or not.
            if (node.Nodes.Count == 0)
            {
                // Create a node for the file.
                if (ImGui.Selectable(node.Name, node.Checked) == true)
                {
                    // Check the selected state of the node and handle accordingly.
                    if (node.Checked == false)
                    {
                        // Check if multi select is enabled and the control key was pressed.
                        if (this.MultiSelect == false || (this.MultiSelect == true && ImGui.GetIO().KeyCtrl == false))
                        {
                            // Clear selected files.
                            ClearSelectedFiles();
                        }

                        // Set the node as checked and add it to the selected node list.
                        node.Checked = true;
                        this.selectedFiles.Add(node);
                    }
                    else
                    {
                        // Check if multi select is enabled and the control key was pressed.
                        if (this.MultiSelect == false || (this.MultiSelect == true && ImGui.GetIO().KeyCtrl == false))
                        {
                            // Clear selected files.
                            ClearSelectedFiles();

                            // Make sure this node is the only one selected.
                            node.Checked = true;
                            this.selectedFiles.Add(node);
                        }
                        else if (this.selectedFiles.Count > 1)
                        {
                            // Remove the node from the selected node list.
                            node.Checked = false;
                            this.selectedFiles.Remove(node);
                        }
                    }
                }
            }
            else
            {
                // Create a tree node for this node.
                if (ImGui.TreeNodeEx(node.Name) == true)
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

        private void ClearSelectedFiles()
        {
            // Loop and clear the selected file list.
            for (int i = this.selectedFiles.Count - 1; i >= 0; i--)
            {
                // Remove the node from the list.
                this.selectedFiles[i].Checked = false;
                this.selectedFiles.RemoveAt(i);

            }
        }
    }
}
