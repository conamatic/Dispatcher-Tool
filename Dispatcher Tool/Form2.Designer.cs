namespace TestTool
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
            this.Quantity_Input = new System.Windows.Forms.TextBox();
            this.Quantity_Label = new System.Windows.Forms.Label();
            this.Template_Label = new System.Windows.Forms.Label();
            this.Template_Input = new System.Windows.Forms.TextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Quantity_Input
            // 
            this.Quantity_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Quantity_Input.Location = new System.Drawing.Point(125, 41);
            this.Quantity_Input.Name = "Quantity_Input";
            this.Quantity_Input.Size = new System.Drawing.Size(73, 23);
            this.Quantity_Input.TabIndex = 0;
            // 
            // Quantity_Label
            // 
            this.Quantity_Label.AutoSize = true;
            this.Quantity_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Quantity_Label.Location = new System.Drawing.Point(26, 44);
            this.Quantity_Label.Name = "Quantity_Label";
            this.Quantity_Label.Size = new System.Drawing.Size(61, 17);
            this.Quantity_Label.TabIndex = 1;
            this.Quantity_Label.Text = "Quantity";
            // 
            // Template_Label
            // 
            this.Template_Label.AutoSize = true;
            this.Template_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Template_Label.Location = new System.Drawing.Point(26, 76);
            this.Template_Label.Name = "Template_Label";
            this.Template_Label.Size = new System.Drawing.Size(67, 17);
            this.Template_Label.TabIndex = 2;
            this.Template_Label.Text = "Template";
            // 
            // Template_Input
            // 
            this.Template_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Template_Input.Location = new System.Drawing.Point(125, 73);
            this.Template_Input.Name = "Template_Input";
            this.Template_Input.Size = new System.Drawing.Size(238, 23);
            this.Template_Input.TabIndex = 3;
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(288, 134);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 4;
            this.Save_Button.Text = "OK";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(207, 134);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 169);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Template_Input);
            this.Controls.Add(this.Template_Label);
            this.Controls.Add(this.Quantity_Label);
            this.Controls.Add(this.Quantity_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Add Multiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Quantity_Input;
        private System.Windows.Forms.Label Quantity_Label;
        private System.Windows.Forms.Label Template_Label;
        private System.Windows.Forms.TextBox Template_Input;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}