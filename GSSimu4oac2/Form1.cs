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







            //副本信息
            listView_dungeon.Items.Clear();
            for (int i = 0; i < Data.dungeon.Length; i++) {
                string[] data = Data.dungeon[i];
                ListViewItem item = new ListViewItem(data[0]);
                item.SubItems.Add(data[1]);
                item.SubItems.Add(data[2]);
                listView_dungeon.Items.Add(item);
            }
        }
    }
}
