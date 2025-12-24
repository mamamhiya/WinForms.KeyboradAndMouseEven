namespace WinForms.KeyboradAndMouseEven
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
            lblResult = new Label();
            txtInput = new TextBox();
            txtCode = new TextBox();
            txtCode2 = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.AppWorkspace;
            lblResult.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(54, 44);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(189, 96);
            lblResult.TabIndex = 0;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(286, 44);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(310, 27);
            txtInput.TabIndex = 1;
            txtInput.KeyPress += txtInput_KeyPress;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(286, 103);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(190, 27);
            txtCode.TabIndex = 2;
            txtCode.KeyPress += txtCode_KeyPress;
            // 
            // txtCode2
            // 
            txtCode2.Location = new Point(286, 162);
            txtCode2.Name = "txtCode2";
            txtCode2.Size = new Size(125, 27);
            txtCode2.TabIndex = 3;
            txtCode2.KeyPress += txtCode2_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 602);
            Controls.Add(txtCode2);
            Controls.Add(txtCode);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtInput;
        private TextBox txtCode;
        private TextBox txtCode2;
    }
}
