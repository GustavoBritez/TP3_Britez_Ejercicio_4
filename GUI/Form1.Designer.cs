namespace GUI
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
            Grilla_Usuario = new DataGridView();
            label1 = new Label();
            BTN_AGREGAR = new Button();
            BTN_MOD = new Button();
            BTN_ELIMINAR = new Button();
            Ultimos_Ingresados = new RichTextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grilla_Usuario).BeginInit();
            SuspendLayout();
            // 
            // Grilla_Usuario
            // 
            Grilla_Usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Usuario.Location = new Point(109, 78);
            Grilla_Usuario.Name = "Grilla_Usuario";
            Grilla_Usuario.Size = new Size(579, 104);
            Grilla_Usuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 43);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 1;
            label1.Text = "Usuarios";
            // 
            // BTN_AGREGAR
            // 
            BTN_AGREGAR.Location = new Point(109, 188);
            BTN_AGREGAR.Name = "BTN_AGREGAR";
            BTN_AGREGAR.Size = new Size(75, 23);
            BTN_AGREGAR.TabIndex = 2;
            BTN_AGREGAR.Text = "Agregar";
            BTN_AGREGAR.UseVisualStyleBackColor = true;
            BTN_AGREGAR.Click += BTN_AGREGAR_Click;
            // 
            // BTN_MOD
            // 
            BTN_MOD.Location = new Point(351, 188);
            BTN_MOD.Name = "BTN_MOD";
            BTN_MOD.Size = new Size(75, 23);
            BTN_MOD.TabIndex = 3;
            BTN_MOD.Text = "Modificar";
            BTN_MOD.UseVisualStyleBackColor = true;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new Point(613, 188);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new Size(75, 23);
            BTN_ELIMINAR.TabIndex = 4;
            BTN_ELIMINAR.Text = "Eliminar";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // Ultimos_Ingresados
            // 
            Ultimos_Ingresados.Location = new Point(214, 271);
            Ultimos_Ingresados.Name = "Ultimos_Ingresados";
            Ultimos_Ingresados.Size = new Size(381, 42);
            Ultimos_Ingresados.TabIndex = 5;
            Ultimos_Ingresados.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(285, 236);
            label2.Name = "label2";
            label2.Size = new Size(235, 32);
            label2.TabIndex = 6;
            label2.Text = "Ultimos Ingresados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 325);
            Controls.Add(label2);
            Controls.Add(Ultimos_Ingresados);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_MOD);
            Controls.Add(BTN_AGREGAR);
            Controls.Add(label1);
            Controls.Add(Grilla_Usuario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla_Usuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Usuario;
        private Label label1;
        private Button BTN_AGREGAR;
        private Button BTN_MOD;
        private Button BTN_ELIMINAR;
        private RichTextBox Ultimos_Ingresados;
        private Label label2;
    }
}
