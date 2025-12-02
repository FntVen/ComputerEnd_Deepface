using System.ComponentModel;

namespace Deepface_Recon;

partial class Database_Work
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
        Database_View = new System.Windows.Forms.TreeView();
        button1 = new System.Windows.Forms.Button();
        Back = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        ShowSelection = new System.Windows.Forms.RichTextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // Database_View
        // 
        Database_View.Location = new System.Drawing.Point(7, 5);
        Database_View.Name = "Database_View";
        Database_View.Size = new System.Drawing.Size(632, 359);
        Database_View.TabIndex = 0;
        Database_View.AfterSelect += Database_View_AfterSelect;
        Database_View.NodeMouseClick += Database_View_NodeMouseClick;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        button1.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ForeColor = System.Drawing.SystemColors.ControlLight;
        button1.Location = new System.Drawing.Point(509, 405);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(130, 43);
        button1.TabIndex = 1;
        button1.Text = "Adicionar Imagens";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // Back
        // 
        Back.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Back.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Back.ForeColor = System.Drawing.SystemColors.ControlLight;
        Back.Location = new System.Drawing.Point(7, 405);
        Back.Name = "Back";
        Back.Size = new System.Drawing.Size(130, 43);
        Back.TabIndex = 2;
        Back.Text = "Voltar";
        Back.UseVisualStyleBackColor = false;
        Back.Click += Back_Click;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        button3.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button3.ForeColor = System.Drawing.SystemColors.ControlLight;
        button3.Location = new System.Drawing.Point(373, 405);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(130, 43);
        button3.TabIndex = 3;
        button3.Text = "Criar Database";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // ShowSelection
        // 
        ShowSelection.Location = new System.Drawing.Point(81, 370);
        ShowSelection.Name = "ShowSelection";
        ShowSelection.ReadOnly = true;
        ShowSelection.Size = new System.Drawing.Size(558, 24);
        ShowSelection.TabIndex = 4;
        ShowSelection.Text = "";
        ShowSelection.TextChanged += ShowSelection_TextChanged;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(0, 370);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(88, 24);
        label1.TabIndex = 5;
        label1.Text = "Selecionado:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Database_Work
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)205)), ((int)((byte)201)), ((int)((byte)198)));
        ClientSize = new System.Drawing.Size(647, 456);
        Controls.Add(ShowSelection);
        Controls.Add(label1);
        Controls.Add(button3);
        Controls.Add(Back);
        Controls.Add(button1);
        Controls.Add(Database_View);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "Database_Work";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.RichTextBox ShowSelection;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button Back;
    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.TreeView Database_View;

    #endregion
}