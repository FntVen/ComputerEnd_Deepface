using System.ComponentModel;

namespace Deepface_Recon.SubMenus;

partial class DirCreate
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
        DatabaseNotice = new System.Windows.Forms.Label();
        dbNameField = new System.Windows.Forms.RichTextBox();
        Confirm = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // DatabaseNotice
        // 
        DatabaseNotice.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        DatabaseNotice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        DatabaseNotice.Location = new System.Drawing.Point(-41, 8);
        DatabaseNotice.Name = "DatabaseNotice";
        DatabaseNotice.Size = new System.Drawing.Size(193, 31);
        DatabaseNotice.TabIndex = 0;
        DatabaseNotice.Text = "Nome da Database:";
        DatabaseNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dbNameField
        // 
        dbNameField.Location = new System.Drawing.Point(109, 12);
        dbNameField.Name = "dbNameField";
        dbNameField.Size = new System.Drawing.Size(491, 22);
        dbNameField.TabIndex = 1;
        dbNameField.Text = "";
        dbNameField.TextChanged += dbNameField_TextChanged;
        // 
        // Confirm
        // 
        Confirm.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Confirm.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Confirm.ForeColor = System.Drawing.SystemColors.ControlLight;
        Confirm.Location = new System.Drawing.Point(450, 37);
        Confirm.Name = "Confirm";
        Confirm.Size = new System.Drawing.Size(143, 25);
        Confirm.TabIndex = 2;
        Confirm.Text = "Confirmar";
        Confirm.UseVisualStyleBackColor = false;
        Confirm.Click += Confirm_Click;
        // 
        // DirCreate
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)245)), ((int)((byte)244)));
        ClientSize = new System.Drawing.Size(611, 66);
        Controls.Add(Confirm);
        Controls.Add(dbNameField);
        Controls.Add(DatabaseNotice);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "DirCreate";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button Confirm;

    private System.Windows.Forms.RichTextBox dbNameField;

    private System.Windows.Forms.Label DatabaseNotice;

    #endregion
}