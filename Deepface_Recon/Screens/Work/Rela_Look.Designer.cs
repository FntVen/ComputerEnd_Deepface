using System.ComponentModel;

namespace Deepface_Recon;

partial class Rela_Look
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Rela_Viewer = new System.Windows.Forms.TreeView();
        SuspendLayout();
        // 
        // Rela_Viewer
        // 
        Rela_Viewer.ItemHeight = 25;
        Rela_Viewer.Location = new System.Drawing.Point(12, 12);
        Rela_Viewer.Name = "Rela_Viewer";
        Rela_Viewer.ShowPlusMinus = false;
        Rela_Viewer.ShowRootLines = false;
        Rela_Viewer.Size = new System.Drawing.Size(612, 274);
        Rela_Viewer.TabIndex = 0;
        Rela_Viewer.AfterSelect += Rela_Viewer_AfterSelect;
        Rela_Viewer.NodeMouseDoubleClick += Rela_Viewer_NodeMouseDoubleClick;
        // 
        // Rela_Look
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)205)), ((int)((byte)201)), ((int)((byte)198)));
        ClientSize = new System.Drawing.Size(636, 298);
        Controls.Add(Rela_Viewer);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "Rela_Look";
        ResumeLayout(false);
    }

    private System.Windows.Forms.TreeView Rela_Viewer;

    #endregion
}