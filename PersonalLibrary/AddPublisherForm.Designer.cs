namespace PersonalLibrary
{
    partial class AddPublisherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPublisherForm));
            this.AddPublisherButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AbbreviationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PublisherNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPublisherButton
            // 
            this.AddPublisherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPublisherButton.Location = new System.Drawing.Point(369, 96);
            this.AddPublisherButton.Name = "AddPublisherButton";
            this.AddPublisherButton.Size = new System.Drawing.Size(98, 52);
            this.AddPublisherButton.TabIndex = 2;
            this.AddPublisherButton.Text = "Add Publisher";
            this.AddPublisherButton.UseVisualStyleBackColor = true;
            this.AddPublisherButton.Click += new System.EventHandler(this.AddPublisherButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Publisher Name Abbreviation:";
            // 
            // AbbreviationTextBox
            // 
            this.AbbreviationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbbreviationTextBox.Location = new System.Drawing.Point(243, 109);
            this.AbbreviationTextBox.Name = "AbbreviationTextBox";
            this.AbbreviationTextBox.Size = new System.Drawing.Size(100, 26);
            this.AbbreviationTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Publisher Full Name:";
            // 
            // PublisherNameTextBox
            // 
            this.PublisherNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisherNameTextBox.Location = new System.Drawing.Point(25, 44);
            this.PublisherNameTextBox.Name = "PublisherNameTextBox";
            this.PublisherNameTextBox.Size = new System.Drawing.Size(442, 26);
            this.PublisherNameTextBox.TabIndex = 0;
            // 
            // AddPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 168);
            this.Controls.Add(this.PublisherNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AbbreviationTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPublisherButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPublisherForm";
            this.Text = "Add Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPublisherButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AbbreviationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PublisherNameTextBox;
    }
}