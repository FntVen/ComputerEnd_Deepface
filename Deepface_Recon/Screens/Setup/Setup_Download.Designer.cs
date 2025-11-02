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
        Procede_Click.BackColor = System.Drawing.Color.Transparent;
        Procede_Click.BackgroundImage = ((System.Drawing.Image)resources.GetObject("Procede_Click.BackgroundImage"));
        Procede_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        Procede_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Procede_Click.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Procede_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
        Procede_Click.Location = new System.Drawing.Point(453, 285);
        Procede_Click.Name = "Procede_Click";
        Procede_Click.Size = new System.Drawing.Size(273, 46);
        Procede_Click.TabIndex = 0;
        Procede_Click.Text = "Entendido";
        Procede_Click.UseVisualStyleBackColor = false;
        Procede_Click.Click += Procede_Click_Click;
        // 
        // GoBack_Click
        // 
        GoBack_Click.BackColor = System.Drawing.Color.Transparent;
        GoBack_Click.BackgroundImage = ((System.Drawing.Image)resources.GetObject("GoBack_Click.BackgroundImage"));
        GoBack_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        GoBack_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        GoBack_Click.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        GoBack_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
        GoBack_Click.Location = new System.Drawing.Point(12, 285);
        GoBack_Click.Name = "GoBack_Click";
        GoBack_Click.Size = new System.Drawing.Size(273, 46);
        GoBack_Click.TabIndex = 1;
        GoBack_Click.Text = "Cancelar";
        GoBack_Click.UseVisualStyleBackColor = false;
        GoBack_Click.Click += GoBack_Click_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(12, 88);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(320, 182);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(415, 88);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(320, 182);
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(102, -4);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(548, 41);
        label1.TabIndex = 4;
        label1.Text = "Aviso!";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(37, 31);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(697, 54);
        label2.TabIndex = 5;
        label2.Text = "Durante o download das dependencias essas duas telas serão abertas\r\nNão as feche!";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        Location = new System.Drawing.Point(15, 15);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button Procede_Click;
    private System.Windows.Forms.Button GoBack_Click;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label1;

    #endregion
}