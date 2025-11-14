using System.ComponentModel;

namespace Deepface_Recon;

partial class AskUser
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskUser));
        UserOptions_CB = new System.Windows.Forms.ComboBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        GoBack_Click = new System.Windows.Forms.Button();
        Proceed_Click = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // UserOptions_CB
        // 
        UserOptions_CB.FormattingEnabled = true;
        UserOptions_CB.Location = new System.Drawing.Point(8, 80);
        UserOptions_CB.Name = "UserOptions_CB";
        UserOptions_CB.Size = new System.Drawing.Size(719, 23);
        UserOptions_CB.TabIndex = 0;
        UserOptions_CB.SelectedIndexChanged += UserOptions_CB_SelectedIndexChanged_1;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(252, 94);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(228, 203);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)55)), ((int)((byte)55)));
        label1.Location = new System.Drawing.Point(10, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(725, 54);
        label1.TabIndex = 2;
        label1.Text = "Qual usuario está instalando Água-Eye?";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)55)), ((int)((byte)55)));
        label2.Location = new System.Drawing.Point(203, 45);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(324, 35);
        label2.TabIndex = 3;
        label2.Text = "Selecione Abaixo";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // GoBack_Click
        // 
        GoBack_Click.BackColor = System.Drawing.Color.Transparent;
        GoBack_Click.BackgroundImage = ((System.Drawing.Image)resources.GetObject("GoBack_Click.BackgroundImage"));
        GoBack_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        GoBack_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        GoBack_Click.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        GoBack_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
        GoBack_Click.Location = new System.Drawing.Point(6, 258);
        GoBack_Click.Name = "GoBack_Click";
        GoBack_Click.Size = new System.Drawing.Size(253, 43);
        GoBack_Click.TabIndex = 4;
        GoBack_Click.Text = "Cancelar";
        GoBack_Click.UseVisualStyleBackColor = false;
        GoBack_Click.Click += GoBack_Click_Click;
        // 
        // Proceed_Click
        // 
        Proceed_Click.BackColor = System.Drawing.Color.Transparent;
        Proceed_Click.BackgroundImage = ((System.Drawing.Image)resources.GetObject("Proceed_Click.BackgroundImage"));
        Proceed_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        Proceed_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Proceed_Click.Font = new System.Drawing.Font("Bodoni MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Proceed_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
        Proceed_Click.Location = new System.Drawing.Point(473, 258);
        Proceed_Click.Name = "Proceed_Click";
        Proceed_Click.Size = new System.Drawing.Size(253, 43);
        Proceed_Click.TabIndex = 5;
        Proceed_Click.Text = "Confirmar";
        Proceed_Click.UseVisualStyleBackColor = false;
        Proceed_Click.Click += Proceed_Click_Click;
        // 
        // AskUser
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)245)), ((int)((byte)240)));
        ClientSize = new System.Drawing.Size(732, 340);
        Controls.Add(UserOptions_CB);
        Controls.Add(Proceed_Click);
        Controls.Add(GoBack_Click);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Location = new System.Drawing.Point(15, 15);
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Load += AskUser_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button GoBack_Click;
    private System.Windows.Forms.Button Proceed_Click;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.ComboBox UserOptions_CB;

    #endregion
}