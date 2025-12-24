using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WinForms.KeyboradAndMouseEvent
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
            label1 = new Label();
            btnTest = new Button();
            txtSource = new TextBox();
            lblTarget = new Label();
            btnMove = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Location = new Point(71, 39);
            label1.Name = "label1";
            label1.Size = new Size(152, 104);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(280, 39);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(119, 48);
            btnTest.TabIndex = 1;
            btnTest.Text = "button1";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.MouseEnter += btnTest_MouseEnter;
            btnTest.MouseLeave += btnTest_MouseLeave;
            // 
            // txtSource
            // 
            txtSource.Location = new Point(71, 218);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(231, 27);
            txtSource.TabIndex = 2;
            txtSource.MouseDown += txtSource_MouseDown;
            // 
            // lblTarget
            // 
            lblTarget.AllowDrop = true;
            lblTarget.BackColor = SystemColors.ActiveBorder;
            lblTarget.Location = new Point(71, 266);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(231, 76);
            lblTarget.TabIndex = 3;
            lblTarget.Text = "label2";
            lblTarget.TextAlign = ContentAlignment.MiddleCenter;
            lblTarget.DragDrop += lblTarget_DragDrop;
            lblTarget.DragEnter += lblTarget_DragEnter;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(326, 229);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(98, 42);
            btnMove.TabIndex = 4;
            btnMove.Text = "move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.MouseDown += btnMove_MouseDown;
            btnMove.MouseMove += btnMove_MouseMove;
            btnMove.MouseUp += btnMove_MouseUp;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 557);
            Controls.Add(btnMove);
            Controls.Add(lblTarget);
            Controls.Add(txtSource);
            Controls.Add(btnTest);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            MouseClick += Form2_MouseClick;
            MouseMove += Form2_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTest;
        private TextBox txtSource;
        private Label lblTarget;
        private Button btnMove;
    }
}