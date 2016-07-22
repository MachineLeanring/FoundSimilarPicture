using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoundSimilarPicture
{
    public partial class BatchSimilarImageMatchForm : Form
    {
        public BatchSimilarImageMatchForm()
        {
            InitializeComponent();
        }

        private void BatchSimilarImageMatchForm_Load(object sender, EventArgs e)
        {
            initListViewConfig();

            // 添加表格内容
            for (int i = 0; i < 30; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = "产品" + i.ToString();
                item.SubItems.Add(i.ToString());
                item.SubItems.Add((i + 7).ToString());
                item.SubItems.Add((i * i).ToString());
                similarImageResultListView.Items.Add(item);
            }

            autoResize();
        }

        private void initListViewConfig()
        {
            similarImageResultListView.GridLines = true;
            similarImageResultListView.FullRowSelect = true;
            similarImageResultListView.View = View.Details;
            similarImageResultListView.Scrollable = true;
            similarImageResultListView.MultiSelect = false;

            // 添加表头（列）
            similarImageResultListView.Columns.Add("ProductName", "产品名称");
            similarImageResultListView.Columns.Add("SN", "产品型号");
            similarImageResultListView.Columns.Add("Price", "价格");
        }

        private void autoResize()
        {
            similarImageResultListView.Columns["ProductName"].Width = -1; // 根据内容设置宽度
            similarImageResultListView.Columns["SN"].Width = -2; // 根据标题设置宽度
            similarImageResultListView.Columns["Price"].Width = -2;
        }
    }
}
