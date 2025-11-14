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

            SetCostEventData();

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

        List<CostEventData> m_lst_data = new List<CostEventData>();

        List<CostEvent> m_lst_costEvent = new List<CostEvent>();

        /// <summary>
        /// 初始化UI
        /// </summary>
        void InitUI()
        {
            RoleName_Label.Text = "角色" + (m_index + 1).ToString();

            UpdatePoint();
        }

        /// <summary>
        /// 資料初始化
        /// </summary>
        private void SetCostEventData()
        {
            //中立
            AddNewEvent(0, "中立卡", 20);
            AddNewEvent(1, "怪物卡", 80);
            AddNewEvent(2, "共用卡靈光一閃", 10);
            AddNewEvent(3, "共用卡神閃", 30);

            //角色
            AddNewEvent(4, "神閃", 20);
            AddNewEvent(5, "移除卡", 0);
            AddNewEvent(6, "移除固有卡", 20);
            AddNewEvent(7, "複製卡", 0);
            AddNewEvent(8, "轉換卡", 10);
            AddNewEvent(9, "禁忌卡", 20);
            m_lst_data.OrderBy(x => x.ID);
        }

        void AddNewEvent(int iID, string iName, int iCost)
        {
            CostEventData _newNeutralCard = new CostEventData() { ID = iID, Name = iName, Cost = iCost };
            m_lst_data.Add(_newNeutralCard);
        }


        /// <summary>
        /// 更新當前存檔價值
        /// </summary>
        public void UpdatePoint()
        {
            RoleDataPoint = 0;

            foreach (var e in m_lst_data)
            {
                RoleDataPoint += e.NowPoint;
            }

            RolePoint_Point.Text = RoleDataPoint + " / " + RoleDataPointMax;

            if (RoleDataPoint <= RoleDataPointMax)
                RolePoint_Point.ForeColor = Color.Green;
            else
                RolePoint_Point.ForeColor = Color.Red;
        }



        private void CreateCostEvent()
        {
            foreach (var e in m_lst_data)
            {
                CostEvent _copy = new CostEvent(e, this);

                m_lst_costEvent.Add(_copy);

                _copy.title.Text = e.Name;

                Content.Controls.Add(_copy);
            }
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_lst_costEvent.Count; i++)
            {
                m_lst_data[i].Count = 0;
                m_lst_data[i].NowPoint = 0;
                m_lst_costEvent[i].numberText.Text = 0.ToString();
            }

            UpdatePoint();
        }
    }
}
