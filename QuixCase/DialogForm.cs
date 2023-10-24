using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinBlur;

namespace QuixCase
{
    public partial class DialogForm : Form
    {
        private Form1 form1; // You need a reference to Form1

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
        public DialogForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void DialogForm_Load(object sender, EventArgs e)
        {
            UI.SetBlurStyle(cntrl: this, blurType: UI.BlurType.Mica, designMode: UI.Mode.DarkMode);
            hotkey.Text = PlainText("config.ini");
            KeyPreview = true;
        }

        private void negativeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void positiveBtn_Click(object sender, EventArgs e)
        {


            

          

            try
            {
                // Create or overwrite the text file and write the content from 'convertedKey'
                File.WriteAllText("config.ini", ";" + hotkey.Text + "\n" + convertedKey(hotkey.Text));
                Console.WriteLine("Text file created successfully.");


             



            }
            catch (Exception err)
            {
                Console.WriteLine("An error occurred: " + err.Message);
            }

        //    RunCommand("taskkill /F /IM Quix.exe");



            if (System.IO.File.Exists("Quix.exe"))
            {
                Process.Start("Quix.exe");
            }
            else
            {
                MessageBox.Show("Executable file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }


            form1.hotkeyReload();
           
           
            this.Close();
        }
        static void RunCommand(string command)
        {
            try
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();

                // Send the command to the Command Prompt process
                process.StandardInput.WriteLine(command);
                process.StandardInput.Flush();
                process.StandardInput.Close();

                // Read the output
                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);

                process.WaitForExit();
                process.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DialogForm_KeyDown(object sender, KeyEventArgs e)
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
            return convertedKey ;
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

        private void hotkey_Click(object sender, EventArgs e)
        {

        }
    }
}
