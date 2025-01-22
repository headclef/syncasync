namespace FormApp
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
            lblStatus1 = new Label();
            lblStatus2 = new Label();
            lblStatus3 = new Label();
            lblStatus4 = new Label();
            lblStatus5 = new Label();
            lblStatus6 = new Label();
            btnSenkron = new Button();
            btnAsenkron = new Button();
            SuspendLayout();
            // 
            // lblStatus1
            // 
            lblStatus1.AutoSize = true;
            lblStatus1.Location = new Point(12, 10);
            lblStatus1.Name = "lblStatus1";
            lblStatus1.Size = new Size(265, 15);
            lblStatus1.TabIndex = 0;
            lblStatus1.Text = "This text will be changed by the button methods.";
            // 
            // lblStatus2
            // 
            lblStatus2.AutoSize = true;
            lblStatus2.Location = new Point(12, 45);
            lblStatus2.Name = "lblStatus2";
            lblStatus2.Size = new Size(265, 15);
            lblStatus2.TabIndex = 1;
            lblStatus2.Text = "This text will be changed by the button methods.";
            // 
            // lblStatus3
            // 
            lblStatus3.AutoSize = true;
            lblStatus3.Location = new Point(12, 80);
            lblStatus3.Name = "lblStatus3";
            lblStatus3.Size = new Size(265, 15);
            lblStatus3.TabIndex = 2;
            lblStatus3.Text = "This text will be changed by the button methods.";
            // 
            // lblStatus4
            // 
            lblStatus4.AutoSize = true;
            lblStatus4.Location = new Point(12, 115);
            lblStatus4.Name = "lblStatus4";
            lblStatus4.Size = new Size(265, 15);
            lblStatus4.TabIndex = 5;
            lblStatus4.Text = "This text will be changed by the button methods.";
            // 
            // lblStatus5
            // 
            lblStatus5.AutoSize = true;
            lblStatus5.Location = new Point(12, 150);
            lblStatus5.Name = "lblStatus5";
            lblStatus5.Size = new Size(265, 15);
            lblStatus5.TabIndex = 6;
            lblStatus5.Text = "This text will be changed by the button methods.";
            // 
            // lblStatus6
            // 
            lblStatus6.AutoSize = true;
            lblStatus6.Location = new Point(12, 185);
            lblStatus6.Name = "lblStatus6";
            lblStatus6.Size = new Size(265, 15);
            lblStatus6.TabIndex = 7;
            lblStatus6.Text = "This text will be changed by the button methods.";
            // 
            // btnSenkron
            // 
            btnSenkron.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSenkron.Location = new Point(12, 388);
            btnSenkron.Name = "btnSenkron";
            btnSenkron.Size = new Size(200, 50);
            btnSenkron.TabIndex = 3;
            btnSenkron.Text = "SENKRON";
            btnSenkron.UseVisualStyleBackColor = true;
            btnSenkron.Click += btnSenkron_Click;
            // 
            // btnAsenkron
            // 
            btnAsenkron.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAsenkron.Location = new Point(588, 388);
            btnAsenkron.Name = "btnAsenkron";
            btnAsenkron.Size = new Size(200, 50);
            btnAsenkron.TabIndex = 4;
            btnAsenkron.Text = "ASENKRON";
            btnAsenkron.UseVisualStyleBackColor = true;
            btnAsenkron.Click += btnAsenkron_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAsenkron);
            Controls.Add(btnSenkron);
            Controls.Add(lblStatus6);
            Controls.Add(lblStatus5);
            Controls.Add(lblStatus4);
            Controls.Add(lblStatus3);
            Controls.Add(lblStatus2);
            Controls.Add(lblStatus1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus1;
        private Label lblStatus2;
        private Label lblStatus3;
        private Label lblStatus4;
        private Label lblStatus5;
        private Label lblStatus6;
        private Button btnSenkron;
        private Button btnAsenkron;
    }
}
