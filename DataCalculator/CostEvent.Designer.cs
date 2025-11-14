using System.Runtime.CompilerServices;

namespace DataCalculator
{

    partial class CostEvent
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// 強啊翠神
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
            ContentCopy = new Panel();
            title = new Label();
            minusBtn = new Button();
            plusBtn = new Button();
            numberText = new TextBox();
            ContentCopy.SuspendLayout();
            SuspendLayout();
            // 
            // ContentCopy
            // 
            ContentCopy.Controls.Add(title);
            ContentCopy.Controls.Add(minusBtn);
            ContentCopy.Controls.Add(plusBtn);
            ContentCopy.Controls.Add(numberText);
            ContentCopy.Location = new Point(3, 3);
            ContentCopy.Name = "ContentCopy";
            ContentCopy.Size = new Size(210, 24);
            ContentCopy.TabIndex = 6;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(3, -3);
            title.Name = "title";
            title.Padding = new Padding(0, 8, 0, 0);
            title.Size = new Size(42, 23);
            title.TabIndex = 0;
            title.Text = "label1";
            // 
            // minusBtn
            // 
            minusBtn.Location = new Point(114, -3);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(25, 25);
            minusBtn.TabIndex = 1;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = true;
            minusBtn.Click += minusBtn_Click;
            // 
            // plusBtn
            // 
            plusBtn.Location = new Point(176, -3);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(25, 25);
            plusBtn.TabIndex = 3;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = true;
            plusBtn.Click += plusBtn_Click;
            // 
            // numberText
            // 
            numberText.Location = new Point(145, 0);
            numberText.Name = "numberText";
            numberText.Size = new Size(25, 23);
            numberText.TabIndex = 2;
            numberText.TextChanged += numberText_TextChanged;
            numberText.KeyPress += numberText_KeyPress;
            // 
            // CostEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentCopy);
            Name = "CostEvent";
            Size = new Size(210, 30);
            ContentCopy.ResumeLayout(false);
            ContentCopy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label title;
        public Button minusBtn;
        public TextBox numberText;
        public Button plusBtn;
        public Panel ContentCopy;

        
    }
}
