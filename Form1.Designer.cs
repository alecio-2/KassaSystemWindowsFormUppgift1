using System;

namespace KassaSystemWindowsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tal1 = new System.Windows.Forms.Label();
            this.tal2 = new System.Windows.Forms.Label();
            this.tal1Value = new System.Windows.Forms.TextBox();
            this.tal2Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeProgram = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.restResultat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kassa System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tal1
            // 
            this.tal1.AutoSize = true;
            this.tal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tal1.Location = new System.Drawing.Point(47, 111);
            this.tal1.Name = "tal1";
            this.tal1.Size = new System.Drawing.Size(91, 22);
            this.tal1.TabIndex = 1;
            this.tal1.Text = "Ange pris:";
            this.tal1.Click += new System.EventHandler(this.tal1_Click);
            // 
            // tal2
            // 
            this.tal2.AutoSize = true;
            this.tal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tal2.Location = new System.Drawing.Point(73, 155);
            this.tal2.Name = "tal2";
            this.tal2.Size = new System.Drawing.Size(61, 22);
            this.tal2.TabIndex = 2;
            this.tal2.Text = "Betalt:";
            this.tal2.Click += new System.EventHandler(this.tal1_Click);
            // 
            // tal1Value
            // 
            this.tal1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tal1Value.Location = new System.Drawing.Point(155, 110);
            this.tal1Value.Name = "tal1Value";
            this.tal1Value.Size = new System.Drawing.Size(245, 27);
            this.tal1Value.TabIndex = 3;
            this.tal1Value.TextChanged += new System.EventHandler(this.tal1Value_TextChanged);
            // 
            // tal2Value
            // 
            this.tal2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tal2Value.Location = new System.Drawing.Point(155, 155);
            this.tal2Value.Name = "tal2Value";
            this.tal2Value.Size = new System.Drawing.Size(245, 27);
            this.tal2Value.TabIndex = 4;
            this.tal2Value.TextChanged += new System.EventHandler(this.tal2Value_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rest:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeProgram
            // 
            this.closeProgram.BackColor = System.Drawing.Color.LightCoral;
            this.closeProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeProgram.Location = new System.Drawing.Point(155, 528);
            this.closeProgram.Name = "closeProgram";
            this.closeProgram.Size = new System.Drawing.Size(190, 53);
            this.closeProgram.TabIndex = 6;
            this.closeProgram.Text = "Avsluta program";
            this.closeProgram.UseVisualStyleBackColor = false;
            this.closeProgram.Click += new System.EventHandler(this.closeProgram_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.LightGreen;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(155, 200);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(245, 72);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Klicka för att räkna ut rest";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // restResultat
            // 
            this.restResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restResultat.Location = new System.Drawing.Point(155, 292);
            this.restResultat.Name = "restResultat";
            this.restResultat.Size = new System.Drawing.Size(245, 219);
            this.restResultat.TabIndex = 8;
            this.restResultat.Text = "";
            this.restResultat.TextChanged += new System.EventHandler(this.restResultat_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 613);
            this.Controls.Add(this.restResultat);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.closeProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tal2Value);
            this.Controls.Add(this.tal1Value);
            this.Controls.Add(this.tal2);
            this.Controls.Add(this.tal1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KassaSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void restResultat_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tal1;
        private System.Windows.Forms.Label tal2;
        private System.Windows.Forms.TextBox tal1Value;
        private System.Windows.Forms.TextBox tal2Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeProgram;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RichTextBox restResultat;
    }
}

