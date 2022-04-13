namespace MultiThreading
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dgvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssbVoltar = new System.Windows.Forms.ToolStripSplitButton();
            this.tssbAvancar = new System.Windows.Forms.ToolStripSplitButton();
            this.tsslPaginacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssbModoAutomatico = new System.Windows.Forms.ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColName,
            this.dgvColHeight,
            this.dgvColWeight,
            this.dgvColTeam,
            this.dgvColPosition});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(636, 450);
            this.dataGridView.TabIndex = 0;
            // 
            // dgvColName
            // 
            this.dgvColName.HeaderText = "Nome";
            this.dgvColName.Name = "dgvColName";
            this.dgvColName.ReadOnly = true;
            // 
            // dgvColHeight
            // 
            this.dgvColHeight.HeaderText = "Altura";
            this.dgvColHeight.Name = "dgvColHeight";
            this.dgvColHeight.ReadOnly = true;
            // 
            // dgvColWeight
            // 
            this.dgvColWeight.HeaderText = "Peso";
            this.dgvColWeight.Name = "dgvColWeight";
            this.dgvColWeight.ReadOnly = true;
            // 
            // dgvColTeam
            // 
            this.dgvColTeam.HeaderText = "Time";
            this.dgvColTeam.Name = "dgvColTeam";
            this.dgvColTeam.ReadOnly = true;
            // 
            // dgvColPosition
            // 
            this.dgvColPosition.HeaderText = "Posição";
            this.dgvColPosition.Name = "dgvColPosition";
            this.dgvColPosition.ReadOnly = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbVoltar,
            this.tssbAvancar,
            this.tsslPaginacao,
            this.tssbModoAutomatico});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(636, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tssbVoltar
            // 
            this.tssbVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("tssbVoltar.Image")));
            this.tssbVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbVoltar.Name = "tssbVoltar";
            this.tssbVoltar.Size = new System.Drawing.Size(32, 20);
            this.tssbVoltar.Text = "Voltar";
            this.tssbVoltar.ButtonClick += new System.EventHandler(this.tssbVoltar_ButtonClick);
            // 
            // tssbAvancar
            // 
            this.tssbAvancar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbAvancar.Image = ((System.Drawing.Image)(resources.GetObject("tssbAvancar.Image")));
            this.tssbAvancar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbAvancar.Name = "tssbAvancar";
            this.tssbAvancar.Size = new System.Drawing.Size(32, 20);
            this.tssbAvancar.Text = "Avançar";
            this.tssbAvancar.ButtonClick += new System.EventHandler(this.tssbAvancar_ButtonClick);
            // 
            // tsslPaginacao
            // 
            this.tsslPaginacao.Name = "tsslPaginacao";
            this.tsslPaginacao.Size = new System.Drawing.Size(67, 17);
            this.tsslPaginacao.Text = "Página {}/{}";
            // 
            // tssbModoAutomatico
            // 
            this.tssbModoAutomatico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbModoAutomatico.Image = ((System.Drawing.Image)(resources.GetObject("tssbModoAutomatico.Image")));
            this.tssbModoAutomatico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbModoAutomatico.Name = "tssbModoAutomatico";
            this.tssbModoAutomatico.Size = new System.Drawing.Size(32, 20);
            this.tssbModoAutomatico.Text = "Modo automático";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form";
            this.Text = "MultiThreading app";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn dgvColName;
        private DataGridViewTextBoxColumn dgvColHeight;
        private DataGridViewTextBoxColumn dgvColWeight;
        private DataGridViewTextBoxColumn dgvColTeam;
        private DataGridViewTextBoxColumn dgvColPosition;
        private StatusStrip statusStrip;
        private ToolStripSplitButton tssbVoltar;
        private ToolStripSplitButton tssbAvancar;
        private ToolStripStatusLabel tsslPaginacao;
        private ToolStripSplitButton tssbModoAutomatico;
    }
}