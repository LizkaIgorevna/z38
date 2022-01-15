
namespace z38
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorR = new System.Windows.Forms.CheckBox();
            this.ColorG = new System.Windows.Forms.CheckBox();
            this.ColorB = new System.Windows.Forms.CheckBox();
            this.bBio = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.bBiometric = new System.Windows.Forms.Button();
            this.bDocs = new System.Windows.Forms.Button();
            this.bHobby = new System.Windows.Forms.Button();
            this.bMedia = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorR
            // 
            this.ColorR.AutoSize = true;
            this.ColorR.Location = new System.Drawing.Point(4, 3);
            this.ColorR.Name = "ColorR";
            this.ColorR.Size = new System.Drawing.Size(46, 17);
            this.ColorR.TabIndex = 0;
            this.ColorR.Text = "Red";
            this.ColorR.UseVisualStyleBackColor = true;
            this.ColorR.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // ColorG
            // 
            this.ColorG.AutoSize = true;
            this.ColorG.Location = new System.Drawing.Point(4, 26);
            this.ColorG.Name = "ColorG";
            this.ColorG.Size = new System.Drawing.Size(55, 17);
            this.ColorG.TabIndex = 1;
            this.ColorG.Text = "Green";
            this.ColorG.UseVisualStyleBackColor = true;
            this.ColorG.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // ColorB
            // 
            this.ColorB.AutoSize = true;
            this.ColorB.Location = new System.Drawing.Point(4, 49);
            this.ColorB.Name = "ColorB";
            this.ColorB.Size = new System.Drawing.Size(47, 17);
            this.ColorB.TabIndex = 2;
            this.ColorB.Text = "Blue";
            this.ColorB.UseVisualStyleBackColor = true;
            this.ColorB.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // bBio
            // 
            this.bBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bBio.Location = new System.Drawing.Point(15, 19);
            this.bBio.Name = "bBio";
            this.bBio.Size = new System.Drawing.Size(121, 31);
            this.bBio.TabIndex = 3;
            this.bBio.Text = "Биография";
            this.bBio.UseVisualStyleBackColor = true;
            this.bBio.Click += new System.EventHandler(this.bBio_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(178, 94);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(85, 29);
            this.bReset.TabIndex = 4;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bBiometric
            // 
            this.bBiometric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bBiometric.Location = new System.Drawing.Point(15, 56);
            this.bBiometric.Name = "bBiometric";
            this.bBiometric.Size = new System.Drawing.Size(121, 31);
            this.bBiometric.TabIndex = 5;
            this.bBiometric.Text = "Физ. данные";
            this.bBiometric.UseVisualStyleBackColor = true;
            this.bBiometric.Click += new System.EventHandler(this.bBiometric_Click);
            // 
            // bDocs
            // 
            this.bDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bDocs.Location = new System.Drawing.Point(15, 93);
            this.bDocs.Name = "bDocs";
            this.bDocs.Size = new System.Drawing.Size(121, 31);
            this.bDocs.TabIndex = 6;
            this.bDocs.Text = "Документы";
            this.bDocs.UseVisualStyleBackColor = true;
            this.bDocs.Click += new System.EventHandler(this.bDocs_Click);
            // 
            // bHobby
            // 
            this.bHobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bHobby.Location = new System.Drawing.Point(16, 19);
            this.bHobby.Name = "bHobby";
            this.bHobby.Size = new System.Drawing.Size(121, 31);
            this.bHobby.TabIndex = 7;
            this.bHobby.Text = "Хобби";
            this.bHobby.UseVisualStyleBackColor = true;
            this.bHobby.Click += new System.EventHandler(this.bHobby_Click);
            // 
            // bMedia
            // 
            this.bMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bMedia.Location = new System.Drawing.Point(16, 56);
            this.bMedia.Name = "bMedia";
            this.bMedia.Size = new System.Drawing.Size(121, 31);
            this.bMedia.TabIndex = 8;
            this.bMedia.Text = "Мультимедиа";
            this.bMedia.UseVisualStyleBackColor = true;
            this.bMedia.Click += new System.EventHandler(this.bMedia_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(168, 174);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bBio);
            this.tabPage1.Controls.Add(this.bBiometric);
            this.tabPage1.Controls.Add(this.bDocs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(160, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Важна!!!";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bHobby);
            this.tabPage2.Controls.Add(this.bMedia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(160, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Не важна)))";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ColorR);
            this.panel1.Controls.Add(this.ColorG);
            this.panel1.Controls.Add(this.ColorB);
            this.panel1.Location = new System.Drawing.Point(178, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 72);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 173);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bReset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ColorR;
        private System.Windows.Forms.CheckBox ColorG;
        private System.Windows.Forms.CheckBox ColorB;
        private System.Windows.Forms.Button bBio;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bBiometric;
        private System.Windows.Forms.Button bDocs;
        private System.Windows.Forms.Button bHobby;
        private System.Windows.Forms.Button bMedia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
    }
}

