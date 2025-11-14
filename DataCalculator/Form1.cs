using System.ComponentModel.Design.Serialization;

namespace DataCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataCost_ComboBox.SelectedIndex = 0; //難度下拉選單預設0
            SetCostEventData();
            CreateRolePanel();
        }
        /// <summary>
        /// 基礎分數
        /// </summary>
        public int TierDataPoint = 30;

        public List<CostEventData> m_lst_data = new List<CostEventData>();

        List<RolePanel> m_lst_role = new List<RolePanel>();

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

        public List<CostEventData> GetLstData()
        {
            return m_lst_data;
        }

        private void CreateRolePanel()
        {
            for(int i = 0; i < 3; i++)
            {
                RolePanel _rolePanel = new RolePanel(this, i);

                m_lst_role.Add(_rolePanel);

                MainPanel.Controls.Add(_rolePanel);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Role_Layout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataCost_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TierDataPoint = 30; //初始化

            TierDataPoint += DataCost_ComboBox.SelectedIndex * 10;

            foreach(var _role in m_lst_role)
            {
                _role.UpdatePoint();
            }
        }
    }
}
