// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) LibreHardwareMonitor and Contributors.
// Partial Copyright (C) Michael Möller <mmoeller@openhardwaremonitor.org> and Contributors.
// All Rights Reserved.

namespace LibreHardwareMonitor.UI
{
    partial class PortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortForm));
            this.portOKButton = new System.Windows.Forms.Button();
            this.portCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.webServerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.portNumericUpDn = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDn)).BeginInit();
            this.SuspendLayout();
            // 
            // portOKButton
            // 
            this.portOKButton.Location = new System.Drawing.Point(366, 190);
            this.portOKButton.Margin = new System.Windows.Forms.Padding(4);
            this.portOKButton.Name = "portOKButton";
            this.portOKButton.Size = new System.Drawing.Size(112, 32);
            this.portOKButton.TabIndex = 0;
            this.portOKButton.Text = "OK";
            this.portOKButton.UseVisualStyleBackColor = true;
            this.portOKButton.Click += new System.EventHandler(this.PortOKButton_Click);
            // 
            // portCancelButton
            // 
            this.portCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.portCancelButton.Location = new System.Drawing.Point(243, 190);
            this.portCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.portCancelButton.Name = "portCancelButton";
            this.portCancelButton.Size = new System.Drawing.Size(112, 32);
            this.portCancelButton.TabIndex = 1;
            this.portCancelButton.Text = "返回";
            this.portCancelButton.UseVisualStyleBackColor = true;
            this.portCancelButton.Click += new System.EventHandler(this.PortCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "注意：您需要关闭本地的防火墙。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "远程web服务器的端口：\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "如果web服务器正在运行，则需要重新启动它才能使端口更改生效。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "web服务器将可从以下位置的浏览器访问：\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // webServerLinkLabel
            // 
            this.webServerLinkLabel.AutoSize = true;
            this.webServerLinkLabel.Location = new System.Drawing.Point(404, 86);
            this.webServerLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.webServerLinkLabel.Name = "webServerLinkLabel";
            this.webServerLinkLabel.Size = new System.Drawing.Size(98, 18);
            this.webServerLinkLabel.TabIndex = 7;
            this.webServerLinkLabel.TabStop = true;
            this.webServerLinkLabel.Text = "linkLabel1";
            this.webServerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebServerLinkLabel_LinkClicked);
            // 
            // portNumericUpDn
            // 
            this.portNumericUpDn.Location = new System.Drawing.Point(312, 10);
            this.portNumericUpDn.Margin = new System.Windows.Forms.Padding(4);
            this.portNumericUpDn.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.portNumericUpDn.Minimum = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            this.portNumericUpDn.Name = "portNumericUpDn";
            this.portNumericUpDn.Size = new System.Drawing.Size(112, 28);
            this.portNumericUpDn.TabIndex = 8;
            this.portNumericUpDn.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            this.portNumericUpDn.ValueChanged += new System.EventHandler(this.PortNumericUpDn_ValueChanged);
            this.portNumericUpDn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PortNumericUpDn_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "您必须通过单击菜单中的“运行”来启动服务器。";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(434, 147);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(170, 18);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "如何关闭本地防火墙";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.portCancelButton;
            this.ClientSize = new System.Drawing.Size(699, 235);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.portNumericUpDn);
            this.Controls.Add(this.webServerLinkLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portCancelButton);
            this.Controls.Add(this.portOKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置端口";
            this.Load += new System.EventHandler(this.PortForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button portOKButton;
        private System.Windows.Forms.Button portCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel webServerLinkLabel;
        private System.Windows.Forms.NumericUpDown portNumericUpDn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
