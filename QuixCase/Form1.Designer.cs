namespace QuixCase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.hotkey = new System.Windows.Forms.Label();
            this.roundButton1 = new CustomComponent.RoundButton(this.components);
            this.roundPanel2 = new CustomComponent.RoundPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.switchButton1 = new CustomComponent.SwitchButton();
            this.roundPanel3 = new CustomComponent.RoundPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roundPanel2.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "QuixCase";
            this.label1.Click += new System.EventHandler(this.roundPanel2_Click);
            // 
            // hotkey
            // 
            this.hotkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hotkey.BackColor = System.Drawing.Color.Transparent;
            this.hotkey.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkey.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hotkey.Location = new System.Drawing.Point(42, 64);
            this.hotkey.Name = "hotkey";
            this.hotkey.Size = new System.Drawing.Size(335, 23);
            this.hotkey.TabIndex = 14;
            this.hotkey.Text = "Ctrl+Capslock";
            // 
            // roundButton1
            // 
            this.roundButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundButton1.BorderRadius = 5;
            this.roundButton1.BorderRoundSize = 1;
         
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold);
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.roundButton1.Location = new System.Drawing.Point(383, 56);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(63, 37);
            this.roundButton1.TabIndex = 19;
            this.roundButton1.Text = "Edit";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click_1);
            // 
            // roundPanel2
            // 
            this.roundPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundPanel2.BorderRadius = 5;
            this.roundPanel2.BorderRoundSize = 1;
            this.roundPanel2.Clickable = true;
            this.roundPanel2.Controls.Add(this.label5);
            this.roundPanel2.Controls.Add(this.label4);
            this.roundPanel2.Controls.Add(this.label3);
            this.roundPanel2.Location = new System.Drawing.Point(31, 188);
            this.roundPanel2.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.roundPanel2.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel2.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.roundPanel2.MouseUpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(415, 77);
            this.roundPanel2.TabIndex = 21;
            this.roundPanel2.Click += new System.EventHandler(this.roundPanel2_Click);
            this.roundPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.roundPanel2_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "About";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(358, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 46);
            this.label4.TabIndex = 22;
            this.label4.Text = "›";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(23, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "App Information";
            // 
            // switchButton1
            // 
            this.switchButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.switchButton1.AutoSize = true;
            this.switchButton1.BackColor = System.Drawing.Color.Transparent;
            this.switchButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.switchButton1.BorderRoundSize = 1;
            this.switchButton1.Location = new System.Drawing.Point(334, 28);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.Padding = new System.Windows.Forms.Padding(6);
            this.switchButton1.Size = new System.Drawing.Size(56, 29);
            this.switchButton1.TabIndex = 22;
            this.switchButton1.Text = "      ";
            this.switchButton1.UseVisualStyleBackColor = false;
            this.switchButton1.CheckedChanged += new System.EventHandler(this.switchButton1_CheckedChanged);
            // 
            // roundPanel3
            // 
            this.roundPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundPanel3.BorderRadius = 5;
            this.roundPanel3.BorderRoundSize = 1;
            this.roundPanel3.Clickable = false;
            this.roundPanel3.Controls.Add(this.label8);
            this.roundPanel3.Controls.Add(this.switchButton1);
            this.roundPanel3.Controls.Add(this.label7);
            this.roundPanel3.Location = new System.Drawing.Point(31, 110);
            this.roundPanel3.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.MouseUpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(415, 77);
            this.roundPanel3.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(22, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Startup Option";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(23, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Run at Startup";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(477, 304);
            this.Controls.Add(this.hotkey);
            this.Controls.Add(this.roundPanel3);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuixCase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hotkey;
        private CustomComponent.RoundButton roundButton1;
        private CustomComponent.RoundPanel roundPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomComponent.SwitchButton switchButton1;
        private CustomComponent.RoundPanel roundPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

