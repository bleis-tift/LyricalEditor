namespace bleistift.LyricalEditor.Options.Ui
{
    partial class GlobalConfigsForm
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
            this.group_rules = new System.Windows.Forms.GroupBox();
            this.lst_rules = new bleistift.LyricalEditor.Options.Ui.RichListControl();
            this.group_details = new System.Windows.Forms.GroupBox();
            this.num_slideShowTiming = new System.Windows.Forms.NumericUpDown();
            this.lbl_opacity = new System.Windows.Forms.Label();
            this.lbl_rule = new System.Windows.Forms.Label();
            this.lst_images = new bleistift.LyricalEditor.Options.Ui.RichListControl();
            this.lbl_opacityValue = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.lbl_images = new System.Windows.Forms.Label();
            this.check_slideShow = new System.Windows.Forms.CheckBox();
            this.check_random = new System.Windows.Forms.CheckBox();
            this.track_opacity = new System.Windows.Forms.TrackBar();
            this.txt_ruleRegex = new System.Windows.Forms.TextBox();
            this.dlg_image = new System.Windows.Forms.OpenFileDialog();
            this.group_rules.SuspendLayout();
            this.group_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_slideShowTiming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // group_rules
            // 
            this.group_rules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_rules.Controls.Add(this.lst_rules);
            this.group_rules.Location = new System.Drawing.Point(0, 0);
            this.group_rules.Name = "group_rules";
            this.group_rules.Size = new System.Drawing.Size(346, 92);
            this.group_rules.TabIndex = 0;
            this.group_rules.TabStop = false;
            this.group_rules.Text = "rules";
            // 
            // lst_rules
            // 
            this.lst_rules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_rules.Location = new System.Drawing.Point(6, 15);
            this.lst_rules.Name = "lst_rules";
            this.lst_rules.Size = new System.Drawing.Size(334, 71);
            this.lst_rules.TabIndex = 0;
            this.lst_rules.ItemAdding += new bleistift.LyricalEditor.Options.Ui.RichListAddHandler(this.lst_rules_ItemAdding);
            this.lst_rules.ItemDeleted += new bleistift.LyricalEditor.Options.Ui.RichListDeleteHandler(this.lst_rules_ItemDeleted);
            this.lst_rules.SelectedItemChanged += new bleistift.LyricalEditor.Options.Ui.RichListEventHandler(this.lst_rules_SelectedItemChanged);
            // 
            // group_details
            // 
            this.group_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_details.Controls.Add(this.num_slideShowTiming);
            this.group_details.Controls.Add(this.lbl_opacity);
            this.group_details.Controls.Add(this.lbl_rule);
            this.group_details.Controls.Add(this.lst_images);
            this.group_details.Controls.Add(this.lbl_opacityValue);
            this.group_details.Controls.Add(this.lbl_sec);
            this.group_details.Controls.Add(this.lbl_images);
            this.group_details.Controls.Add(this.check_slideShow);
            this.group_details.Controls.Add(this.check_random);
            this.group_details.Controls.Add(this.track_opacity);
            this.group_details.Controls.Add(this.txt_ruleRegex);
            this.group_details.Enabled = false;
            this.group_details.Location = new System.Drawing.Point(3, 92);
            this.group_details.Name = "group_details";
            this.group_details.Size = new System.Drawing.Size(343, 154);
            this.group_details.TabIndex = 1;
            this.group_details.TabStop = false;
            this.group_details.Text = "details";
            // 
            // num_slideShowTiming
            // 
            this.num_slideShowTiming.DecimalPlaces = 2;
            this.num_slideShowTiming.Enabled = false;
            this.num_slideShowTiming.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_slideShowTiming.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_slideShowTiming.Location = new System.Drawing.Point(138, 33);
            this.num_slideShowTiming.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_slideShowTiming.Name = "num_slideShowTiming";
            this.num_slideShowTiming.Size = new System.Drawing.Size(53, 18);
            this.num_slideShowTiming.TabIndex = 6;
            this.num_slideShowTiming.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_slideShowTiming.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_slideShowTiming.ValueChanged += new System.EventHandler(this.num_slideShowTiming_ValueChanged);
            // 
            // lbl_opacity
            // 
            this.lbl_opacity.AutoSize = true;
            this.lbl_opacity.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_opacity.Location = new System.Drawing.Point(173, 16);
            this.lbl_opacity.Name = "lbl_opacity";
            this.lbl_opacity.Size = new System.Drawing.Size(38, 11);
            this.lbl_opacity.TabIndex = 2;
            this.lbl_opacity.Text = "opacity";
            // 
            // lbl_rule
            // 
            this.lbl_rule.AutoSize = true;
            this.lbl_rule.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_rule.Location = new System.Drawing.Point(6, 17);
            this.lbl_rule.Name = "lbl_rule";
            this.lbl_rule.Size = new System.Drawing.Size(55, 11);
            this.lbl_rule.TabIndex = 0;
            this.lbl_rule.Text = "rule(regex)";
            // 
            // lst_images
            // 
            this.lst_images.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_images.Location = new System.Drawing.Point(9, 57);
            this.lst_images.Name = "lst_images";
            this.lst_images.Size = new System.Drawing.Size(328, 89);
            this.lst_images.TabIndex = 7;
            this.lst_images.ItemAdding += new bleistift.LyricalEditor.Options.Ui.RichListAddHandler(this.lst_images_ItemAdding);
            this.lst_images.ItemDeleted += new bleistift.LyricalEditor.Options.Ui.RichListDeleteHandler(this.lst_images_ItemDeleted);
            this.lst_images.ItemDoubleClick += new bleistift.LyricalEditor.Options.Ui.RichListDoubleClickHandler(this.lst_images_ItemDoubleClick);
            // 
            // lbl_opacityValue
            // 
            this.lbl_opacityValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_opacityValue.AutoSize = true;
            this.lbl_opacityValue.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_opacityValue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_opacityValue.Location = new System.Drawing.Point(315, 32);
            this.lbl_opacityValue.Name = "lbl_opacityValue";
            this.lbl_opacityValue.Size = new System.Drawing.Size(17, 11);
            this.lbl_opacityValue.TabIndex = 8;
            this.lbl_opacityValue.Text = "50";
            this.lbl_opacityValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_sec.Location = new System.Drawing.Point(191, 37);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(22, 11);
            this.lbl_sec.TabIndex = 8;
            this.lbl_sec.Text = "sec";
            // 
            // lbl_images
            // 
            this.lbl_images.AutoSize = true;
            this.lbl_images.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_images.Location = new System.Drawing.Point(7, 48);
            this.lbl_images.Name = "lbl_images";
            this.lbl_images.Size = new System.Drawing.Size(38, 11);
            this.lbl_images.TabIndex = 8;
            this.lbl_images.Text = "images:";
            // 
            // check_slideShow
            // 
            this.check_slideShow.AutoSize = true;
            this.check_slideShow.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.check_slideShow.Location = new System.Drawing.Point(73, 34);
            this.check_slideShow.Name = "check_slideShow";
            this.check_slideShow.Size = new System.Drawing.Size(68, 15);
            this.check_slideShow.TabIndex = 5;
            this.check_slideShow.Text = "slideshow";
            this.check_slideShow.UseVisualStyleBackColor = true;
            this.check_slideShow.CheckedChanged += new System.EventHandler(this.check_slideShow_CheckedChanged);
            // 
            // check_random
            // 
            this.check_random.AutoSize = true;
            this.check_random.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.check_random.Location = new System.Drawing.Point(9, 34);
            this.check_random.Name = "check_random";
            this.check_random.Size = new System.Drawing.Size(58, 15);
            this.check_random.TabIndex = 4;
            this.check_random.Text = "random";
            this.check_random.UseVisualStyleBackColor = true;
            this.check_random.CheckedChanged += new System.EventHandler(this.check_random_CheckedChanged);
            // 
            // track_opacity
            // 
            this.track_opacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.track_opacity.LargeChange = 10;
            this.track_opacity.Location = new System.Drawing.Point(217, 13);
            this.track_opacity.Maximum = 100;
            this.track_opacity.Name = "track_opacity";
            this.track_opacity.Size = new System.Drawing.Size(120, 45);
            this.track_opacity.TabIndex = 3;
            this.track_opacity.TickFrequency = 10;
            this.track_opacity.Value = 50;
            this.track_opacity.ValueChanged += new System.EventHandler(this.track_opacity_ValueChanged);
            // 
            // txt_ruleRegex
            // 
            this.txt_ruleRegex.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ruleRegex.Location = new System.Drawing.Point(67, 13);
            this.txt_ruleRegex.Name = "txt_ruleRegex";
            this.txt_ruleRegex.Size = new System.Drawing.Size(100, 19);
            this.txt_ruleRegex.TabIndex = 1;
            this.txt_ruleRegex.TextChanged += new System.EventHandler(this.txt_ruleRegex_TextChanged);
            // 
            // dlg_image
            // 
            this.dlg_image.Filter = "Supported Images|*.png;*.gif;*.jpg";
            this.dlg_image.Multiselect = true;
            // 
            // GlobalConfigsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.group_details);
            this.Controls.Add(this.group_rules);
            this.Name = "GlobalConfigsForm";
            this.Size = new System.Drawing.Size(349, 249);
            this.group_rules.ResumeLayout(false);
            this.group_details.ResumeLayout(false);
            this.group_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_slideShowTiming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_opacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_rules;
        private System.Windows.Forms.GroupBox group_details;
        private RichListControl lst_rules;
        private RichListControl lst_images;
        private System.Windows.Forms.CheckBox check_slideShow;
        private System.Windows.Forms.CheckBox check_random;
        private System.Windows.Forms.TrackBar track_opacity;
        private System.Windows.Forms.TextBox txt_ruleRegex;
        private System.Windows.Forms.Label lbl_opacity;
        private System.Windows.Forms.Label lbl_rule;
        private System.Windows.Forms.NumericUpDown num_slideShowTiming;
        private System.Windows.Forms.Label lbl_images;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label lbl_opacityValue;
        private System.Windows.Forms.OpenFileDialog dlg_image;

    }
}
