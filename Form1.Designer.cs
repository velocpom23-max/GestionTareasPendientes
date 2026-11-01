namespace GestionTareasPendientes
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
            label1 = new Label();
            label2 = new Label();
            txtTarea = new TextBox();
            btnAgregarTarea = new Button();
            lstTareas = new ListBox();
            btnEliminarTarea = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 26);
            label1.TabIndex = 0;
            label1.Text = "GESTION DE TAREAS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 51);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese una nueva tarea";
            label2.Click += label2_Click;
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(23, 86);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(216, 27);
            txtTarea.TabIndex = 2;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = Color.DeepSkyBlue;
            btnAgregarTarea.Location = new Point(23, 131);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(216, 36);
            btnAgregarTarea.TabIndex = 3;
            btnAgregarTarea.Text = "Agregar tareas";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.Location = new Point(23, 183);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(279, 164);
            lstTareas.TabIndex = 4;
            lstTareas.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackColor = Color.Crimson;
            btnEliminarTarea.Location = new Point(23, 370);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(279, 68);
            btnEliminarTarea.TabIndex = 5;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = false;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(367, 460);
            Controls.Add(btnEliminarTarea);
            Controls.Add(lstTareas);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtTarea);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTarea;
        private Button btnAgregarTarea;
        private ListBox lstTareas;
        private Button btnEliminarTarea;
    }
}
