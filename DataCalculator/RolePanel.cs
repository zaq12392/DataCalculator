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
    public partial class RolePanel : UserControl
    {
        public RolePanel(Form1 iMain, int iIndex)
        {
            InitializeComponent();

            Main = iMain;

            m_index = iIndex;

            InitUI();

            CreateCostEvent();
        }

        Form1 Main;

        int m_index;

        /// <summary>
        /// 當前存檔價值
        /// </summary>
        public int RoleDataPoint;

        /// <summary>
        /// 存檔價值上限
        /// </summary>
        public int RoleDataPointMax
        {
            get { return Main.TierDataPoint; }
        }

        /// <summary>
        /// 初始化UI
        /// </summary>
        void InitUI()
        {
            RoleName_Label.Text = "角色" + (m_index + 1).ToString();

            UpdatePoint();
        }

        /// <summary>
        /// 更新當前存檔價值
        /// </summary>
        public void UpdatePoint()
        {
            RoleDataPoint = 0;

            foreach(var e in m_lst_data)
            {
                RoleDataPoint += e.NowPoint;
            }

            RolePoint_Point.Text = RoleDataPoint + " / " + RoleDataPointMax;

            if (RoleDataPoint <= RoleDataPointMax)
                RolePoint_Point.ForeColor = Color.Green;
            else
                RolePoint_Point.ForeColor = Color.Red;
        }

        List<CostEventData> m_lst_data = new List<CostEventData>();

        private void CreateCostEvent()
        {
            m_lst_data.AddRange(Main.GetLstData());

            foreach (var e in m_lst_data)
            {
                CostEvent _copy = new CostEvent(e, this);

                _copy.title.Text = e.Name;

                Content.Controls.Add(_copy);
            }
        }
    }
}
