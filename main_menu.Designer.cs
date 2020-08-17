namespace kana_train
{
    partial class main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.start_hiragana_button = new System.Windows.Forms.Button();
            this.start_katakana_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_hiragana_button
            // 
            this.start_hiragana_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_hiragana_button.Location = new System.Drawing.Point(537, 248);
            this.start_hiragana_button.Name = "start_hiragana_button";
            this.start_hiragana_button.Size = new System.Drawing.Size(206, 51);
            this.start_hiragana_button.TabIndex = 0;
            this.start_hiragana_button.Text = "тренировать хирагану";
            this.start_hiragana_button.UseVisualStyleBackColor = true;
            this.start_hiragana_button.Click += new System.EventHandler(this.start_hiragana_button_Click);
            this.start_hiragana_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_menu_KeyDown);
            // 
            // start_katakana_button
            // 
            this.start_katakana_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_katakana_button.Location = new System.Drawing.Point(537, 306);
            this.start_katakana_button.Name = "start_katakana_button";
            this.start_katakana_button.Size = new System.Drawing.Size(206, 51);
            this.start_katakana_button.TabIndex = 1;
            this.start_katakana_button.Text = "тренировать катакану";
            this.start_katakana_button.UseVisualStyleBackColor = true;
            this.start_katakana_button.Click += new System.EventHandler(this.start_katakana_button_Click);
            // 
            // about_button
            // 
            this.about_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.about_button.Location = new System.Drawing.Point(537, 364);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(206, 51);
            this.about_button.TabIndex = 2;
            this.about_button.Text = "о программе";
            this.about_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(537, 422);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(206, 51);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::kana_train.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.start_hiragana_button);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.about_button);
            this.panel1.Controls.Add(this.start_katakana_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 5;
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kana train";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_menu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_hiragana_button;
        private System.Windows.Forms.Button start_katakana_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel panel1;
    }
}