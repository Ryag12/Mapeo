namespace RegistroyMapeo
{
    partial class FormularioPrincipal
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registosEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registosGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(119, 148);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(187, 153);
            this.metroTile1.TabIndex = 0;
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.Red;
            //this.metroTile2.CustomBackground = true;
            this.metroTile2.Location = new System.Drawing.Point(406, 148);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(187, 157);
            this.metroTile2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registosEstudiantesToolStripMenuItem,
            this.registosGrupoToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registosEstudiantesToolStripMenuItem
            // 
            this.registosEstudiantesToolStripMenuItem.Name = "registosEstudiantesToolStripMenuItem";
            this.registosEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.registosEstudiantesToolStripMenuItem.Text = "Registos Estudiantes";
            this.registosEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.registosEstudiantesToolStripMenuItem_Click);
            // 
            // registosGrupoToolStripMenuItem
            // 
            this.registosGrupoToolStripMenuItem.Name = "registosGrupoToolStripMenuItem";
            this.registosGrupoToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.registosGrupoToolStripMenuItem.Text = "Registos Grupo";
            this.registosGrupoToolStripMenuItem.Click += new System.EventHandler(this.registosGrupoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaEstudianteToolStripMenuItem,
            this.consultaGrupoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaEstudianteToolStripMenuItem
            // 
            this.consultaEstudianteToolStripMenuItem.Name = "consultaEstudianteToolStripMenuItem";
            this.consultaEstudianteToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.consultaEstudianteToolStripMenuItem.Text = "Consulta Estudiante";
            // 
            // consultaGrupoToolStripMenuItem
            // 
            this.consultaGrupoToolStripMenuItem.Name = "consultaGrupoToolStripMenuItem";
            this.consultaGrupoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.consultaGrupoToolStripMenuItem.Text = "Consulta Grupo";
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(406, 382);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(187, 153);
            this.metroTile3.TabIndex = 3;
            // 
            // metroTile4
            // 
            this.metroTile4.BackColor = System.Drawing.Color.Red;
            //this.metroTile4.CustomBackground = true;
            this.metroTile4.Location = new System.Drawing.Point(119, 382);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(187, 153);
            this.metroTile4.TabIndex = 4;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 633);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registosEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registosGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaGrupoToolStripMenuItem;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}

