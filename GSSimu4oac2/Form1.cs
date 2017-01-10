using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSSimu4oac2
{
    public partial class Form1 : Form
    {
        string app_name = "装备评分模拟器4混沌与秩序2";
        string app_author = "Majesty";
        string app_version = "0.1";


        public Form1()
        {
            InitializeComponent();
        }
        //载入事件
        private void Form1_Load(object sender, EventArgs e)
        {
            //界面信息
            this.Text = app_name;
            //初始化面板数据


            //武器
            List<MyItem> weapon_list = new List<MyItem>();
            for (int i = 0; i < Data.items_weapon.Length; i++) {
                weapon_list.Add(new MyItem(Data.items_weapon[i]));
            }
            comboBox_item_weapon.DataSource = weapon_list;
            comboBox_item_weapon.DisplayMember = "Name";

            //首饰

            List<MyItem> neck_list = new List<MyItem>();
            for (int i = 0; i < Data.items_neck.Length; i++) {
                neck_list.Add(new MyItem(Data.items_neck[i]));
            }
            comboBox_item_neck.DataSource = neck_list;
            comboBox_item_neck.DisplayMember = "Name";


            //ring
            List<MyItem> ring_list = new List<MyItem>();
            for (int i = 0; i < Data.items_ring.Length; i++)
            {
                ring_list.Add(new MyItem(Data.items_ring[i]));
            }
            comboBox_item_ring1.DataSource = ring_list;
            comboBox_item_ring2.DataSource = new List<MyItem>(ring_list.ToArray());
            comboBox_item_ring1.DisplayMember = "Name";
            comboBox_item_ring2.DisplayMember = "Name";


            //身体
            List<MyItem> body_list = new List<MyItem>();
            for (int i = 0; i < Data.items_body.Length; i++)
            {
                body_list.Add(new MyItem(Data.items_body[i]));
            }
            comboBox_item_head.DataSource = body_list;
            comboBox_item_body.DataSource = new List<MyItem>(body_list.ToArray());
            comboBox_item_shoulder.DataSource = new List<MyItem>(body_list.ToArray());
            comboBox_item_shoes.DataSource = new List<MyItem>(body_list.ToArray());
            comboBox_item_wrist.DataSource = new List<MyItem>(body_list.ToArray());
            comboBox_item_head.DisplayMember = "Name";
            comboBox_item_body.DisplayMember = "Name";
            comboBox_item_shoulder.DisplayMember = "Name";
            comboBox_item_shoes.DisplayMember = "Name";
            comboBox_item_wrist.DisplayMember = "Name";

            //时装
            List<MyItem> fashion_list = new List<MyItem>();
            for (int i = 0; i < Data.items_fashion.Length; i++)
            {
                fashion_list.Add(new MyItem(Data.items_fashion[i]));
            }
            comboBox_item_fa_back.DataSource = fashion_list;
            comboBox_item_fa_body.DataSource = new List<MyItem>(fashion_list.ToArray());
            comboBox_item_fa_head.DataSource = new List<MyItem>(fashion_list.ToArray());
            comboBox_item_fa_foot.DataSource = new List<MyItem>(fashion_list.ToArray());
            comboBox_item_fa_back.DisplayMember = "Name";
            comboBox_item_fa_body.DisplayMember = "Name";
            comboBox_item_fa_head.DisplayMember = "Name";
            comboBox_item_fa_foot.DisplayMember = "Name";


            //调整listview
            columnHeader1.Width = 128;
            columnHeader2.Width = 66;
            columnHeader3.Width = 66;

           
            //触发一次更新
            calGS(sender, e);
        }




        //计算
        private void calGS(object sender,EventArgs e) {

            int value = 
                Convert.ToInt32(((MyItem)comboBox_item_head.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_body.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_shoulder.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_wrist.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_shoes.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_neck.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_ring1.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_ring2.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_weapon.SelectedItem).Score)+

                Convert.ToInt32(((MyItem)comboBox_item_fa_back.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_fa_head.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_fa_foot.SelectedItem).Score) +
                Convert.ToInt32(((MyItem)comboBox_item_fa_body.SelectedItem).Score);
            label_GS.Text = value + "";
            //自动调整label居中
            this.label_GS.Location = new System.Drawing.Point((groupBox3.Size.Width-label_GS.Width)/2, 69);
            //修改副本显示
            update_dungeon(value);
        }

        //修改副本显示分数
        private void update_dungeon(int GS)
        {
            //副本信息
            listView_dungeon.Items.Clear();
            for (int i = 0; i < Data.dungeon.Length; i++)
            {
                string[] data = Data.dungeon[i];
                ListViewItem item = new ListViewItem(data[0]);
                int value_small = Convert.ToInt32(data[1]);
                int value_big = Convert.ToInt32(data[2]);
                string showsmall = "";
                string showbig = "";
                if (GS >= value_small)
                {
                    showsmall = value_small + "";
                }
                else {
                    showsmall = value_small + " X";
                }
                if (GS >= value_big)
                {
                    showbig = value_big + "";
                }
                else
                {
                    showbig = value_big + " X";
                }
                item.SubItems.Add(showsmall);
                item.SubItems.Add(showbig);
                listView_dungeon.Items.Add(item);
            }

        }
    }
}
