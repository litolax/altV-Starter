using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace altVStarter
{
    public partial class Form1 : Form
    {
        public record LastConfig(int Branch, int Debug, int NoUpdate)
        {
            public int Branch { get; } = Branch;
            public int Debug { get; } = Debug;
            public int NoUpdate { get; } = NoUpdate;
        }

        #region Constructors

        readonly Color originalColor;

        private static readonly Dictionary<int, string> BranchNames = new Dictionary<int, string>()
        {
            {0, "branch: 'release'"},
            {1, "branch: 'rc'"},
            {2, "branch: 'dev'"}
        };

        public Form1()
        {
            this.InitializeComponent();
            originalColor = this.startButton.ForeColor;
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DisplayBranches();
            this.DisplayDebug();
            this.DisplayNoUpdate();

            var file = new FileInfo("./last.json");
            if (file.Exists)
            {
                var fileData = File.ReadAllText(file.FullName);
                var data = JsonSerializer.Deserialize<LastConfig>(fileData);
                this.branchListBox.SetSelected(data?.Branch ?? 0, true);
                this.debugListBox.SetSelected(data?.Debug ?? 0, true);
                this.noUpdateListBox.SetSelected(data?.NoUpdate ?? 0, true);
            }
        }

        #endregion

        #region Methods

        private void DisplayBranches()
        {
            Field[] fieldsChoices =
            {
                new Field("Release"),
                new Field("Release Candidate"),
                new Field("Development")
            };
            this.branchListBox.DataSource = fieldsChoices;
            this.branchListBox.DisplayMember = "Name";
        }

        private void DisplayDebug()
        {
            Field[] fieldsChoices =
            {
                new Field("False"),
                new Field("True"),
            };

            this.debugListBox.DataSource = fieldsChoices;
        }

        private void DisplayNoUpdate()
        {
            Field[] fieldsChoices =
            {
                new Field("False"),
                new Field("True"),
            };

            this.noUpdateListBox.DataSource = fieldsChoices;
        }

        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.StartAltV();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.StartAltV();
        }

        private void StartAltV()
        {
            var config = new Config<MainConfig>();

            this.ButtonAnimation();

            var branchConfiguration = BranchNames[this.branchListBox.SelectedIndex];
            var debugConfiguration = this.debugListBox.SelectedIndex == 1 ? "debug: true" : "debug: false";
            var noUpdateConfiguration = this.noUpdateListBox.SelectedIndex == 1;

            List<string> lines = File.ReadAllLines($"{config.Entries.AltVDirectory}/altv.cfg").ToList();
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                if (lines[i].Contains("debug:") || lines[i].Contains("branch:")) lines.RemoveAt(i);
            }

            File.WriteAllText($"{config.Entries.AltVDirectory}/altv.cfg", string.Empty);
            File.WriteAllLines($"{config.Entries.AltVDirectory}/altv.cfg", lines);
            File.AppendAllText($"{config.Entries.AltVDirectory}/altv.cfg",
                branchConfiguration + "\n" + debugConfiguration);

            var lastConfig = JsonSerializer.Serialize(new LastConfig(this.branchListBox.SelectedIndex,
                this.debugListBox.SelectedIndex,
                this.noUpdateListBox.SelectedIndex));

            File.WriteAllText("./last.json", lastConfig);


            var processStartInfo = noUpdateConfiguration
                ? new ProcessStartInfo($"{config.Entries.AltVDirectory}/altv.exe", "-noupdate")
                : new ProcessStartInfo($"{config.Entries.AltVDirectory}/altv.exe");
            processStartInfo.WorkingDirectory = config.Entries.AltVDirectory;
            Process.Start(processStartInfo);
            Application.Exit();
        }

        private void ButtonAnimation()
        {
            DateTime start = DateTime.Now;
            TimeSpan duration = TimeSpan.FromSeconds(1);
            TimeSpan interpolation;
            Color a = this.startButton.ForeColor;
            Color b = a != originalColor
                ? originalColor
                : this.startButton.Parent.BackColor;
            while ((interpolation = DateTime.Now - start) < duration)
            {
                double ratio = interpolation.TotalSeconds / duration.TotalSeconds;
                double alpha = a.A - ((a.A - b.A) * ratio);
                double red = a.R - ((a.R - b.R) * ratio);
                double green = a.G - ((a.G - b.G) * ratio);
                double blue = a.B - ((a.B - b.B) * ratio);
                this.startButton.ForeColor = Color.FromArgb((byte) alpha, (byte) red, (byte) green, (byte) blue);
                this.startButton.Refresh();
            }

            this.startButton.ForeColor = b;
        }

        private void OnHelpButtonClicked(object sender, CancelEventArgs e)
        {
            Process.Start("https://github.com/litolax/altV-Starter");
        }
    }
}