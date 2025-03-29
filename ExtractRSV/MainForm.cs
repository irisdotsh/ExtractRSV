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

                foreach (KeyValuePair<string, string> rsv in RSVPairs)
                {
                    ListViewItem item = new ListViewItem(new[] { rsv.Key, rsv.Value });

                    lvRSVPairs.Items.Add(item);
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
    }
}
