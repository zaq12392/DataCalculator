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
            RoleName_Label = new Label();
            RoleNmae_Text = new TextBox();
            RolePoint = new Panel();
            RolePoint_Label = new Label();
            RolePoint_Point = new Label();
            Reset_Btn = new Button();
            Content.SuspendLayout();
            RoleName.SuspendLayout();
            RolePoint.SuspendLayout();
            SuspendLayout();
            // 
            // Content
            // 
            Content.Controls.Add(RoleName);
            Content.FlowDirection = FlowDirection.TopDown;
            Content.Location = new Point(3, 3);
            Content.Name = "Content";
            Content.Size = new Size(272, 432);
            Content.TabIndex = 0;
            // 
            // RoleName
            // 
            RoleName.Controls.Add(Reset_Btn);
            RoleName.Controls.Add(RoleName_Label);
            RoleName.Controls.Add(RoleNmae_Text);
            RoleName.Location = new Point(3, 3);
            RoleName.Name = "RoleName";
            RoleName.Size = new Size(269, 37);
            RoleName.TabIndex = 0;
            // 
            // RoleName_Label
            // 
            RoleName_Label.AutoSize = true;
            RoleName_Label.Location = new Point(11, 13);
            RoleName_Label.Name = "RoleName_Label";
            RoleName_Label.Size = new Size(64, 15);
            RoleName_Label.TabIndex = 1;
            RoleName_Label.Text = "roleName";
            // 
            // RoleNmae_Text
            // 
            RoleNmae_Text.Location = new Point(81, 10);
            RoleNmae_Text.Name = "RoleNmae_Text";
            RoleNmae_Text.Size = new Size(100, 23);
            RoleNmae_Text.TabIndex = 0;
            // 
            // RolePoint
            // 
            RolePoint.Controls.Add(RolePoint_Label);
            RolePoint.Controls.Add(RolePoint_Point);
            RolePoint.Location = new Point(3, 441);
            RolePoint.Name = "RolePoint";
            RolePoint.Size = new Size(272, 49);
            RolePoint.TabIndex = 1;
            // 
            // RolePoint_Label
            // 
            RolePoint_Label.AutoSize = true;
            RolePoint_Label.Location = new Point(3, 17);
            RolePoint_Label.Name = "RolePoint_Label";
            RolePoint_Label.Size = new Size(55, 15);
            RolePoint_Label.TabIndex = 0;
            RolePoint_Label.Text = "存檔價值";
            // 
            // RolePoint_Point
            // 
            RolePoint_Point.AutoSize = true;
            RolePoint_Point.Location = new Point(64, 17);
            RolePoint_Point.Name = "RolePoint_Point";
            RolePoint_Point.Size = new Size(77, 15);
            RolePoint_Point.TabIndex = 1;
            RolePoint_Point.Text = "costNumber";
            // 
            // Reset_Btn
            // 
            Reset_Btn.Location = new Point(187, 9);
            Reset_Btn.Name = "Reset_Btn";
            Reset_Btn.Size = new Size(75, 23);
            Reset_Btn.TabIndex = 2;
            Reset_Btn.Text = "重置";
            Reset_Btn.UseVisualStyleBackColor = true;
            Reset_Btn.Click += Reset_Btn_Click;
            // 
            // RolePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RolePoint);
            Controls.Add(Content);
            Name = "RolePanel";
            Size = new Size(278, 493);
            Content.ResumeLayout(false);
            RoleName.ResumeLayout(false);
            RoleName.PerformLayout();
            RolePoint.ResumeLayout(false);
            RolePoint.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Content;
        private Panel RoleName;
        private Label RoleName_Label;
        private TextBox RoleNmae_Text;
        private Panel RolePoint;
        private Label RolePoint_Label;
        private Label RolePoint_Point;
        private Button Reset_Btn;
    }
}
