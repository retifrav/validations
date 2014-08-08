namespace validations
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_ogrn_result = new System.Windows.Forms.Label();
            this.label_kpp_result = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.label_inn = new System.Windows.Forms.Label();
            this.label_kpp = new System.Windows.Forms.Label();
            this.label_ogrn = new System.Windows.Forms.Label();
            this.textBox_inn = new System.Windows.Forms.TextBox();
            this.textBox_kpp = new System.Windows.Forms.TextBox();
            this.textBox_ogrn = new System.Windows.Forms.TextBox();
            this.label_inn_result = new System.Windows.Forms.Label();
            this.toolTip_main = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_ogrn_result, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_kpp_result, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_check, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_inn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_kpp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_ogrn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_inn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_kpp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ogrn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_inn_result, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 133);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_ogrn_result
            // 
            this.label_ogrn_result.AutoSize = true;
            this.label_ogrn_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ogrn_result.Location = new System.Drawing.Point(299, 57);
            this.label_ogrn_result.Name = "label_ogrn_result";
            this.label_ogrn_result.Size = new System.Drawing.Size(217, 26);
            this.label_ogrn_result.TabIndex = 9;
            this.label_ogrn_result.Text = "результат проверки";
            this.label_ogrn_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_kpp_result
            // 
            this.label_kpp_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_kpp_result.AutoSize = true;
            this.label_kpp_result.Location = new System.Drawing.Point(299, 31);
            this.label_kpp_result.Name = "label_kpp_result";
            this.label_kpp_result.Size = new System.Drawing.Size(217, 26);
            this.label_kpp_result.TabIndex = 8;
            this.label_kpp_result.Text = "результат проверки";
            this.label_kpp_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_check
            // 
            this.button_check.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.SetColumnSpan(this.button_check, 3);
            this.button_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_check.Location = new System.Drawing.Point(164, 93);
            this.button_check.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button_check.MaximumSize = new System.Drawing.Size(200, 0);
            this.button_check.MinimumSize = new System.Drawing.Size(0, 30);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(200, 30);
            this.button_check.TabIndex = 0;
            this.button_check.Text = "Проверить";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label_inn
            // 
            this.label_inn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_inn.AutoSize = true;
            this.label_inn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_inn.Location = new System.Drawing.Point(13, 5);
            this.label_inn.Name = "label_inn";
            this.label_inn.Size = new System.Drawing.Size(40, 26);
            this.label_inn.TabIndex = 1;
            this.label_inn.Text = "ИНН";
            this.label_inn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_main.SetToolTip(this.label_inn, "Идентификационный номер налогоплательщика");
            // 
            // label_kpp
            // 
            this.label_kpp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_kpp.AutoSize = true;
            this.label_kpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kpp.Location = new System.Drawing.Point(13, 31);
            this.label_kpp.Name = "label_kpp";
            this.label_kpp.Size = new System.Drawing.Size(40, 26);
            this.label_kpp.TabIndex = 2;
            this.label_kpp.Text = "КПП";
            this.label_kpp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_main.SetToolTip(this.label_kpp, "Код причины постановки на учёт");
            // 
            // label_ogrn
            // 
            this.label_ogrn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ogrn.AutoSize = true;
            this.label_ogrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ogrn.Location = new System.Drawing.Point(13, 57);
            this.label_ogrn.Name = "label_ogrn";
            this.label_ogrn.Size = new System.Drawing.Size(40, 26);
            this.label_ogrn.TabIndex = 3;
            this.label_ogrn.Text = "ОГРН";
            this.label_ogrn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_main.SetToolTip(this.label_ogrn, "Основной государственный регистрационный номер");
            // 
            // textBox_inn
            // 
            this.textBox_inn.Location = new System.Drawing.Point(59, 8);
            this.textBox_inn.Name = "textBox_inn";
            this.textBox_inn.Size = new System.Drawing.Size(234, 20);
            this.textBox_inn.TabIndex = 4;
            this.textBox_inn.TextChanged += new System.EventHandler(this.textBox_inn_TextChanged);
            // 
            // textBox_kpp
            // 
            this.textBox_kpp.Location = new System.Drawing.Point(59, 34);
            this.textBox_kpp.Name = "textBox_kpp";
            this.textBox_kpp.Size = new System.Drawing.Size(234, 20);
            this.textBox_kpp.TabIndex = 5;
            this.textBox_kpp.TextChanged += new System.EventHandler(this.textBox_kpp_TextChanged);
            // 
            // textBox_ogrn
            // 
            this.textBox_ogrn.Location = new System.Drawing.Point(59, 60);
            this.textBox_ogrn.Name = "textBox_ogrn";
            this.textBox_ogrn.Size = new System.Drawing.Size(234, 20);
            this.textBox_ogrn.TabIndex = 6;
            this.textBox_ogrn.TextChanged += new System.EventHandler(this.textBox_ogrn_TextChanged);
            // 
            // label_inn_result
            // 
            this.label_inn_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_inn_result.AutoSize = true;
            this.label_inn_result.Location = new System.Drawing.Point(299, 5);
            this.label_inn_result.Name = "label_inn_result";
            this.label_inn_result.Size = new System.Drawing.Size(217, 26);
            this.label_inn_result.TabIndex = 7;
            this.label_inn_result.Text = "результат проверки";
            this.label_inn_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip_main.Size = new System.Drawing.Size(529, 24);
            this.menuStrip_main.TabIndex = 10;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьВсеПоляToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // очиститьВсеПоляToolStripMenuItem
            // 
            this.очиститьВсеПоляToolStripMenuItem.Name = "очиститьВсеПоляToolStripMenuItem";
            this.очиститьВсеПоляToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.очиститьВсеПоляToolStripMenuItem.Text = "Очистить все поля";
            this.очиститьВсеПоляToolStripMenuItem.Click += new System.EventHandler(this.очиститьВсеПоляToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 24);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 157);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Проверка ИНН, КПП, ОГРН";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label_inn;
        private System.Windows.Forms.ToolTip toolTip_main;
        private System.Windows.Forms.Label label_kpp;
        private System.Windows.Forms.Label label_ogrn;
        private System.Windows.Forms.TextBox textBox_inn;
        private System.Windows.Forms.TextBox textBox_kpp;
        private System.Windows.Forms.TextBox textBox_ogrn;
        private System.Windows.Forms.Label label_ogrn_result;
        private System.Windows.Forms.Label label_kpp_result;
        private System.Windows.Forms.Label label_inn_result;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

