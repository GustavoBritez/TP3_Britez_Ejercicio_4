namespace GUI
{
    partial class Libros
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            BTN_Agregar = new Button();
            BTN_Modificar = new Button();
            BTN_Eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(102, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(561, 239);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 22);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 2;
            label1.Text = "Libros";
            // 
            // BTN_Agregar
            // 
            BTN_Agregar.Location = new Point(102, 312);
            BTN_Agregar.Name = "BTN_Agregar";
            BTN_Agregar.Size = new Size(75, 23);
            BTN_Agregar.TabIndex = 3;
            BTN_Agregar.Text = "Agregar";
            BTN_Agregar.UseVisualStyleBackColor = true;
            // 
            // BTN_Modificar
            // 
            BTN_Modificar.Location = new Point(578, 312);
            BTN_Modificar.Name = "BTN_Modificar";
            BTN_Modificar.Size = new Size(75, 23);
            BTN_Modificar.TabIndex = 4;
            BTN_Modificar.Text = "Modificar";
            BTN_Modificar.UseVisualStyleBackColor = true;
            // 
            // BTN_Eliminar
            // 
            BTN_Eliminar.Location = new Point(336, 312);
            BTN_Eliminar.Name = "BTN_Eliminar";
            BTN_Eliminar.Size = new Size(75, 23);
            BTN_Eliminar.TabIndex = 5;
            BTN_Eliminar.Text = "Eliminar";
            BTN_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_Eliminar);
            Controls.Add(BTN_Modificar);
            Controls.Add(BTN_Agregar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Libros";
            Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button BTN_Agregar;
        private Button BTN_Modificar;
        private Button BTN_Eliminar;
    }
}