namespace ENGworks.Navis.Ctr
{
    partial class UcProperties
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
            this.tbProp = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.tbValueName = new System.Windows.Forms.TextBox();
            this.lbValueName = new System.Windows.Forms.Label();
            this.lbPropName = new System.Windows.Forms.Label();
            this.tbPropName = new System.Windows.Forms.TextBox();
            this.lbCatName = new System.Windows.Forms.Label();
            this.tbCatName = new System.Windows.Forms.TextBox();
            this.cbPause = new System.Windows.Forms.CheckBox();
            this.pnFeature = new System.Windows.Forms.Panel();
            this.btCreateSet = new System.Windows.Forms.Button();
            this.btCreateSearch = new System.Windows.Forms.Button();
            this.pnFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProp
            // 
            this.tbProp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProp.Location = new System.Drawing.Point(3, 23);
            this.tbProp.Margin = new System.Windows.Forms.Padding(0);
            this.tbProp.Multiline = true;
            this.tbProp.Name = "tbProp";
            this.tbProp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbProp.Size = new System.Drawing.Size(323, 354);
            this.tbProp.TabIndex = 0;
            // 
            // btFind
            // 
            this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFind.Location = new System.Drawing.Point(3, 2);
            this.btFind.Margin = new System.Windows.Forms.Padding(0);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(92, 22);
            this.btFind.TabIndex = 1;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btFind_MouseUp);
            // 
            // tbValueName
            // 
            this.tbValueName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValueName.Location = new System.Drawing.Point(109, 432);
            this.tbValueName.Margin = new System.Windows.Forms.Padding(0);
            this.tbValueName.Name = "tbValueName";
            this.tbValueName.Size = new System.Drawing.Size(114, 20);
            this.tbValueName.TabIndex = 2;
            // 
            // lbValueName
            // 
            this.lbValueName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValueName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbValueName.Location = new System.Drawing.Point(4, 432);
            this.lbValueName.Margin = new System.Windows.Forms.Padding(0);
            this.lbValueName.Name = "lbValueName";
            this.lbValueName.Size = new System.Drawing.Size(99, 20);
            this.lbValueName.TabIndex = 3;
            this.lbValueName.Text = "Property Value:";
            this.lbValueName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPropName
            // 
            this.lbPropName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPropName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPropName.Location = new System.Drawing.Point(4, 409);
            this.lbPropName.Margin = new System.Windows.Forms.Padding(0);
            this.lbPropName.Name = "lbPropName";
            this.lbPropName.Size = new System.Drawing.Size(99, 20);
            this.lbPropName.TabIndex = 5;
            this.lbPropName.Text = "Property Name:";
            this.lbPropName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPropName
            // 
            this.tbPropName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPropName.Location = new System.Drawing.Point(109, 409);
            this.tbPropName.Margin = new System.Windows.Forms.Padding(0);
            this.tbPropName.Name = "tbPropName";
            this.tbPropName.Size = new System.Drawing.Size(114, 20);
            this.tbPropName.TabIndex = 4;
            // 
            // lbCatName
            // 
            this.lbCatName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCatName.Location = new System.Drawing.Point(4, 387);
            this.lbCatName.Margin = new System.Windows.Forms.Padding(0);
            this.lbCatName.Name = "lbCatName";
            this.lbCatName.Size = new System.Drawing.Size(99, 20);
            this.lbCatName.TabIndex = 7;
            this.lbCatName.Text = "Category Name:";
            this.lbCatName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCatName
            // 
            this.tbCatName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCatName.Location = new System.Drawing.Point(109, 387);
            this.tbCatName.Margin = new System.Windows.Forms.Padding(0);
            this.tbCatName.Name = "tbCatName";
            this.tbCatName.Size = new System.Drawing.Size(114, 20);
            this.tbCatName.TabIndex = 6;
            // 
            // cbPause
            // 
            this.cbPause.AutoSize = true;
            this.cbPause.Checked = true;
            this.cbPause.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPause.Location = new System.Drawing.Point(0, 0);
            this.cbPause.Margin = new System.Windows.Forms.Padding(0);
            this.cbPause.Name = "cbPause";
            this.cbPause.Size = new System.Drawing.Size(329, 17);
            this.cbPause.TabIndex = 8;
            this.cbPause.Text = "Pause";
            this.cbPause.UseVisualStyleBackColor = true;
            // 
            // pnFeature
            // 
            this.pnFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFeature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFeature.Controls.Add(this.btCreateSearch);
            this.pnFeature.Controls.Add(this.btCreateSet);
            this.pnFeature.Controls.Add(this.btFind);
            this.pnFeature.Location = new System.Drawing.Point(225, 383);
            this.pnFeature.Margin = new System.Windows.Forms.Padding(0);
            this.pnFeature.Name = "pnFeature";
            this.pnFeature.Size = new System.Drawing.Size(100, 72);
            this.pnFeature.TabIndex = 9;
            // 
            // btCreateSet
            // 
            this.btCreateSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateSet.Location = new System.Drawing.Point(3, 24);
            this.btCreateSet.Margin = new System.Windows.Forms.Padding(0);
            this.btCreateSet.Name = "btCreateSet";
            this.btCreateSet.Size = new System.Drawing.Size(92, 22);
            this.btCreateSet.TabIndex = 2;
            this.btCreateSet.Text = "Create Set";
            this.btCreateSet.UseVisualStyleBackColor = true;
            this.btCreateSet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btCreateSet_MouseUp);
            // 
            // btCreateSearch
            // 
            this.btCreateSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateSearch.Location = new System.Drawing.Point(3, 46);
            this.btCreateSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btCreateSearch.Name = "btCreateSearch";
            this.btCreateSearch.Size = new System.Drawing.Size(92, 22);
            this.btCreateSearch.TabIndex = 3;
            this.btCreateSearch.Text = "Create Search";
            this.btCreateSearch.UseVisualStyleBackColor = true;
            this.btCreateSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btCreateSearch_MouseUp);
            // 
            // UcProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnFeature);
            this.Controls.Add(this.cbPause);
            this.Controls.Add(this.lbCatName);
            this.Controls.Add(this.tbCatName);
            this.Controls.Add(this.lbPropName);
            this.Controls.Add(this.tbPropName);
            this.Controls.Add(this.lbValueName);
            this.Controls.Add(this.tbValueName);
            this.Controls.Add(this.tbProp);
            this.Name = "UcProperties";
            this.Size = new System.Drawing.Size(329, 459);
            this.pnFeature.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProp;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TextBox tbValueName;
        private System.Windows.Forms.Label lbValueName;
        private System.Windows.Forms.Label lbPropName;
        private System.Windows.Forms.TextBox tbPropName;
        private System.Windows.Forms.Label lbCatName;
        private System.Windows.Forms.TextBox tbCatName;
        private System.Windows.Forms.CheckBox cbPause;
        private System.Windows.Forms.Panel pnFeature;
        private System.Windows.Forms.Button btCreateSearch;
        private System.Windows.Forms.Button btCreateSet;
    }
}
