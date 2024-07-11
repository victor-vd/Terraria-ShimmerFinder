using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Reflection.Emit;

namespace IShimmerFinder
{
    public partial class IShimmerFinder : Form
    {
    int toolTipCount;
        // Message box text
        string textMessageInput;
        // Jungle is headed to de left ow right 
        // (opposite direction of the snow biome and the dungeon)
        String jungleDirection;
        // World size
        String worldWidth;
        // Guide name treatment
        String guideName;
        float guideCode;
        // Result
        float horizontalValue = 0;

        public IShimmerFinder()
        {
            InitializeComponent();
        }
        private void IShimmerFinder_Load(object sender, EventArgs e)
        {
        }
        private void Inside_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.Inside.ClientRectangle, Color.DarkOrange, ButtonBorderStyle.Solid);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr one, int two, int three, int four);
        // Make the windows movable
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /*
         * Uncomment this and the line 93 in "IShimmer.Designer.cs" 
         * to make the maximize button work
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        */
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Get all the data from the inputs of the user
        // calculates, and send to the textbox output
        private void DoneButton_Click(object sender, EventArgs e)
        {
            guideName = GuideNameInput.Text;
            // Converts the guide name into the code of that name
            guideCode = Dictionary(guideName);
            if (!(guideCode == 404 || jungleDirection == "" || worldWidth == ""))
            {
                // Calculates the horizontal coordinates of the aether
                switch (worldWidth)
                {
                    case "small":
                        if (jungleDirection == "west")
                        {
                            horizontalValue = 3800 - ((3800 - 3276) * guideCode);
                        }
                        else
                        {
                            horizontalValue = 3276 + ((3800 - 3276) * guideCode);
                        }
                        break;
                    case "medium":
                        if (jungleDirection == "west")
                        {
                            horizontalValue = 6000 - ((6000 - 4992) * guideCode);
                        }
                        else
                        {
                            horizontalValue = 4992 + ((6000 - 4992) * guideCode);
                        }
                        break;
                    case "large":
                        if (jungleDirection == "west")
                        {
                            horizontalValue = 8000 - ((8000 - 6552) * guideCode);
                        }
                        else
                        {
                            horizontalValue = 6552 + ((8000 - 6552) * guideCode);
                        }
                        break;
                }
            }
            // If the horizontal value don't recieve any information
            // the program clears the inputs and show an error window
            if (horizontalValue == 0)
            {
                textMessageInput = "FATAL ERROR 001:\r\nInvalid Input";
                IMessage message = new IMessage(textMessageInput);
                message.Show();
                ResultOutput.Text = "";
            } 
            else
            {
                //Result
                ResultOutputSetter();
            }
            // Either of the below will clear the checked state
            JunglePanel.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            WorldSizePanel.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            GuideNameInput.Clear();
        }
        public void ResultOutputSetter()
        {
            // Result and input clear
            ResultOutput.Text = "Dig somewhere around " + horizontalValue + " " + jungleDirection + " and at some point you'll find the Aether";
            guideName = "";
            guideCode = 0;
            horizontalValue = 0;
        }
        // Convert the guide name to a valid code
        // Or return error
        static public float Dictionary(String a)
        {
            Dictionary<string, float> names = new Dictionary<string, float>
            {
                {"joe", 0.0000F},
                {"connor", 0.0278F},
                {"tanner", 0.0556F},
                {"wyatt", 0.0833F},
                {"levi", 0.1389F},
                {"luke", 0.1667F},
                {"jack", 0.1944F},
                {"scott", 0.2222F},
                {"logan", 0.2500F},
                {"cole", 0.2778F},
                {"asher", 0.3056F},
                {"bradley", 0.3333F},
                {"jacob", 0.3611F},
                {"garrett", 0.3889F},
                {"dylan", 0.4167F},
                {"maxwell", 0.4444F},
                {"steve", 0.4722F},
                {"brett", 0.5000F},
                {"andrew", 0.5278F},
                {"harley", 0.5556F},
                {"kyle", 0.5833F},
                {"jake", 0.6111F},
                {"ryan", 0.6389F},
                {"jeffrey", 0.6667F},
                {"seth", 0.6944F},
                {"marty", 0.7222F},
                {"brandon", 0.7500F},
                {"zach", 0.7778F},
                {"jeff", 0.8056F},
                {"daniel", 0.8333F},
                {"trent", 0.8611F},
                {"kevin", 0.8889F},
                {"brian", 0.9167F},
                {"colin", 0.9444F},
                {"jan", 0.9722F}
            };
            float b = 404;
            if (names.TryGetValue(a, out b))
            {
                return b;
            }
            else
            {
                return 404;
            }
        }
        private void Text_Hover(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.OwnerDraw = true;
            toolTip1.BackColor = System.Drawing.Color.FromArgb(50, 50, 100);
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 300;
            toolTip1.ReshowDelay = 5000;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            // Also, it only set one time. If don't, a pop-up would
            // overwrite the other and it would be a huge mess
            if (toolTipCount==0)
            {
                toolTipCount++;
                toolTip1.SetToolTip(this.textGuideName, "Create a new world with \nthe same seed of yours, then \nsee the name of the guide");
                toolTip1.SetToolTip(this.textJungleDirection, "The jungle is located in \nthe opposite way of the \nsnow biome and the dungeon");
                toolTip1.SetToolTip(this.textWorldWidth, "Man, please, just read \nyour world's size!");
            }
            toolTip1.Popup += (ss, ee) => { ee.ToolTipSize = new Size(260, 80); };
            toolTip1.Draw += (ss, ee) =>
            {
                ee.DrawBackground();
                ee.Graphics.DrawString("        A TINY HELP!        ", Font, Brushes.Orange, 1, 1);
                ee.Graphics.DrawString(ee.ToolTipText, Font, Brushes.Orange, 1, 22);
            };
        }
        private void WorldSizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            worldWidth = "small";
        }
        private void WorldSizeMedium_CheckedChanged(object sender, EventArgs e)
        {
            worldWidth = "medium";
        }
        private void WorldSizeLarge_CheckedChanged(object sender, EventArgs e)
        {
            worldWidth = "large";
        }
        private void JungleDirectionLeft_CheckedChanged(object sender, EventArgs e)
        {
            jungleDirection = "west";
        }
        private void JungleDirectionRight_CheckedChanged(object sender, EventArgs e)
        {
            jungleDirection = "east";
        }
    }
}