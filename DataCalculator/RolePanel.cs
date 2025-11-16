using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            InitComboBox();

            CreateCostEvent();

            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //打字自動補完選項
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems; //打字自動搜尋清單內的ITEM

            comboBox1.SelectedIndexChanged += (s, e) => //選完之後取消反白
            {
                this.BeginInvoke((Action)(() =>
                {
                    comboBox1.SelectionStart = comboBox1.Text.Length;
                    comboBox1.SelectionLength = 0;
                }));
            };
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

        void InitComboBox()
        {
            comboBox1.Items.AddRange(new object[] { 
                "---5★---", 
                "友紀", 
                "小春", 
                "琳", 
                "路克", 
                "卡莉佩", 
                "麥格納", 
                "奧爾萊亞", 
                "梅鈴", 
                "維若妮卡", 
                "蕾歐娜", 
                "雨果", 
                "凱隆", 
                "---4★---", 
                "妮雅", 
                "席琳娜", 
                "德蕾莎", 
                "艾美", 
                "盧卡斯", 
                "瑪莉貝爾", 
                "米卡", 
                "百麗兒", 
                "凱西烏斯", 
                "歐文", 
                "蕾伊" });
        }

        /// <summary>
        /// 資料初始化
        /// </summary>
        private void SetCostEventData()
        {
            //卡牌分
            AddNewEvent(4, "一般神閃", 20);

            AddNewEvent(0, "中立卡牌", 20);
            AddNewEvent(2, "中立靈光一閃", 10);
            AddNewEvent(3, "中立神閃", 30);

            AddNewEvent(9, "禁忌卡牌", 20);

            AddNewEvent(1, "怪物卡牌", 80);
            //事件分
            AddNewEvent(8, "轉換卡牌", 10);
            AddNewEvent(6, "移除角色卡牌", 20);
            AddNewEvent(5, "移除卡牌", 0);

            AddNewEvent(7, "複製卡牌", 0);

            // 排序
            //m_lst_data.OrderBy(x => x.ID);
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

        // 提示物件
        private System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        private void CreateCostEvent()
        {
            foreach (var e in m_lst_data)
            {
                CostEvent _copy = new CostEvent(e, this);
                m_lst_costEvent.Add(_copy);
                _copy.title.Text = e.Name;
                // 上色
                if (new[] { 0, 1, 2, 3, 4, 9 }.Contains(e.ID))
                {
                    _copy.BackColor = Color.LightBlue;
                }
                if (new[] { 5, 6, 7, 8 }.Contains(e.ID))
                {
                    _copy.BackColor = Color.Moccasin;
                }

                // 提示文字
                string tipText = "";
                switch (e.ID)
                {
                    case 6: tipText = "移除角色卡牌時，會同步移除卡牌數量"; break;

                }

                toolTip.SetToolTip(_copy.title, tipText);

                Content.Controls.Add(_copy);
            }
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            Reset(false);
        }
        
        /// <summary>
        /// 選擇角色連動換圖片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectionStart = comboBox1.Text.Length;
            comboBox1.SelectionLength = 0;

            RoleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            if (comboBox1.SelectedItem != null)
            {
                Image? _img = LoadImage(comboBox1.SelectedItem.ToString());
                if (_img != null)
                    RoleImage.Image = _img;

                RoleName_Label.Text = string.Empty;
            }
        }



        Image? LoadImage(string iName)
        {
            //找同名檔案的圖片
            object _obj = Properties.Resources.ResourceManager.GetObject(iName);

            if (_obj is Image img)
            {
                return img;
            }
            return null;
        }


        public void Reset(bool iIsAllReset)
        {
            for (int i = 0; i < m_lst_costEvent.Count; i++)
            {
                m_lst_data[i].Count = 0;
                m_lst_data[i].NowPoint = 0;
                m_lst_costEvent[i].numberText.Text = "0";
            }

            if (iIsAllReset)
            {
                comboBox1.SelectedIndex = -1;
                comboBox1.Text = "請選擇角色";
                RoleName_Label.Text = "角色" + (m_index + 1).ToString();
                RoleImage.Image = null;
            }
            
            UpdatePoint();
        }

        // 同步移除卡牌數量
        public void SyncRemoveCard(int count)
        {
            // 移除卡牌 (ID=5)
            var removeCard = m_lst_data.FirstOrDefault(x => x.ID == 5);
            if (removeCard != null)
            {
                removeCard.Count = count;
                removeCard.NowPoint = count * removeCard.Cost;

                // 更新 UI
                var removeCardUI = m_lst_costEvent.FirstOrDefault(x => x.m_data.ID == 5);
                if (removeCardUI != null)
                {
                    removeCardUI.numberText.Text = count.ToString();
                }
            }

            UpdatePoint();
        }
        // 檢查中立卡牌數量並同步
        public void EnsureNeutralCard(int requiredCount)
        {
            var neutral = m_lst_data.FirstOrDefault(x => x.ID == 0);
            if (neutral != null && neutral.Count < requiredCount)
            {
                neutral.Count = requiredCount;
                neutral.NowPoint = neutral.Count * neutral.Cost;

                // 更新 UI
                var neutralUI = m_lst_costEvent.FirstOrDefault(x => x.m_data.ID == 0);
                if (neutralUI != null)
                    neutralUI.numberText.Text = neutral.Count.ToString();
            }

            UpdatePoint();
        }

    }
}
