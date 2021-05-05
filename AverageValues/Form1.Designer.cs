
namespace AverageValues
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructions1Label = new System.Windows.Forms.Label();
            this.instructions2 = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.answerOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(179, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(443, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Average Number Solver";
            // 
            // instructions1Label
            // 
            this.instructions1Label.AutoSize = true;
            this.instructions1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions1Label.ForeColor = System.Drawing.Color.White;
            this.instructions1Label.Location = new System.Drawing.Point(181, 94);
            this.instructions1Label.Name = "instructions1Label";
            this.instructions1Label.Size = new System.Drawing.Size(429, 32);
            this.instructions1Label.TabIndex = 1;
            this.instructions1Label.Text = "enter a number then press add";
            // 
            // instructions2
            // 
            this.instructions2.AutoSize = true;
            this.instructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions2.ForeColor = System.Drawing.Color.White;
            this.instructions2.Location = new System.Drawing.Point(116, 126);
            this.instructions2.Name = "instructions2";
            this.instructions2.Size = new System.Drawing.Size(572, 32);
            this.instructions2.TabIndex = 2;
            this.instructions2.Text = "enter 0 and press add to find the average";
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.Location = new System.Drawing.Point(262, 209);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(123, 39);
            this.numberInput.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(436, 200);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 57);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(699, 381);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 57);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // answerOutput
            // 
            this.answerOutput.BackColor = System.Drawing.Color.White;
            this.answerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.answerOutput.Location = new System.Drawing.Point(116, 279);
            this.answerOutput.Name = "answerOutput";
            this.answerOutput.Size = new System.Drawing.Size(572, 89);
            this.answerOutput.TabIndex = 6;
            this.answerOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerOutput);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.instructions2);
            this.Controls.Add(this.instructions1Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Average Values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructions1Label;
        private System.Windows.Forms.Label instructions2;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label answerOutput;
    }
}

