using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using altVStarter.Config;
using Tomlyn;

namespace altVStarter
{
    public partial class Form1 : Form
    {
        public record LastConfig(int Branch, int Debug)
        {
            public int Branch { get; } = Branch;
            public int Debug { get; } = Debug;
        }

        #region Constructors

        readonly Color originalColor;

        private static readonly Dictionary<int, string> BranchNames = new()
        {
            { 0, "release" },
            { 1, "rc" },
            { 2, "dev" }
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
            var file = new FileInfo("./last.json");
            if (file.Exists)
            {
                var fileData = File.ReadAllText(file.FullName);
                var data = JsonSerializer.Deserialize<LastConfig>(fileData);
                this.branchListBox.SetSelected(data?.Branch ?? 0, true);
                this.debugListBox.SetSelected(data?.Debug ?? 0, true);
            }
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
            var debugConfiguration = this.debugListBox.SelectedIndex == 1;

            //
            var path = Path.Combine(config.Entries.AltVDirectory, "altv.toml");

            var model = Toml.ToModel(File.ReadAllText(path));

            model["branch"] = branchConfiguration;
            model["debug"] = debugConfiguration;

            File.WriteAllText(path, Toml.FromModel(model));
            //

            var lastConfig = JsonSerializer.Serialize(new LastConfig(this.branchListBox.SelectedIndex,
                this.debugListBox.SelectedIndex));

            File.WriteAllText("./last.json", lastConfig);


            var processStartInfo = new ProcessStartInfo($"{config.Entries.AltVDirectory}/altv.exe")
            {
                WorkingDirectory = config.Entries.AltVDirectory
            };

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
                double alpha = a.A - (a.A - b.A) * ratio;
                double red = a.R - (a.R - b.R) * ratio;
                double green = a.G - (a.G - b.G) * ratio;
                double blue = a.B - (a.B - b.B) * ratio;
                this.startButton.ForeColor = Color.FromArgb((byte)alpha, (byte)red, (byte)green, (byte)blue);
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