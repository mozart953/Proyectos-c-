namespace Proyecto_Cajero_Archivos_Wilson
{
    partial class ad_trans
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
            this.tabla1 = new System.Windows.Forms.DataGridView();
            this.txtselec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdos = new System.Windows.Forms.TextBox();
            this.txtcien = new System.Windows.Forms.TextBox();
            this.txtcincuenta = new System.Windows.Forms.TextBox();
            this.txtveinte = new System.Windows.Forms.TextBox();
            this.txtdiez = new System.Windows.Forms.TextBox();
            this.txtcinco = new System.Windows.Forms.TextBox();
            this.txtuno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla1
            // 
            this.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla1.Location = new System.Drawing.Point(16, 215);
            this.tabla1.Name = "tabla1";
            this.tabla1.Size = new System.Drawing.Size(726, 139);
            this.tabla1.TabIndex = 0;
            // 
            // txtselec
            // 
            this.txtselec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtselec.FormattingEnabled = true;
            this.txtselec.Items.AddRange(new object[] {
            "Inicializar Cajero",
            "Agregar Efectivo"});
            this.txtselec.Location = new System.Drawing.Point(425, 37);
            this.txtselec.Name = "txtselec";
            this.txtselec.Size = new System.Drawing.Size(209, 28);
            this.txtselec.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elegir accion a realizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese la cantidad de billetes de cada denominacion.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdos
            // 
            this.txtdos.Location = new System.Drawing.Point(38, 107);
            this.txtdos.Name = "txtdos";
            this.txtdos.Size = new System.Drawing.Size(73, 20);
            this.txtdos.TabIndex = 6;
            // 
            // txtcien
            // 
            this.txtcien.Location = new System.Drawing.Point(132, 107);
            this.txtcien.Name = "txtcien";
            this.txtcien.Size = new System.Drawing.Size(73, 20);
            this.txtcien.TabIndex = 7;
            // 
            // txtcincuenta
            // 
            this.txtcincuenta.Location = new System.Drawing.Point(227, 107);
            this.txtcincuenta.Name = "txtcincuenta";
            this.txtcincuenta.Size = new System.Drawing.Size(73, 20);
            this.txtcincuenta.TabIndex = 8;
            // 
            // txtveinte
            // 
            this.txtveinte.Location = new System.Drawing.Point(326, 107);
            this.txtveinte.Name = "txtveinte";
            this.txtveinte.Size = new System.Drawing.Size(73, 20);
            this.txtveinte.TabIndex = 9;
            // 
            // txtdiez
            // 
            this.txtdiez.Location = new System.Drawing.Point(421, 107);
            this.txtdiez.Name = "txtdiez";
            this.txtdiez.Size = new System.Drawing.Size(73, 20);
            this.txtdiez.TabIndex = 10;
            // 
            // txtcinco
            // 
            this.txtcinco.Location = new System.Drawing.Point(513, 107);
            this.txtcinco.Name = "txtcinco";
            this.txtcinco.Size = new System.Drawing.Size(73, 20);
            this.txtcinco.TabIndex = 11;
            // 
            // txtuno
            // 
            this.txtuno.Location = new System.Drawing.Point(602, 107);
            this.txtuno.Name = "txtuno";
            this.txtuno.Size = new System.Drawing.Size(73, 20);
            this.txtuno.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "B200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "B100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "B50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "B20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(434, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "B10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "B5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "B1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Ingresar billetes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ad_trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(754, 388);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtuno);
            this.Controls.Add(this.txtcinco);
            this.Controls.Add(this.txtdiez);
            this.Controls.Add(this.txtveinte);
            this.Controls.Add(this.txtcincuenta);
            this.Controls.Add(this.txtcien);
            this.Controls.Add(this.txtdos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtselec);
            this.Controls.Add(this.tabla1);
            this.Name = "ad_trans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ad_trans";
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla1;
        private System.Windows.Forms.ComboBox txtselec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdos;
        private System.Windows.Forms.TextBox txtcien;
        private System.Windows.Forms.TextBox txtcincuenta;
        private System.Windows.Forms.TextBox txtveinte;
        private System.Windows.Forms.TextBox txtdiez;
        private System.Windows.Forms.TextBox txtcinco;
        private System.Windows.Forms.TextBox txtuno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}