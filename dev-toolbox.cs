using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace dev_toolbox
{
    public partial class Toolbox : Form
    {
        /**
         * The use of the Environment.UserName variable pigeonholes this program to run only on
         * and account that the username matches the user folder; an account that has never had
         * the account name changed. Since I've written this for myself that is not a problem.
         */
        public Toolbox()
        {
            InitializeComponent();
        }

        // Get personal variables/settings
        static dynamic personal = JsonConvert.DeserializeObject(File.ReadAllText("script\\private.json"));

        // Splash message, written to console on init. Available via 'splash' command as well
        static String versionNumber = Application.ProductVersion;
        String consoleSplash = "\n"
            + "zajrikDEV Toolbox // version " + versionNumber + "\n\n"
            + "Click a button to launch the associated script or activitry.\n"
            + "Script output will be displayed in this console.\n\n"
            + "Enter \"help\" for a list of valid commands.";

        // Init executions
        private void Toolbox_Load(object sender, EventArgs e)
        {
            consoleBox.ReadOnly = false;
            consoleBox.DetectUrls = false;
            consoleWrite(consoleSplash);
            cmdPrompt();
        }

        // Focus console on hover to allow mouse-wheel scrolling without clicking console first
        private void consoleHover(object sender, EventArgs e)
        {
            consoleBox.Focus();
        }

        // Begin command prompt
        private void cmdPrompt()
        {
            consoleBox.ScrollToCaret();
            consoleBox.AppendText("\n" + "$ ");
            consoleBox.Focus();
        }

        // Handle command following proper prompt caret ( $ )
        private void consoleBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {   
                try
                {
                    switch (consoleBox.Lines.Last())
                    // Valid commands
                    {
                        case "$ clear":
                            consoleBox.Text = "";
                            break;
                        case "$ splash":
                            consoleBox.Text = "";
                            consoleWrite(consoleSplash);
                            break;
                        case "$ help":
                            String help = "\n\n"
                                + "Commands:\n"
                                + "    help    :  Display this help message\n"
                                + "    clear   :  Clear console\n"
                                + "    splash  :  Clear console & display console startup msg\n"
                                + "    exit    :  Exit the application\n\n"
                                + "If you lose the command prompt and a new one is not given,\n"
                                + "you can begin your own on a new line with \"$\" and a space: \n"
                                + "\"$ <command>\"";
                            consoleWrite(help);
                            break;
                        case "$ exit":
                            Application.Exit();
                            break;
                        case "$ ":
                            // Do nothing, new command prompt will be given
                            break;
                        case "":
                            cmdPrompt();
                            break;
                        default:
                            String err = "\n"
                                + "Invalid command or prompt was missing. Enter \"help\" for a list of valid commands";
                            consoleBox.AppendText(err);
                            break;
                    }
                    cmdPrompt();
                    e.Handled = true;
                }
                catch
                {   
                    cmdPrompt();
                    e.Handled = true;
                }
            }
            // Prevent backspace over prompt caret. Not the most graceful of implementations.
            // Might end up splitting command entry to a separate box that will allow for easier
            // control of input to better simulate an actual command line, but I do like it better
            // as one box.
            if (e.KeyData == Keys.Back)
            {
                try
                {
                    if (consoleBox.Lines.Last() == "$ ")
                    {
                        e.Handled = true;
                    }
                }
                catch
                {
                    cmdPrompt();
                    e.Handled = true;
                }
            }
        }

        // Write a line to the console, optionally followed by command prompt
        private void consoleWrite(String text, Boolean doPrompt = false)
        {
            consoleBox.AppendText(text + "\n");
            consoleBox.ScrollToCaret();
            if (doPrompt) { cmdPrompt(); }
        }

        // Runs the provided script in the console box, followed by command prompt by default
        private void consoleRun(String script, Boolean doPrompt = true, List<string> args = null)
        {
            consoleBox.Text = "";
            ProcessStartInfo consoleStartInfo = new ProcessStartInfo()
            {
                FileName = script,
                Arguments = (args == null) ? "" : String.Join(" ", args),
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            Process console = new Process();
            console.StartInfo = consoleStartInfo;
            console.Start();

            StreamReader readerStdOut = console.StandardOutput;
            while (!readerStdOut.EndOfStream)
            {
                String output = readerStdOut.ReadLine();
                consoleWrite(output);
            }
            if (doPrompt) { cmdPrompt(); }
        }

        // Protected click dialog, prevents accidental execution of protected scripts
        // Supported types (String): repoSync, releaseSync
        private Boolean protectedClick(String type)
        {
            consoleWrite("\nPROTECTED ACTION -- Check dialog for more info");
            Boolean isAllowed = false;
            switch (type)
            {
                case "repoSync":
                    DialogResult repoSync = MessageBox.Show
                        ( "Are you sure you want to resync from repo?\n"
                        + "This will replace all local files with those from repo,\n"
                        + "any undo/redo history will be lost.", "Protected action",
                        MessageBoxButtons.YesNo);
                    if (repoSync == DialogResult.Yes) { isAllowed = true; }
                    break;
                case "releaseSync":
                    DialogResult releaseSync = MessageBox.Show
                        ( "Did you remember to format the newest release filename?\n"
                        + "If not, do this before pushing release to server", "Reminder",
                        MessageBoxButtons.YesNo);
                    if (releaseSync == DialogResult.Yes) { isAllowed = true; }
                    break;
                default:
                    MessageBox.Show
                        ( "protectedClick() requires valid string type,\n"
                        + "String type \"" + type + "\" is not valid.\n"
                        + "Plrease check supported types list.", "Alert", MessageBoxButtons.OK);
                    break;
            }
            if (!isAllowed) { consoleWrite("PROTECTED ACTION CANCELLED."); }
            cmdPrompt();
            return isAllowed;
        }

        // Restart function for Ruby on Rails apps. Uses a crude cmd approximation of the
        // Unix "touch" command to update the Date Modified of the restart file to which
        // changes are detected by Rails to restart Rails apps.
        private void restartRailsApp(String script)
        {
            consoleRun(script, false);
            Boolean restartSuccess = false;
            // Save console output, clear console, and reconstruct output line by line to restructure success/
            // failure message. Couldn't manage a proper success/failure message while removing the "# file(s)
            // copied." from within touch.cmd itself so this was the best solution I could come up with.
            String[] output = consoleBox.Lines;
            consoleBox.Text = "";
            foreach (String line in output)
            {
                if (line.Contains("1 file(s)"))
                {
                    restartSuccess = true;
                    continue;
                }
                else if (line.Contains("0 file(s)"))
                {
                    consoleBox.Text += ( "Failed to interact with restart file, "
                                       + "likely due to insufficient permissions.\n");
                    continue;
                }
                else if (line.Contains("cannot find the file"))
                {
                    consoleBox.Text += ( "Restart file does not exist. Please create it "
                                       + "and try again.\n");
                    continue;
                }
                // Replace batch echo "blankline" string literal with an actual blank line
                if (line.Contains("blankline"))
                {
                    consoleBox.Text += "\n";
                    continue;
                }
                if (line.Equals(""))
                {
                    continue;
                }
                consoleBox.Text += (line + "\n");
            }
            if (restartSuccess)
            {
                consoleWrite("Restart was successful.", true);
            }
            else
            {
                consoleWrite("Restart was unsuccessful.", true);
            }
        }

        //// ZajrikSRV mobile script buttons
        private void androidToGit(object sender, EventArgs e)
        {
            consoleRun("script\\sync-android-to-git.bat");
        }

        private void projectToGit(object sender, EventArgs e)
        {
            consoleRun("script\\sync-project-to-git.bat");
        }

        private void webToGit(object sender, EventArgs e)
        {
            consoleRun("script\\sync-web-to-git.bat");
        }

        private void updateReleaseJSON(object sender, EventArgs e)
        {
            consoleRun("script\\release_update.bat");
        }

        //// Todo-app Ruby backend script buttons
        private void restartTodo(object sender, EventArgs e)
        {
            restartRailsApp("script\\restart-todo.bat");
        }

        //// Rift Timer script buttons
        private void updateVersion(object sender, EventArgs e)
        {
            UpdateDialog updateDialog = new UpdateDialog();

            updateDialog.StartPosition = FormStartPosition.CenterParent;
            updateDialog.ShowDialog();

            if (updateDialog.DialogResult == DialogResult.OK)
            {
                List<string> args = new List<string>{updateDialog.updateResult};
                consoleRun("script\\update-rift-timer-version.bat", true, args);
                updateDialog.Dispose();
            }
            else
            {
                consoleWrite("\nRelease version update cancelled.", true);
                updateDialog.Dispose();
            }
        }

        private void packageRelease(object sender, EventArgs e)
        {
            UpdateDialog releaseDialog = new UpdateDialog("Enter package version:", "Create package");

            releaseDialog.StartPosition = FormStartPosition.CenterParent;
            releaseDialog.ShowDialog();

            if (releaseDialog.DialogResult == DialogResult.OK)
            {
                string[] releaseResultExplode = releaseDialog.updateResult.Split('.');
                List<string> args = new List<string>();
                for (int i = 0; i < releaseResultExplode.Length; i++)
                {
                    args.Add(releaseResultExplode[i]);
                }
                consoleRun("script\\create-rift-timer-release.bat", true, args);
            }
            else
            {
                consoleWrite("\nUpdate package creation cancelled.", true);
                releaseDialog.Dispose();
            }
        }

        //// Utility buttons
        private void launchParse(object sender, EventArgs e)
        {
            ProcessStartInfo parse = new ProcessStartInfo()
            {
                FileName = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Google\\Chrome\\Application\\Chrome.exe",
                Arguments = personal["parseArgs"]
            };
            Process.Start(parse);
        }

        private void gitShell(object sender, EventArgs e)
        {
            ProcessStartInfo gitShell = new ProcessStartInfo()
            {
                FileName = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\GitHub\\GitHub.appref-ms",
                Arguments = "--open-shell"
            };
            Process.Start(gitShell);
        }

        private void gitApp(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\GitHub\\GitHub.appref-ms");
        }

        private void dbAdmin(object sender, EventArgs e)
        {
            ProcessStartInfo pma = new ProcessStartInfo()
            {
                FileName = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Google\\Chrome\\Application\\chrome.exe",
                Arguments = personal["dbAdminArgs"]
            };
            Process.Start(pma);
        }

        private void serverStatus(object sender, EventArgs e)
        {
            consoleRun("script\\server-status.bat");
        }
        //// End utilities

        //// Protected scripts, prompts via protectedClick dialog
        // ZajrikSRV mobile protected scripts
        private void repoPullAndroid(object sender, EventArgs e)
        {
            if (protectedClick("repoSync"))
            {
                consoleRun("script\\sync-git-to-android.bat");
            }
        }

        private void repoPullWeb(object sender, EventArgs e)
        {
            if (protectedClick("repoSync"))
            {
                consoleRun("script\\sync-git-to-web.bat");
            }
        }

        private void syncAppRelease(object sender, EventArgs e)
        {
            if (protectedClick("releaseSync"))
            {
                consoleRun("script\\sync-release-to-server.bat");
            }
        }
        //// End protected scripts
    }
}
