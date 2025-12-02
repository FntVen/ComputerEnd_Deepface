using System.ComponentModel;

namespace Deepface_Recon;

partial class SelectImage
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
        FileSearcher = new System.Windows.Forms.TreeView();
        Sel_File = new System.Windows.Forms.Button();
        Sel_Dir = new System.Windows.Forms.Button();
        Back = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // FileSearcher
        // 
        FileSearcher.Location = new System.Drawing.Point(11, 12);
        FileSearcher.Name = "FileSearcher";
        FileSearcher.Size = new System.Drawing.Size(603, 349);
        FileSearcher.TabIndex = 0;
        FileSearcher.AfterSelect += FileSearcher_AfterSelect;
        FileSearcher.NodeMouseClick += FileSearcher_NodeMouseClick;
        FileSearcher.NodeMouseDoubleClick += FileSearcher_NodeMouseDoubleClick;
        // 
        // Sel_File
        // 
        Sel_File.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Sel_File.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Sel_File.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Sel_File.ForeColor = System.Drawing.SystemColors.ControlLight;
        Sel_File.Location = new System.Drawing.Point(471, 379);
        Sel_File.Name = "Sel_File";
        Sel_File.Size = new System.Drawing.Size(143, 40);
        Sel_File.TabIndex = 1;
        Sel_File.Text = "Selecionar arquivo";
        Sel_File.UseVisualStyleBackColor = false;
        Sel_File.Click += Sel_File_Click;
        // 
        // Sel_Dir
        // 
        Sel_Dir.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Sel_Dir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Sel_Dir.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Sel_Dir.ForeColor = System.Drawing.SystemColors.ControlLight;
        Sel_Dir.Location = new System.Drawing.Point(313, 379);
        Sel_Dir.Name = "Sel_Dir";
        Sel_Dir.Size = new System.Drawing.Size(143, 40);
        Sel_Dir.TabIndex = 2;
        Sel_Dir.Text = "Selecionar Pasta";
        Sel_Dir.UseVisualStyleBackColor = false;
        Sel_Dir.Click += Sel_Dir_Click;
        // 
        // Back
        // 
        Back.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Back.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Back.ForeColor = System.Drawing.SystemColors.ControlLight;
        Back.Location = new System.Drawing.Point(11, 379);
        Back.Name = "Back";
        Back.Size = new System.Drawing.Size(143, 40);
        Back.TabIndex = 3;
        Back.Text = "Voltar";
        Back.UseVisualStyleBackColor = false;
        Back.Click += Back_Click;
        // 
        // SelectImage
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)205)), ((int)((byte)201)), ((int)((byte)198)));
        ClientSize = new System.Drawing.Size(626, 426);
        Controls.Add(Back);
        Controls.Add(Sel_Dir);
        Controls.Add(Sel_File);
        Controls.Add(FileSearcher);
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "SelectImage";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button Sel_Dir;
    private System.Windows.Forms.Button Back;

    private System.Windows.Forms.Button Sel_File;

    private System.Windows.Forms.TreeView FileSearcher;

    #endregion
}