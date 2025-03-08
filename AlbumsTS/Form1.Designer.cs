namespace AlbumsTS
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
            dataGridTS = new DataGridView();
            label1 = new Label();
            pctboxTS = new PictureBox();
            label3 = new Label();
            cmbTS = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridTS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctboxTS).BeginInit();
            SuspendLayout();
            // 
            // dataGridTS
            // 
            dataGridTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTS.ColumnHeadersHeight = 29;
            dataGridTS.Location = new Point(22, 419);
            dataGridTS.Name = "dataGridTS";
            dataGridTS.RowHeadersWidth = 51;
            dataGridTS.Size = new Size(956, 329);
            dataGridTS.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(234, 34);
            label1.Name = "label1";
            label1.Size = new Size(429, 39);
            label1.TabIndex = 1;
            label1.Text = "Albums de Taylor Swift";
            // 
            // pctboxTS
            // 
            pctboxTS.Location = new Point(49, 110);
            pctboxTS.Name = "pctboxTS";
            pctboxTS.Size = new Size(284, 272);
            pctboxTS.SizeMode = PictureBoxSizeMode.StretchImage;
            pctboxTS.TabIndex = 2;
            pctboxTS.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 110);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 4;
            label3.Text = "Selecciona un album:";
            // 
            // cmbTS
            // 
            cmbTS.FormattingEnabled = true;
            cmbTS.Location = new Point(464, 158);
            cmbTS.Name = "cmbTS";
            cmbTS.Size = new Size(151, 28);
            cmbTS.TabIndex = 5;
            cmbTS.SelectedIndexChanged += cmbTS_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 778);
            Controls.Add(cmbTS);
            Controls.Add(label3);
            Controls.Add(pctboxTS);
            Controls.Add(label1);
            Controls.Add(dataGridTS);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctboxTS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridTS;
        private Label label1;
        private PictureBox pctboxTS;
        private Label label3;
        private ComboBox cmbTS;
    }
}
