
namespace Revision_efm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRchercher = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPerviows = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.textPos = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTele = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEmb = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSepecilite = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "code medcin";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(15, 158);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(86, 35);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(107, 158);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(86, 35);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(291, 158);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(86, 35);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRchercher
            // 
            this.btnRchercher.Location = new System.Drawing.Point(199, 158);
            this.btnRchercher.Name = "btnRchercher";
            this.btnRchercher.Size = new System.Drawing.Size(86, 35);
            this.btnRchercher.TabIndex = 4;
            this.btnRchercher.Text = "rechercher";
            this.btnRchercher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRchercher.UseVisualStyleBackColor = true;
            this.btnRchercher.Click += new System.EventHandler(this.btnRchercher_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(475, 158);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(86, 35);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(383, 158);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(86, 35);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(659, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(567, 158);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(86, 35);
            this.btnImprimer.TabIndex = 8;
            this.btnImprimer.Text = "imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(549, 425);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(86, 35);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(457, 425);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 35);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPerviows
            // 
            this.btnPerviows.Location = new System.Drawing.Point(247, 425);
            this.btnPerviows.Name = "btnPerviows";
            this.btnPerviows.Size = new System.Drawing.Size(86, 35);
            this.btnPerviows.TabIndex = 11;
            this.btnPerviows.Text = "Previows";
            this.btnPerviows.UseVisualStyleBackColor = true;
            this.btnPerviows.Click += new System.EventHandler(this.btnPerviows_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(155, 425);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(86, 35);
            this.btnFirst.TabIndex = 10;
            this.btnFirst.Text = "first";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // textPos
            // 
            this.textPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPos.Location = new System.Drawing.Point(344, 429);
            this.textPos.Name = "textPos";
            this.textPos.Size = new System.Drawing.Size(100, 28);
            this.textPos.TabIndex = 14;
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(106, 37);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(141, 22);
            this.textCode.TabIndex = 15;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(107, 81);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(141, 22);
            this.textNom.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "nom";
            // 
            // textTele
            // 
            this.textTele.Location = new System.Drawing.Point(107, 127);
            this.textTele.Name = "textTele";
            this.textTele.Size = new System.Drawing.Size(141, 22);
            this.textTele.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "tele";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "date Embauche";
            // 
            // dateEmb
            // 
            this.dateEmb.Location = new System.Drawing.Point(494, 34);
            this.dateEmb.Name = "dateEmb";
            this.dateEmb.Size = new System.Drawing.Size(200, 22);
            this.dateEmb.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sepecilite";
            // 
            // cbSepecilite
            // 
            this.cbSepecilite.FormattingEnabled = true;
            this.cbSepecilite.Location = new System.Drawing.Point(494, 83);
            this.cbSepecilite.Name = "cbSepecilite";
            this.cbSepecilite.Size = new System.Drawing.Size(121, 24);
            this.cbSepecilite.TabIndex = 23;
            this.cbSepecilite.SelectionChangeCommitted += new System.EventHandler(this.cbSepecilite_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.cbSepecilite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateEmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.textPos);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPerviows);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnRchercher);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRchercher;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPerviows;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox textPos;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateEmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSepecilite;
    }
}

