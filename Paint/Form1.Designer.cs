namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCoordenada = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.cbxDots = new System.Windows.Forms.CheckBox();
            this.imgColores = new System.Windows.Forms.PictureBox();
            this.nudGrosor = new System.Windows.Forms.NumericUpDown();
            this.btntexto = new System.Windows.Forms.Button();
            this.btnlinea = new System.Windows.Forms.Button();
            this.btnhexagono = new System.Windows.Forms.Button();
            this.btncirculo = new System.Windows.Forms.Button();
            this.btnborrador = new System.Windows.Forms.Button();
            this.btncuadro = new System.Windows.Forms.Button();
            this.btnpluma = new System.Windows.Forms.Button();
            this.btnlapiz = new System.Windows.Forms.Button();
            this.imgdibujo = new System.Windows.Forms.PictureBox();
            this.cdgColores = new System.Windows.Forms.ColorDialog();
            this.sfdGuardarComo = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgColores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.borrarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCoordenada,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCoordenada
            // 
            this.lblCoordenada.Name = "lblCoordenada";
            this.lblCoordenada.Size = new System.Drawing.Size(118, 17);
            this.lblCoordenada.Text = "toolStripStatusLabel1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnColor);
            this.splitContainer1.Panel1.Controls.Add(this.btnFill);
            this.splitContainer1.Panel1.Controls.Add(this.btnTriangulo);
            this.splitContainer1.Panel1.Controls.Add(this.cbxDots);
            this.splitContainer1.Panel1.Controls.Add(this.imgColores);
            this.splitContainer1.Panel1.Controls.Add(this.nudGrosor);
            this.splitContainer1.Panel1.Controls.Add(this.btntexto);
            this.splitContainer1.Panel1.Controls.Add(this.btnlinea);
            this.splitContainer1.Panel1.Controls.Add(this.btnhexagono);
            this.splitContainer1.Panel1.Controls.Add(this.btncirculo);
            this.splitContainer1.Panel1.Controls.Add(this.btnborrador);
            this.splitContainer1.Panel1.Controls.Add(this.btncuadro);
            this.splitContainer1.Panel1.Controls.Add(this.btnpluma);
            this.splitContainer1.Panel1.Controls.Add(this.btnlapiz);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.imgdibujo);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(642, 347);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(83, 257);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(43, 63);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Snow;
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.Location = new System.Drawing.Point(70, 143);
            this.btnFill.Margin = new System.Windows.Forms.Padding(2);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(56, 41);
            this.btnFill.TabIndex = 12;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTriangulo.Image = ((System.Drawing.Image)(resources.GetObject("btnTriangulo.Image")));
            this.btnTriangulo.Location = new System.Drawing.Point(9, 143);
            this.btnTriangulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(56, 41);
            this.btnTriangulo.TabIndex = 11;
            this.btnTriangulo.UseVisualStyleBackColor = false;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // cbxDots
            // 
            this.cbxDots.AutoSize = true;
            this.cbxDots.Location = new System.Drawing.Point(42, 324);
            this.cbxDots.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDots.Name = "cbxDots";
            this.cbxDots.Size = new System.Drawing.Size(48, 17);
            this.cbxDots.TabIndex = 9;
            this.cbxDots.Text = "Dots";
            this.cbxDots.UseVisualStyleBackColor = true;
            // 
            // imgColores
            // 
            this.imgColores.Image = ((System.Drawing.Image)(resources.GetObject("imgColores.Image")));
            this.imgColores.Location = new System.Drawing.Point(11, 257);
            this.imgColores.Margin = new System.Windows.Forms.Padding(2);
            this.imgColores.Name = "imgColores";
            this.imgColores.Size = new System.Drawing.Size(115, 63);
            this.imgColores.TabIndex = 8;
            this.imgColores.TabStop = false;
            this.imgColores.Click += new System.EventHandler(this.imgColores_Click);
            // 
            // nudGrosor
            // 
            this.nudGrosor.Location = new System.Drawing.Point(26, 233);
            this.nudGrosor.Margin = new System.Windows.Forms.Padding(2);
            this.nudGrosor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosor.Name = "nudGrosor";
            this.nudGrosor.Size = new System.Drawing.Size(90, 20);
            this.nudGrosor.TabIndex = 3;
            this.nudGrosor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btntexto
            // 
            this.btntexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btntexto.Image = ((System.Drawing.Image)(resources.GetObject("btntexto.Image")));
            this.btntexto.Location = new System.Drawing.Point(70, 188);
            this.btntexto.Margin = new System.Windows.Forms.Padding(2);
            this.btntexto.Name = "btntexto";
            this.btntexto.Size = new System.Drawing.Size(56, 41);
            this.btntexto.TabIndex = 7;
            this.btntexto.UseVisualStyleBackColor = false;
            // 
            // btnlinea
            // 
            this.btnlinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlinea.Image = ((System.Drawing.Image)(resources.GetObject("btnlinea.Image")));
            this.btnlinea.Location = new System.Drawing.Point(9, 188);
            this.btnlinea.Margin = new System.Windows.Forms.Padding(2);
            this.btnlinea.Name = "btnlinea";
            this.btnlinea.Size = new System.Drawing.Size(56, 41);
            this.btnlinea.TabIndex = 6;
            this.btnlinea.UseVisualStyleBackColor = false;
            this.btnlinea.Click += new System.EventHandler(this.btnlinea_Click);
            // 
            // btnhexagono
            // 
            this.btnhexagono.BackColor = System.Drawing.Color.Pink;
            this.btnhexagono.Image = ((System.Drawing.Image)(resources.GetObject("btnhexagono.Image")));
            this.btnhexagono.Location = new System.Drawing.Point(69, 98);
            this.btnhexagono.Margin = new System.Windows.Forms.Padding(2);
            this.btnhexagono.Name = "btnhexagono";
            this.btnhexagono.Size = new System.Drawing.Size(56, 41);
            this.btnhexagono.TabIndex = 5;
            this.btnhexagono.UseVisualStyleBackColor = false;
            this.btnhexagono.Click += new System.EventHandler(this.btnhexagono_Click);
            // 
            // btncirculo
            // 
            this.btncirculo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btncirculo.Image = ((System.Drawing.Image)(resources.GetObject("btncirculo.Image")));
            this.btncirculo.Location = new System.Drawing.Point(9, 98);
            this.btncirculo.Margin = new System.Windows.Forms.Padding(2);
            this.btncirculo.Name = "btncirculo";
            this.btncirculo.Size = new System.Drawing.Size(56, 41);
            this.btncirculo.TabIndex = 4;
            this.btncirculo.UseVisualStyleBackColor = false;
            this.btncirculo.Click += new System.EventHandler(this.btncirculo_Click);
            // 
            // btnborrador
            // 
            this.btnborrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnborrador.Image = ((System.Drawing.Image)(resources.GetObject("btnborrador.Image")));
            this.btnborrador.Location = new System.Drawing.Point(70, 56);
            this.btnborrador.Margin = new System.Windows.Forms.Padding(2);
            this.btnborrador.Name = "btnborrador";
            this.btnborrador.Size = new System.Drawing.Size(56, 41);
            this.btnborrador.TabIndex = 3;
            this.btnborrador.UseVisualStyleBackColor = false;
            this.btnborrador.Click += new System.EventHandler(this.btnborrador_Click);
            // 
            // btncuadro
            // 
            this.btncuadro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncuadro.Image = ((System.Drawing.Image)(resources.GetObject("btncuadro.Image")));
            this.btncuadro.Location = new System.Drawing.Point(9, 55);
            this.btncuadro.Margin = new System.Windows.Forms.Padding(2);
            this.btncuadro.Name = "btncuadro";
            this.btncuadro.Size = new System.Drawing.Size(56, 41);
            this.btncuadro.TabIndex = 2;
            this.btncuadro.UseVisualStyleBackColor = false;
            this.btncuadro.Click += new System.EventHandler(this.btncuadro_Click);
            // 
            // btnpluma
            // 
            this.btnpluma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnpluma.Image = ((System.Drawing.Image)(resources.GetObject("btnpluma.Image")));
            this.btnpluma.Location = new System.Drawing.Point(70, 10);
            this.btnpluma.Margin = new System.Windows.Forms.Padding(2);
            this.btnpluma.Name = "btnpluma";
            this.btnpluma.Size = new System.Drawing.Size(56, 41);
            this.btnpluma.TabIndex = 1;
            this.btnpluma.UseVisualStyleBackColor = false;
            // 
            // btnlapiz
            // 
            this.btnlapiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlapiz.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnlapiz.Image = ((System.Drawing.Image)(resources.GetObject("btnlapiz.Image")));
            this.btnlapiz.Location = new System.Drawing.Point(9, 10);
            this.btnlapiz.Margin = new System.Windows.Forms.Padding(2);
            this.btnlapiz.Name = "btnlapiz";
            this.btnlapiz.Size = new System.Drawing.Size(56, 41);
            this.btnlapiz.TabIndex = 0;
            this.btnlapiz.UseVisualStyleBackColor = false;
            this.btnlapiz.Click += new System.EventHandler(this.btnlapiz_Click);
            // 
            // imgdibujo
            // 
            this.imgdibujo.Location = new System.Drawing.Point(26, 10);
            this.imgdibujo.Margin = new System.Windows.Forms.Padding(2);
            this.imgdibujo.Name = "imgdibujo";
            this.imgdibujo.Size = new System.Drawing.Size(437, 322);
            this.imgdibujo.TabIndex = 0;
            this.imgdibujo.TabStop = false;
            this.imgdibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgdibujo_MouseDown);
            this.imgdibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgdibujo_MouseMove);
            this.imgdibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgdibujo_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 393);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "PAINT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgColores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordenada;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btntexto;
        private System.Windows.Forms.Button btnlinea;
        private System.Windows.Forms.Button btnhexagono;
        private System.Windows.Forms.Button btncirculo;
        private System.Windows.Forms.Button btnborrador;
        private System.Windows.Forms.Button btncuadro;
        private System.Windows.Forms.Button btnpluma;
        private System.Windows.Forms.Button btnlapiz;
        private System.Windows.Forms.PictureBox imgdibujo;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.NumericUpDown nudGrosor;
        private System.Windows.Forms.ColorDialog cdgColores;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox imgColores;
        private System.Windows.Forms.CheckBox cbxDots;
        private System.Windows.Forms.SaveFileDialog sfdGuardarComo;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnTriangulo;
    }
}

