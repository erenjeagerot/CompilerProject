
namespace CompilerProject
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
            this.derleyiciText = new System.Windows.Forms.RichTextBox();
            this.konsolText = new System.Windows.Forms.RichTextBox();
            this.derleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kapatButton = new System.Windows.Forms.Button();
            this.asagiAlmaButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // derleyiciText
            // 
            this.derleyiciText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.derleyiciText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.derleyiciText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.derleyiciText.ForeColor = System.Drawing.Color.White;
            this.derleyiciText.Location = new System.Drawing.Point(25, 53);
            this.derleyiciText.Name = "derleyiciText";
            this.derleyiciText.Size = new System.Drawing.Size(860, 307);
            this.derleyiciText.TabIndex = 0;
            this.derleyiciText.Text = "";
            // 
            // konsolText
            // 
            this.konsolText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.konsolText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.konsolText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.konsolText.Location = new System.Drawing.Point(25, 423);
            this.konsolText.Name = "konsolText";
            this.konsolText.ReadOnly = true;
            this.konsolText.Size = new System.Drawing.Size(860, 222);
            this.konsolText.TabIndex = 1;
            this.konsolText.Text = "";
            // 
            // derleButton
            // 
            this.derleButton.BackColor = System.Drawing.Color.Transparent;
            this.derleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.derleButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.derleButton.ForeColor = System.Drawing.Color.Transparent;
            this.derleButton.Location = new System.Drawing.Point(676, 366);
            this.derleButton.Name = "derleButton";
            this.derleButton.Size = new System.Drawing.Size(209, 42);
            this.derleButton.TabIndex = 2;
            this.derleButton.Text = "DERLE";
            this.derleButton.UseVisualStyleBackColor = false;
            this.derleButton.Click += new System.EventHandler(this.derleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "DERLEYİCİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "KONSOL";
            // 
            // kapatButton
            // 
            this.kapatButton.BackColor = System.Drawing.Color.Transparent;
            this.kapatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kapatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kapatButton.Location = new System.Drawing.Point(850, 12);
            this.kapatButton.Name = "kapatButton";
            this.kapatButton.Size = new System.Drawing.Size(35, 35);
            this.kapatButton.TabIndex = 5;
            this.kapatButton.Text = "X";
            this.kapatButton.UseVisualStyleBackColor = false;
            this.kapatButton.Click += new System.EventHandler(this.kapatButton_Click);
            // 
            // asagiAlmaButton
            // 
            this.asagiAlmaButton.BackColor = System.Drawing.Color.Transparent;
            this.asagiAlmaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asagiAlmaButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asagiAlmaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.asagiAlmaButton.Location = new System.Drawing.Point(809, 12);
            this.asagiAlmaButton.Name = "asagiAlmaButton";
            this.asagiAlmaButton.Size = new System.Drawing.Size(35, 35);
            this.asagiAlmaButton.TabIndex = 6;
            this.asagiAlmaButton.Text = "_";
            this.asagiAlmaButton.UseVisualStyleBackColor = false;
            this.asagiAlmaButton.Click += new System.EventHandler(this.asagiAlmaButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(661, 655);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eren Alkan | Gaziosmanpaşa Uni.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::CompilerProject.Properties.Resources.Deep_Space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 688);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.asagiAlmaButton);
            this.Controls.Add(this.kapatButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.derleButton);
            this.Controls.Add(this.konsolText);
            this.Controls.Add(this.derleyiciText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox derleyiciText;
        private System.Windows.Forms.RichTextBox konsolText;
        private System.Windows.Forms.Button derleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kapatButton;
        private System.Windows.Forms.Button asagiAlmaButton;
        private System.Windows.Forms.Label label3;
    }
}

