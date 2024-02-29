namespace Ass3
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            menuStripCities = new ToolStripMenuItem();
            jacksonvileToolStripMenuItem = new ToolStripMenuItem();
            miamiToolStripMenuItem = new ToolStripMenuItem();
            orlandoToolStripMenuItem = new ToolStripMenuItem();
            tampaToolStripMenuItem = new ToolStripMenuItem();
            menuStripDirections = new ToolStripMenuItem();
            nEToolStripMenuItem = new ToolStripMenuItem();
            sEToolStripMenuItem = new ToolStripMenuItem();
            sWToolStripMenuItem = new ToolStripMenuItem();
            nWToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxJackosnville = new PictureBox();
            pictureBoxOrlando = new PictureBox();
            pictureBoxMiami = new PictureBox();
            pictureBoxTampa = new PictureBox();
            contextMenuStripCitiesDirections = new ContextMenuStrip(components);
            orlandoContextToolStripMenuItem = new ToolStripMenuItem();
            miamiContextToolStripMenuItem = new ToolStripMenuItem();
            TampaContextToolStripMenuItem = new ToolStripMenuItem();
            jacksonvilleContextToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripMenuItem();
            nEContextToolStripMenuItem = new ToolStripMenuItem();
            sEContextToolStripMenuItem = new ToolStripMenuItem();
            sWContextToolStripMenuItem = new ToolStripMenuItem();
            nW = new ToolStripMenuItem();
            movementTimer = new System.Windows.Forms.Timer(components);
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJackosnville).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrlando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiami).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTampa).BeginInit();
            contextMenuStripCitiesDirections.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuStripCities, menuStripDirections });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuStripCities
            // 
            menuStripCities.DropDownItems.AddRange(new ToolStripItem[] { jacksonvileToolStripMenuItem, miamiToolStripMenuItem, orlandoToolStripMenuItem, tampaToolStripMenuItem });
            menuStripCities.Name = "menuStripCities";
            menuStripCities.Size = new Size(59, 24);
            menuStripCities.Text = "Cities";
            // 
            // jacksonvileToolStripMenuItem
            // 
            jacksonvileToolStripMenuItem.Name = "jacksonvileToolStripMenuItem";
            jacksonvileToolStripMenuItem.Size = new Size(165, 26);
            jacksonvileToolStripMenuItem.Text = "Jacksonvile";
            jacksonvileToolStripMenuItem.Click += jacksonvileToolStripMenuItem_Click;
            // 
            // miamiToolStripMenuItem
            // 
            miamiToolStripMenuItem.Name = "miamiToolStripMenuItem";
            miamiToolStripMenuItem.Size = new Size(165, 26);
            miamiToolStripMenuItem.Text = "Miami";
            miamiToolStripMenuItem.Click += miamiToolStripMenuItem_Click;
            // 
            // orlandoToolStripMenuItem
            // 
            orlandoToolStripMenuItem.Name = "orlandoToolStripMenuItem";
            orlandoToolStripMenuItem.Size = new Size(165, 26);
            orlandoToolStripMenuItem.Text = "Orlando";
            orlandoToolStripMenuItem.Click += orlandoToolStripMenuItem_Click;
            // 
            // tampaToolStripMenuItem
            // 
            tampaToolStripMenuItem.Name = "tampaToolStripMenuItem";
            tampaToolStripMenuItem.Size = new Size(165, 26);
            tampaToolStripMenuItem.Text = "Tampa";
            tampaToolStripMenuItem.Click += tampaToolStripMenuItem_Click;
            // 
            // menuStripDirections
            // 
            menuStripDirections.DropDownItems.AddRange(new ToolStripItem[] { nEToolStripMenuItem, sEToolStripMenuItem, sWToolStripMenuItem, nWToolStripMenuItem });
            menuStripDirections.Name = "menuStripDirections";
            menuStripDirections.Size = new Size(90, 24);
            menuStripDirections.Text = "Directions";
            // 
            // nEToolStripMenuItem
            // 
            nEToolStripMenuItem.Name = "nEToolStripMenuItem";
            nEToolStripMenuItem.Size = new Size(117, 26);
            nEToolStripMenuItem.Text = "NE";
            nEToolStripMenuItem.Click += nEToolStripMenuItem_Click;
            // 
            // sEToolStripMenuItem
            // 
            sEToolStripMenuItem.Name = "sEToolStripMenuItem";
            sEToolStripMenuItem.Size = new Size(117, 26);
            sEToolStripMenuItem.Text = "SE";
            sEToolStripMenuItem.Click += sEToolStripMenuItem_Click;
            // 
            // sWToolStripMenuItem
            // 
            sWToolStripMenuItem.Name = "sWToolStripMenuItem";
            sWToolStripMenuItem.Size = new Size(117, 26);
            sWToolStripMenuItem.Text = "SW";
            sWToolStripMenuItem.Click += sWToolStripMenuItem_Click;
            // 
            // nWToolStripMenuItem
            // 
            nWToolStripMenuItem.Name = "nWToolStripMenuItem";
            nWToolStripMenuItem.Size = new Size(117, 26);
            nWToolStripMenuItem.Text = "NW";
            nWToolStripMenuItem.Click += nWToolStripMenuItem_Click;
            // 
            // pictureBoxJackosnville
            // 
            pictureBoxJackosnville.Image = Properties.Resources.Jacksonville;
            pictureBoxJackosnville.Location = new Point(307, 182);
            pictureBoxJackosnville.Name = "pictureBoxJackosnville";
            pictureBoxJackosnville.Size = new Size(145, 80);
            pictureBoxJackosnville.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxJackosnville.TabIndex = 1;
            pictureBoxJackosnville.TabStop = false;
            pictureBoxJackosnville.Visible = false;
            // 
            // pictureBoxOrlando
            // 
            pictureBoxOrlando.Image = Properties.Resources.Orlando;
            pictureBoxOrlando.Location = new Point(307, 182);
            pictureBoxOrlando.Name = "pictureBoxOrlando";
            pictureBoxOrlando.Size = new Size(145, 80);
            pictureBoxOrlando.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOrlando.TabIndex = 2;
            pictureBoxOrlando.TabStop = false;
            pictureBoxOrlando.Visible = false;
            // 
            // pictureBoxMiami
            // 
            pictureBoxMiami.Image = Properties.Resources.Miami;
            pictureBoxMiami.Location = new Point(307, 182);
            pictureBoxMiami.Name = "pictureBoxMiami";
            pictureBoxMiami.Size = new Size(145, 80);
            pictureBoxMiami.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMiami.TabIndex = 3;
            pictureBoxMiami.TabStop = false;
            pictureBoxMiami.Visible = false;
            // 
            // pictureBoxTampa
            // 
            pictureBoxTampa.Image = Properties.Resources.Tampa;
            pictureBoxTampa.Location = new Point(307, 182);
            pictureBoxTampa.Name = "pictureBoxTampa";
            pictureBoxTampa.Size = new Size(145, 80);
            pictureBoxTampa.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTampa.TabIndex = 4;
            pictureBoxTampa.TabStop = false;
            pictureBoxTampa.Visible = false;
            // 
            // contextMenuStripCitiesDirections
            // 
            contextMenuStripCitiesDirections.ImageScalingSize = new Size(20, 20);
            contextMenuStripCitiesDirections.Items.AddRange(new ToolStripItem[] { orlandoContextToolStripMenuItem, miamiContextToolStripMenuItem, TampaContextToolStripMenuItem, jacksonvilleContextToolStripMenuItem, toolStripSeparator, nEContextToolStripMenuItem, sEContextToolStripMenuItem, sWContextToolStripMenuItem, nW });
            contextMenuStripCitiesDirections.Name = "contextMenuStrip1";
            contextMenuStripCitiesDirections.Size = new Size(156, 220);
            // 
            // orlandoContextToolStripMenuItem
            // 
            orlandoContextToolStripMenuItem.Name = "orlandoContextToolStripMenuItem";
            orlandoContextToolStripMenuItem.Size = new Size(155, 24);
            orlandoContextToolStripMenuItem.Text = "Orlando";
            orlandoContextToolStripMenuItem.Click += orlandoContextToolStripMenuItem_Click;
            // 
            // miamiContextToolStripMenuItem
            // 
            miamiContextToolStripMenuItem.Name = "miamiContextToolStripMenuItem";
            miamiContextToolStripMenuItem.Size = new Size(155, 24);
            miamiContextToolStripMenuItem.Text = "Miami";
            miamiContextToolStripMenuItem.Click += miamiContextToolStripMenuItem_Click;
            // 
            // TampaContextToolStripMenuItem
            // 
            TampaContextToolStripMenuItem.Name = "TampaContextToolStripMenuItem";
            TampaContextToolStripMenuItem.Size = new Size(155, 24);
            TampaContextToolStripMenuItem.Text = "Tampa";
            TampaContextToolStripMenuItem.Click += TampaContextToolStripMenuItem_Click;
            // 
            // jacksonvilleContextToolStripMenuItem
            // 
            jacksonvilleContextToolStripMenuItem.Name = "jacksonvilleContextToolStripMenuItem";
            jacksonvilleContextToolStripMenuItem.Size = new Size(155, 24);
            jacksonvilleContextToolStripMenuItem.Text = "Jacksonville";
            jacksonvilleContextToolStripMenuItem.Click += jacksonvilleContextToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(155, 24);
            toolStripSeparator.Text = " ";
            // 
            // nEContextToolStripMenuItem
            // 
            nEContextToolStripMenuItem.Name = "nEContextToolStripMenuItem";
            nEContextToolStripMenuItem.Size = new Size(155, 24);
            nEContextToolStripMenuItem.Text = "NE";
            nEContextToolStripMenuItem.Click += nEContextToolStripMenuItem_Click;
            // 
            // sEContextToolStripMenuItem
            // 
            sEContextToolStripMenuItem.Name = "sEContextToolStripMenuItem";
            sEContextToolStripMenuItem.Size = new Size(155, 24);
            sEContextToolStripMenuItem.Text = "SE";
            sEContextToolStripMenuItem.Click += sEContextToolStripMenuItem_Click;
            // 
            // sWContextToolStripMenuItem
            // 
            sWContextToolStripMenuItem.Name = "sWContextToolStripMenuItem";
            sWContextToolStripMenuItem.Size = new Size(155, 24);
            sWContextToolStripMenuItem.Text = "SW";
            sWContextToolStripMenuItem.Click += sWContextToolStripMenuItem_Click;
            // 
            // nW
            // 
            nW.Name = "nW";
            nW.Size = new Size(155, 24);
            nW.Text = "NW";
            nW.Click += nW_Click;
            // 
            // movementTimer
            // 
            movementTimer.Interval = 125;
            movementTimer.Tick += movementTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxTampa);
            Controls.Add(pictureBoxMiami);
            Controls.Add(pictureBoxOrlando);
            Controls.Add(pictureBoxJackosnville);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            MouseDoubleClick += Form1_MouseDoubleClick;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJackosnville).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOrlando).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiami).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTampa).EndInit();
            contextMenuStripCitiesDirections.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuStripCities;
        private ToolStripMenuItem jacksonvileToolStripMenuItem;
        private ToolStripMenuItem miamiToolStripMenuItem;
        private ToolStripMenuItem orlandoToolStripMenuItem;
        private ToolStripMenuItem tampaToolStripMenuItem;
        private PictureBox pictureBoxJackosnville;
        private PictureBox pictureBoxOrlando;
        private PictureBox pictureBoxMiami;
        private PictureBox pictureBoxTampa;
        private ToolStripMenuItem menuStripDirections;
        private ToolStripMenuItem nEToolStripMenuItem;
        private ToolStripMenuItem sEToolStripMenuItem;
        private ToolStripMenuItem sWToolStripMenuItem;
        private ToolStripMenuItem nWToolStripMenuItem;
        private ContextMenuStrip contextMenuStripCitiesDirections;
        private ToolStripMenuItem orlandoContextToolStripMenuItem;
        private ToolStripMenuItem miamiContextToolStripMenuItem;
        private ToolStripMenuItem TampaContextToolStripMenuItem;
        private ToolStripMenuItem jacksonvilleContextToolStripMenuItem;
        private ToolStripMenuItem toolStripSeparator;
        private ToolStripMenuItem nEContextToolStripMenuItem;
        private ToolStripMenuItem sEContextToolStripMenuItem;
        private ToolStripMenuItem sWContextToolStripMenuItem;
        private ToolStripMenuItem nW;
        private System.Windows.Forms.Timer movementTimer;
    }
}
