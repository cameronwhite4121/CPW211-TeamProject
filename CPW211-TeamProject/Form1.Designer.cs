namespace CPW211_TeamProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnViewDeleteCharacter = new Button();
            btnAddCharacter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(452, 45);
            label1.TabIndex = 0;
            label1.Text = "Marvel/Dc Character Index";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 248);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnViewDeleteCharacter
            // 
            btnViewDeleteCharacter.Anchor = AnchorStyles.None;
            btnViewDeleteCharacter.Location = new Point(304, 396);
            btnViewDeleteCharacter.Name = "btnViewDeleteCharacter";
            btnViewDeleteCharacter.Size = new Size(124, 43);
            btnViewDeleteCharacter.TabIndex = 3;
            btnViewDeleteCharacter.Text = "View/Delete Character";
            btnViewDeleteCharacter.UseVisualStyleBackColor = true;
            btnViewDeleteCharacter.Click += btnViewDeleteCharacter_Click;
            // 
            // btnAddCharacter
            // 
            btnAddCharacter.Anchor = AnchorStyles.None;
            btnAddCharacter.Location = new Point(76, 396);
            btnAddCharacter.Name = "btnAddCharacter";
            btnAddCharacter.Size = new Size(124, 43);
            btnAddCharacter.TabIndex = 4;
            btnAddCharacter.Text = "Add Character";
            btnAddCharacter.UseVisualStyleBackColor = true;
            btnAddCharacter.Click += btnAddCharacter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 497);
            Controls.Add(btnAddCharacter);
            Controls.Add(btnViewDeleteCharacter);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Character Index";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnViewDeleteCharacter;
        private Button btnAddCharacter;
    }
}
