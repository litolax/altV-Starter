using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace altVStarter
{
    public partial class Form1 : Form
    {
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
            originalColor = startLabel.ForeColor;
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DisplayBranches();
            this.DisplayDebug();
            this.DisplayNoUpdate();
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

            this.updateListBox.DataSource = fieldsChoices;
        }

        #endregion

        private void label4_Click(object sender, EventArgs e)
        {
            var config = new Config<MainConfig>();

            this.ButtonAnimation();

            var branchConfiguration = BranchNames[this.branchListBox.SelectedIndex];
            var debugConfiguration = this.debugListBox.SelectedIndex == 1 ? "debug: true" : "debug: false";
            var noUpdateConfiguration = this.updateListBox.SelectedIndex == 1;

            List<string> lines = File.ReadAllLines($"{config.Entries.AltVDirectory}/altv.cfg").ToList();
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                if (lines[i].Contains("debug:") || lines[i].Contains("branch:")) lines.RemoveAt(i);
            }

            File.WriteAllText($"{config.Entries.AltVDirectory}/altv.cfg", string.Empty);
            File.WriteAllLines($"{config.Entries.AltVDirectory}/altv.cfg", lines);
            File.AppendAllText($"{config.Entries.AltVDirectory}/altv.cfg", branchConfiguration + "\n" + debugConfiguration);

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
            Color a = startLabel.ForeColor;
            Color b = a != originalColor
                ? originalColor
                : startLabel.Parent.BackColor;
            while ((interpolation = DateTime.Now - start) < duration)
            {
                double ratio = interpolation.TotalSeconds / duration.TotalSeconds;
                double alpha = a.A - ((a.A - b.A) * ratio);
                double red = a.R - ((a.R - b.R) * ratio);
                double green = a.G - ((a.G - b.G) * ratio);
                double blue = a.B - ((a.B - b.B) * ratio);
                startLabel.ForeColor = Color.FromArgb((byte) alpha, (byte) red, (byte) green, (byte) blue);
                startLabel.Refresh();
            }

            startLabel.ForeColor = b;
        }
    }
}