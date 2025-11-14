using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCalculator
{
    public partial class CostEvent : UserControl
    {
        public CostEvent(CostEventData iData, RolePanel iRole)
        {
            InitializeComponent();
            m_role = iRole;
            m_data = iData;

            numberText.Text = 0.ToString();
        }

        public CostEventData m_data;

        RolePanel m_role;

        private void numberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允許數字和控制鍵（Backspace等）
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numberText_TextChanged(object sender, EventArgs e)
        {
            // 空字串就不處理，避免 TryParse 出錯
            if (string.IsNullOrEmpty(numberText.Text))
            {
                m_data.Count = 0;

                m_data.NowPoint = m_data.Count * m_data.Cost;

                m_role.UpdatePoint();

                return;
            }
                

            // 取數字
            if (int.TryParse(numberText.Text, out int iNum))
            {
                m_data.Count = iNum;

                if (IsSpecialPoint())
                {
                    SpecialPoint();
                }
                else
                {
                    m_data.NowPoint = m_data.Count * m_data.Cost;

                    SetPointText();
                }
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (m_data.Count == 0) //不能為負
                return;

            m_data.Count--;

            if (IsSpecialPoint())
            {
                SpecialPoint();
            }
            else
            {
                m_data.NowPoint -= m_data.Cost;

                SetPointText();
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            m_data.Count++;

            if (IsSpecialPoint())
            {
                SpecialPoint();
            }
            else
            {
                m_data.NowPoint += m_data.Cost;

                SetPointText();
            }  
        }

        void SetPointText()
        {
            numberText.Text = m_data.Count.ToString();

            m_role.UpdatePoint();
        }

        /// <summary>
        /// 是否為特殊算法 (複製、移除)
        /// </summary>
        /// <returns></returns>
        bool IsSpecialPoint()
        {
            return m_data.ID == 5 || m_data.ID == 7;
        }

        /// <summary>
        /// 特殊算法 (複製、移除)
        /// </summary>
        void SpecialPoint()
        {
            if (m_data.Count == 1)
            {
                m_data.NowPoint = 0;
            }
            else if (m_data.Count == 2)
            {
                m_data.NowPoint = 10;
            }
            else if (m_data.Count == 3)
            {
                m_data.NowPoint = 40;
            }
            else if (m_data.Count == 4)
            {
                m_data.NowPoint = 90;
            }
            else if (m_data.Count > 4)
            {
                int _count = m_data.Count - 4;

                m_data.NowPoint = 90 + _count * 70;
            }

            SetPointText();
        }
    }
}
