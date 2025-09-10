namespace GUI
{
    partial class Prestamos
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
            Grilla_Prestamos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            LB_Usuarios = new ListBox();
            Label123s = new Label();
            LB_Libros = new ListBox();
            label3 = new Label();
            BTN_AGREGAR = new Button();
            BTN_MODIFICAR = new Button();
            BTN_ELIMINAR = new Button();
            ((System.ComponentModel.ISupportInitialize)Grilla_Prestamos).BeginInit();
            SuspendLayout();
            // 
            // Grilla_Prestamos
            // 
            Grilla_Prestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Prestamos.Location = new Point(12, 83);
            Grilla_Prestamos.Name = "Grilla_Prestamos";
            Grilla_Prestamos.Size = new Size(596, 225);
            Grilla_Prestamos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 33);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 48);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 4;
            label2.Text = "Prestamos";
            // 
            // LB_Usuarios
            // 
            LB_Usuarios.FormattingEnabled = true;
            LB_Usuarios.Location = new Point(614, 83);
            LB_Usuarios.Name = "LB_Usuarios";
            LB_Usuarios.Size = new Size(120, 94);
            LB_Usuarios.TabIndex = 5;
            // 
            // Label123s
            // 
            Label123s.AutoSize = true;
            Label123s.BackColor = Color.Transparent;
            Label123s.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label123s.Location = new Point(614, 179);
            Label123s.Name = "Label123s";
            Label123s.Size = new Size(84, 32);
            Label123s.TabIndex = 6;
            Label123s.Text = "Libros";
            // 
            // LB_Libros
            // 
            LB_Libros.FormattingEnabled = true;
            LB_Libros.Location = new Point(614, 214);
            LB_Libros.Name = "LB_Libros";
            LB_Libros.Size = new Size(120, 94);
            LB_Libros.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(614, 48);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 8;
            label3.Text = "Usuarios";
            // 
            // BTN_AGREGAR
            // 
            BTN_AGREGAR.Location = new Point(12, 314);
            BTN_AGREGAR.Name = "BTN_AGREGAR";
            BTN_AGREGAR.Size = new Size(75, 23);
            BTN_AGREGAR.TabIndex = 9;
            BTN_AGREGAR.Text = "Agregar";
            BTN_AGREGAR.UseVisualStyleBackColor = true;
            // 
            // BTN_MODIFICAR
            // 
            BTN_MODIFICAR.Location = new Point(239, 314);
            BTN_MODIFICAR.Name = "BTN_MODIFICAR";
            BTN_MODIFICAR.Size = new Size(75, 23);
            BTN_MODIFICAR.TabIndex = 10;
            BTN_MODIFICAR.Text = "Modificar";
            BTN_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new Point(512, 314);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new Size(75, 23);
            BTN_ELIMINAR.TabIndex = 11;
            BTN_ELIMINAR.Text = "Eliminar";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            BTN_ELIMINAR.Click += BTN_ELIMINAR_Click;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_MODIFICAR);
            Controls.Add(BTN_AGREGAR);
            Controls.Add(label3);
            Controls.Add(LB_Libros);
            Controls.Add(Label123s);
            Controls.Add(LB_Usuarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Grilla_Prestamos);
            Name = "Prestamos";
            Text = "Prestamos";
            Load += Prestamos_Load;
            ((System.ComponentModel.ISupportInitialize)Grilla_Prestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Prestamos;
        private Label label1;
        private Label label2;
        private ListBox LB_Usuarios;
        private Label Label123s;
        private ListBox LB_Libros;
        private Label label3;
        private Button BTN_AGREGAR;
        private Button BTN_MODIFICAR;
        private Button BTN_ELIMINAR;
    }
}