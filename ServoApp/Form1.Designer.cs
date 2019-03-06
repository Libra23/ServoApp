namespace ServoApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.portCB = new System.Windows.Forms.ComboBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.positionTB = new System.Windows.Forms.TrackBar();
            this.baudRateCB = new System.Windows.Forms.ComboBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.positionValue = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.idCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.positionTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionValue)).BeginInit();
            this.SuspendLayout();
            // 
            // portCB
            // 
            this.portCB.FormattingEnabled = true;
            this.portCB.Location = new System.Drawing.Point(48, 48);
            this.portCB.Name = "portCB";
            this.portCB.Size = new System.Drawing.Size(121, 26);
            this.portCB.TabIndex = 0;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(320, 48);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(106, 32);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(48, 24);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(40, 18);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port";
            // 
            // positionTB
            // 
            this.positionTB.Location = new System.Drawing.Point(48, 160);
            this.positionTB.Name = "positionTB";
            this.positionTB.Size = new System.Drawing.Size(606, 69);
            this.positionTB.TabIndex = 3;
            this.positionTB.Scroll += new System.EventHandler(this.positionTB_Scroll);
            // 
            // baudRateCB
            // 
            this.baudRateCB.FormattingEnabled = true;
            this.baudRateCB.Location = new System.Drawing.Point(184, 48);
            this.baudRateCB.Name = "baudRateCB";
            this.baudRateCB.Size = new System.Drawing.Size(121, 26);
            this.baudRateCB.TabIndex = 5;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(184, 24);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(81, 18);
            this.baudRateLabel.TabIndex = 6;
            this.baudRateLabel.Text = "BaudRate";
            // 
            // positionValue
            // 
            this.positionValue.Location = new System.Drawing.Point(664, 168);
            this.positionValue.Name = "positionValue";
            this.positionValue.Size = new System.Drawing.Size(120, 25);
            this.positionValue.TabIndex = 7;
            this.positionValue.ValueChanged += new System.EventHandler(this.positionValue_ValueChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(48, 88);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 18);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID";
            // 
            // idCB
            // 
            this.idCB.FormattingEnabled = true;
            this.idCB.Location = new System.Drawing.Point(48, 112);
            this.idCB.Name = "idCB";
            this.idCB.Size = new System.Drawing.Size(121, 26);
            this.idCB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.idCB);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.positionValue);
            this.Controls.Add(this.baudRateLabel);
            this.Controls.Add(this.baudRateCB);
            this.Controls.Add(this.positionTB);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.portCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portCB;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TrackBar positionTB;
        private System.Windows.Forms.ComboBox baudRateCB;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.NumericUpDown positionValue;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ComboBox idCB;
    }
}

