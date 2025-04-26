using System;

namespace Countier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ConsoleListBox = new System.Windows.Forms.ListBox();
            this.Settings = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.arendalabel = new System.Windows.Forms.Label();
            this.eatlabel = new System.Windows.Forms.Label();
            this.invlabel = new System.Windows.Forms.Label();
            this.cashlabel = new System.Windows.Forms.Label();
            this.Calculator = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmbalnceButton = new System.Windows.Forms.Button();
            this.browserbutton = new System.Windows.Forms.Button();
            this.MaxpriceTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmMaxPriceForPB = new System.Windows.Forms.Button();
            this.safetynetlabel = new System.Windows.Forms.Label();
            this.emergencyplanlabel = new System.Windows.Forms.Label();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(277, 12);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(423, 48);
            this.progressBar1.TabIndex = 1;
            // 
            // ConsoleListBox
            // 
            this.ConsoleListBox.FormattingEnabled = true;
            this.ConsoleListBox.Location = new System.Drawing.Point(12, 12);
            this.ConsoleListBox.Name = "ConsoleListBox";
            this.ConsoleListBox.Size = new System.Drawing.Size(259, 420);
            this.ConsoleListBox.TabIndex = 2;
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.Settings.Font = new System.Drawing.Font("ROG Fonts", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.Aqua;
            this.Settings.Location = new System.Drawing.Point(704, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(91, 48);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Aqua;
            this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(705, 151);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 19);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Follow";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // arendalabel
            // 
            this.arendalabel.AutoSize = true;
            this.arendalabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arendalabel.ForeColor = System.Drawing.Color.Aqua;
            this.arendalabel.Location = new System.Drawing.Point(277, 85);
            this.arendalabel.Name = "arendalabel";
            this.arendalabel.Size = new System.Drawing.Size(124, 19);
            this.arendalabel.TabIndex = 6;
            this.arendalabel.Text = "for rent: ";
            // 
            // eatlabel
            // 
            this.eatlabel.AutoSize = true;
            this.eatlabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatlabel.ForeColor = System.Drawing.Color.Aqua;
            this.eatlabel.Location = new System.Drawing.Point(277, 116);
            this.eatlabel.Name = "eatlabel";
            this.eatlabel.Size = new System.Drawing.Size(57, 19);
            this.eatlabel.TabIndex = 7;
            this.eatlabel.Text = "EAT:";
            // 
            // invlabel
            // 
            this.invlabel.AutoSize = true;
            this.invlabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invlabel.ForeColor = System.Drawing.Color.Aqua;
            this.invlabel.Location = new System.Drawing.Point(277, 149);
            this.invlabel.Name = "invlabel";
            this.invlabel.Size = new System.Drawing.Size(162, 19);
            this.invlabel.TabIndex = 8;
            this.invlabel.Text = "Investments:";
            // 
            // cashlabel
            // 
            this.cashlabel.AutoSize = true;
            this.cashlabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashlabel.ForeColor = System.Drawing.Color.Aqua;
            this.cashlabel.Location = new System.Drawing.Point(277, 181);
            this.cashlabel.Name = "cashlabel";
            this.cashlabel.Size = new System.Drawing.Size(131, 19);
            this.cashlabel.TabIndex = 9;
            this.cashlabel.Text = "Free Cash:";
            // 
            // Calculator
            // 
            this.Calculator.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.Calculator.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator.ForeColor = System.Drawing.Color.Aqua;
            this.Calculator.Location = new System.Drawing.Point(704, 66);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(91, 38);
            this.Calculator.TabIndex = 10;
            this.Calculator.Text = "Calc%";
            this.Calculator.UseVisualStyleBackColor = true;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.ForeColor = System.Drawing.Color.Aqua;
            this.labelBalance.Location = new System.Drawing.Point(278, 409);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(87, 16);
            this.labelBalance.TabIndex = 11;
            this.labelBalance.Text = "Balance:";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(367, 409);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 12;
            // 
            // ConfirmbalnceButton
            // 
            this.ConfirmbalnceButton.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmbalnceButton.ForeColor = System.Drawing.Color.Aqua;
            this.ConfirmbalnceButton.Location = new System.Drawing.Point(473, 400);
            this.ConfirmbalnceButton.Name = "ConfirmbalnceButton";
            this.ConfirmbalnceButton.Size = new System.Drawing.Size(128, 36);
            this.ConfirmbalnceButton.TabIndex = 13;
            this.ConfirmbalnceButton.Text = "Confirm";
            this.ConfirmbalnceButton.UseVisualStyleBackColor = true;
            this.ConfirmbalnceButton.Click += new System.EventHandler(this.ConfirmbalnceButton_Click);
            // 
            // browserbutton
            // 
            this.browserbutton.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.browserbutton.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserbutton.ForeColor = System.Drawing.Color.Aqua;
            this.browserbutton.Location = new System.Drawing.Point(704, 110);
            this.browserbutton.Name = "browserbutton";
            this.browserbutton.Size = new System.Drawing.Size(91, 38);
            this.browserbutton.TabIndex = 14;
            this.browserbutton.Text = "Google";
            this.browserbutton.UseVisualStyleBackColor = true;
            this.browserbutton.Click += new System.EventHandler(this.browserbutton_Click);
            // 
            // MaxpriceTextBox
            // 
            this.MaxpriceTextBox.ForeColor = System.Drawing.Color.Aqua;
            this.MaxpriceTextBox.Location = new System.Drawing.Point(600, 65);
            this.MaxpriceTextBox.Name = "MaxpriceTextBox";
            this.MaxpriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxpriceTextBox.TabIndex = 16;
            this.MaxpriceTextBox.Text = "Макс значение";
            // 
            // ConfirmMaxPriceForPB
            // 
            this.ConfirmMaxPriceForPB.Font = new System.Drawing.Font("ROG Fonts", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmMaxPriceForPB.ForeColor = System.Drawing.Color.Aqua;
            this.ConfirmMaxPriceForPB.Location = new System.Drawing.Point(559, 65);
            this.ConfirmMaxPriceForPB.Name = "ConfirmMaxPriceForPB";
            this.ConfirmMaxPriceForPB.Size = new System.Drawing.Size(35, 20);
            this.ConfirmMaxPriceForPB.TabIndex = 17;
            this.ConfirmMaxPriceForPB.Text = "Ok";
            this.ConfirmMaxPriceForPB.UseVisualStyleBackColor = true;
            this.ConfirmMaxPriceForPB.Click += new System.EventHandler(this.ConfirmMaxPriceForPB_Click);
            // 
            // safetynetlabel
            // 
            this.safetynetlabel.AutoSize = true;
            this.safetynetlabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safetynetlabel.ForeColor = System.Drawing.Color.Aqua;
            this.safetynetlabel.Location = new System.Drawing.Point(277, 213);
            this.safetynetlabel.Name = "safetynetlabel";
            this.safetynetlabel.Size = new System.Drawing.Size(141, 19);
            this.safetynetlabel.TabIndex = 18;
            this.safetynetlabel.Text = "SafetyNet:";
            // 
            // emergencyplanlabel
            // 
            this.emergencyplanlabel.AutoSize = true;
            this.emergencyplanlabel.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyplanlabel.ForeColor = System.Drawing.Color.Aqua;
            this.emergencyplanlabel.Location = new System.Drawing.Point(277, 244);
            this.emergencyplanlabel.Name = "emergencyplanlabel";
            this.emergencyplanlabel.Size = new System.Drawing.Size(196, 19);
            this.emergencyplanlabel.TabIndex = 19;
            this.emergencyplanlabel.Text = "EmergencyPlan:";
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackgroundImage = global::Countier.Properties.Resources.reload;
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Location = new System.Drawing.Point(750, 400);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(36, 36);
            this.ReloadButton.TabIndex = 20;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            this.ReloadButton.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.emergencyplanlabel);
            this.Controls.Add(this.safetynetlabel);
            this.Controls.Add(this.ConfirmMaxPriceForPB);
            this.Controls.Add(this.MaxpriceTextBox);
            this.Controls.Add(this.browserbutton);
            this.Controls.Add(this.ConfirmbalnceButton);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.cashlabel);
            this.Controls.Add(this.invlabel);
            this.Controls.Add(this.eatlabel);
            this.Controls.Add(this.arendalabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.ConsoleListBox);
            this.Controls.Add(this.progressBar1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Bookkeeping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox ConsoleListBox;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label arendalabel;
        private System.Windows.Forms.Label eatlabel;
        private System.Windows.Forms.Label invlabel;
        private System.Windows.Forms.Label cashlabel;
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button ConfirmbalnceButton;
        private System.Windows.Forms.Button browserbutton;
        private System.Windows.Forms.TextBox MaxpriceTextBox;
        private System.Windows.Forms.Button ConfirmMaxPriceForPB;
        private System.Windows.Forms.Label safetynetlabel;
        private System.Windows.Forms.Label emergencyplanlabel;
        private System.Windows.Forms.Button ReloadButton;
    }
}

