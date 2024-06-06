namespace Game2048
{
    partial class GameForm
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
            this.TLP_GF_Main = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_GF_Board = new System.Windows.Forms.TableLayoutPanel();
            this.BS_Board_0 = new System.Windows.Forms.Button();
            this.BS_Board_13 = new System.Windows.Forms.Button();
            this.BS_Board_14 = new System.Windows.Forms.Button();
            this.BS_Board_15 = new System.Windows.Forms.Button();
            this.BS_Board_9 = new System.Windows.Forms.Button();
            this.BS_Board_10 = new System.Windows.Forms.Button();
            this.BS_Board_11 = new System.Windows.Forms.Button();
            this.BS_Board_12 = new System.Windows.Forms.Button();
            this.BS_Board_5 = new System.Windows.Forms.Button();
            this.BS_Board_6 = new System.Windows.Forms.Button();
            this.BS_Board_7 = new System.Windows.Forms.Button();
            this.BS_Board_8 = new System.Windows.Forms.Button();
            this.BS_Board_4 = new System.Windows.Forms.Button();
            this.BS_Board_3 = new System.Windows.Forms.Button();
            this.BS_Board_2 = new System.Windows.Forms.Button();
            this.BS_Board_1 = new System.Windows.Forms.Button();
            this.PNL_GF_Control = new System.Windows.Forms.Panel();
            this.BS_GF_ColorSetting = new System.Windows.Forms.Button();
            this.TLP_GF_Main.SuspendLayout();
            this.TLP_GF_Board.SuspendLayout();
            this.PNL_GF_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_GF_Main
            // 
            this.TLP_GF_Main.BackColor = System.Drawing.Color.Black;
            this.TLP_GF_Main.ColumnCount = 1;
            this.TLP_GF_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_GF_Main.Controls.Add(this.TLP_GF_Board, 0, 1);
            this.TLP_GF_Main.Controls.Add(this.PNL_GF_Control, 0, 0);
            this.TLP_GF_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_GF_Main.Location = new System.Drawing.Point(0, 0);
            this.TLP_GF_Main.Name = "TLP_GF_Main";
            this.TLP_GF_Main.RowCount = 2;
            this.TLP_GF_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.51292F));
            this.TLP_GF_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.48708F));
            this.TLP_GF_Main.Size = new System.Drawing.Size(470, 511);
            this.TLP_GF_Main.TabIndex = 0;
            // 
            // TLP_GF_Board
            // 
            this.TLP_GF_Board.BackColor = System.Drawing.Color.Black;
            this.TLP_GF_Board.ColumnCount = 4;
            this.TLP_GF_Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_GF_Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_GF_Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_GF_Board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_GF_Board.Controls.Add(this.BS_Board_0, 3, 3);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_13, 0, 3);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_14, 1, 3);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_15, 2, 3);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_9, 0, 2);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_10, 1, 2);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_11, 2, 2);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_12, 3, 2);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_5, 0, 1);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_6, 1, 1);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_7, 2, 1);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_8, 3, 1);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_4, 3, 0);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_3, 2, 0);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_2, 1, 0);
            this.TLP_GF_Board.Controls.Add(this.BS_Board_1, 0, 0);
            this.TLP_GF_Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_GF_Board.Font = new System.Drawing.Font("Agency FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLP_GF_Board.ForeColor = System.Drawing.Color.Black;
            this.TLP_GF_Board.Location = new System.Drawing.Point(3, 77);
            this.TLP_GF_Board.Name = "TLP_GF_Board";
            this.TLP_GF_Board.RowCount = 4;
            this.TLP_GF_Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_GF_Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_GF_Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_GF_Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_GF_Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_GF_Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_GF_Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_GF_Board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_GF_Board.Size = new System.Drawing.Size(464, 431);
            this.TLP_GF_Board.TabIndex = 0;
            // 
            // BS_Board_0
            // 
            this.BS_Board_0.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_0.FlatAppearance.BorderSize = 0;
            this.BS_Board_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_0.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_0.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_0.Location = new System.Drawing.Point(351, 324);
            this.BS_Board_0.Name = "BS_Board_0";
            this.BS_Board_0.Size = new System.Drawing.Size(110, 104);
            this.BS_Board_0.TabIndex = 16;
            this.BS_Board_0.Tag = "0";
            this.BS_Board_0.Text = "0";
            this.BS_Board_0.UseVisualStyleBackColor = false;
            // 
            // BS_Board_13
            // 
            this.BS_Board_13.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_13.FlatAppearance.BorderSize = 0;
            this.BS_Board_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_13.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_13.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_13.Location = new System.Drawing.Point(3, 324);
            this.BS_Board_13.Name = "BS_Board_13";
            this.BS_Board_13.Size = new System.Drawing.Size(110, 104);
            this.BS_Board_13.TabIndex = 15;
            this.BS_Board_13.Tag = "13";
            this.BS_Board_13.Text = "13";
            this.BS_Board_13.UseVisualStyleBackColor = false;
            // 
            // BS_Board_14
            // 
            this.BS_Board_14.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_14.FlatAppearance.BorderSize = 0;
            this.BS_Board_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_14.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_14.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_14.Location = new System.Drawing.Point(119, 324);
            this.BS_Board_14.Name = "BS_Board_14";
            this.BS_Board_14.Size = new System.Drawing.Size(110, 104);
            this.BS_Board_14.TabIndex = 14;
            this.BS_Board_14.Tag = "14";
            this.BS_Board_14.Text = "14";
            this.BS_Board_14.UseVisualStyleBackColor = false;
            // 
            // BS_Board_15
            // 
            this.BS_Board_15.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_15.FlatAppearance.BorderSize = 0;
            this.BS_Board_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_15.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_15.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_15.Location = new System.Drawing.Point(235, 324);
            this.BS_Board_15.Name = "BS_Board_15";
            this.BS_Board_15.Size = new System.Drawing.Size(110, 104);
            this.BS_Board_15.TabIndex = 13;
            this.BS_Board_15.Tag = "15";
            this.BS_Board_15.Text = "15";
            this.BS_Board_15.UseVisualStyleBackColor = false;
            // 
            // BS_Board_9
            // 
            this.BS_Board_9.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_9.FlatAppearance.BorderSize = 0;
            this.BS_Board_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_9.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_9.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_9.Location = new System.Drawing.Point(3, 217);
            this.BS_Board_9.Name = "BS_Board_9";
            this.BS_Board_9.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_9.TabIndex = 11;
            this.BS_Board_9.Tag = "9";
            this.BS_Board_9.Text = "9";
            this.BS_Board_9.UseVisualStyleBackColor = false;
            // 
            // BS_Board_10
            // 
            this.BS_Board_10.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_10.FlatAppearance.BorderSize = 0;
            this.BS_Board_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_10.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_10.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_10.Location = new System.Drawing.Point(119, 217);
            this.BS_Board_10.Name = "BS_Board_10";
            this.BS_Board_10.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_10.TabIndex = 10;
            this.BS_Board_10.Tag = "10";
            this.BS_Board_10.Text = "10";
            this.BS_Board_10.UseVisualStyleBackColor = false;
            // 
            // BS_Board_11
            // 
            this.BS_Board_11.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_11.FlatAppearance.BorderSize = 0;
            this.BS_Board_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_11.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_11.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_11.Location = new System.Drawing.Point(235, 217);
            this.BS_Board_11.Name = "BS_Board_11";
            this.BS_Board_11.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_11.TabIndex = 9;
            this.BS_Board_11.Tag = "11";
            this.BS_Board_11.Text = "11";
            this.BS_Board_11.UseVisualStyleBackColor = false;
            // 
            // BS_Board_12
            // 
            this.BS_Board_12.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_12.FlatAppearance.BorderSize = 0;
            this.BS_Board_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_12.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_12.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_12.Location = new System.Drawing.Point(351, 217);
            this.BS_Board_12.Name = "BS_Board_12";
            this.BS_Board_12.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_12.TabIndex = 8;
            this.BS_Board_12.Tag = "12";
            this.BS_Board_12.Text = "12";
            this.BS_Board_12.UseVisualStyleBackColor = false;
            // 
            // BS_Board_5
            // 
            this.BS_Board_5.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_5.FlatAppearance.BorderSize = 0;
            this.BS_Board_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_5.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_5.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_5.Location = new System.Drawing.Point(3, 110);
            this.BS_Board_5.Name = "BS_Board_5";
            this.BS_Board_5.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_5.TabIndex = 7;
            this.BS_Board_5.Tag = "5";
            this.BS_Board_5.Text = "5";
            this.BS_Board_5.UseVisualStyleBackColor = false;
            // 
            // BS_Board_6
            // 
            this.BS_Board_6.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_6.FlatAppearance.BorderSize = 0;
            this.BS_Board_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_6.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_6.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_6.Location = new System.Drawing.Point(119, 110);
            this.BS_Board_6.Name = "BS_Board_6";
            this.BS_Board_6.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_6.TabIndex = 6;
            this.BS_Board_6.Tag = "6";
            this.BS_Board_6.Text = "6";
            this.BS_Board_6.UseVisualStyleBackColor = false;
            // 
            // BS_Board_7
            // 
            this.BS_Board_7.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_7.FlatAppearance.BorderSize = 0;
            this.BS_Board_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_7.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_7.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_7.Location = new System.Drawing.Point(235, 110);
            this.BS_Board_7.Name = "BS_Board_7";
            this.BS_Board_7.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_7.TabIndex = 5;
            this.BS_Board_7.Tag = "7";
            this.BS_Board_7.Text = "7";
            this.BS_Board_7.UseVisualStyleBackColor = false;
            // 
            // BS_Board_8
            // 
            this.BS_Board_8.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_8.FlatAppearance.BorderSize = 0;
            this.BS_Board_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_8.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_8.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_8.Location = new System.Drawing.Point(351, 110);
            this.BS_Board_8.Name = "BS_Board_8";
            this.BS_Board_8.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_8.TabIndex = 4;
            this.BS_Board_8.Tag = "8";
            this.BS_Board_8.Text = "8";
            this.BS_Board_8.UseVisualStyleBackColor = false;
            // 
            // BS_Board_4
            // 
            this.BS_Board_4.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_4.FlatAppearance.BorderSize = 0;
            this.BS_Board_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_4.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_4.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_4.Location = new System.Drawing.Point(351, 3);
            this.BS_Board_4.Name = "BS_Board_4";
            this.BS_Board_4.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_4.TabIndex = 3;
            this.BS_Board_4.Tag = "4";
            this.BS_Board_4.Text = "4";
            this.BS_Board_4.UseVisualStyleBackColor = false;
            // 
            // BS_Board_3
            // 
            this.BS_Board_3.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_3.FlatAppearance.BorderSize = 0;
            this.BS_Board_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_3.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_3.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_3.Location = new System.Drawing.Point(235, 3);
            this.BS_Board_3.Name = "BS_Board_3";
            this.BS_Board_3.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_3.TabIndex = 2;
            this.BS_Board_3.Tag = "3";
            this.BS_Board_3.Text = "3";
            this.BS_Board_3.UseVisualStyleBackColor = false;
            // 
            // BS_Board_2
            // 
            this.BS_Board_2.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_2.FlatAppearance.BorderSize = 0;
            this.BS_Board_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_2.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_2.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_2.Location = new System.Drawing.Point(119, 3);
            this.BS_Board_2.Name = "BS_Board_2";
            this.BS_Board_2.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_2.TabIndex = 1;
            this.BS_Board_2.Tag = "2";
            this.BS_Board_2.Text = "2";
            this.BS_Board_2.UseVisualStyleBackColor = false;
            // 
            // BS_Board_1
            // 
            this.BS_Board_1.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_Board_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BS_Board_1.FlatAppearance.BorderSize = 0;
            this.BS_Board_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_Board_1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Board_1.ForeColor = System.Drawing.Color.Black;
            this.BS_Board_1.Location = new System.Drawing.Point(3, 3);
            this.BS_Board_1.Name = "BS_Board_1";
            this.BS_Board_1.Size = new System.Drawing.Size(110, 101);
            this.BS_Board_1.TabIndex = 0;
            this.BS_Board_1.Tag = "1";
            this.BS_Board_1.Text = "1";
            this.BS_Board_1.UseVisualStyleBackColor = false;
            // 
            // PNL_GF_Control
            // 
            this.PNL_GF_Control.BackColor = System.Drawing.Color.Black;
            this.PNL_GF_Control.Controls.Add(this.BS_GF_ColorSetting);
            this.PNL_GF_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_GF_Control.Location = new System.Drawing.Point(3, 3);
            this.PNL_GF_Control.Name = "PNL_GF_Control";
            this.PNL_GF_Control.Size = new System.Drawing.Size(464, 68);
            this.PNL_GF_Control.TabIndex = 1;
            // 
            // BS_GF_ColorSetting
            // 
            this.BS_GF_ColorSetting.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_GF_ColorSetting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BS_GF_ColorSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_GF_ColorSetting.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BS_GF_ColorSetting.ForeColor = System.Drawing.Color.Black;
            this.BS_GF_ColorSetting.Location = new System.Drawing.Point(351, 3);
            this.BS_GF_ColorSetting.Name = "BS_GF_ColorSetting";
            this.BS_GF_ColorSetting.Size = new System.Drawing.Size(110, 28);
            this.BS_GF_ColorSetting.TabIndex = 3;
            this.BS_GF_ColorSetting.Text = "Color Setting";
            this.BS_GF_ColorSetting.UseVisualStyleBackColor = false;
            this.BS_GF_ColorSetting.Click += new System.EventHandler(this.BS_GF_ColorSetting_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 511);
            this.Controls.Add(this.TLP_GF_Main);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2024";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.TLP_GF_Main.ResumeLayout(false);
            this.TLP_GF_Board.ResumeLayout(false);
            this.PNL_GF_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_GF_Main;
        private System.Windows.Forms.TableLayoutPanel TLP_GF_Board;
        private System.Windows.Forms.Button BS_Board_13;
        private System.Windows.Forms.Button BS_Board_14;
        private System.Windows.Forms.Button BS_Board_15;
        private System.Windows.Forms.Button BS_Board_9;
        private System.Windows.Forms.Button BS_Board_10;
        private System.Windows.Forms.Button BS_Board_11;
        private System.Windows.Forms.Button BS_Board_12;
        private System.Windows.Forms.Button BS_Board_5;
        private System.Windows.Forms.Button BS_Board_6;
        private System.Windows.Forms.Button BS_Board_7;
        private System.Windows.Forms.Button BS_Board_8;
        private System.Windows.Forms.Button BS_Board_4;
        private System.Windows.Forms.Button BS_Board_3;
        private System.Windows.Forms.Button BS_Board_2;
        private System.Windows.Forms.Button BS_Board_1;
        private System.Windows.Forms.Panel PNL_GF_Control;
        private System.Windows.Forms.Button BS_Board_0;
        private System.Windows.Forms.Button BS_GF_ColorSetting;
    }
}

