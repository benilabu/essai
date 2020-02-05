namespace Binairo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsExist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.existetilUneSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAnnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsChanged = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(51, 61);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(340, 340);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExist,
            this.MenuAnnuler,
            this.MenuQuitter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsExist
            // 
            this.tsExist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNew,
            this.toolStripMenuItem1,
            this.tsLoad,
            this.toolStripMenuItem2,
            this.tsSave,
            this.toolStripMenuItem3,
            this.existetilUneSolutionToolStripMenuItem});
            this.tsExist.Name = "tsExist";
            this.tsExist.Size = new System.Drawing.Size(46, 20);
            this.tsExist.Text = "Grille";
            // 
            // tsNew
            // 
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(198, 22);
            this.tsNew.Text = "Créer une nouvelle";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // tsLoad
            // 
            this.tsLoad.Name = "tsLoad";
            this.tsLoad.Size = new System.Drawing.Size(198, 22);
            this.tsLoad.Text = "Charger une grille";
            this.tsLoad.Click += new System.EventHandler(this.tsLoad_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 6);
            // 
            // tsSave
            // 
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(198, 22);
            this.tsSave.Text = "Enregistrer cette grille";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(195, 6);
            // 
            // existetilUneSolutionToolStripMenuItem
            // 
            this.existetilUneSolutionToolStripMenuItem.Name = "existetilUneSolutionToolStripMenuItem";
            this.existetilUneSolutionToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.existetilUneSolutionToolStripMenuItem.Text = "Existe-t-il une solution?";
            this.existetilUneSolutionToolStripMenuItem.Click += new System.EventHandler(this.existetilUneSolutionToolStripMenuItem_Click);
            // 
            // MenuAnnuler
            // 
            this.MenuAnnuler.Name = "MenuAnnuler";
            this.MenuAnnuler.Size = new System.Drawing.Size(61, 20);
            this.MenuAnnuler.Text = "Annuler";
            this.MenuAnnuler.Click += new System.EventHandler(this.MenuAnnuler_Click);
            // 
            // MenuQuitter
            // 
            this.MenuQuitter.Name = "MenuQuitter";
            this.MenuQuitter.Size = new System.Drawing.Size(56, 20);
            this.MenuQuitter.Text = "Quitter";
            this.MenuQuitter.Click += new System.EventHandler(this.MenuQuitter_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTime,
            this.tsState,
            this.tsChanged});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsTime
            // 
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(78, 17);
            this.tsTime.Text = "00 min 00 sec";
            // 
            // tsState
            // 
            this.tsState.Name = "tsState";
            this.tsState.Size = new System.Drawing.Size(143, 17);
            this.tsState.Text = "État initial de l\'application";
            // 
            // tsChanged
            // 
            this.tsChanged.Name = "tsChanged";
            this.tsChanged.Size = new System.Drawing.Size(92, 17);
            this.tsChanged.Text = "Grille inchangée";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(644, 484);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jeu de Binairo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsExist;
        private System.Windows.Forms.ToolStripMenuItem tsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsSave;
        private System.Windows.Forms.ToolStripMenuItem MenuAnnuler;
        private System.Windows.Forms.ToolStripMenuItem MenuQuitter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.ToolStripStatusLabel tsState;
        private System.Windows.Forms.ToolStripStatusLabel tsChanged;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem existetilUneSolutionToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
    }
}

