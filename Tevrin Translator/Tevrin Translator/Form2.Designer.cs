namespace Tevrin_Translator
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(428, 118);
            label1.TabIndex = 0;
            label1.Text = "Tevrin Translator ver. beta 1.0.0. Desarrollado por piliomaps";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(303, 115);
            label2.TabIndex = 1;
            label2.Text = "Tevrin Translator esta actualizado\r\n\r\nLista de vocabulario: https://1drv.ms/x/c/ba1349abaa04a8cd/EcFq6o0RoD5LndvSv6vMcsYBCKwAYYpa96ZaIheZfuAlpg?e=oQSlWA";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 164);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Acerca de";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}