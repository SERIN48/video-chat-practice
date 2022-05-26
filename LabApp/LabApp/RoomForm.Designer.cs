namespace LabApp
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CameraButton = new System.Windows.Forms.Button();
            this.AudioOnButton = new System.Windows.Forms.Button();
            this.ShareButton = new System.Windows.Forms.Button();
            this.AudioOffButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 603);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CameraButton
            // 
            this.CameraButton.BackColor = System.Drawing.Color.Transparent;
            this.CameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraButton.Font = new System.Drawing.Font("나눔바른펜", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CameraButton.Location = new System.Drawing.Point(11, 611);
            this.CameraButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CameraButton.Name = "CameraButton";
            this.CameraButton.Size = new System.Drawing.Size(75, 31);
            this.CameraButton.TabIndex = 1;
            this.CameraButton.Text = "카메라";
            this.CameraButton.UseVisualStyleBackColor = false;
            this.CameraButton.Click += new System.EventHandler(this.CameraButton_Click);
            // 
            // AudioOnButton
            // 
            this.AudioOnButton.BackColor = System.Drawing.Color.Transparent;
            this.AudioOnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AudioOnButton.Font = new System.Drawing.Font("나눔바른펜", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AudioOnButton.Location = new System.Drawing.Point(100, 611);
            this.AudioOnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AudioOnButton.Name = "AudioOnButton";
            this.AudioOnButton.Size = new System.Drawing.Size(75, 31);
            this.AudioOnButton.TabIndex = 2;
            this.AudioOnButton.Text = "오디오ON";
            this.AudioOnButton.UseVisualStyleBackColor = false;
            this.AudioOnButton.Click += new System.EventHandler(this.AudioOnButton_Click);
            // 
            // ShareButton
            // 
            this.ShareButton.BackColor = System.Drawing.Color.Transparent;
            this.ShareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShareButton.Font = new System.Drawing.Font("나눔바른펜", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShareButton.Location = new System.Drawing.Point(277, 611);
            this.ShareButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShareButton.Name = "ShareButton";
            this.ShareButton.Size = new System.Drawing.Size(75, 31);
            this.ShareButton.TabIndex = 3;
            this.ShareButton.Text = "화면공유";
            this.ShareButton.UseVisualStyleBackColor = false;
            this.ShareButton.Click += new System.EventHandler(this.ShareButton_Click);
            // 
            // AudioOffButton
            // 
            this.AudioOffButton.BackColor = System.Drawing.Color.Transparent;
            this.AudioOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AudioOffButton.Font = new System.Drawing.Font("나눔바른펜", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AudioOffButton.Location = new System.Drawing.Point(180, 611);
            this.AudioOffButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AudioOffButton.Name = "AudioOffButton";
            this.AudioOffButton.Size = new System.Drawing.Size(75, 31);
            this.AudioOffButton.TabIndex = 4;
            this.AudioOffButton.Text = "오디오OFF";
            this.AudioOffButton.UseVisualStyleBackColor = false;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 648);
            this.Controls.Add(this.AudioOffButton);
            this.Controls.Add(this.ShareButton);
            this.Controls.Add(this.AudioOnButton);
            this.Controls.Add(this.CameraButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("나눔바른펜", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CameraButton;
        private System.Windows.Forms.Button AudioOnButton;
        private System.Windows.Forms.Button ShareButton;
        private System.Windows.Forms.Button AudioOffButton;
    }
}