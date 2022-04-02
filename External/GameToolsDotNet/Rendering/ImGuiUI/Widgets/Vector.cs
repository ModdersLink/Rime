using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameToolsDotNet.Rendering.ImGuiUI.Widgets
{
    public static partial class ImGuiEx
    {
        public static bool InputVector2(string label, ref short x, ref short y)
        {
            bool valueChanged = false;

            // Get the total width of the widget.
            float totalWidth = ImGui.CalcItemWidth();
            float itemWidthOne = (float)Math.Max(1f, Math.Floor((totalWidth - ImGui.GetStyle().ItemInnerSpacing.X * 1f) / 2f));
            float itemWidthLast = (float)Math.Max(1f, Math.Floor(totalWidth - (itemWidthOne + ImGui.GetStyle().ItemInnerSpacing.X) * 1f));

            // Create a group box using the label as the id.
            ImGui.BeginGroup();
            ImGui.PushID(label);

            // Draw the x component:
            ImGui.SetNextItemWidth(itemWidthOne);
            valueChanged |= ImGui.InputScalarInt16("##x", ref x, 1, 1, "X:%u");

            // Draw the y component:
            ImGui.SameLine(0, ImGui.GetStyle().ItemInnerSpacing.X);
            ImGui.SetNextItemWidth(itemWidthLast);
            valueChanged |= ImGui.InputScalarInt16("##y", ref y, 1, 1, "Y:%u");

            // Pop the group id.
            ImGui.PopID();

            // Draw the label.
            ImGui.SameLine(0f, ImGui.GetStyle().ItemInnerSpacing.X);
            ImGui.Text(label);

            // End the group.
            ImGui.EndGroup();
            return valueChanged;
        }
    }
}
