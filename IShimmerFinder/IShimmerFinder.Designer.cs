using System.Drawing;

namespace IShimmerFinder
{
    partial class IShimmerFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IShimmerFinder));
            this.CloseButton = new System.Windows.Forms.Button();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.textGuideName = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.textJungleDirection = new System.Windows.Forms.Label();
            this.WorldSizeSmall = new System.Windows.Forms.RadioButton();
            this.WorldSizeMedium = new System.Windows.Forms.RadioButton();
            this.WorldSizeLarge = new System.Windows.Forms.RadioButton();
            this.textWorldWidth = new System.Windows.Forms.Label();
            this.ResultOutput = new System.Windows.Forms.TextBox();
            this.JunglePanel = new System.Windows.Forms.Panel();
            this.JungleDirectionRight = new System.Windows.Forms.RadioButton();
            this.JungleDirectionLeft = new System.Windows.Forms.RadioButton();
            this.WorldSizePanel = new System.Windows.Forms.Panel();
            this.textTooltip = new System.Windows.Forms.Label();
            this.Inside = new System.Windows.Forms.Panel();
            this.GuideNameInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.JunglePanel.SuspendLayout();
            this.WorldSizePanel.SuspendLayout();
            this.Inside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(655, 5);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CloseButton.Size = new System.Drawing.Size(40, 20);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.MaximizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.BackgroundImage")));
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Location = new System.Drawing.Point(630, 5);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(20, 20);
            this.MaximizeButton.TabIndex = 3;
            this.MaximizeButton.UseVisualStyleBackColor = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(605, 5);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(20, 20);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.Title.Font = new System.Drawing.Font("Consolas", 10F);
            this.Title.ForeColor = System.Drawing.Color.Orange;
            this.Title.Location = new System.Drawing.Point(34, 6);
            this.Title.Margin = new System.Windows.Forms.Padding(4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(127, 20);
            this.Title.TabIndex = 19;
            this.Title.Text = "ShimmerFinder";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // textGuideName
            // 
            this.textGuideName.AutoSize = true;
            this.textGuideName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textGuideName.Font = new System.Drawing.Font("Consolas", 12F);
            this.textGuideName.ForeColor = System.Drawing.Color.Orange;
            this.textGuideName.Location = new System.Drawing.Point(37, 44);
            this.textGuideName.Name = "textGuideName";
            this.textGuideName.Size = new System.Drawing.Size(250, 22);
            this.textGuideName.TabIndex = 1;
            this.textGuideName.Text = "Name of the first guide:";
            this.textGuideName.MouseHover += new System.EventHandler(this.Text_Hover);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.DoneButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DoneButton.BackgroundImage")));
            this.DoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.DoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(30)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Location = new System.Drawing.Point(626, 371);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(5);
            this.DoneButton.MaximumSize = new System.Drawing.Size(60, 20);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(60, 20);
            this.DoneButton.TabIndex = 5;
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // textJungleDirection
            // 
            this.textJungleDirection.AutoSize = true;
            this.textJungleDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textJungleDirection.Font = new System.Drawing.Font("Consolas", 11F);
            this.textJungleDirection.ForeColor = System.Drawing.Color.Orange;
            this.textJungleDirection.Location = new System.Drawing.Point(37, 105);
            this.textJungleDirection.Name = "textJungleDirection";
            this.textJungleDirection.Size = new System.Drawing.Size(306, 20);
            this.textJungleDirection.TabIndex = 7;
            this.textJungleDirection.Text = "Which side is located the jungle?";
            this.textJungleDirection.MouseHover += new System.EventHandler(this.Text_Hover);
            // 
            // WorldSizeSmall
            // 
            this.WorldSizeSmall.AutoSize = true;
            this.WorldSizeSmall.FlatAppearance.BorderSize = 0;
            this.WorldSizeSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorldSizeSmall.Font = new System.Drawing.Font("Consolas", 10F);
            this.WorldSizeSmall.ForeColor = System.Drawing.Color.Orange;
            this.WorldSizeSmall.Location = new System.Drawing.Point(0, -1);
            this.WorldSizeSmall.Name = "WorldSizeSmall";
            this.WorldSizeSmall.Size = new System.Drawing.Size(66, 22);
            this.WorldSizeSmall.TabIndex = 10;
            this.WorldSizeSmall.TabStop = true;
            this.WorldSizeSmall.Tag = "WorldSize";
            this.WorldSizeSmall.Text = "small";
            this.WorldSizeSmall.UseVisualStyleBackColor = true;
            this.WorldSizeSmall.CheckedChanged += new System.EventHandler(this.WorldSizeSmall_CheckedChanged);
            // 
            // WorldSizeMedium
            // 
            this.WorldSizeMedium.AutoSize = true;
            this.WorldSizeMedium.FlatAppearance.BorderSize = 0;
            this.WorldSizeMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorldSizeMedium.Font = new System.Drawing.Font("Consolas", 10F);
            this.WorldSizeMedium.ForeColor = System.Drawing.Color.Orange;
            this.WorldSizeMedium.Location = new System.Drawing.Point(78, -1);
            this.WorldSizeMedium.Name = "WorldSizeMedium";
            this.WorldSizeMedium.Size = new System.Drawing.Size(74, 22);
            this.WorldSizeMedium.TabIndex = 11;
            this.WorldSizeMedium.TabStop = true;
            this.WorldSizeMedium.Tag = "WorldSize";
            this.WorldSizeMedium.Text = "medium";
            this.WorldSizeMedium.UseVisualStyleBackColor = true;
            this.WorldSizeMedium.CheckedChanged += new System.EventHandler(this.WorldSizeMedium_CheckedChanged);
            // 
            // WorldSizeLarge
            // 
            this.WorldSizeLarge.AutoSize = true;
            this.WorldSizeLarge.FlatAppearance.BorderSize = 0;
            this.WorldSizeLarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorldSizeLarge.Font = new System.Drawing.Font("Consolas", 10F);
            this.WorldSizeLarge.ForeColor = System.Drawing.Color.Orange;
            this.WorldSizeLarge.Location = new System.Drawing.Point(165, -1);
            this.WorldSizeLarge.Name = "WorldSizeLarge";
            this.WorldSizeLarge.Size = new System.Drawing.Size(66, 22);
            this.WorldSizeLarge.TabIndex = 12;
            this.WorldSizeLarge.TabStop = true;
            this.WorldSizeLarge.Text = "large";
            this.WorldSizeLarge.UseVisualStyleBackColor = true;
            this.WorldSizeLarge.CheckedChanged += new System.EventHandler(this.WorldSizeLarge_CheckedChanged);
            // 
            // textWorldWidth
            // 
            this.textWorldWidth.AutoSize = true;
            this.textWorldWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textWorldWidth.Font = new System.Drawing.Font("Consolas", 11F);
            this.textWorldWidth.ForeColor = System.Drawing.Color.Orange;
            this.textWorldWidth.Location = new System.Drawing.Point(37, 165);
            this.textWorldWidth.Name = "textWorldWidth";
            this.textWorldWidth.Size = new System.Drawing.Size(288, 20);
            this.textWorldWidth.TabIndex = 13;
            this.textWorldWidth.Text = "What is the size of your world?";
            this.textWorldWidth.MouseHover += new System.EventHandler(this.Text_Hover);
            // 
            // ResultOutput
            // 
            this.ResultOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.ResultOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.ResultOutput.ForeColor = System.Drawing.Color.Orange;
            this.ResultOutput.Location = new System.Drawing.Point(41, 225);
            this.ResultOutput.MaxLength = 128;
            this.ResultOutput.Multiline = true;
            this.ResultOutput.Name = "ResultOutput";
            this.ResultOutput.ReadOnly = true;
            this.ResultOutput.Size = new System.Drawing.Size(579, 31);
            this.ResultOutput.TabIndex = 14;
            this.ResultOutput.Tag = "WorldSize";
            this.ResultOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JunglePanel
            // 
            this.JunglePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.JunglePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.JunglePanel.Controls.Add(this.JungleDirectionRight);
            this.JunglePanel.Controls.Add(this.JungleDirectionLeft);
            this.JunglePanel.Location = new System.Drawing.Point(383, 105);
            this.JunglePanel.Name = "JunglePanel";
            this.JunglePanel.Size = new System.Drawing.Size(237, 24);
            this.JunglePanel.TabIndex = 16;
            // 
            // JungleDirectionRight
            // 
            this.JungleDirectionRight.AutoSize = true;
            this.JungleDirectionRight.FlatAppearance.BorderSize = 0;
            this.JungleDirectionRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JungleDirectionRight.Font = new System.Drawing.Font("Consolas", 10F);
            this.JungleDirectionRight.ForeColor = System.Drawing.Color.Orange;
            this.JungleDirectionRight.Location = new System.Drawing.Point(121, -1);
            this.JungleDirectionRight.Margin = new System.Windows.Forms.Padding(0);
            this.JungleDirectionRight.Name = "JungleDirectionRight";
            this.JungleDirectionRight.Size = new System.Drawing.Size(66, 22);
            this.JungleDirectionRight.TabIndex = 9;
            this.JungleDirectionRight.TabStop = true;
            this.JungleDirectionRight.Tag = "JungleDirection";
            this.JungleDirectionRight.Text = "right";
            this.JungleDirectionRight.UseVisualStyleBackColor = true;
            this.JungleDirectionRight.CheckedChanged += new System.EventHandler(this.JungleDirectionRight_CheckedChanged);
            // 
            // JungleDirectionLeft
            // 
            this.JungleDirectionLeft.AutoSize = true;
            this.JungleDirectionLeft.FlatAppearance.BorderSize = 0;
            this.JungleDirectionLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JungleDirectionLeft.Font = new System.Drawing.Font("Consolas", 10F);
            this.JungleDirectionLeft.ForeColor = System.Drawing.Color.Orange;
            this.JungleDirectionLeft.Location = new System.Drawing.Point(38, -1);
            this.JungleDirectionLeft.Name = "JungleDirectionLeft";
            this.JungleDirectionLeft.Size = new System.Drawing.Size(58, 22);
            this.JungleDirectionLeft.TabIndex = 8;
            this.JungleDirectionLeft.TabStop = true;
            this.JungleDirectionLeft.Tag = "JungleDirection";
            this.JungleDirectionLeft.Text = "left";
            this.JungleDirectionLeft.UseVisualStyleBackColor = true;
            this.JungleDirectionLeft.CheckedChanged += new System.EventHandler(this.JungleDirectionLeft_CheckedChanged);
            // 
            // WorldSizePanel
            // 
            this.WorldSizePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.WorldSizePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WorldSizePanel.Controls.Add(this.WorldSizeSmall);
            this.WorldSizePanel.Controls.Add(this.WorldSizeMedium);
            this.WorldSizePanel.Controls.Add(this.WorldSizeLarge);
            this.WorldSizePanel.Location = new System.Drawing.Point(383, 165);
            this.WorldSizePanel.Name = "WorldSizePanel";
            this.WorldSizePanel.Size = new System.Drawing.Size(237, 24);
            this.WorldSizePanel.TabIndex = 17;
            // 
            // textTooltip
            // 
            this.textTooltip.AutoSize = true;
            this.textTooltip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textTooltip.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic);
            this.textTooltip.ForeColor = System.Drawing.Color.Orange;
            this.textTooltip.Location = new System.Drawing.Point(12, 373);
            this.textTooltip.Name = "textTooltip";
            this.textTooltip.Size = new System.Drawing.Size(384, 18);
            this.textTooltip.TabIndex = 18;
            this.textTooltip.Text = "hover the mouse on the text to show useful tips";
            // 
            // Inside
            // 
            this.Inside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.Inside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inside.Controls.Add(this.GuideNameInput);
            this.Inside.Controls.Add(this.textGuideName);
            this.Inside.Controls.Add(this.textJungleDirection);
            this.Inside.Controls.Add(this.textWorldWidth);
            this.Inside.Controls.Add(this.JunglePanel);
            this.Inside.Controls.Add(this.WorldSizePanel);
            this.Inside.Controls.Add(this.ResultOutput);
            this.Inside.Font = new System.Drawing.Font("Consolas", 12F);
            this.Inside.Location = new System.Drawing.Point(14, 45);
            this.Inside.Margin = new System.Windows.Forms.Padding(5);
            this.Inside.Name = "Inside";
            this.Inside.Size = new System.Drawing.Size(672, 305);
            this.Inside.TabIndex = 19;
            this.Inside.Paint += new System.Windows.Forms.PaintEventHandler(this.Inside_Paint);
            // 
            // GuideNameInput
            // 
            this.GuideNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.GuideNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GuideNameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.GuideNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GuideNameInput.Font = new System.Drawing.Font("Consolas", 10F);
            this.GuideNameInput.ForeColor = System.Drawing.Color.Orange;
            this.GuideNameInput.Location = new System.Drawing.Point(383, 48);
            this.GuideNameInput.MaxLength = 16;
            this.GuideNameInput.Name = "GuideNameInput";
            this.GuideNameInput.Size = new System.Drawing.Size(237, 18);
            this.GuideNameInput.TabIndex = 20;
            this.GuideNameInput.Tag = "WorldSize";
            this.GuideNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.MaximizeButton);
            this.Header.Controls.Add(this.CloseButton);
            this.Header.Controls.Add(this.Title);
            this.Header.Controls.Add(this.MinimizeButton);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(700, 30);
            this.Header.TabIndex = 20;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // IShimmerFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Inside);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.textTooltip);
            this.Font = new System.Drawing.Font("Consolas", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IShimmerFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shimmer Finder";
            this.Load += new System.EventHandler(this.IShimmerFinder_Load);
            this.JunglePanel.ResumeLayout(false);
            this.JunglePanel.PerformLayout();
            this.WorldSizePanel.ResumeLayout(false);
            this.WorldSizePanel.PerformLayout();
            this.Inside.ResumeLayout(false);
            this.Inside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label textGuideName;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label textJungleDirection;
        private System.Windows.Forms.RadioButton WorldSizeSmall;
        private System.Windows.Forms.RadioButton WorldSizeMedium;
        private System.Windows.Forms.RadioButton WorldSizeLarge;
        private System.Windows.Forms.Label textWorldWidth;
        private System.Windows.Forms.TextBox ResultOutput;
        private System.Windows.Forms.Panel JunglePanel;
        private System.Windows.Forms.RadioButton JungleDirectionRight;
        private System.Windows.Forms.RadioButton JungleDirectionLeft;
        private System.Windows.Forms.Panel WorldSizePanel;
        private System.Windows.Forms.Label textTooltip;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Inside;
        private System.Windows.Forms.TextBox GuideNameInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Header;
    }
}

