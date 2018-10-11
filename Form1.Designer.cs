namespace Travian_2._0
{
    partial class Main1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.About = new System.Windows.Forms.ToolStripStatusLabel();
            this.ValueTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ModeAutoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusAutoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonDemarrer = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupView1 = new System.Windows.Forms.GroupBox();
            this.groupView2 = new System.Windows.Forms.GroupBox();
            this.groupView3 = new System.Windows.Forms.GroupBox();
            this.groupView4 = new System.Windows.Forms.GroupBox();
            this.groupView5 = new System.Windows.Forms.GroupBox();
            this.groupView6 = new System.Windows.Forms.GroupBox();
            this.groupView7 = new System.Windows.Forms.GroupBox();
            this.groupView8 = new System.Windows.Forms.GroupBox();
            this.groupView9 = new System.Windows.Forms.GroupBox();
            this.groupView10 = new System.Windows.Forms.GroupBox();
            this.groupView11 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSecondes = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.ValueTime,
            this.toolStripStatusLabel2,
            this.ModeAutoLabel,
            this.StatusAutoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(-3, 799);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1135, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.SystemColors.Control;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(256, 19);
            this.About.Text = "Coded by Magi_Oxygène                                       ";
            // 
            // ValueTime
            // 
            this.ValueTime.BackColor = System.Drawing.Color.Transparent;
            this.ValueTime.Name = "ValueTime";
            this.ValueTime.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 19);
            // 
            // ModeAutoLabel
            // 
            this.ModeAutoLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModeAutoLabel.ForeColor = System.Drawing.Color.Black;
            this.ModeAutoLabel.Name = "ModeAutoLabel";
            this.ModeAutoLabel.Size = new System.Drawing.Size(225, 19);
            this.ModeAutoLabel.Text = "                                  Mode Automatique :  ";
            // 
            // StatusAutoLabel
            // 
            this.StatusAutoLabel.BackColor = System.Drawing.Color.Black;
            this.StatusAutoLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusAutoLabel.Name = "StatusAutoLabel";
            this.StatusAutoLabel.Size = new System.Drawing.Size(24, 19);
            this.StatusAutoLabel.Text = "Off";
            // 
            // buttonDemarrer
            // 
            this.buttonDemarrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDemarrer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDemarrer.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDemarrer.Location = new System.Drawing.Point(979, 697);
            this.buttonDemarrer.Name = "buttonDemarrer";
            this.buttonDemarrer.Size = new System.Drawing.Size(139, 36);
            this.buttonDemarrer.TabIndex = 1;
            this.buttonDemarrer.Text = "Démarrer";
            this.buttonDemarrer.UseVisualStyleBackColor = false;
            this.buttonDemarrer.Click += new System.EventHandler(this.buttonDemarrer_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClose.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(979, 750);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(139, 36);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Quitter";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupView1
            // 
            this.groupView1.Location = new System.Drawing.Point(0, 0);
            this.groupView1.Name = "groupView1";
            this.groupView1.Size = new System.Drawing.Size(200, 100);
            this.groupView1.TabIndex = 0;
            this.groupView1.TabStop = false;
            // 
            // groupView2
            // 
            this.groupView2.Location = new System.Drawing.Point(0, 0);
            this.groupView2.Name = "groupView2";
            this.groupView2.Size = new System.Drawing.Size(200, 100);
            this.groupView2.TabIndex = 0;
            this.groupView2.TabStop = false;
            // 
            // groupView3
            // 
            this.groupView3.Location = new System.Drawing.Point(0, 0);
            this.groupView3.Name = "groupView3";
            this.groupView3.Size = new System.Drawing.Size(200, 100);
            this.groupView3.TabIndex = 0;
            this.groupView3.TabStop = false;
            // 
            // groupView4
            // 
            this.groupView4.Location = new System.Drawing.Point(0, 0);
            this.groupView4.Name = "groupView4";
            this.groupView4.Size = new System.Drawing.Size(200, 100);
            this.groupView4.TabIndex = 0;
            this.groupView4.TabStop = false;
            // 
            // groupView5
            // 
            this.groupView5.Location = new System.Drawing.Point(0, 0);
            this.groupView5.Name = "groupView5";
            this.groupView5.Size = new System.Drawing.Size(200, 100);
            this.groupView5.TabIndex = 0;
            this.groupView5.TabStop = false;
            // 
            // groupView6
            // 
            this.groupView6.Location = new System.Drawing.Point(0, 0);
            this.groupView6.Name = "groupView6";
            this.groupView6.Size = new System.Drawing.Size(200, 100);
            this.groupView6.TabIndex = 0;
            this.groupView6.TabStop = false;
            // 
            // groupView7
            // 
            this.groupView7.Location = new System.Drawing.Point(0, 0);
            this.groupView7.Name = "groupView7";
            this.groupView7.Size = new System.Drawing.Size(200, 100);
            this.groupView7.TabIndex = 0;
            this.groupView7.TabStop = false;
            // 
            // groupView8
            // 
            this.groupView8.Location = new System.Drawing.Point(0, 0);
            this.groupView8.Name = "groupView8";
            this.groupView8.Size = new System.Drawing.Size(200, 100);
            this.groupView8.TabIndex = 0;
            this.groupView8.TabStop = false;
            // 
            // groupView9
            // 
            this.groupView9.Location = new System.Drawing.Point(0, 0);
            this.groupView9.Name = "groupView9";
            this.groupView9.Size = new System.Drawing.Size(200, 100);
            this.groupView9.TabIndex = 0;
            this.groupView9.TabStop = false;
            // 
            // groupView10
            // 
            this.groupView10.Location = new System.Drawing.Point(0, 0);
            this.groupView10.Name = "groupView10";
            this.groupView10.Size = new System.Drawing.Size(200, 100);
            this.groupView10.TabIndex = 0;
            this.groupView10.TabStop = false;
            // 
            // groupView11
            // 
            this.groupView11.Location = new System.Drawing.Point(0, 0);
            this.groupView11.Name = "groupView11";
            this.groupView11.Size = new System.Drawing.Size(200, 100);
            this.groupView11.TabIndex = 0;
            this.groupView11.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(819, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Activer/Désactiver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 749);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "AutoRefesh choisir le temps en min : ";
            // 
            // textBoxSecondes
            // 
            this.textBoxSecondes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSecondes.Location = new System.Drawing.Point(854, 746);
            this.textBoxSecondes.Name = "textBoxSecondes";
            this.textBoxSecondes.Size = new System.Drawing.Size(67, 20);
            this.textBoxSecondes.TabIndex = 5;
            this.textBoxSecondes.Text = "5";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1130, 822);
            this.Controls.Add(this.textBoxSecondes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDemarrer);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travian 2.0";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel About;
        private System.Windows.Forms.Button buttonDemarrer;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupView1;
        private System.Windows.Forms.GroupBox groupView2;
        private System.Windows.Forms.GroupBox groupView3;
        private System.Windows.Forms.GroupBox groupView4;
        private System.Windows.Forms.GroupBox groupView5;
        private System.Windows.Forms.GroupBox groupView6;
        private System.Windows.Forms.GroupBox groupView7;
        private System.Windows.Forms.GroupBox groupView8;
        private System.Windows.Forms.GroupBox groupView9;
        private System.Windows.Forms.GroupBox groupView10;
        private System.Windows.Forms.GroupBox groupView11;
        private System.Windows.Forms.ToolStripStatusLabel ValueTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ModeAutoLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusAutoLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSecondes;
        private System.Windows.Forms.Timer timer1;
        
    }
}

