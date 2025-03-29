using Newtonsoft.Json;

namespace ExtractRSV
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> RSVPairs = [];

        public MainForm()
        {
            InitializeComponent();
        }

        public void btnBrowseLog_Click(object sender, EventArgs e)
        {
            if (ofdLog.ShowDialog() == DialogResult.OK)
            {
                tbLog.Text = ofdLog.FileName;

                RSVPairs = Extract.FromFile(ofdLog.FileName);
                lvRSVPairs.Items.Clear();

                foreach (KeyValuePair<string, string> rsv in RSVPairs)
                {
                    ListViewItem item = new ListViewItem(new[] { rsv.Key, rsv.Value });

                    lvRSVPairs.Items.Add(item);
                }

                if (RSVPairs.Count == 0)
                {
                    MessageBox.Show("No RSV lines were found in the log.", "Extract RSV");
                }
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            if (sfdRSVs.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(RSVPairs, Formatting.Indented);

                File.WriteAllText(sfdRSVs.FileName, json);
            }
        }

        private void lvRSVPairs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem? item = lvRSVPairs.FocusedItem;

                if (item != null && item.Bounds.Contains(e.Location))
                {
                    cmsListView.Show(Cursor.Position);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = lvRSVPairs.SelectedItems;

            if (items.Count > 0)
            {
                List<string> keys = new List<string>();

                for (int i = 0; i < items.Count; i++)
                {
                    keys.Add(items[i].Text);
                }

                Dictionary<string, string> selectedRSVPairs = RSVPairs
                    .Where(pair => keys.Contains(pair.Key))
                    .ToDictionary();

                string json = JsonConvert.SerializeObject(selectedRSVPairs, Formatting.Indented);

                Clipboard.SetText(json);
            }
        }
    }
}
