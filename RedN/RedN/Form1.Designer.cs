
namespace RedN
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.brnEntrenar = new System.Windows.Forms.Button();
            this.txtw0 = new System.Windows.Forms.TextBox();
            this.txtw1 = new System.Windows.Forms.TextBox();
            this.txtw2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.txttxt3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtw3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brnEntrenar
            // 
            this.brnEntrenar.Location = new System.Drawing.Point(97, 35);
            this.brnEntrenar.Name = "brnEntrenar";
            this.brnEntrenar.Size = new System.Drawing.Size(153, 65);
            this.brnEntrenar.TabIndex = 0;
            this.brnEntrenar.Text = "Entrenar";
            this.brnEntrenar.UseVisualStyleBackColor = true;
            this.brnEntrenar.Click += new System.EventHandler(this.brnEntrenar_Click);
            // 
            // txtw0
            // 
            this.txtw0.Location = new System.Drawing.Point(97, 127);
            this.txtw0.Name = "txtw0";
            this.txtw0.Size = new System.Drawing.Size(153, 20);
            this.txtw0.TabIndex = 1;
            // 
            // txtw1
            // 
            this.txtw1.Location = new System.Drawing.Point(97, 164);
            this.txtw1.Name = "txtw1";
            this.txtw1.Size = new System.Drawing.Size(153, 20);
            this.txtw1.TabIndex = 2;
            // 
            // txtw2
            // 
            this.txtw2.Location = new System.Drawing.Point(97, 204);
            this.txtw2.Name = "txtw2";
            this.txtw2.Size = new System.Drawing.Size(153, 20);
            this.txtw2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "w0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "w1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "w2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "x2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "x1";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(442, 249);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(153, 20);
            this.txtresult.TabIndex = 9;
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(442, 164);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(153, 20);
            this.txtx2.TabIndex = 8;
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(442, 127);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(153, 20);
            this.txtx1.TabIndex = 7;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(442, 35);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(153, 65);
            this.btnEvaluar.TabIndex = 13;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // txttxt3
            // 
            this.txttxt3.Location = new System.Drawing.Point(442, 204);
            this.txttxt3.Name = "txttxt3";
            this.txttxt3.Size = new System.Drawing.Size(153, 20);
            this.txttxt3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "x3";
            // 
            // txtw3
            // 
            this.txtw3.Location = new System.Drawing.Point(97, 245);
            this.txtw3.Name = "txtw3";
            this.txtw3.Size = new System.Drawing.Size(153, 20);
            this.txtw3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "w3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtw3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttxt3);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtw2);
            this.Controls.Add(this.txtw1);
            this.Controls.Add(this.txtw0);
            this.Controls.Add(this.brnEntrenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnEntrenar;
        private System.Windows.Forms.TextBox txtw0;
        private System.Windows.Forms.TextBox txtw1;
        private System.Windows.Forms.TextBox txtw2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.TextBox txttxt3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtw3;
        private System.Windows.Forms.Label label8;
    }
}

