﻿namespace Encrypt_Decrypt
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
            this.Input_textBox = new System.Windows.Forms.TextBox();
            this.Output_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_textBox
            // 
            this.Input_textBox.Location = new System.Drawing.Point(12, 61);
            this.Input_textBox.Multiline = true;
            this.Input_textBox.Name = "Input_textBox";
            this.Input_textBox.Size = new System.Drawing.Size(295, 204);
            this.Input_textBox.TabIndex = 0;
            // 
            // Output_textBox
            // 
            this.Output_textBox.Location = new System.Drawing.Point(322, 61);
            this.Output_textBox.Multiline = true;
            this.Output_textBox.Name = "Output_textBox";
            this.Output_textBox.Size = new System.Drawing.Size(295, 204);
            this.Output_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OUTPUT";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "ENCRYPT",
            "DECRYPT"});
            this.comboBox.Location = new System.Drawing.Point(12, 13);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 4;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(139, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 5;
            this.button.Text = "Go";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(420, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(97, 23);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Create Dictionary";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(523, 12);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(93, 23);
            this.buttonRead.TabIndex = 7;
            this.buttonRead.Text = "Read Dictionary";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 277);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.button);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output_textBox);
            this.Controls.Add(this.Input_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt - Decrypt V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_textBox;
        private System.Windows.Forms.TextBox Output_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonRead;
    }
}

