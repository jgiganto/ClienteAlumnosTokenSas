namespace ClienteAlumnosTokenSas
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
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.btnacceder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridalumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridalumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca curso";
            // 
            // txtcurso
            // 
            this.txtcurso.Location = new System.Drawing.Point(172, 47);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(136, 26);
            this.txtcurso.TabIndex = 1;
            // 
            // btnacceder
            // 
            this.btnacceder.Location = new System.Drawing.Point(364, 45);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(164, 76);
            this.btnacceder.TabIndex = 2;
            this.btnacceder.Text = "Acceder a datos Azure Table";
            this.btnacceder.UseVisualStyleBackColor = true;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alumnos";
            // 
            // gridalumnos
            // 
            this.gridalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridalumnos.Location = new System.Drawing.Point(42, 207);
            this.gridalumnos.Name = "gridalumnos";
            this.gridalumnos.Size = new System.Drawing.Size(530, 259);
            this.gridalumnos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 515);
            this.Controls.Add(this.gridalumnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridalumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.Button btnacceder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridalumnos;
    }
}

