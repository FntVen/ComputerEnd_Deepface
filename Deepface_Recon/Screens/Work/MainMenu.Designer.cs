using System.ComponentModel;

namespace Deepface_Recon;

partial class MainMenu
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
        pictureBox2 = new System.Windows.Forms.PictureBox();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        Iniciar = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        Ver_R = new System.Windows.Forms.Button();
        Criar_R = new System.Windows.Forms.Button();
        Entenda = new System.Windows.Forms.Button();
        richTextBox1 = new System.Windows.Forms.RichTextBox();
        UserConsole = new System.Windows.Forms.RichTextBox();
        Databases = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = System.Drawing.Color.White;
        pictureBox2.Location = new System.Drawing.Point(567, 307);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(228, 82);
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.BackColor = System.Drawing.Color.White;
        pictureBox3.Location = new System.Drawing.Point(567, 22);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new System.Drawing.Size(228, 279);
        pictureBox3.TabIndex = 2;
        pictureBox3.TabStop = false;
        // 
        // Iniciar
        // 
        Iniciar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Iniciar.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Iniciar.ForeColor = System.Drawing.SystemColors.ControlLight;
        Iniciar.Location = new System.Drawing.Point(416, 399);
        Iniciar.Name = "Iniciar";
        Iniciar.Size = new System.Drawing.Size(137, 43);
        Iniciar.TabIndex = 3;
        Iniciar.Text = "Iniciar";
        Iniciar.UseVisualStyleBackColor = false;
        Iniciar.Click += Iniciar_Click;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.White;
        label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        label1.Location = new System.Drawing.Point(573, 308);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(215, 45);
        label1.TabIndex = 6;
        label1.Text = "Insira esse Link no aplicativo \r\nem seu dispositivo móvel";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Ver_R
        // 
        Ver_R.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Ver_R.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Ver_R.Location = new System.Drawing.Point(573, 40);
        Ver_R.Name = "Ver_R";
        Ver_R.Size = new System.Drawing.Size(214, 45);
        Ver_R.TabIndex = 8;
        Ver_R.Text = "Ver Relatórios";
        Ver_R.UseVisualStyleBackColor = true;
        Ver_R.Click += Ver_R_Click;
        // 
        // Criar_R
        // 
        Criar_R.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Criar_R.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Criar_R.Location = new System.Drawing.Point(574, 105);
        Criar_R.Name = "Criar_R";
        Criar_R.Size = new System.Drawing.Size(214, 45);
        Criar_R.TabIndex = 9;
        Criar_R.Text = "Criar Relatórios";
        Criar_R.UseVisualStyleBackColor = true;
        Criar_R.Click += Criar_R_Click;
        // 
        // Entenda
        // 
        Entenda.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)29)), ((int)((byte)44)));
        Entenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Entenda.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Entenda.ForeColor = System.Drawing.SystemColors.ControlLight;
        Entenda.Location = new System.Drawing.Point(567, 399);
        Entenda.Name = "Entenda";
        Entenda.Size = new System.Drawing.Size(228, 43);
        Entenda.TabIndex = 11;
        Entenda.Text = "Entenda Mais";
        Entenda.UseVisualStyleBackColor = false;
        Entenda.Click += Entenda_Click;
        // 
        // richTextBox1
        // 
        richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        richTextBox1.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        richTextBox1.Location = new System.Drawing.Point(574, 348);
        richTextBox1.Multiline = false;
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ReadOnly = true;
        richTextBox1.Size = new System.Drawing.Size(213, 30);
        richTextBox1.TabIndex = 13;
        richTextBox1.Text = "";
        richTextBox1.TextChanged += richTextBox1_TextChanged;
        // 
        // UserConsole
        // 
        UserConsole.BackColor = System.Drawing.Color.White;
        UserConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
        UserConsole.Location = new System.Drawing.Point(25, 22);
        UserConsole.Name = "UserConsole";
        UserConsole.ReadOnly = true;
        UserConsole.Size = new System.Drawing.Size(528, 367);
        UserConsole.TabIndex = 14;
        UserConsole.Text = "";
        UserConsole.TextChanged += UserConsole_TextChanged;
        // 
        // Databases
        // 
        Databases.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        Databases.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Databases.Location = new System.Drawing.Point(574, 244);
        Databases.Name = "Databases";
        Databases.Size = new System.Drawing.Size(214, 45);
        Databases.TabIndex = 15;
        Databases.Text = "Gerenciar Databases";
        Databases.UseVisualStyleBackColor = true;
        Databases.Click += Databases_Click;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)205)), ((int)((byte)201)), ((int)((byte)198)));
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(Databases);
        Controls.Add(UserConsole);
        Controls.Add(richTextBox1);
        Controls.Add(Entenda);
        Controls.Add(Criar_R);
        Controls.Add(Ver_R);
        Controls.Add(label1);
        Controls.Add(Iniciar);
        Controls.Add(pictureBox3);
        Controls.Add(pictureBox2);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "MainMenu";
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button Databases;

    private System.Windows.Forms.RichTextBox UserConsole;

    private System.Windows.Forms.RichTextBox richTextBox1;

    private System.Windows.Forms.Button Entenda;

    private System.Windows.Forms.Button Criar_R;

    private System.Windows.Forms.Button Ver_R;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button Iniciar;

    private System.Windows.Forms.PictureBox pictureBox3;

    private System.Windows.Forms.PictureBox pictureBox2;

    #endregion
}