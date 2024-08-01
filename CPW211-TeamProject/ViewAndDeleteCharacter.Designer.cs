namespace CPW211_TeamProject
{
    partial class ViewAndDeleteCharacter
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
            btnEditCharacter = new Button();
            btnDeleteCharacter = new Button();
            lsbxCharacterList = new ListBox();
            SuspendLayout();
            // 
            // btnEditCharacter
            // 
            btnEditCharacter.Location = new Point(339, 94);
            btnEditCharacter.Name = "btnEditCharacter";
            btnEditCharacter.Size = new Size(112, 38);
            btnEditCharacter.TabIndex = 0;
            btnEditCharacter.Text = "Edit Character";
            btnEditCharacter.UseVisualStyleBackColor = true;
            btnEditCharacter.Click += btnEditCharacter_Click;
            // 
            // btnDeleteCharacter
            // 
            btnDeleteCharacter.Location = new Point(339, 195);
            btnDeleteCharacter.Name = "btnDeleteCharacter";
            btnDeleteCharacter.Size = new Size(112, 38);
            btnDeleteCharacter.TabIndex = 2;
            btnDeleteCharacter.Text = "Delete Character";
            btnDeleteCharacter.UseVisualStyleBackColor = true;
            btnDeleteCharacter.Click += btnDeleteCharacter_Click;
            // 
            // lsbxCharacterList
            // 
            lsbxCharacterList.FormattingEnabled = true;
            lsbxCharacterList.ItemHeight = 15;
            lsbxCharacterList.Location = new Point(37, 30);
            lsbxCharacterList.Name = "lsbxCharacterList";
            lsbxCharacterList.Size = new Size(236, 274);
            lsbxCharacterList.TabIndex = 3;
            // 
            // ViewAndDeleteCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(500, 362);
            Controls.Add(lsbxCharacterList);
            Controls.Add(btnDeleteCharacter);
            Controls.Add(btnEditCharacter);
            Name = "ViewAndDeleteCharacter";
            Text = "View/Delete Character";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditCharacter;
        private Button btnDeleteCharacter;
        private ListBox lsbxCharacterList;
    }
}