namespace ADFGVX_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEncryptPermKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEncryptSubKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnCrypt = new System.Windows.Forms.Button();
            this.textBoxOutputEnCryptText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputPlainText = new System.Windows.Forms.TextBox();
            this.checkBoxCZVerze = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDecryptPermKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDecryptSubKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDeCrypt = new System.Windows.Forms.Button();
            this.textBoxOutputDeCryptText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInputCryptedText = new System.Windows.Forms.TextBox();
            this.checkBoxCZVerze2 = new System.Windows.Forms.CheckBox();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxEncryptPermKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEncryptSubKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonEnCrypt);
            this.groupBox1.Controls.Add(this.textBoxOutputEnCryptText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxInputPlainText);
            this.groupBox1.Controls.Add(this.checkBoxCZVerze);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 217);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Zadejte permutacni klic:";
            // 
            // textBoxEncryptPermKey
            // 
            this.textBoxEncryptPermKey.Location = new System.Drawing.Point(6, 152);
            this.textBoxEncryptPermKey.Name = "textBoxEncryptPermKey";
            this.textBoxEncryptPermKey.Size = new System.Drawing.Size(158, 20);
            this.textBoxEncryptPermKey.TabIndex = 8;
            this.textBoxEncryptPermKey.Text = "Privacy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zadejte substitucni klic:";
            // 
            // textBoxEncryptSubKey
            // 
            this.textBoxEncryptSubKey.Location = new System.Drawing.Point(6, 115);
            this.textBoxEncryptSubKey.Name = "textBoxEncryptSubKey";
            this.textBoxEncryptSubKey.Size = new System.Drawing.Size(158, 20);
            this.textBoxEncryptSubKey.TabIndex = 6;
            this.textBoxEncryptSubKey.Text = "147REGIMENT";
            this.textBoxEncryptSubKey.TextChanged += new System.EventHandler(this.textBoxEncryptSubKey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zasifrovany text:";
            // 
            // buttonEnCrypt
            // 
            this.buttonEnCrypt.Location = new System.Drawing.Point(238, 113);
            this.buttonEnCrypt.Name = "buttonEnCrypt";
            this.buttonEnCrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEnCrypt.TabIndex = 1;
            this.buttonEnCrypt.Text = "Encrypt";
            this.buttonEnCrypt.UseVisualStyleBackColor = true;
            this.buttonEnCrypt.Click += new System.EventHandler(this.buttonEnCrypt_Click);
            // 
            // textBoxOutputEnCryptText
            // 
            this.textBoxOutputEnCryptText.Location = new System.Drawing.Point(6, 191);
            this.textBoxOutputEnCryptText.Name = "textBoxOutputEnCryptText";
            this.textBoxOutputEnCryptText.ReadOnly = true;
            this.textBoxOutputEnCryptText.Size = new System.Drawing.Size(307, 20);
            this.textBoxOutputEnCryptText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zadejte text:";
            // 
            // textBoxInputPlainText
            // 
            this.textBoxInputPlainText.Location = new System.Drawing.Point(6, 76);
            this.textBoxInputPlainText.Name = "textBoxInputPlainText";
            this.textBoxInputPlainText.Size = new System.Drawing.Size(307, 20);
            this.textBoxInputPlainText.TabIndex = 0;
            // 
            // checkBoxCZVerze
            // 
            this.checkBoxCZVerze.AutoSize = true;
            this.checkBoxCZVerze.Checked = true;
            this.checkBoxCZVerze.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCZVerze.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCZVerze.Name = "checkBoxCZVerze";
            this.checkBoxCZVerze.Size = new System.Drawing.Size(69, 17);
            this.checkBoxCZVerze.TabIndex = 2;
            this.checkBoxCZVerze.Text = "CZ verze";
            this.checkBoxCZVerze.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxDecryptPermKey);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxDecryptSubKey);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonDeCrypt);
            this.groupBox2.Controls.Add(this.textBoxOutputDeCryptText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxInputCryptedText);
            this.groupBox2.Controls.Add(this.checkBoxCZVerze2);
            this.groupBox2.Location = new System.Drawing.Point(6, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 217);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Zadejte permutacni klic:";
            // 
            // textBoxDecryptPermKey
            // 
            this.textBoxDecryptPermKey.Location = new System.Drawing.Point(6, 150);
            this.textBoxDecryptPermKey.Name = "textBoxDecryptPermKey";
            this.textBoxDecryptPermKey.Size = new System.Drawing.Size(158, 20);
            this.textBoxDecryptPermKey.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Zadejte substitucni klic:";
            // 
            // textBoxDecryptSubKey
            // 
            this.textBoxDecryptSubKey.Location = new System.Drawing.Point(6, 113);
            this.textBoxDecryptSubKey.Name = "textBoxDecryptSubKey";
            this.textBoxDecryptSubKey.Size = new System.Drawing.Size(158, 20);
            this.textBoxDecryptSubKey.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Desifrovany text:";
            // 
            // buttonDeCrypt
            // 
            this.buttonDeCrypt.Location = new System.Drawing.Point(238, 113);
            this.buttonDeCrypt.Name = "buttonDeCrypt";
            this.buttonDeCrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDeCrypt.TabIndex = 1;
            this.buttonDeCrypt.Text = "Decrypt";
            this.buttonDeCrypt.UseVisualStyleBackColor = true;
            this.buttonDeCrypt.Click += new System.EventHandler(this.buttonDeCrypt_Click);
            // 
            // textBoxOutputDeCryptText
            // 
            this.textBoxOutputDeCryptText.Location = new System.Drawing.Point(6, 191);
            this.textBoxOutputDeCryptText.Name = "textBoxOutputDeCryptText";
            this.textBoxOutputDeCryptText.ReadOnly = true;
            this.textBoxOutputDeCryptText.Size = new System.Drawing.Size(307, 20);
            this.textBoxOutputDeCryptText.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Zadejte text:";
            // 
            // textBoxInputCryptedText
            // 
            this.textBoxInputCryptedText.Location = new System.Drawing.Point(6, 76);
            this.textBoxInputCryptedText.Name = "textBoxInputCryptedText";
            this.textBoxInputCryptedText.Size = new System.Drawing.Size(307, 20);
            this.textBoxInputCryptedText.TabIndex = 0;
            // 
            // checkBoxCZVerze2
            // 
            this.checkBoxCZVerze2.AutoSize = true;
            this.checkBoxCZVerze2.Checked = true;
            this.checkBoxCZVerze2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCZVerze2.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCZVerze2.Name = "checkBoxCZVerze2";
            this.checkBoxCZVerze2.Size = new System.Drawing.Size(69, 17);
            this.checkBoxCZVerze2.TabIndex = 2;
            this.checkBoxCZVerze2.Text = "CZ verze";
            this.checkBoxCZVerze2.UseVisualStyleBackColor = true;
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(6, 17);
            this.textBoxTable.Multiline = true;
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.ReadOnly = true;
            this.textBoxTable.Size = new System.Drawing.Size(279, 118);
            this.textBoxTable.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxTable);
            this.groupBox3.Location = new System.Drawing.Point(331, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 217);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 500);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADFGVX";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADFGX";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEncryptSubKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEnCrypt;
        private System.Windows.Forms.TextBox textBoxOutputEnCryptText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputPlainText;
        private System.Windows.Forms.CheckBox checkBoxCZVerze;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDeCrypt;
        private System.Windows.Forms.TextBox textBoxOutputDeCryptText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInputCryptedText;
        private System.Windows.Forms.CheckBox checkBoxCZVerze2;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEncryptPermKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDecryptPermKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDecryptSubKey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

