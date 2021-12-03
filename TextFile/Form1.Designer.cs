namespace TextFile
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colourInput = new System.Windows.Forms.TextBox();
            this.addColourButton = new System.Windows.Forms.Button();
            this.colourOutput = new System.Windows.Forms.Label();
            this.loadColoursButton = new System.Windows.Forms.Button();
            this.saveColoursButton = new System.Windows.Forms.Button();
            this.sortColoursButton = new System.Windows.Forms.Button();
            this.removeInput = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.name2Label = new System.Windows.Forms.Label();
            this.nameRemove = new System.Windows.Forms.TextBox();
            this.scoreRemoveButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addScoreButton = new System.Windows.Forms.Button();
            this.sortScoresButton = new System.Windows.Forms.Button();
            this.saveScoresButton = new System.Windows.Forms.Button();
            this.loadScoresButton = new System.Windows.Forms.Button();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colourInput
            // 
            this.colourInput.Location = new System.Drawing.Point(62, 148);
            this.colourInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colourInput.Name = "colourInput";
            this.colourInput.Size = new System.Drawing.Size(153, 34);
            this.colourInput.TabIndex = 7;
            // 
            // addColourButton
            // 
            this.addColourButton.Location = new System.Drawing.Point(249, 142);
            this.addColourButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addColourButton.Name = "addColourButton";
            this.addColourButton.Size = new System.Drawing.Size(155, 46);
            this.addColourButton.TabIndex = 6;
            this.addColourButton.Text = "Add";
            this.addColourButton.UseVisualStyleBackColor = true;
            this.addColourButton.Click += new System.EventHandler(this.addColourButton_Click);
            // 
            // colourOutput
            // 
            this.colourOutput.BackColor = System.Drawing.Color.White;
            this.colourOutput.Location = new System.Drawing.Point(57, 267);
            this.colourOutput.Name = "colourOutput";
            this.colourOutput.Size = new System.Drawing.Size(347, 197);
            this.colourOutput.TabIndex = 5;
            // 
            // loadColoursButton
            // 
            this.loadColoursButton.Location = new System.Drawing.Point(62, 52);
            this.loadColoursButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadColoursButton.Name = "loadColoursButton";
            this.loadColoursButton.Size = new System.Drawing.Size(155, 46);
            this.loadColoursButton.TabIndex = 4;
            this.loadColoursButton.Text = "Load";
            this.loadColoursButton.UseVisualStyleBackColor = true;
            this.loadColoursButton.Click += new System.EventHandler(this.loadColoursButton_Click);
            // 
            // saveColoursButton
            // 
            this.saveColoursButton.Location = new System.Drawing.Point(249, 476);
            this.saveColoursButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveColoursButton.Name = "saveColoursButton";
            this.saveColoursButton.Size = new System.Drawing.Size(155, 46);
            this.saveColoursButton.TabIndex = 9;
            this.saveColoursButton.Text = "Save";
            this.saveColoursButton.UseVisualStyleBackColor = true;
            this.saveColoursButton.Click += new System.EventHandler(this.saveColoursButton_Click);
            // 
            // sortColoursButton
            // 
            this.sortColoursButton.Location = new System.Drawing.Point(249, 52);
            this.sortColoursButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortColoursButton.Name = "sortColoursButton";
            this.sortColoursButton.Size = new System.Drawing.Size(155, 46);
            this.sortColoursButton.TabIndex = 12;
            this.sortColoursButton.Text = "Sort";
            this.sortColoursButton.UseVisualStyleBackColor = true;
            this.sortColoursButton.Click += new System.EventHandler(this.sortColoursButton_Click);
            // 
            // removeInput
            // 
            this.removeInput.Location = new System.Drawing.Point(62, 200);
            this.removeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeInput.Name = "removeInput";
            this.removeInput.Size = new System.Drawing.Size(153, 34);
            this.removeInput.TabIndex = 14;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(249, 193);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(155, 46);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove Colour";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Location = new System.Drawing.Point(33, 213);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(84, 29);
            this.name2Label.TabIndex = 37;
            this.name2Label.Text = "Name:";
            // 
            // nameRemove
            // 
            this.nameRemove.Location = new System.Drawing.Point(155, 217);
            this.nameRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameRemove.Name = "nameRemove";
            this.nameRemove.Size = new System.Drawing.Size(99, 34);
            this.nameRemove.TabIndex = 36;
            // 
            // scoreRemoveButton
            // 
            this.scoreRemoveButton.Location = new System.Drawing.Point(286, 209);
            this.scoreRemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreRemoveButton.Name = "scoreRemoveButton";
            this.scoreRemoveButton.Size = new System.Drawing.Size(155, 50);
            this.scoreRemoveButton.TabIndex = 35;
            this.scoreRemoveButton.Text = "Remove ";
            this.scoreRemoveButton.UseVisualStyleBackColor = true;
            this.scoreRemoveButton.Click += new System.EventHandler(this.removeScoresButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(33, 158);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(83, 29);
            this.scoreLabel.TabIndex = 34;
            this.scoreLabel.Text = "Score:";
            // 
            // scoreInput
            // 
            this.scoreInput.Location = new System.Drawing.Point(155, 164);
            this.scoreInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreInput.Name = "scoreInput";
            this.scoreInput.Size = new System.Drawing.Size(99, 34);
            this.scoreInput.TabIndex = 33;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(33, 129);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 29);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "Name:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(155, 126);
            this.nameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(99, 34);
            this.nameInput.TabIndex = 31;
            // 
            // addScoreButton
            // 
            this.addScoreButton.Location = new System.Drawing.Point(286, 126);
            this.addScoreButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addScoreButton.Name = "addScoreButton";
            this.addScoreButton.Size = new System.Drawing.Size(155, 50);
            this.addScoreButton.TabIndex = 30;
            this.addScoreButton.Text = "Add";
            this.addScoreButton.UseVisualStyleBackColor = true;
            this.addScoreButton.Click += new System.EventHandler(this.addScoreButton_Click);
            // 
            // sortScoresButton
            // 
            this.sortScoresButton.Location = new System.Drawing.Point(286, 52);
            this.sortScoresButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortScoresButton.Name = "sortScoresButton";
            this.sortScoresButton.Size = new System.Drawing.Size(155, 46);
            this.sortScoresButton.TabIndex = 29;
            this.sortScoresButton.Text = "Sort";
            this.sortScoresButton.UseVisualStyleBackColor = true;
            this.sortScoresButton.Click += new System.EventHandler(this.sortScoresButton_Click);
            // 
            // saveScoresButton
            // 
            this.saveScoresButton.Location = new System.Drawing.Point(286, 476);
            this.saveScoresButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveScoresButton.Name = "saveScoresButton";
            this.saveScoresButton.Size = new System.Drawing.Size(155, 46);
            this.saveScoresButton.TabIndex = 28;
            this.saveScoresButton.Text = "Save";
            this.saveScoresButton.UseVisualStyleBackColor = true;
            this.saveScoresButton.Click += new System.EventHandler(this.saveScoresButton_Click);
            // 
            // loadScoresButton
            // 
            this.loadScoresButton.Location = new System.Drawing.Point(38, 52);
            this.loadScoresButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadScoresButton.Name = "loadScoresButton";
            this.loadScoresButton.Size = new System.Drawing.Size(155, 46);
            this.loadScoresButton.TabIndex = 27;
            this.loadScoresButton.Text = "Load";
            this.loadScoresButton.UseVisualStyleBackColor = true;
            this.loadScoresButton.Click += new System.EventHandler(this.loadScoresButton_Click);
            // 
            // scoreOutput
            // 
            this.scoreOutput.BackColor = System.Drawing.Color.White;
            this.scoreOutput.Location = new System.Drawing.Point(33, 267);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(408, 197);
            this.scoreOutput.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.scoreRemoveButton);
            this.groupBox1.Controls.Add(this.name2Label);
            this.groupBox1.Controls.Add(this.scoreOutput);
            this.groupBox1.Controls.Add(this.nameRemove);
            this.groupBox1.Controls.Add(this.loadScoresButton);
            this.groupBox1.Controls.Add(this.saveScoresButton);
            this.groupBox1.Controls.Add(this.scoreLabel);
            this.groupBox1.Controls.Add(this.sortScoresButton);
            this.groupBox1.Controls.Add(this.scoreInput);
            this.groupBox1.Controls.Add(this.addScoreButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(548, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(468, 538);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objects";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.loadColoursButton);
            this.groupBox2.Controls.Add(this.colourOutput);
            this.groupBox2.Controls.Add(this.removeInput);
            this.groupBox2.Controls.Add(this.addColourButton);
            this.groupBox2.Controls.Add(this.removeButton);
            this.groupBox2.Controls.Add(this.colourInput);
            this.groupBox2.Controls.Add(this.sortColoursButton);
            this.groupBox2.Controls.Add(this.saveColoursButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(468, 538);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Strings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1054, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox colourInput;
        private System.Windows.Forms.Button addColourButton;
        private System.Windows.Forms.Label colourOutput;
        private System.Windows.Forms.Button loadColoursButton;
        private System.Windows.Forms.Button saveColoursButton;
        private System.Windows.Forms.Button sortColoursButton;
        private System.Windows.Forms.TextBox removeInput;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label name2Label;
        private System.Windows.Forms.TextBox nameRemove;
        private System.Windows.Forms.Button scoreRemoveButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button addScoreButton;
        private System.Windows.Forms.Button sortScoresButton;
        private System.Windows.Forms.Button saveScoresButton;
        private System.Windows.Forms.Button loadScoresButton;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

