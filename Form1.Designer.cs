
namespace Filtros
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
            this.BNButton = new System.Windows.Forms.Button();
            this.GButton = new System.Windows.Forms.Button();
            this.NButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.SButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BNButton
            // 
            this.BNButton.Location = new System.Drawing.Point(61, 311);
            this.BNButton.Name = "BNButton";
            this.BNButton.Size = new System.Drawing.Size(104, 23);
            this.BNButton.TabIndex = 0;
            this.BNButton.Text = "Blanco y Negro";
            this.BNButton.UseVisualStyleBackColor = true;
            this.BNButton.Click += new System.EventHandler(this.BNButton_Click);
            // 
            // GButton
            // 
            this.GButton.Location = new System.Drawing.Point(185, 311);
            this.GButton.Name = "GButton";
            this.GButton.Size = new System.Drawing.Size(75, 23);
            this.GButton.TabIndex = 1;
            this.GButton.Text = "Grises";
            this.GButton.UseVisualStyleBackColor = true;
            this.GButton.Click += new System.EventHandler(this.GButton_Click);
            // 
            // NButton
            // 
            this.NButton.Location = new System.Drawing.Point(386, 311);
            this.NButton.Name = "NButton";
            this.NButton.Size = new System.Drawing.Size(75, 23);
            this.NButton.TabIndex = 2;
            this.NButton.Text = "Negativos";
            this.NButton.UseVisualStyleBackColor = true;
            this.NButton.Click += new System.EventHandler(this.NButton_Click);
            // 
            // RButton
            // 
            this.RButton.Location = new System.Drawing.Point(484, 311);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(75, 23);
            this.RButton.TabIndex = 3;
            this.RButton.Text = "Restaurar";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // SButton
            // 
            this.SButton.Location = new System.Drawing.Point(285, 311);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(75, 23);
            this.SButton.TabIndex = 4;
            this.SButton.Text = "Sepia";
            this.SButton.UseVisualStyleBackColor = true;
            this.SButton.Click += new System.EventHandler(this.SButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 346);
            this.Controls.Add(this.SButton);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.NButton);
            this.Controls.Add(this.GButton);
            this.Controls.Add(this.BNButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BNButton;
        private System.Windows.Forms.Button GButton;
        private System.Windows.Forms.Button NButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button SButton;
    }
}

