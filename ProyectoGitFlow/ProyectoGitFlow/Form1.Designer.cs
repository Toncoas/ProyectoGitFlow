namespace ProyectoGitFlow
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
            this.ID_Autobuses = new System.Windows.Forms.Label();
            this.txtAutobuses_ID = new System.Windows.Forms.TextBox();
            this.GuardarVehiculo = new System.Windows.Forms.Button();
            this.Marca = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.Placa = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.año = new System.Windows.Forms.Label();
            this.txtAutobuses_Marca = new System.Windows.Forms.TextBox();
            this.txtAutobuses_Modelo = new System.Windows.Forms.TextBox();
            this.txtAutobuses_Placa = new System.Windows.Forms.TextBox();
            this.txtAutobuses_Color = new System.Windows.Forms.TextBox();
            this.txtAutobuses_año = new System.Windows.Forms.TextBox();
            this.EditarVehiculo = new System.Windows.Forms.Button();
            this.BuscarVehiculo = new System.Windows.Forms.Button();
            this.EliminarVehiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_Autobuses
            // 
            this.ID_Autobuses.AutoSize = true;
            this.ID_Autobuses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ID_Autobuses.Location = new System.Drawing.Point(25, 28);
            this.ID_Autobuses.Name = "ID_Autobuses";
            this.ID_Autobuses.Size = new System.Drawing.Size(27, 20);
            this.ID_Autobuses.TabIndex = 0;
            this.ID_Autobuses.Text = "ID:";
            // 
            // txtAutobuses_ID
            // 
            this.txtAutobuses_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutobuses_ID.Location = new System.Drawing.Point(95, 25);
            this.txtAutobuses_ID.Name = "txtAutobuses_ID";
            this.txtAutobuses_ID.Size = new System.Drawing.Size(47, 27);
            this.txtAutobuses_ID.TabIndex = 1;
            // 
            // GuardarVehiculo
            // 
            this.GuardarVehiculo.Location = new System.Drawing.Point(25, 324);
            this.GuardarVehiculo.Name = "GuardarVehiculo";
            this.GuardarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.GuardarVehiculo.TabIndex = 2;
            this.GuardarVehiculo.Text = "Save";
            this.GuardarVehiculo.UseVisualStyleBackColor = true;
            this.GuardarVehiculo.Click += new System.EventHandler(this.GuardarVehiculo_Click);
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Marca.Location = new System.Drawing.Point(25, 76);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(53, 20);
            this.Marca.TabIndex = 3;
            this.Marca.Text = "Marca:";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Modelo.Location = new System.Drawing.Point(25, 130);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(64, 20);
            this.Modelo.TabIndex = 4;
            this.Modelo.Text = "Modelo:";
            // 
            // Placa
            // 
            this.Placa.AutoSize = true;
            this.Placa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Placa.Location = new System.Drawing.Point(25, 180);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(47, 20);
            this.Placa.TabIndex = 5;
            this.Placa.Text = "Placa:";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Color.Location = new System.Drawing.Point(25, 234);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(48, 20);
            this.Color.TabIndex = 6;
            this.Color.Text = "Color:";
            // 
            // año
            // 
            this.año.AutoSize = true;
            this.año.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.año.Location = new System.Drawing.Point(25, 281);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(39, 20);
            this.año.TabIndex = 7;
            this.año.Text = "Año:";
            // 
            // txtAutobuses_Marca
            // 
            this.txtAutobuses_Marca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutobuses_Marca.Location = new System.Drawing.Point(95, 76);
            this.txtAutobuses_Marca.Name = "txtAutobuses_Marca";
            this.txtAutobuses_Marca.Size = new System.Drawing.Size(218, 27);
            this.txtAutobuses_Marca.TabIndex = 8;
            // 
            // txtAutobuses_Modelo
            // 
            this.txtAutobuses_Modelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutobuses_Modelo.Location = new System.Drawing.Point(95, 127);
            this.txtAutobuses_Modelo.Name = "txtAutobuses_Modelo";
            this.txtAutobuses_Modelo.Size = new System.Drawing.Size(218, 27);
            this.txtAutobuses_Modelo.TabIndex = 9;
            // 
            // txtAutobuses_Placa
            // 
            this.txtAutobuses_Placa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutobuses_Placa.Location = new System.Drawing.Point(95, 177);
            this.txtAutobuses_Placa.Name = "txtAutobuses_Placa";
            this.txtAutobuses_Placa.Size = new System.Drawing.Size(218, 27);
            this.txtAutobuses_Placa.TabIndex = 10;
            // 
            // txtAutobuses_Color
            // 
            this.txtAutobuses_Color.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutobuses_Color.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAutobuses_Color.Location = new System.Drawing.Point(95, 232);
            this.txtAutobuses_Color.Name = "txtAutobuses_Color";
            this.txtAutobuses_Color.Size = new System.Drawing.Size(218, 27);
            this.txtAutobuses_Color.TabIndex = 11;
            // 
            // txtAutobuses_año
            // 
            this.txtAutobuses_año.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutobuses_año.Location = new System.Drawing.Point(95, 278);
            this.txtAutobuses_año.Name = "txtAutobuses_año";
            this.txtAutobuses_año.Size = new System.Drawing.Size(118, 27);
            this.txtAutobuses_año.TabIndex = 12;
            // 
            // EditarVehiculo
            // 
            this.EditarVehiculo.Location = new System.Drawing.Point(184, 324);
            this.EditarVehiculo.Name = "EditarVehiculo";
            this.EditarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.EditarVehiculo.TabIndex = 13;
            this.EditarVehiculo.Text = "Edit";
            this.EditarVehiculo.UseVisualStyleBackColor = true;
            this.EditarVehiculo.Click += new System.EventHandler(this.EditarVehiculo_Click);
            // 
            // BuscarVehiculo
            // 
            this.BuscarVehiculo.Location = new System.Drawing.Point(105, 324);
            this.BuscarVehiculo.Name = "BuscarVehiculo";
            this.BuscarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.BuscarVehiculo.TabIndex = 14;
            this.BuscarVehiculo.Text = "Search";
            this.BuscarVehiculo.UseVisualStyleBackColor = true;
            this.BuscarVehiculo.Click += new System.EventHandler(this.BuscarVehiculo_Click_1);
            // 
            // EliminarVehiculo
            // 
            this.EliminarVehiculo.Location = new System.Drawing.Point(264, 324);
            this.EliminarVehiculo.Name = "EliminarVehiculo";
            this.EliminarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.EliminarVehiculo.TabIndex = 15;
            this.EliminarVehiculo.Text = "Delete";
            this.EliminarVehiculo.UseVisualStyleBackColor = true;
            this.EliminarVehiculo.Click += new System.EventHandler(this.EliminarVehiculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 375);
            this.Controls.Add(this.EliminarVehiculo);
            this.Controls.Add(this.BuscarVehiculo);
            this.Controls.Add(this.EditarVehiculo);
            this.Controls.Add(this.txtAutobuses_año);
            this.Controls.Add(this.txtAutobuses_Color);
            this.Controls.Add(this.txtAutobuses_Placa);
            this.Controls.Add(this.txtAutobuses_Modelo);
            this.Controls.Add(this.txtAutobuses_Marca);
            this.Controls.Add(this.año);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.GuardarVehiculo);
            this.Controls.Add(this.txtAutobuses_ID);
            this.Controls.Add(this.ID_Autobuses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_Autobuses;
        private System.Windows.Forms.TextBox txtAutobuses_ID;
        private System.Windows.Forms.Button GuardarVehiculo;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label Placa;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label año;
        private System.Windows.Forms.TextBox txtAutobuses_Marca;
        private System.Windows.Forms.TextBox txtAutobuses_Modelo;
        private System.Windows.Forms.TextBox txtAutobuses_Placa;
        private System.Windows.Forms.TextBox txtAutobuses_Color;
        private System.Windows.Forms.TextBox txtAutobuses_año;
        private System.Windows.Forms.Button EditarVehiculo;
        private System.Windows.Forms.Button BuscarVehiculo;
        private System.Windows.Forms.Button EliminarVehiculo;
    }
}

