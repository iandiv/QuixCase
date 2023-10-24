using Microsoft.Win32;
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
using WinBlur;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuixCase
{

    public partial class Form1 : Form
    {

        private Dictionary<Keys, string> specialCharacterMapping = new Dictionary<Keys, string>
{
    { Keys.OemSemicolon, ";" },
    { Keys.OemQuotes, "'" },
    { Keys.OemOpenBrackets, "[" },
    { Keys.OemCloseBrackets, "]" },
    { Keys.OemPipe, "\\" },
    { Keys.OemQuestion, "/" },
    { Keys.OemMinus, "-" },
    { Keys.Oemplus, "=" },
    { Keys.Oemcomma, "," },
    { Keys.OemPeriod, "." },
    { Keys.Oemtilde, "`" },
    // Add more special characters as needed
};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           UI.SetBlurStyle(cntrl: this, blurType: UI.BlurType.Mica, designMode: UI.Mode.DarkMode);
            if (IsStartupEnabled("QuixCase"))
            {
                switchButton1.Checked = true;
            }
            hotkey.Text = PlainText("config.ini");
            if (System.IO.File.Exists("Quix.exe"))
            {
                Process.Start("Quix.exe");
            }
            else
            {
                MessageBox.Show("Executable file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKeys = e.Modifiers;
            Keys pressedKey = e.KeyCode;

            string shortcutText = "";

            if (modifierKeys.HasFlag(Keys.Control))
            {

                shortcutText += "Ctrl+";

            }

            if (modifierKeys.HasFlag(Keys.Alt))
            {

                shortcutText += "Alt+";
            }

            if (modifierKeys.HasFlag(Keys.Shift))
            {

                shortcutText += "Shift+";
            }

            if (pressedKey == Keys.CapsLock)
            {
                shortcutText += "Capslock";

            }

            //if (pressedKey == Keys.LWin || pressedKey == Keys.RWin)
            //{
            //    shortcutText += "Win+";

            //}


            if (pressedKey >= Keys.A && pressedKey <= Keys.Z)
            {
                // Handle letters A to Z

                shortcutText += (char)pressedKey;


            }
            else if (pressedKey >= Keys.D0 && pressedKey <= Keys.D9)
            {
                // Handle numbers 0 to 9
                shortcutText += (char)pressedKey;
            }
            else if (specialCharacterMapping.ContainsKey((Keys)e.KeyValue))
            {
                // Handle special characters using the custom mapping
                shortcutText += specialCharacterMapping[(Keys)e.KeyValue];
            }
            /*  else
              {
                  // Handle special characters
                  shortcutText += pressedKey.ToString();
              }
            */
            hotkey.Text = shortcutText;
        }
        private string convertedKey(String plainText)
        {
            string convertedKey = plainText;
            convertedKey = convertedKey.Replace("Ctrl+", "^");
            convertedKey = convertedKey.Replace("Shift+", "+");
            convertedKey = convertedKey.Replace("Alt+", "!");
            return convertedKey += "::";
        }


        static string PlainText(string filePath)
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Find the first line that starts with a semicolon (;)
                string hotkeyLine = lines.FirstOrDefault(line => line.StartsWith(";"));

                if (hotkeyLine != null)
                {
                    // Remove the semicolon and any leading/trailing white spaces
                    return hotkeyLine.TrimStart(';').Trim();
                }
                else
                {
                    return null; // Return null if no matching line is found
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return null; // Return null in case of an error
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
          
        }


        private void roundPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton1_Click_1(object sender, EventArgs e)
        {
            new DialogForm(this).ShowDialog();
        }
        public void hotkeyReload()
        {
            hotkey.Text = PlainText("config.ini");
        }

        private void roundPanel2_Paint_1(object sender, PaintEventArgs e)
        {
          
        }

        private void roundPanel2_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void switchButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            SetStartup("QuixCase",switchButton1.Checked);
        }
        private bool IsStartupEnabled(string name)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                return key.GetValue(name) != null;
            }
        }

        private void SetStartup(string name,bool enabled)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                if (enabled)
                {
                    string executableDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    string secondaryExecutablePath = Path.Combine(executableDirectory, "Quix.exe");

                    key.SetValue(name, secondaryExecutablePath);
                }
                else
                {
                    key.DeleteValue(name, false);
                }
            }
        }
    }
   
}
