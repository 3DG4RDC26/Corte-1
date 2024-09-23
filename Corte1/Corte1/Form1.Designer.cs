namespace Corte1
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnMostrar = new System.Windows.Forms.Button();
         this.cmbCiudad = new System.Windows.Forms.ComboBox();
         this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
         this.tbName = new System.Windows.Forms.TextBox();
         this.tbLastName = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(49, 54);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(52, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nombres:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(49, 91);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(52, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Apellidos:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(49, 136);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(117, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Fecha de Naciemiento:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(49, 177);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(43, 13);
         this.label4.TabIndex = 3;
         this.label4.Text = "Ciudad:";
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(52, 235);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(75, 23);
         this.btnAdd.TabIndex = 4;
         this.btnAdd.Text = "Agregar";
         this.btnAdd.UseVisualStyleBackColor = true;
         // 
         // btnMostrar
         // 
         this.btnMostrar.Location = new System.Drawing.Point(158, 235);
         this.btnMostrar.Name = "btnMostrar";
         this.btnMostrar.Size = new System.Drawing.Size(75, 23);
         this.btnMostrar.TabIndex = 5;
         this.btnMostrar.Text = "Mostrar";
         this.btnMostrar.UseVisualStyleBackColor = true;
         // 
         // cmbCiudad
         // 
         this.cmbCiudad.FormattingEnabled = true;
         this.cmbCiudad.Location = new System.Drawing.Point(186, 177);
         this.cmbCiudad.Name = "cmbCiudad";
         this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
         this.cmbCiudad.TabIndex = 6;
         // 
         // dtpFechaNac
         // 
         this.dtpFechaNac.Location = new System.Drawing.Point(186, 136);
         this.dtpFechaNac.Name = "dtpFechaNac";
         this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
         this.dtpFechaNac.TabIndex = 7;
         // 
         // tbName
         // 
         this.tbName.Location = new System.Drawing.Point(186, 54);
         this.tbName.Name = "tbName";
         this.tbName.Size = new System.Drawing.Size(100, 20);
         this.tbName.TabIndex = 8;
         // 
         // tbLastName
         // 
         this.tbLastName.Location = new System.Drawing.Point(186, 88);
         this.tbLastName.Name = "tbLastName";
         this.tbLastName.Size = new System.Drawing.Size(100, 20);
         this.tbLastName.TabIndex = 9;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.tbLastName);
         this.Controls.Add(this.tbName);
         this.Controls.Add(this.dtpFechaNac);
         this.Controls.Add(this.cmbCiudad);
         this.Controls.Add(this.btnMostrar);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Registro de edades - ERCV";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnMostrar;
      private System.Windows.Forms.ComboBox cmbCiudad;
      private System.Windows.Forms.DateTimePicker dtpFechaNac;
      private System.Windows.Forms.TextBox tbName;
      private System.Windows.Forms.TextBox tbLastName;
   }
}

