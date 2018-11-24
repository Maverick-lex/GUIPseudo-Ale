namespace GUIaleatorio
{
    partial class Panel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.bbnMinimizar = new System.Windows.Forms.PictureBox();
            this.bbnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn6Met = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn5Met = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn4Met = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn3Met = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn2Met = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1Met = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BarraTitulo.Controls.Add(this.bbnMinimizar);
            this.BarraTitulo.Controls.Add(this.bbnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // bbnMinimizar
            // 
            this.bbnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bbnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbnMinimizar.Image = global::GUIaleatorio.Properties.Resources.minimazar;
            this.bbnMinimizar.Location = new System.Drawing.Point(1227, 7);
            this.bbnMinimizar.Name = "bbnMinimizar";
            this.bbnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.bbnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bbnMinimizar.TabIndex = 2;
            this.bbnMinimizar.TabStop = false;
            this.bbnMinimizar.Click += new System.EventHandler(this.bbnMinimizar_Click);
            // 
            // bbnCerrar
            // 
            this.bbnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bbnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbnCerrar.Image = global::GUIaleatorio.Properties.Resources.cerrar;
            this.bbnCerrar.Location = new System.Drawing.Point(1268, 6);
            this.bbnCerrar.Name = "bbnCerrar";
            this.bbnCerrar.Size = new System.Drawing.Size(25, 25);
            this.bbnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bbnCerrar.TabIndex = 0;
            this.bbnCerrar.TabStop = false;
            this.bbnCerrar.Click += new System.EventHandler(this.bbnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.panel6);
            this.MenuVertical.Controls.Add(this.btn6Met);
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.btn5Met);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.btn4Met);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btn3Met);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btn2Met);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btn1Met);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 615);
            this.MenuVertical.TabIndex = 1;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Location = new System.Drawing.Point(6, 349);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 44);
            this.panel6.TabIndex = 9;
            // 
            // btn6Met
            // 
            this.btn6Met.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn6Met.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6Met.FlatAppearance.BorderSize = 0;
            this.btn6Met.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn6Met.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6Met.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6Met.ForeColor = System.Drawing.Color.White;
            this.btn6Met.Location = new System.Drawing.Point(12, 349);
            this.btn6Met.Name = "btn6Met";
            this.btn6Met.Size = new System.Drawing.Size(208, 44);
            this.btn6Met.TabIndex = 10;
            this.btn6Met.Text = "Congruencial Aditivo";
            this.btn6Met.UseVisualStyleBackColor = false;
            this.btn6Met.Click += new System.EventHandler(this.btn6Met_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Location = new System.Drawing.Point(6, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 44);
            this.panel5.TabIndex = 7;
            // 
            // btn5Met
            // 
            this.btn5Met.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn5Met.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5Met.FlatAppearance.BorderSize = 0;
            this.btn5Met.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn5Met.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5Met.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Met.ForeColor = System.Drawing.Color.White;
            this.btn5Met.Location = new System.Drawing.Point(12, 299);
            this.btn5Met.Name = "btn5Met";
            this.btn5Met.Size = new System.Drawing.Size(208, 44);
            this.btn5Met.TabIndex = 8;
            this.btn5Met.Text = "Congruencial Multiplicativo";
            this.btn5Met.UseVisualStyleBackColor = false;
            this.btn5Met.Click += new System.EventHandler(this.btn5Met_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(6, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 44);
            this.panel4.TabIndex = 5;
            // 
            // btn4Met
            // 
            this.btn4Met.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn4Met.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4Met.FlatAppearance.BorderSize = 0;
            this.btn4Met.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn4Met.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4Met.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Met.ForeColor = System.Drawing.Color.White;
            this.btn4Met.Location = new System.Drawing.Point(12, 249);
            this.btn4Met.Name = "btn4Met";
            this.btn4Met.Size = new System.Drawing.Size(208, 44);
            this.btn4Met.TabIndex = 6;
            this.btn4Met.Text = "Algoritmo Lineal";
            this.btn4Met.UseVisualStyleBackColor = false;
            this.btn4Met.Click += new System.EventHandler(this.btn4Met_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(6, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 44);
            this.panel3.TabIndex = 3;
            // 
            // btn3Met
            // 
            this.btn3Met.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn3Met.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3Met.FlatAppearance.BorderSize = 0;
            this.btn3Met.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn3Met.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Met.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Met.ForeColor = System.Drawing.Color.White;
            this.btn3Met.Location = new System.Drawing.Point(12, 199);
            this.btn3Met.Name = "btn3Met";
            this.btn3Met.Size = new System.Drawing.Size(208, 44);
            this.btn3Met.TabIndex = 4;
            this.btn3Met.Text = "Multiplicador Constante";
            this.btn3Met.UseVisualStyleBackColor = false;
            this.btn3Met.Click += new System.EventHandler(this.btn3Met_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(6, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 44);
            this.panel2.TabIndex = 1;
            // 
            // btn2Met
            // 
            this.btn2Met.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn2Met.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2Met.FlatAppearance.BorderSize = 0;
            this.btn2Met.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn2Met.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Met.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Met.ForeColor = System.Drawing.Color.White;
            this.btn2Met.Location = new System.Drawing.Point(12, 149);
            this.btn2Met.Name = "btn2Met";
            this.btn2Met.Size = new System.Drawing.Size(208, 44);
            this.btn2Met.TabIndex = 2;
            this.btn2Met.Text = "Productos Medios";
            this.btn2Met.UseVisualStyleBackColor = false;
            this.btn2Met.Click += new System.EventHandler(this.btn2Met_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(6, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 44);
            this.panel1.TabIndex = 0;
            // 
            // btn1Met
            // 
            this.btn1Met.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn1Met.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1Met.FlatAppearance.BorderSize = 0;
            this.btn1Met.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn1Met.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Met.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Met.ForeColor = System.Drawing.Color.White;
            this.btn1Met.Location = new System.Drawing.Point(12, 96);
            this.btn1Met.Name = "btn1Met";
            this.btn1Met.Size = new System.Drawing.Size(208, 44);
            this.btn1Met.TabIndex = 0;
            this.btn1Met.Text = "Cuadrados Medios";
            this.btn1Met.UseVisualStyleBackColor = false;
            this.btn1Met.Click += new System.EventHandler(this.btn1Met_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GUIaleatorio.Properties.Resources.aleatorio1;
            this.pictureBox1.Location = new System.Drawing.Point(65, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(220, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1080, 615);
            this.PanelContenedor.TabIndex = 2;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bbnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox bbnCerrar;
        private System.Windows.Forms.PictureBox bbnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn1Met;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn6Met;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn5Met;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn4Met;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn3Met;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn2Met;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}

