﻿
namespace Environmental_monitoring_DateBase_ADO5.Net
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSource = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmission = new System.Windows.Forms.DataGridView();
            this.buttonAddSource = new System.Windows.Forms.Button();
            this.buttonDelteEmission = new System.Windows.Forms.Button();
            this.buttonAddEmission = new System.Windows.Forms.Button();
            this.buttonRedactSource = new System.Windows.Forms.Button();
            this.buttonDeleteSource = new System.Windows.Forms.Button();
            this.buttonRedactEmission = new System.Windows.Forms.Button();
            this.buttonAvgEmission = new System.Windows.Forms.Button();
            this.buttonMaxEmission = new System.Windows.Forms.Button();
            this.buttonMinEmission = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.источникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.минимальныеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальныеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средниеВыбросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmission)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Источник выбросов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбросы";
            // 
            // dataGridViewSource
            // 
            this.dataGridViewSource.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSource.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSource.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSource.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSource.Location = new System.Drawing.Point(28, 78);
            this.dataGridViewSource.Name = "dataGridViewSource";
            this.dataGridViewSource.RowHeadersWidth = 51;
            this.dataGridViewSource.RowTemplate.Height = 24;
            this.dataGridViewSource.Size = new System.Drawing.Size(626, 259);
            this.dataGridViewSource.TabIndex = 2;
            // 
            // dataGridViewEmission
            // 
            this.dataGridViewEmission.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewEmission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewEmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmission.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewEmission.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEmission.Location = new System.Drawing.Point(28, 389);
            this.dataGridViewEmission.Name = "dataGridViewEmission";
            this.dataGridViewEmission.RowHeadersWidth = 51;
            this.dataGridViewEmission.RowTemplate.Height = 24;
            this.dataGridViewEmission.Size = new System.Drawing.Size(626, 244);
            this.dataGridViewEmission.TabIndex = 3;
            // 
            // buttonAddSource
            // 
            this.buttonAddSource.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAddSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddSource.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSource.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonAddSource.Location = new System.Drawing.Point(739, 109);
            this.buttonAddSource.Name = "buttonAddSource";
            this.buttonAddSource.Size = new System.Drawing.Size(218, 40);
            this.buttonAddSource.TabIndex = 4;
            this.buttonAddSource.Text = "Добавить источник";
            this.buttonAddSource.UseVisualStyleBackColor = false;
            this.buttonAddSource.Click += new System.EventHandler(this.buttonAddSource_Click);
            // 
            // buttonDelteEmission
            // 
            this.buttonDelteEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDelteEmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelteEmission.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelteEmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonDelteEmission.Location = new System.Drawing.Point(740, 479);
            this.buttonDelteEmission.Name = "buttonDelteEmission";
            this.buttonDelteEmission.Size = new System.Drawing.Size(217, 38);
            this.buttonDelteEmission.TabIndex = 5;
            this.buttonDelteEmission.Text = "Удалить выбросы";
            this.buttonDelteEmission.UseVisualStyleBackColor = false;
            this.buttonDelteEmission.Click += new System.EventHandler(this.buttonDelteEmission_Click);
            // 
            // buttonAddEmission
            // 
            this.buttonAddEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAddEmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddEmission.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonAddEmission.Location = new System.Drawing.Point(740, 409);
            this.buttonAddEmission.Name = "buttonAddEmission";
            this.buttonAddEmission.Size = new System.Drawing.Size(217, 38);
            this.buttonAddEmission.TabIndex = 6;
            this.buttonAddEmission.Text = "Добавить выбросы";
            this.buttonAddEmission.UseVisualStyleBackColor = false;
            this.buttonAddEmission.Click += new System.EventHandler(this.buttonAddEmission_Click);
            // 
            // buttonRedactSource
            // 
            this.buttonRedactSource.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRedactSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRedactSource.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedactSource.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonRedactSource.Location = new System.Drawing.Point(740, 230);
            this.buttonRedactSource.Name = "buttonRedactSource";
            this.buttonRedactSource.Size = new System.Drawing.Size(217, 38);
            this.buttonRedactSource.TabIndex = 7;
            this.buttonRedactSource.Text = "Редактировать источник";
            this.buttonRedactSource.UseVisualStyleBackColor = false;
            this.buttonRedactSource.Click += new System.EventHandler(this.buttonRedactSource_Click);
            // 
            // buttonDeleteSource
            // 
            this.buttonDeleteSource.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDeleteSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteSource.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSource.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonDeleteSource.Location = new System.Drawing.Point(739, 166);
            this.buttonDeleteSource.Name = "buttonDeleteSource";
            this.buttonDeleteSource.Size = new System.Drawing.Size(218, 39);
            this.buttonDeleteSource.TabIndex = 8;
            this.buttonDeleteSource.Text = "Удалить источник";
            this.buttonDeleteSource.UseVisualStyleBackColor = false;
            this.buttonDeleteSource.Click += new System.EventHandler(this.buttonDeleteSource_Click);
            // 
            // buttonRedactEmission
            // 
            this.buttonRedactEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonRedactEmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRedactEmission.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedactEmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonRedactEmission.Location = new System.Drawing.Point(739, 546);
            this.buttonRedactEmission.Name = "buttonRedactEmission";
            this.buttonRedactEmission.Size = new System.Drawing.Size(218, 36);
            this.buttonRedactEmission.TabIndex = 9;
            this.buttonRedactEmission.Text = "Редактировать выбросы";
            this.buttonRedactEmission.UseVisualStyleBackColor = false;
            this.buttonRedactEmission.Click += new System.EventHandler(this.buttonRedactEmission_Click);
            // 
            // buttonAvgEmission
            // 
            this.buttonAvgEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAvgEmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAvgEmission.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvgEmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonAvgEmission.Location = new System.Drawing.Point(494, 658);
            this.buttonAvgEmission.Name = "buttonAvgEmission";
            this.buttonAvgEmission.Size = new System.Drawing.Size(196, 47);
            this.buttonAvgEmission.TabIndex = 10;
            this.buttonAvgEmission.Text = "Средние выбросы";
            this.buttonAvgEmission.UseVisualStyleBackColor = false;
            this.buttonAvgEmission.Click += new System.EventHandler(this.buttonAvgEmission_Click);
            // 
            // buttonMaxEmission
            // 
            this.buttonMaxEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMaxEmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMaxEmission.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaxEmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonMaxEmission.Location = new System.Drawing.Point(255, 658);
            this.buttonMaxEmission.Name = "buttonMaxEmission";
            this.buttonMaxEmission.Size = new System.Drawing.Size(213, 47);
            this.buttonMaxEmission.TabIndex = 11;
            this.buttonMaxEmission.Text = "Максимальные выбросы";
            this.buttonMaxEmission.UseVisualStyleBackColor = false;
            this.buttonMaxEmission.Click += new System.EventHandler(this.buttonMaxEmission_Click);
            // 
            // buttonMinEmission
            // 
            this.buttonMinEmission.BackColor = System.Drawing.SystemColors.Info;
            this.buttonMinEmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinEmission.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinEmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonMinEmission.Location = new System.Drawing.Point(28, 658);
            this.buttonMinEmission.Name = "buttonMinEmission";
            this.buttonMinEmission.Size = new System.Drawing.Size(195, 47);
            this.buttonMinEmission.TabIndex = 12;
            this.buttonMinEmission.Text = "Минимальные выбросы";
            this.buttonMinEmission.UseVisualStyleBackColor = false;
            this.buttonMinEmission.Click += new System.EventHandler(this.buttonMinEmission_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.источникToolStripMenuItem,
            this.выбросыToolStripMenuItem,
            this.расчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 30);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // источникToolStripMenuItem
            // 
            this.источникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.источникToolStripMenuItem.Name = "источникToolStripMenuItem";
            this.источникToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.источникToolStripMenuItem.Text = "Источник";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // выбросыToolStripMenuItem
            // 
            this.выбросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1,
            this.редактироватьToolStripMenuItem1});
            this.выбросыToolStripMenuItem.Name = "выбросыToolStripMenuItem";
            this.выбросыToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.выбросыToolStripMenuItem.Text = "Выбросы";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            // 
            // расчетToolStripMenuItem
            // 
            this.расчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.минимальныеВыбросыToolStripMenuItem,
            this.максимальныеВыбросыToolStripMenuItem,
            this.средниеВыбросыToolStripMenuItem});
            this.расчетToolStripMenuItem.Name = "расчетToolStripMenuItem";
            this.расчетToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.расчетToolStripMenuItem.Text = "Расчет";
            // 
            // минимальныеВыбросыToolStripMenuItem
            // 
            this.минимальныеВыбросыToolStripMenuItem.Name = "минимальныеВыбросыToolStripMenuItem";
            this.минимальныеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.минимальныеВыбросыToolStripMenuItem.Text = "Минимальные выбросы";
            // 
            // максимальныеВыбросыToolStripMenuItem
            // 
            this.максимальныеВыбросыToolStripMenuItem.Name = "максимальныеВыбросыToolStripMenuItem";
            this.максимальныеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.максимальныеВыбросыToolStripMenuItem.Text = "Максимальные выбросы";
            // 
            // средниеВыбросыToolStripMenuItem
            // 
            this.средниеВыбросыToolStripMenuItem.Name = "средниеВыбросыToolStripMenuItem";
            this.средниеВыбросыToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.средниеВыбросыToolStripMenuItem.Text = "Средние выбросы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1026, 733);
            this.Controls.Add(this.buttonMinEmission);
            this.Controls.Add(this.buttonMaxEmission);
            this.Controls.Add(this.buttonAvgEmission);
            this.Controls.Add(this.buttonRedactEmission);
            this.Controls.Add(this.buttonDeleteSource);
            this.Controls.Add(this.buttonRedactSource);
            this.Controls.Add(this.buttonAddEmission);
            this.Controls.Add(this.buttonDelteEmission);
            this.Controls.Add(this.buttonAddSource);
            this.Controls.Add(this.dataGridViewEmission);
            this.Controls.Add(this.dataGridViewSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Программа мониторинга окружающей среды";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmission)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSource;
        private System.Windows.Forms.DataGridView dataGridViewEmission;
        private System.Windows.Forms.Button buttonAddSource;
        private System.Windows.Forms.Button buttonDelteEmission;
        private System.Windows.Forms.Button buttonAddEmission;
        private System.Windows.Forms.Button buttonRedactSource;
        private System.Windows.Forms.Button buttonDeleteSource;
        private System.Windows.Forms.Button buttonRedactEmission;
        private System.Windows.Forms.Button buttonAvgEmission;
        private System.Windows.Forms.Button buttonMaxEmission;
        private System.Windows.Forms.Button buttonMinEmission;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem источникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem расчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минимальныеВыбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальныеВыбросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средниеВыбросыToolStripMenuItem;
    }
}

