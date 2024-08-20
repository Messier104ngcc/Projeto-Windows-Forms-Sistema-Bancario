namespace PrimeiroProjetoWF {
    partial class Extrato {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGridViewExtrato = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSairExtrato = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtDataInicio = new PrimeiroProjetoWF.Calendario();
            this.dtDataFim = new PrimeiroProjetoWF.Calendario();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExtrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewExtrato
            // 
            this.dtGridViewExtrato.AllowUserToAddRows = false;
            this.dtGridViewExtrato.AllowUserToDeleteRows = false;
            this.dtGridViewExtrato.AllowUserToResizeColumns = false;
            this.dtGridViewExtrato.AllowUserToResizeRows = false;
            this.dtGridViewExtrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridViewExtrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridViewExtrato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            this.dtGridViewExtrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewExtrato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(119)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(119)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewExtrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewExtrato.ColumnHeadersHeight = 30;
            this.dtGridViewExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewExtrato.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewExtrato.EnableHeadersVisualStyles = false;
            this.dtGridViewExtrato.GridColor = System.Drawing.Color.Silver;
            this.dtGridViewExtrato.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtGridViewExtrato.Location = new System.Drawing.Point(49, 0);
            this.dtGridViewExtrato.Name = "dtGridViewExtrato";
            this.dtGridViewExtrato.ReadOnly = true;
            this.dtGridViewExtrato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewExtrato.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewExtrato.RowHeadersVisible = false;
            this.dtGridViewExtrato.RowTemplate.Height = 25;
            this.dtGridViewExtrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewExtrato.Size = new System.Drawing.Size(367, 150);
            this.dtGridViewExtrato.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrimeiroProjetoWF.Properties.Resources.icons8_livro_de_caixa_50;
            this.pictureBox1.Location = new System.Drawing.Point(193, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSairExtrato
            // 
            this.btnSairExtrato.AutoSize = true;
            this.btnSairExtrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            this.btnSairExtrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairExtrato.FlatAppearance.BorderSize = 0;
            this.btnSairExtrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairExtrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSairExtrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(119)))), ((int)(((byte)(48)))));
            this.btnSairExtrato.Location = new System.Drawing.Point(460, 0);
            this.btnSairExtrato.Name = "btnSairExtrato";
            this.btnSairExtrato.Size = new System.Drawing.Size(40, 40);
            this.btnSairExtrato.TabIndex = 20;
            this.btnSairExtrato.Text = "X";
            this.btnSairExtrato.UseVisualStyleBackColor = false;
            this.btnSairExtrato.Click += new System.EventHandler(this.btnSairExtrato_Click_1);
            // 
            // btnExtrato
            // 
            this.btnExtrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(119)))), ((int)(((byte)(48)))));
            this.btnExtrato.FlatAppearance.BorderSize = 0;
            this.btnExtrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtrato.Location = new System.Drawing.Point(113, 234);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(261, 29);
            this.btnExtrato.TabIndex = 21;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = false;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtGridViewExtrato);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 150);
            this.panel1.TabIndex = 24;
            // 
            // dtDataInicio
            // 
            this.dtDataInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(119)))), ((int)(((byte)(48)))));
            this.dtDataInicio.BorderSize = 1;
            this.dtDataInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtDataInicio.CustomFormat = "dd MMMM, yyy";
            this.dtDataInicio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataInicio.Location = new System.Drawing.Point(113, 178);
            this.dtDataInicio.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtDataInicio.Name = "dtDataInicio";
            this.dtDataInicio.Size = new System.Drawing.Size(123, 35);
            this.dtDataInicio.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            this.dtDataInicio.TabIndex = 25;
            this.dtDataInicio.TextColor = System.Drawing.Color.Silver;
            // 
            // dtDataFim
            // 
            this.dtDataFim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(119)))), ((int)(((byte)(48)))));
            this.dtDataFim.BorderSize = 1;
            this.dtDataFim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtDataFim.CustomFormat = "dd MMMM, yyy";
            this.dtDataFim.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataFim.Location = new System.Drawing.Point(249, 178);
            this.dtDataFim.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtDataFim.Name = "dtDataFim";
            this.dtDataFim.Size = new System.Drawing.Size(125, 35);
            this.dtDataFim.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            this.dtDataFim.TabIndex = 26;
            this.dtDataFim.TextColor = System.Drawing.Color.Silver;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(113, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Data Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(249, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data Fim:";
            // 
            // Extrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDataFim);
            this.Controls.Add(this.dtDataInicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnSairExtrato);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Extrato";
            this.Size = new System.Drawing.Size(500, 430);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExtrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dtGridViewExtrato;
        private PictureBox pictureBox1;
        private Button btnSairExtrato;
        private Button btnExtrato;
        private Panel panel1;
        private Calendario dtDataInicio;
        private Calendario dtDataFim;
        private Label label1;
        private Label label2;
    }
}
