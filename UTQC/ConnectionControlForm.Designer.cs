namespace UTQC
{
    partial class ConnectionControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionControlForm));
            this.button_connect = new System.Windows.Forms.Button();
            this.comboBox_gameType = new System.Windows.Forms.ComboBox();
            this.label_gameType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(164, 9);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // comboBox_gameType
            // 
            this.comboBox_gameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gameType.FormattingEnabled = true;
            this.comboBox_gameType.Items.AddRange(new object[] {
            "Individual",
            "Team"});
            this.comboBox_gameType.Location = new System.Drawing.Point(83, 10);
            this.comboBox_gameType.Name = "comboBox_gameType";
            this.comboBox_gameType.Size = new System.Drawing.Size(75, 21);
            this.comboBox_gameType.TabIndex = 1;
            this.comboBox_gameType.SelectedIndexChanged += new System.EventHandler(this.comboBox_gameType_SelectedIndexChanged);
            // 
            // label_gameType
            // 
            this.label_gameType.AutoSize = true;
            this.label_gameType.Location = new System.Drawing.Point(12, 14);
            this.label_gameType.Name = "label_gameType";
            this.label_gameType.Size = new System.Drawing.Size(65, 13);
            this.label_gameType.TabIndex = 2;
            this.label_gameType.Text = "Game Type:";
            // 
            // ConnectionControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 41);
            this.Controls.Add(this.label_gameType);
            this.Controls.Add(this.comboBox_gameType);
            this.Controls.Add(this.button_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionControlForm";
            this.Text = "UT Quick Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ComboBox comboBox_gameType;
        private System.Windows.Forms.Label label_gameType;
    }
}

