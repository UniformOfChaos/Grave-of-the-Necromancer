namespace GameWindow
{
    partial class ChooseClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseClass));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.WarriorClass_label = new System.Windows.Forms.Label();
            this.RogueClass_label = new System.Windows.Forms.Label();
            this.WizardClass_label = new System.Windows.Forms.Label();
            this.WarriorDescription_label = new System.Windows.Forms.Label();
            this.btnSelectWarrior = new System.Windows.Forms.Button();
            this.btnSelectRogue = new System.Windows.Forms.Button();
            this.btnSelectWizard = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 184);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(206, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 184);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(390, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 184);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // WarriorClass_label
            // 
            this.WarriorClass_label.AutoSize = true;
            this.WarriorClass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarriorClass_label.Location = new System.Drawing.Point(66, 204);
            this.WarriorClass_label.Name = "WarriorClass_label";
            this.WarriorClass_label.Size = new System.Drawing.Size(71, 24);
            this.WarriorClass_label.TabIndex = 2;
            this.WarriorClass_label.Text = "Warrior";
            // 
            // RogueClass_label
            // 
            this.RogueClass_label.AutoSize = true;
            this.RogueClass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RogueClass_label.Location = new System.Drawing.Point(264, 204);
            this.RogueClass_label.Name = "RogueClass_label";
            this.RogueClass_label.Size = new System.Drawing.Size(67, 24);
            this.RogueClass_label.TabIndex = 2;
            this.RogueClass_label.Text = "Rogue";
            // 
            // WizardClass_label
            // 
            this.WizardClass_label.AutoSize = true;
            this.WizardClass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WizardClass_label.Location = new System.Drawing.Point(454, 204);
            this.WizardClass_label.Name = "WizardClass_label";
            this.WizardClass_label.Size = new System.Drawing.Size(68, 24);
            this.WizardClass_label.TabIndex = 2;
            this.WizardClass_label.Text = "Wizard";
            // 
            // WarriorDescription_label
            // 
            this.WarriorDescription_label.AutoSize = true;
            this.WarriorDescription_label.Location = new System.Drawing.Point(19, 241);
            this.WarriorDescription_label.Name = "WarriorDescription_label";
            this.WarriorDescription_label.Size = new System.Drawing.Size(0, 13);
            this.WarriorDescription_label.TabIndex = 3;
            // 
            // btnSelectWarrior
            // 
            this.btnSelectWarrior.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectWarrior.Location = new System.Drawing.Point(22, 349);
            this.btnSelectWarrior.Name = "btnSelectWarrior";
            this.btnSelectWarrior.Size = new System.Drawing.Size(178, 43);
            this.btnSelectWarrior.TabIndex = 4;
            this.btnSelectWarrior.Text = "Select this Class";
            this.btnSelectWarrior.UseVisualStyleBackColor = false;
            this.btnSelectWarrior.Click += new System.EventHandler(this.btnSelectWarrior_Click);
            // 
            // btnSelectRogue
            // 
            this.btnSelectRogue.Location = new System.Drawing.Point(206, 349);
            this.btnSelectRogue.Name = "btnSelectRogue";
            this.btnSelectRogue.Size = new System.Drawing.Size(178, 43);
            this.btnSelectRogue.TabIndex = 4;
            this.btnSelectRogue.Text = "Select this Class";
            this.btnSelectRogue.UseVisualStyleBackColor = true;
            this.btnSelectRogue.Click += new System.EventHandler(this.btnSelectRogue_Click);
            // 
            // btnSelectWizard
            // 
            this.btnSelectWizard.Location = new System.Drawing.Point(390, 349);
            this.btnSelectWizard.Name = "btnSelectWizard";
            this.btnSelectWizard.Size = new System.Drawing.Size(178, 43);
            this.btnSelectWizard.TabIndex = 4;
            this.btnSelectWizard.Text = "Select this Class";
            this.btnSelectWizard.UseVisualStyleBackColor = true;
            this.btnSelectWizard.Click += new System.EventHandler(this.btnSelectWizard_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 231);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 98);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(206, 231);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 98);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Rogues are the only class which can dual wield. They are a sort of cross between " +
    "warriors and wizards, with some of the abilities of both.";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(390, 231);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 98);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Wizards are the plysically weakest class, but wield powerful magics to account fo" +
    "r this. They are able to heal themselves effectively.";
            // 
            // ChooseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(596, 433);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSelectWizard);
            this.Controls.Add(this.btnSelectRogue);
            this.Controls.Add(this.btnSelectWarrior);
            this.Controls.Add(this.WarriorDescription_label);
            this.Controls.Add(this.WizardClass_label);
            this.Controls.Add(this.RogueClass_label);
            this.Controls.Add(this.WarriorClass_label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChooseClass";
            this.Text = "ChooseClass";
            this.Load += new System.EventHandler(this.ChooseClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label WarriorClass_label;
        private System.Windows.Forms.Label RogueClass_label;
        private System.Windows.Forms.Label WizardClass_label;
        private System.Windows.Forms.Label WarriorDescription_label;
        private System.Windows.Forms.Button btnSelectWarrior;
        private System.Windows.Forms.Button btnSelectRogue;
        private System.Windows.Forms.Button btnSelectWizard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}