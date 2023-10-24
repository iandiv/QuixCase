namespace QuixCase
{
    partial class DialogForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.hotkey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundPanel2 = new CustomComponent.RoundPanel();
            this.negativeBtn = new CustomComponent.RoundButton(this.components);
            this.positiveBtn = new CustomComponent.RoundButton(this.components);
            this.roundPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Key";
            // 
            // hotkey
            // 
            this.hotkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hotkey.BackColor = System.Drawing.Color.Transparent;
            this.hotkey.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F, System.Drawing.FontStyle.Bold);
            this.hotkey.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hotkey.Location = new System.Drawing.Point(3, 10);
            this.hotkey.Name = "hotkey";
            this.hotkey.Size = new System.Drawing.Size(291, 55);
            this.hotkey.TabIndex = 16;
            this.hotkey.Text = "Ctrl+Capslock";
            this.hotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotkey.Click += new System.EventHandler(this.hotkey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Press any key to set as shortcut key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundPanel2.BorderRadius = 5;
            this.roundPanel2.BorderRoundSize = 1;
            this.roundPanel2.Clickable = false;
            this.roundPanel2.Controls.Add(this.hotkey);
            this.roundPanel2.Location = new System.Drawing.Point(29, 61);
            this.roundPanel2.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel2.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel2.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel2.MouseUpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(297, 73);
            this.roundPanel2.TabIndex = 18;
            // 
            // negativeBtn
            // 
            this.negativeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.negativeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.negativeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.negativeBtn.BorderRadius = 5;
            this.negativeBtn.BorderRoundSize = 1;
            this.negativeBtn.FlatAppearance.BorderSize = 0;
            this.negativeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.negativeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.negativeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.negativeBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativeBtn.ForeColor = System.Drawing.Color.White;
            this.negativeBtn.Location = new System.Drawing.Point(120, 143);
            this.negativeBtn.Name = "negativeBtn";
            this.negativeBtn.Size = new System.Drawing.Size(100, 37);
            this.negativeBtn.TabIndex = 0;
            this.negativeBtn.Text = "Cancel";
            this.negativeBtn.UseVisualStyleBackColor = false;
            this.negativeBtn.Click += new System.EventHandler(this.negativeBtn_Click);
            // 
            // positiveBtn
            // 
            this.positiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positiveBtn.AutoSize = true;
            this.positiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.positiveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.positiveBtn.BorderRadius = 5;
            this.positiveBtn.BorderRoundSize = 1;
            this.positiveBtn.FlatAppearance.BorderSize = 0;
            this.positiveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(86)))), ((int)(((byte)(150)))));
            this.positiveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
            this.positiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positiveBtn.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold);
            this.positiveBtn.ForeColor = System.Drawing.Color.White;
            this.positiveBtn.Location = new System.Drawing.Point(226, 143);
            this.positiveBtn.Name = "positiveBtn";
            this.positiveBtn.Size = new System.Drawing.Size(100, 37);
            this.positiveBtn.TabIndex = 7;
            this.positiveBtn.Text = "Apply";
            this.positiveBtn.UseVisualStyleBackColor = false;
            this.positiveBtn.Click += new System.EventHandler(this.positiveBtn_Click);
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(359, 210);
            this.ControlBox = false;
            this.Controls.Add(this.positiveBtn);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.negativeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DialogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "    ";
            this.Load += new System.EventHandler(this.DialogForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DialogForm_KeyDown);
            this.roundPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hotkey;
        private System.Windows.Forms.Label label2;
        private CustomComponent.RoundPanel roundPanel2;
        private CustomComponent.RoundButton positiveBtn;
        private CustomComponent.RoundButton negativeBtn;
    }
}