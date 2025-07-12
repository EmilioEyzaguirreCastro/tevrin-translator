namespace Tevrin_Translator
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
            answerBox = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            submitEnglish = new Button();
            submitSpanish = new Button();
            aboutUs = new Button();
            SuspendLayout();
            // 
            // answerBox
            // 
            answerBox.Location = new Point(12, 260);
            answerBox.Multiline = true;
            answerBox.Name = "answerBox";
            answerBox.ReadOnly = true;
            answerBox.Size = new Size(662, 178);
            answerBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(662, 178);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(262, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese texto (spanish is kinda broken)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 237);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 4;
            label2.Text = "Traduccion en TEVRIN";
            // 
            // submitEnglish
            // 
            submitEnglish.Location = new Point(680, 41);
            submitEnglish.Name = "submitEnglish";
            submitEnglish.Size = new Size(108, 84);
            submitEnglish.TabIndex = 5;
            submitEnglish.Text = "Translate from English";
            submitEnglish.UseVisualStyleBackColor = true;
            submitEnglish.Click += submitEnglish_Click;
            // 
            // submitSpanish
            // 
            submitSpanish.Location = new Point(680, 135);
            submitSpanish.Name = "submitSpanish";
            submitSpanish.Size = new Size(108, 84);
            submitSpanish.TabIndex = 6;
            submitSpanish.Text = "Traducir del Español";
            submitSpanish.UseVisualStyleBackColor = true;
            submitSpanish.Click += submitSpanish_Click;
            // 
            // aboutUs
            // 
            aboutUs.Location = new Point(680, 260);
            aboutUs.Name = "aboutUs";
            aboutUs.Size = new Size(108, 178);
            aboutUs.TabIndex = 7;
            aboutUs.Text = "Acerca de";
            aboutUs.UseVisualStyleBackColor = true;
            aboutUs.Click += aboutUs_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(aboutUs);
            Controls.Add(submitSpanish);
            Controls.Add(submitEnglish);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(answerBox);
            Name = "Form1";
            Text = "Tevrin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox answerBox;
        private Label label1;
        private Label label2;
        public Button aboutUs;
        public Button submitEnglish;
        public Button submitSpanish;
        public TextBox textBox1;
    }
}
