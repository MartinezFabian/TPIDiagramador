namespace TPIDiagramador
{
    partial class FormAyuda
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
            this.txtTextoAyuda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTextoAyuda
            // 
            this.txtTextoAyuda.BackColor = System.Drawing.SystemColors.Info;
            this.txtTextoAyuda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTextoAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoAyuda.Location = new System.Drawing.Point(28, 28);
            this.txtTextoAyuda.Multiline = true;
            this.txtTextoAyuda.Name = "txtTextoAyuda";
            this.txtTextoAyuda.ReadOnly = true;
            this.txtTextoAyuda.Size = new System.Drawing.Size(733, 422);
            this.txtTextoAyuda.TabIndex = 0;
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTextoAyuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAyuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoAyuda;
    }
}