namespace Deepface_Recon;

partial class Welcome_Screen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Screen));
        NoDownload_Click = new System.Windows.Forms.Button();
        Download_Click = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // NoDownload_Click
        // 
        NoDownload_Click.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        NoDownload_Click.BackColor = System.Drawing.Color.FromArgb(((int)((byte)88)), ((int)((byte)5)), ((int)((byte)191)));
        NoDownload_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        NoDownload_Click.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        NoDownload_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
        NoDownload_Click.Location = new System.Drawing.Point(47, 336);
        NoDownload_Click.Name = "NoDownload_Click";
        NoDownload_Click.Size = new System.Drawing.Size(241, 44);
        NoDownload_Click.TabIndex = 0;
        NoDownload_Click.Text = "Bem-Vindo de Volta";
        NoDownload_Click.UseVisualStyleBackColor = false;
        NoDownload_Click.Click += NoDownload_Click_Click;
        // 
        // Download_Click
        // 
        Download_Click.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        Download_Click.BackColor = System.Drawing.Color.FromArgb(((int)((byte)88)), ((int)((byte)5)), ((int)((byte)191)));
        Download_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Download_Click.Font = new System.Drawing.Font("Bodoni MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Download_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
        Download_Click.Location = new System.Drawing.Point(466, 196);
        Download_Click.Name = "Download_Click";
        Download_Click.Size = new System.Drawing.Size(322, 44);
        Download_Click.TabIndex = 1;
        Download_Click.Text = "Baixar o Necessário";
        Download_Click.UseVisualStyleBackColor = false;
        Download_Click.Click += Download_Click_Click;
        // 
        // label1
        // 
        label1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        label1.BackColor = System.Drawing.Color.Transparent;
        label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlLight;
        label1.Location = new System.Drawing.Point(47, 196);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(240, 100);
        label1.TabIndex = 2;
        label1.Text = "Já fez esse passo antes?\r\nEntão Continue!";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlLight;
        label2.Location = new System.Drawing.Point(466, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(321, 157);
        label2.TabIndex = 3;
        label2.Text = "Seja Bem-Vindo\r\nVamos Iniciar sua\r\nExperiência";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(-213, -66);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(619, 362);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(238, 175);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(752, 485);
        pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 5;
        pictureBox2.TabStop = false;
        pictureBox2.Click += pictureBox2_Click;
        // 
        // pictureBox3
        // 
        pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
        pictureBox3.Image = ((System.Drawing.Image)resources.GetObject("pictureBox3.Image"));
        pictureBox3.Location = new System.Drawing.Point(292, 146);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new System.Drawing.Size(168, 148);
        pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 6;
        pictureBox3.TabStop = false;
        // 
        // Welcome_Screen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)53)), ((int)((byte)53)), ((int)((byte)53)));
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Download_Click);
        Controls.Add(label1);
        Controls.Add(pictureBox3);
        Controls.Add(label2);
        Controls.Add(NoDownload_Click);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Text = "Águia-Eye";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox pictureBox3;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button Download_Click;

    private System.Windows.Forms.Button NoDownload_Click;

    #endregion
}