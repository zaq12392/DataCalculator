namespace DataCalculator
{
    partial class RolePanel
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            Content = new FlowLayoutPanel();
            RoleName = new Panel();
            RoleImage = new PictureBox();
            comboBox1 = new ComboBox();
            Reset_Btn = new Button();
            RoleName_Label = new Label();
            RolePoint = new Panel();
            RolePoint_Label = new Label();
            RolePoint_Point = new Label();
            Content.SuspendLayout();
            RoleName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoleImage).BeginInit();
            RolePoint.SuspendLayout();
            SuspendLayout();
            // 
            // Content
            // 
            Content.Controls.Add(RoleName);
            Content.FlowDirection = FlowDirection.TopDown;
            Content.Location = new Point(3, 3);
            Content.Name = "Content";
            Content.Size = new Size(272, 470);
            Content.TabIndex = 0;
            // 
            // RoleName
            // 
            RoleName.Controls.Add(RoleImage);
            RoleName.Controls.Add(comboBox1);
            RoleName.Controls.Add(Reset_Btn);
            RoleName.Controls.Add(RoleName_Label);
            RoleName.Location = new Point(3, 3);
            RoleName.Name = "RoleName";
            RoleName.Size = new Size(269, 66);
            RoleName.TabIndex = 0;
            // 
            // RoleImage
            // 
            RoleImage.Location = new Point(3, 3);
            RoleImage.Name = "RoleImage";
            RoleImage.Size = new Size(50, 50);
            RoleImage.TabIndex = 4;
            RoleImage.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(61, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Reset_Btn
            // 
            Reset_Btn.Location = new Point(191, 30);
            Reset_Btn.Name = "Reset_Btn";
            Reset_Btn.Size = new Size(75, 23);
            Reset_Btn.TabIndex = 2;
            Reset_Btn.Text = "重置";
            Reset_Btn.UseVisualStyleBackColor = true;
            Reset_Btn.Click += Reset_Btn_Click;
            // 
            // RoleName_Label
            // 
            RoleName_Label.AutoSize = true;
            RoleName_Label.Location = new Point(59, 13);
            RoleName_Label.Name = "RoleName_Label";
            RoleName_Label.Size = new Size(64, 15);
            RoleName_Label.TabIndex = 1;
            RoleName_Label.Text = "roleName";
            // 
            // RolePoint
            // 
            RolePoint.Controls.Add(RolePoint_Label);
            RolePoint.Controls.Add(RolePoint_Point);
            RolePoint.Location = new Point(3, 479);
            RolePoint.Name = "RolePoint";
            RolePoint.Size = new Size(272, 49);
            RolePoint.TabIndex = 1;
            // 
            // RolePoint_Label
            // 
            RolePoint_Label.AutoSize = true;
            RolePoint_Label.Location = new Point(147, 17);
            RolePoint_Label.Name = "RolePoint_Label";
            RolePoint_Label.Size = new Size(55, 15);
            RolePoint_Label.TabIndex = 0;
            RolePoint_Label.Text = "存檔價值";
            // 
            // RolePoint_Point
            // 
            RolePoint_Point.AutoSize = true;
            RolePoint_Point.Location = new Point(208, 17);
            RolePoint_Point.Name = "RolePoint_Point";
            RolePoint_Point.Size = new Size(77, 15);
            RolePoint_Point.TabIndex = 1;
            RolePoint_Point.Text = "costNumber";
            // 
            // RolePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            Controls.Add(RolePoint);
            Controls.Add(Content);
            Name = "RolePanel";
            Size = new Size(278, 531);
            Content.ResumeLayout(false);
            RoleName.ResumeLayout(false);
            RoleName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoleImage).EndInit();
            RolePoint.ResumeLayout(false);
            RolePoint.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Content;
        private Panel RoleName;
        private Label RoleName_Label;
        private Panel RolePoint;
        private Label RolePoint_Label;
        private Label RolePoint_Point;
        private Button Reset_Btn;
        private ComboBox comboBox1;
        private PictureBox RoleImage;
    }
}
