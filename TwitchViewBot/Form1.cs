using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchViewBot
{
    public partial class MainForm : Form
    {
        // Misc
        private Random r;

        // Bots
        private LiveViewBot liveViewBot = new LiveViewBot();

        // Datasources
        List<string> viewLinks = new List<string>();
        List<string> proxies = new List<string>();
        List<string> accounts = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            r = new Random();

            // Populate Lists from files
            LoadProxiesFromFile("proxies.txt");
            LoadAccountsFromFile("accounts.txt");

            // Setup the Datasources for our lists
            LsbURLSWithTokens.DataSource = viewLinks;
            LsbProxies.DataSource = proxies;
            LsbViewProxies.DataSource = proxies;
            LsbFollowAccounts.DataSource = accounts;
        }

        private void Rebind(ListControl control, IList datasource)
        {
            // HACK: Rebinding the datasource like this is dirty, a better approach is to use the BindingSource Class [http://msdn.microsoft.com/en-us/library/system.windows.forms.bindingsource.aspx]
            // Sopme drawbacks are that you can only add 1 item at a time, since it does not expose a AddRange Method. As well as it forces the code to talk to the winforms controls directly.
            control.DataSource = null;
            control.DataSource = datasource;
        }

        private void ButtonFollowChannel_Click(object sender, EventArgs e)
        {
            foreach (string item in LsbFollowAccounts.Items)
            {
                var split = item.Split(':');
                int index = r.Next(1, LsbProxies.Items.Count - 1);

                // Pick a random Proxy, TODO: Instead of deleting the Proxy from the list add a status enum for InUse etc
                string proxy = LsbProxies.Items[index].ToString();
                LsbProxies.Items.Remove(index);
                string username = split[0];
                string password = split[1];
                string channel = TextBoxChannelToFollow.Text;

                // TODO: Run the Follow Channel Process
            }
        }

        private void ButtonIncreasePageViews_Click(object sender, EventArgs e)
        {

        }

        private void ButtonStartChatBot_Click(object sender, EventArgs e)
        {

        }


        private async void ButtonGenerateViewLinks_Click(object sender, EventArgs e)
        {
            // TODO: Figure out if you want to add the specified amount or the difference beetwen the current and the desired amount?
            // If we don't care about the current entries, we can use the BindingSource approach and always create a new BindingList using the copy constructor.
            // Will need to check if it still runs the update logic per entry in the old list.
            string[] viewLinksToAdd = await liveViewBot.GenerateViewLinksAsync(TextBoxViewChannel.Text, int.Parse(TextBoxViewAmount.Text));
            viewLinks.AddRange(viewLinksToAdd);
            Rebind(LsbURLSWithTokens, viewLinks);
        }

        private void ButtonLoadProxies_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog { Multiselect = false, CheckFileExists = true };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadProxiesFromFile(fileDialog.FileName);
            }
        }

        // TODO: Refactor the file Handling, and calling code
        private List<string> LoadFromFile(string fileName)
        {
            // Exit early if no file was selected
            var list = new List<string>();
            if (fileName == "") { return list; }

            using (var sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Kinda bad, but since File.ReadAllLines(fileName) does this too we are saving a bit of performance since we don't need to convert to array
                    list.Add(line);
                }
            }

            return list;
        }

        void LoadProxiesFromFile(string fileName)
        {
            proxies = LoadFromFile(fileName);
            Rebind(LsbProxies, proxies);
            Rebind(LsbViewProxies, proxies);
        }

        void LoadAccountsFromFile(string fileName)
        {
            accounts = LoadFromFile(fileName);
            Rebind(LsbFollowAccounts, accounts);
        }

        private void ButtonLoadAccounts_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog { Multiselect = false, CheckFileExists = true };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadAccountsFromFile(fileDialog.FileName);
            }
        }
    }
}
