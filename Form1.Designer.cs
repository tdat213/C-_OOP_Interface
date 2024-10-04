namespace C__OOP_Interface
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
            btnClick = new Button();
            btnAnimal = new Button();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Location = new Point(32, 28);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(75, 23);
            btnClick.TabIndex = 0;
            btnClick.Text = "button1";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // btnAnimal
            // 
            btnAnimal.Location = new Point(202, 106);
            btnAnimal.Name = "btnAnimal";
            btnAnimal.Size = new Size(75, 23);
            btnAnimal.TabIndex = 1;
            btnAnimal.Text = "Animal";
            btnAnimal.UseVisualStyleBackColor = true;
            btnAnimal.Click += btnAnimal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnimal);
            Controls.Add(btnClick);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClick;
        private Button btnAnimal;
    }
}
