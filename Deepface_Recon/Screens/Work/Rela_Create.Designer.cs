using System.ComponentModel;

namespace Deepface_Recon;

partial class Rela_Create
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
        ComboSessãoList = new System.Windows.Forms.ComboBox();
        Back = new System.Windows.Forms.Button();
        Confirm = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // ComboSessãoList
        // 
        ComboSessãoList.FlatStyle = System.Windows.Forms.FlatStyle.System;
        ComboSessãoList.FormattingEnabled = true;
        ComboSessãoList.Location = new System.Drawing.Point(11, 63);
        ComboSessãoList.Name = "ComboSessãoList";
        ComboSessãoList.Size = new System.Drawing.Size(620, 23);
        ComboSessãoList.TabIndex = 0;
        ComboSessãoList.SelectedIndexChanged += ComboSessãoList_SelectedIndexChanged;
        // 
        // Back
        // 
        Back.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Back.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Back.ForeColor = System.Drawing.SystemColors.ControlLight;
        Back.Location = new System.Drawing.Point(13, 251);
        Back.Name = "Back";
        Back.Size = new System.Drawing.Size(156, 36);
        Back.TabIndex = 1;
        Back.Text = "Voltar";
        Back.UseVisualStyleBackColor = false;
        // 
        // Confirm
        // 
        Confirm.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Confirm.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Confirm.ForeColor = System.Drawing.SystemColors.ControlLight;
        Confirm.Location = new System.Drawing.Point(474, 251);
        Confirm.Name = "Confirm";
        Confirm.Size = new System.Drawing.Size(156, 36);
        Confirm.TabIndex = 2;
        Confirm.Text = "Confirmar";
        Confirm.UseVisualStyleBackColor = false;
        Confirm.Click += Confirm_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)55)), ((int)((byte)55)));
        label1.Location = new System.Drawing.Point(13, 3);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(617, 60);
        label1.TabIndex = 3;
        label1.Text = "Gostaria de fazer um relatório\r\nde qual Sessão?";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Rela_Create
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)245)), ((int)((byte)244)));
        ClientSize = new System.Drawing.Size(643, 299);
        Controls.Add(label1);
        Controls.Add(Confirm);
        Controls.Add(Back);
        Controls.Add(ComboSessãoList);
        Cursor = System.Windows.Forms.Cursors.Arrow;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowIcon = false;
        ShowInTaskbar = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Rela_Create";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox ComboSessãoList;
    private System.Windows.Forms.Button Back;
    private System.Windows.Forms.Button Confirm;
    private System.Windows.Forms.Label label1;

    #endregion
}