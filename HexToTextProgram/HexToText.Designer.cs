namespace HexToTextProgram
{
    partial class HexToText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexToText));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHexInput = new System.Windows.Forms.TextBox();
            this.txtTextOuput = new System.Windows.Forms.TextBox();
            this.butPaste = new System.Windows.Forms.Button();
            this.butCopy = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hex input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text ouput";
            // 
            // txtHexInput
            // 
            this.txtHexInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHexInput.Location = new System.Drawing.Point(95, 27);
            this.txtHexInput.Name = "txtHexInput";
            this.txtHexInput.Size = new System.Drawing.Size(393, 23);
            this.txtHexInput.TabIndex = 2;
            this.txtHexInput.TextChanged += new System.EventHandler(this.txtHexInput_TextChanged);
            // 
            // txtTextOuput
            // 
            this.txtTextOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTextOuput.Location = new System.Drawing.Point(95, 68);
            this.txtTextOuput.Name = "txtTextOuput";
            this.txtTextOuput.Size = new System.Drawing.Size(393, 23);
            this.txtTextOuput.TabIndex = 3;
            // 
            // butPaste
            // 
            this.butPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butPaste.Location = new System.Drawing.Point(494, 24);
            this.butPaste.Name = "butPaste";
            this.butPaste.Size = new System.Drawing.Size(75, 27);
            this.butPaste.TabIndex = 4;
            this.butPaste.Text = "Paste";
            this.butPaste.UseVisualStyleBackColor = true;
            this.butPaste.Click += new System.EventHandler(this.butPaste_Click);
            // 
            // butCopy
            // 
            this.butCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butCopy.Location = new System.Drawing.Point(494, 63);
            this.butCopy.Name = "butCopy";
            this.butCopy.Size = new System.Drawing.Size(75, 30);
            this.butCopy.TabIndex = 5;
            this.butCopy.Text = "Copy";
            this.butCopy.UseVisualStyleBackColor = true;
            this.butCopy.Click += new System.EventHandler(this.butCopy_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbStatus.Location = new System.Drawing.Point(92, 109);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(47, 15);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Status";
            // 
            // HexToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 149);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.butCopy);
            this.Controls.Add(this.butPaste);
            this.Controls.Add(this.txtTextOuput);
            this.Controls.Add(this.txtHexInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HexToText";
            this.Text = "Hex to Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHexInput;
        private System.Windows.Forms.TextBox txtTextOuput;
        private System.Windows.Forms.Button butPaste;
        private System.Windows.Forms.Button butCopy;
        private System.Windows.Forms.Label lbStatus;
    }
}

