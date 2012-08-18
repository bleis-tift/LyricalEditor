namespace bleistift.LyricalEditor.Options.Ui
{
    partial class RichListControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_bottomMost = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_topMost = new System.Windows.Forms.Button();
            this.lst_values = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(108, 51);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 18);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_del.Enabled = false;
            this.btn_del.Location = new System.Drawing.Point(0, 51);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 18);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_bottomMost
            // 
            this.btn_bottomMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bottomMost.Enabled = false;
            this.btn_bottomMost.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_bottomMost.Location = new System.Drawing.Point(189, 51);
            this.btn_bottomMost.Name = "btn_bottomMost";
            this.btn_bottomMost.Size = new System.Drawing.Size(23, 18);
            this.btn_bottomMost.TabIndex = 4;
            this.btn_bottomMost.Text = "a";
            this.btn_bottomMost.UseVisualStyleBackColor = true;
            this.btn_bottomMost.Click += new System.EventHandler(this.btn_bottomMost_Click);
            // 
            // btn_down
            // 
            this.btn_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_down.Enabled = false;
            this.btn_down.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_down.Location = new System.Drawing.Point(189, 34);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(23, 18);
            this.btn_down.TabIndex = 3;
            this.btn_down.Text = "O";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_up.Enabled = false;
            this.btn_up.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_up.Location = new System.Drawing.Point(189, 17);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(23, 18);
            this.btn_up.TabIndex = 2;
            this.btn_up.Text = "O";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_topMost
            // 
            this.btn_topMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_topMost.Enabled = false;
            this.btn_topMost.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_topMost.Location = new System.Drawing.Point(189, 0);
            this.btn_topMost.Name = "btn_topMost";
            this.btn_topMost.Size = new System.Drawing.Size(23, 18);
            this.btn_topMost.TabIndex = 1;
            this.btn_topMost.Text = "a";
            this.btn_topMost.UseVisualStyleBackColor = true;
            this.btn_topMost.Click += new System.EventHandler(this.btn_topMost_Click);
            // 
            // lst_values
            // 
            this.lst_values.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_values.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lst_values.FormattingEnabled = true;
            this.lst_values.ItemHeight = 11;
            this.lst_values.Location = new System.Drawing.Point(0, 0);
            this.lst_values.Name = "lst_values";
            this.lst_values.Size = new System.Drawing.Size(183, 48);
            this.lst_values.TabIndex = 0;
            this.lst_values.SelectedIndexChanged += new System.EventHandler(this.lst_values_SelectedIndexChanged);
            this.lst_values.DoubleClick += new System.EventHandler(this.lst_values_DoubleClick);
            // 
            // RichListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_bottomMost);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_topMost);
            this.Controls.Add(this.lst_values);
            this.Name = "RichListControl";
            this.Size = new System.Drawing.Size(212, 69);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_bottomMost;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_topMost;
        private System.Windows.Forms.ListBox lst_values;
    }
}
