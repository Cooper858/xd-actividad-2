namespace hello_world
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
            label1 = new Label();
            como = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(207, 33);
            label1.TabIndex = 1;
            label1.Text = "hello  world";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // como
            // 
            como.AutoSize = true;
            como.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            como.ForeColor = Color.Black;
            como.Location = new Point(12, 113);
            como.Name = "como";
            como.Size = new Size(273, 36);
            como.TabIndex = 2;
            como.Text = "como te llamas ?";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(36, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(27, 227);
            label2.Name = "label2";
            label2.Size = new Size(341, 36);
            label2.TabIndex = 4;
            label2.Text = "hola alguen especial";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(334, 139);
            button1.Name = "button1";
            button1.Size = new Size(126, 70);
            button1.TabIndex = 5;
            button1.Text = "diga \"hello\"";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(como);
            Controls.Add(label1);
            ForeColor = Color.Aqua;
            Name = "Form1";
            Text = "hello bro";
            TopMost = true;
            TransparencyKey = Color.Blue;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label como;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
    }
}