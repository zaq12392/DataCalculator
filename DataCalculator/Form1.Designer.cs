namespace DataCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataCost_Text = new Label();
            DataCost_ComboBox = new ComboBox();
            MainPanel = new FlowLayoutPanel();
            Reset_Btn = new Button();
            SuspendLayout();
            // 
            // DataCost_Text
            // 
            DataCost_Text.AutoSize = true;
            DataCost_Text.Font = new Font("Microsoft JhengHei UI", 12F);
            DataCost_Text.Location = new Point(0, 7);
            DataCost_Text.Name = "DataCost_Text";
            DataCost_Text.Size = new Size(85, 20);
            DataCost_Text.TabIndex = 0;
            DataCost_Text.Text = "存檔價值 : ";
            // 
            // DataCost_ComboBox
            // 
            DataCost_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DataCost_ComboBox.FormattingEnabled = true;
            DataCost_ComboBox.Items.AddRange(new object[] { "TIER 1", "TIER 2", "TIER 3", "TIER 4", "TIER 5", "TIER 6", "TIER 7", "TIER 8", "TIER 9", "TIER 10", "TIER 11", "TIER 12", "TIER 13", "TIER 14", "TIER 15" });
            DataCost_ComboBox.Location = new Point(91, 8);
            DataCost_ComboBox.Name = "DataCost_ComboBox";
            DataCost_ComboBox.Size = new Size(121, 23);
            DataCost_ComboBox.TabIndex = 1;
            DataCost_ComboBox.SelectedIndexChanged += DataCost_ComboBox_SelectedIndexChanged;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(12, 32);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(878, 515);
            MainPanel.TabIndex = 2;
            // 
            // Reset_Btn
            // 
            Reset_Btn.Location = new Point(218, 7);
            Reset_Btn.Name = "Reset_Btn";
            Reset_Btn.Size = new Size(75, 23);
            Reset_Btn.TabIndex = 3;
            Reset_Btn.Text = "全域重置";
            Reset_Btn.UseVisualStyleBackColor = true;
            Reset_Btn.Click += ResetAllBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 559);
            Controls.Add(Reset_Btn);
            Controls.Add(DataCost_Text);
            Controls.Add(DataCost_ComboBox);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CZN計算機";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DataCost_Text;
        private ComboBox DataCost_ComboBox;
        private FlowLayoutPanel MainPanel;
        private Button Reset_Btn;
    }
}
