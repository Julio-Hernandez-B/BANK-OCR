namespace BankOCR_Gobierno_Digital
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
            panel1 = new Panel();
            lb_resultados = new ListBox();
            btn_ruta = new Button();
            label = new Label();
            tb_ruta = new TextBox();
            btn_interprete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_interprete);
            panel1.Controls.Add(lb_resultados);
            panel1.Controls.Add(btn_ruta);
            panel1.Controls.Add(label);
            panel1.Controls.Add(tb_ruta);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // lb_resultados
            // 
            lb_resultados.FormattingEnabled = true;
            lb_resultados.Location = new Point(29, 82);
            lb_resultados.Name = "lb_resultados";
            lb_resultados.Size = new Size(633, 304);
            lb_resultados.TabIndex = 3;
            // 
            // btn_ruta
            // 
            btn_ruta.Location = new Point(668, 23);
            btn_ruta.Name = "btn_ruta";
            btn_ruta.Size = new Size(81, 29);
            btn_ruta.TabIndex = 2;
            btn_ruta.Text = "Abrir";
            btn_ruta.UseVisualStyleBackColor = true;
            btn_ruta.Click += btn_ruta_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(29, 32);
            label.Name = "label";
            label.Size = new Size(114, 20);
            label.TabIndex = 1;
            label.Text = "Ruta de Archivo";
            // 
            // tb_ruta
            // 
            tb_ruta.Location = new Point(146, 25);
            tb_ruta.Name = "tb_ruta";
            tb_ruta.Size = new Size(516, 27);
            tb_ruta.TabIndex = 0;
            // 
            // btn_interprete
            // 
            btn_interprete.Location = new Point(668, 82);
            btn_interprete.Name = "btn_interprete";
            btn_interprete.Size = new Size(94, 29);
            btn_interprete.TabIndex = 4;
            btn_interprete.Text = "Interpretar";
            btn_interprete.UseVisualStyleBackColor = true;
            btn_interprete.Click += btn_interprete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Bank OCR Gob Digital";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lb_resultados;
        private Button btn_ruta;
        private Label label;
        private TextBox tb_ruta;
        private Button btn_interprete;
    }
}
