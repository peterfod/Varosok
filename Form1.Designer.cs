
namespace Varosok
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbOrszag = new System.Windows.Forms.TextBox();
            this.txbNepesseg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbVaros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbLegnagyobb = new System.Windows.Forms.RadioButton();
            this.rdbLegkisebb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbCsokkeno = new System.Windows.Forms.RadioButton();
            this.rdbNovekvo = new System.Windows.Forms.RadioButton();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMegnyitas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSzures = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(101, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "A világ legnagyobb városai";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(65, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 372);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ország:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Népesség:";
            // 
            // txbOrszag
            // 
            this.txbOrszag.Location = new System.Drawing.Point(482, 156);
            this.txbOrszag.Name = "txbOrszag";
            this.txbOrszag.ReadOnly = true;
            this.txbOrszag.Size = new System.Drawing.Size(100, 22);
            this.txbOrszag.TabIndex = 4;
            // 
            // txbNepesseg
            // 
            this.txbNepesseg.Location = new System.Drawing.Point(482, 199);
            this.txbNepesseg.Name = "txbNepesseg";
            this.txbNepesseg.ReadOnly = true;
            this.txbNepesseg.Size = new System.Drawing.Size(100, 22);
            this.txbNepesseg.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbVaros);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdbLegnagyobb);
            this.groupBox1.Controls.Add(this.rdbLegkisebb);
            this.groupBox1.Location = new System.Drawing.Point(355, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 228);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Népesség";
            // 
            // txbVaros
            // 
            this.txbVaros.Location = new System.Drawing.Point(53, 186);
            this.txbVaros.Name = "txbVaros";
            this.txbVaros.ReadOnly = true;
            this.txbVaros.Size = new System.Drawing.Size(100, 22);
            this.txbVaros.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Város";
            // 
            // rdbLegnagyobb
            // 
            this.rdbLegnagyobb.AutoSize = true;
            this.rdbLegnagyobb.Location = new System.Drawing.Point(47, 94);
            this.rdbLegnagyobb.Name = "rdbLegnagyobb";
            this.rdbLegnagyobb.Size = new System.Drawing.Size(108, 21);
            this.rdbLegnagyobb.TabIndex = 1;
            this.rdbLegnagyobb.TabStop = true;
            this.rdbLegnagyobb.Text = "Legnagyobb";
            this.rdbLegnagyobb.UseVisualStyleBackColor = true;
            this.rdbLegnagyobb.CheckedChanged += new System.EventHandler(this.rdbLegnagyobb_CheckedChanged);
            // 
            // rdbLegkisebb
            // 
            this.rdbLegkisebb.AutoSize = true;
            this.rdbLegkisebb.Location = new System.Drawing.Point(47, 40);
            this.rdbLegkisebb.Name = "rdbLegkisebb";
            this.rdbLegkisebb.Size = new System.Drawing.Size(94, 21);
            this.rdbLegkisebb.TabIndex = 0;
            this.rdbLegkisebb.TabStop = true;
            this.rdbLegkisebb.Text = "Legkisebb";
            this.rdbLegkisebb.UseVisualStyleBackColor = true;
            this.rdbLegkisebb.CheckedChanged += new System.EventHandler(this.rdbLegkisebb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCsokkeno);
            this.groupBox2.Controls.Add(this.rdbNovekvo);
            this.groupBox2.Location = new System.Drawing.Point(78, 530);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 114);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rendezés népesség szerint";
            // 
            // rdbCsokkeno
            // 
            this.rdbCsokkeno.AutoSize = true;
            this.rdbCsokkeno.Location = new System.Drawing.Point(178, 51);
            this.rdbCsokkeno.Name = "rdbCsokkeno";
            this.rdbCsokkeno.Size = new System.Drawing.Size(91, 21);
            this.rdbCsokkeno.TabIndex = 1;
            this.rdbCsokkeno.TabStop = true;
            this.rdbCsokkeno.Text = "Csökkenő";
            this.rdbCsokkeno.UseVisualStyleBackColor = true;
            this.rdbCsokkeno.CheckedChanged += new System.EventHandler(this.rdbCsokkeno_CheckedChanged);
            // 
            // rdbNovekvo
            // 
            this.rdbNovekvo.AutoSize = true;
            this.rdbNovekvo.Location = new System.Drawing.Point(21, 51);
            this.rdbNovekvo.Name = "rdbNovekvo";
            this.rdbNovekvo.Size = new System.Drawing.Size(84, 21);
            this.rdbNovekvo.TabIndex = 0;
            this.rdbNovekvo.TabStop = true;
            this.rdbNovekvo.Text = "Növekvő";
            this.rdbNovekvo.UseVisualStyleBackColor = true;
            this.rdbNovekvo.CheckedChanged += new System.EventHandler(this.rdbNovekvo_CheckedChanged);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(507, 579);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(75, 23);
            this.btnKilepes.TabIndex = 8;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.mnuKilepes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.mnuSzures});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMegnyitas,
            this.mnuKilepes});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // mnuMegnyitas
            // 
            this.mnuMegnyitas.Name = "mnuMegnyitas";
            this.mnuMegnyitas.Size = new System.Drawing.Size(166, 26);
            this.mnuMegnyitas.Text = "Megnyitás..";
            this.mnuMegnyitas.Click += new System.EventHandler(this.mnuMegnyitas_Click);
            // 
            // mnuKilepes
            // 
            this.mnuKilepes.Name = "mnuKilepes";
            this.mnuKilepes.Size = new System.Drawing.Size(166, 26);
            this.mnuKilepes.Text = "Kilépés";
            this.mnuKilepes.Click += new System.EventHandler(this.mnuKilepes_Click);
            // 
            // mnuSzures
            // 
            this.mnuSzures.Name = "mnuSzures";
            this.mnuSzures.Size = new System.Drawing.Size(65, 24);
            this.mnuSzures.Text = "Szűrés";
            this.mnuSzures.Click += new System.EventHandler(this.mnuSzures_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 665);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbNepesseg);
            this.Controls.Add(this.txbOrszag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Városok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbOrszag;
        private System.Windows.Forms.TextBox txbNepesseg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbVaros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbLegnagyobb;
        private System.Windows.Forms.RadioButton rdbLegkisebb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbCsokkeno;
        private System.Windows.Forms.RadioButton rdbNovekvo;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuKilepes;
        private System.Windows.Forms.ToolStripMenuItem mnuSzures;
        private System.Windows.Forms.ToolStripMenuItem mnuMegnyitas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

