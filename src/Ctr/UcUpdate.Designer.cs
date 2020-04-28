namespace ENGworks.Navis.Ctr
{
    partial class UcUpdate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btUpdate = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbPause = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpdate.Location = new System.Drawing.Point(0, 0);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(305, 23);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btUpdate_MouseUp);
            // 
            // btClear
            // 
            this.btClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btClear.Location = new System.Drawing.Point(0, 384);
            this.btClear.Margin = new System.Windows.Forms.Padding(0);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(305, 23);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "Clear Log";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btClear_MouseUp);
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(0, 60);
            this.tbLog.Margin = new System.Windows.Forms.Padding(0);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(305, 324);
            this.tbLog.TabIndex = 2;
            this.tbLog.Text = "Monitoring Models...\r\n";
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUpdate.Location = new System.Drawing.Point(0, 23);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(305, 17);
            this.cbUpdate.TabIndex = 3;
            this.cbUpdate.Text = "Auto Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbPause
            // 
            this.cbPause.AutoSize = true;
            this.cbPause.Checked = true;
            this.cbPause.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPause.Location = new System.Drawing.Point(0, 40);
            this.cbPause.Name = "cbPause";
            this.cbPause.Size = new System.Drawing.Size(305, 17);
            this.cbPause.TabIndex = 4;
            this.cbPause.Text = "Pause";
            this.cbPause.UseVisualStyleBackColor = true;
            // 
            // UcUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cbPause);
            this.Controls.Add(this.cbUpdate);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btUpdate);
            this.Name = "UcUpdate";
            this.Size = new System.Drawing.Size(305, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbPause;
    }
}
