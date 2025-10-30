using System.ComponentModel;

namespace Deepface_Recon;

partial class Setup_Download
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup_Download));
        Procede_Click = new System.Windows.Forms.Button();
        GoBack_Click = new System.Windows.Forms.Button();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // Procede_Click
        // 
        Procede_Click.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Procede_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Procede_Click.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Procede_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
        Procede_Click.Location = new System.Drawing.Point(587, 293);
        Procede_Click.Name = "Procede_Click";
        Procede_Click.Size = new System.Drawing.Size(148, 38);
        Procede_Click.TabIndex = 0;
        Procede_Click.Text = "Entendido";
        Procede_Click.UseVisualStyleBackColor = false;
        Procede_Click.Click += Procede_Click_Click;
        // 
        // GoBack_Click
        // 
        GoBack_Click.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        GoBack_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        GoBack_Click.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        GoBack_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
        GoBack_Click.Location = new System.Drawing.Point(12, 293);
        GoBack_Click.Name = "GoBack_Click";
        GoBack_Click.Size = new System.Drawing.Size(148, 38);
        GoBack_Click.TabIndex = 1;
        GoBack_Click.Text = "Cancelar";
        GoBack_Click.UseVisualStyleBackColor = false;
        GoBack_Click.Click += GoBack_Click_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(12, 86);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(348, 186);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(391, 86);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(344, 186);
        pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)55)), ((int)((byte)55)));
        label1.Location = new System.Drawing.Point(198, -4);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(345, 36);
        label1.TabIndex = 4;
        label1.Text = "Aviso: Não Feche Essas Telas";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)55)), ((int)((byte)55)));
        label2.Location = new System.Drawing.Point(12, 28);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(722, 55);
        label2.TabIndex = 5;
        label2.Text = ("Durante o download de recursos essenciais ambas telas demonstradas abaixo vão apa" + "recer. Prompt de Comando e Python Installer.\r\nNão as feche!");
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label2.Click += label2_Click;
        // 
        // Setup_Download
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)245)), ((int)((byte)244)));
        ClientSize = new System.Drawing.Size(747, 343);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(GoBack_Click);
        Controls.Add(Procede_Click);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Setup_Download";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Button Procede_Click;
    private System.Windows.Forms.Button GoBack_Click;

    #endregion
}