using System.ComponentModel.Design.Serialization;

namespace DataCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataCost_ComboBox.SelectedIndex = 0; //難度下拉選單預設0
            CreateRolePanel();
        }
        // 全域重置
        public void ResetAllRoles()
        {
            foreach (var role in m_lst_role)
            {
                role.Reset();
            }
        }


        private void ResetAllBtn_Click(object sender, EventArgs e)
        {
            ResetAllRoles();
        }

        /// <summary>
        /// 基礎分數
        /// </summary>
        public int TierDataPoint = 30;
        List<RolePanel> m_lst_role = new List<RolePanel>();

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
