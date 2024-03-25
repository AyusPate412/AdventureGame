namespace AdventureGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleImage = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleImage
            // 
            this.titleImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleImage.BackgroundImage")));
            this.titleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleImage.Location = new System.Drawing.Point(16, 112);
            this.titleImage.Margin = new System.Windows.Forms.Padding(4);
            this.titleImage.Name = "titleImage";
            this.titleImage.Size = new System.Drawing.Size(615, 664);
            this.titleImage.TabIndex = 0;
            this.titleImage.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titleLabel.BackgroundImage")));
            this.titleLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.titleLabel.Location = new System.Drawing.Point(155, 26);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(802, 69);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.Location = new System.Drawing.Point(798, 334);
            this.playButton.Margin = new System.Windows.Forms.Padding(4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(124, 55);
            this.playButton.TabIndex = 2;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(101, 15);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(840, 94);
            this.outputLabel.TabIndex = 3;
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(621, 663);
            this.option1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(383, 36);
            this.option1Label.TabIndex = 4;
            this.option1Label.Text = "label1";
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(621, 607);
            this.option2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(383, 38);
            this.option2Label.TabIndex = 5;
            this.option2Label.Text = "label1";
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(155, 660);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(87, 38);
            this.option1Button.TabIndex = 6;
            this.option1Button.Text = "button1";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(155, 605);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(87, 36);
            this.option2Button.TabIndex = 7;
            this.option2Button.Text = "button1";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Image = global::AdventureGame.Properties.Resources.Designer;
            this.mainPictureBox.Location = new System.Drawing.Point(16, 112);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(627, 468);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 9;
            this.mainPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1019, 821);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.titleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox titleImage;
        private System.Windows.Forms.PictureBox titleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.PictureBox mainPictureBox;
    }
}

