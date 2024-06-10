namespace Game15
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
            this.TB_GF_Timer = new System.Windows.Forms.TextBox();
            this.L_Info_Timer = new System.Windows.Forms.Label();
            this.TB_GF_Moves = new System.Windows.Forms.TextBox();
            this.L_Info_MoveCount = new System.Windows.Forms.Label();
            this.MS_GF_Main = new System.Windows.Forms.MenuStrip();
            this.TSMI_Main_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Main_AllwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Main_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Game_NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Game_ResetGame = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Main_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Settings_ColorSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ColorSettings_Back = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ColorSettings_Text = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ColorSettings_Reverse = new System.Windows.Forms.ToolStripMenuItem();
            this.BS_GF_PauseResume = new System.Windows.Forms.Button();
            this.TSMI_GF_HightScore = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_GF_Username = new System.Windows.Forms.TextBox();
            this.L_Info_Username = new System.Windows.Forms.Label();
            this.BS_GF_ApplyUsername = new System.Windows.Forms.Button();
            this.TLP_GF_Main.SuspendLayout();
            this.TLP_GF_Board.SuspendLayout();
            this.PNL_GF_Control.SuspendLayout();
            this.MS_GF_Main.SuspendLayout();
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
            this.PNL_GF_Control.Controls.Add(this.BS_GF_ApplyUsername);
            this.PNL_GF_Control.Controls.Add(this.TB_GF_Username);
            this.PNL_GF_Control.Controls.Add(this.L_Info_Username);
            this.PNL_GF_Control.Controls.Add(this.BS_GF_PauseResume);
            this.PNL_GF_Control.Controls.Add(this.TB_GF_Timer);
            this.PNL_GF_Control.Controls.Add(this.L_Info_Timer);
            this.PNL_GF_Control.Controls.Add(this.TB_GF_Moves);
            this.PNL_GF_Control.Controls.Add(this.L_Info_MoveCount);
            this.PNL_GF_Control.Controls.Add(this.MS_GF_Main);
            this.PNL_GF_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_GF_Control.Location = new System.Drawing.Point(3, 3);
            this.PNL_GF_Control.Name = "PNL_GF_Control";
            this.PNL_GF_Control.Size = new System.Drawing.Size(464, 68);
            this.PNL_GF_Control.TabIndex = 1;
            // 
            // TB_GF_Timer
            // 
            this.TB_GF_Timer.BackColor = System.Drawing.Color.Black;
            this.TB_GF_Timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_GF_Timer.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_GF_Timer.ForeColor = System.Drawing.Color.OrangeRed;
            this.TB_GF_Timer.Location = new System.Drawing.Point(328, 43);
            this.TB_GF_Timer.Name = "TB_GF_Timer";
            this.TB_GF_Timer.Size = new System.Drawing.Size(66, 22);
            this.TB_GF_Timer.TabIndex = 4;
            this.TB_GF_Timer.Text = "00:00:00";
            this.TB_GF_Timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // L_Info_Timer
            // 
            this.L_Info_Timer.AutoSize = true;
            this.L_Info_Timer.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Info_Timer.ForeColor = System.Drawing.Color.OrangeRed;
            this.L_Info_Timer.Location = new System.Drawing.Point(325, 26);
            this.L_Info_Timer.Name = "L_Info_Timer";
            this.L_Info_Timer.Size = new System.Drawing.Size(36, 14);
            this.L_Info_Timer.TabIndex = 3;
            this.L_Info_Timer.Text = "Timer";
            // 
            // TB_GF_Moves
            // 
            this.TB_GF_Moves.BackColor = System.Drawing.Color.Black;
            this.TB_GF_Moves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_GF_Moves.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_GF_Moves.ForeColor = System.Drawing.Color.OrangeRed;
            this.TB_GF_Moves.Location = new System.Drawing.Point(400, 43);
            this.TB_GF_Moves.Name = "TB_GF_Moves";
            this.TB_GF_Moves.Size = new System.Drawing.Size(61, 22);
            this.TB_GF_Moves.TabIndex = 2;
            this.TB_GF_Moves.Text = "0";
            this.TB_GF_Moves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // L_Info_MoveCount
            // 
            this.L_Info_MoveCount.AutoSize = true;
            this.L_Info_MoveCount.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Info_MoveCount.ForeColor = System.Drawing.Color.OrangeRed;
            this.L_Info_MoveCount.Location = new System.Drawing.Point(397, 26);
            this.L_Info_MoveCount.Name = "L_Info_MoveCount";
            this.L_Info_MoveCount.Size = new System.Drawing.Size(64, 14);
            this.L_Info_MoveCount.TabIndex = 1;
            this.L_Info_MoveCount.Text = "Move count";
            // 
            // MS_GF_Main
            // 
            this.MS_GF_Main.BackColor = System.Drawing.Color.OrangeRed;
            this.MS_GF_Main.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MS_GF_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Main_File,
            this.TSMI_Main_Game,
            this.TSMI_Main_Settings,
            this.TSMI_GF_HightScore});
            this.MS_GF_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_GF_Main.Name = "MS_GF_Main";
            this.MS_GF_Main.Size = new System.Drawing.Size(464, 24);
            this.MS_GF_Main.TabIndex = 0;
            this.MS_GF_Main.Text = "menuStrip1";
            // 
            // TSMI_Main_File
            // 
            this.TSMI_Main_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Main_AllwaysOnTop});
            this.TSMI_Main_File.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMI_Main_File.ForeColor = System.Drawing.Color.Black;
            this.TSMI_Main_File.Name = "TSMI_Main_File";
            this.TSMI_Main_File.Size = new System.Drawing.Size(37, 20);
            this.TSMI_Main_File.Text = "File";
            // 
            // TSMI_Main_AllwaysOnTop
            // 
            this.TSMI_Main_AllwaysOnTop.BackColor = System.Drawing.Color.OrangeRed;
            this.TSMI_Main_AllwaysOnTop.CheckOnClick = true;
            this.TSMI_Main_AllwaysOnTop.Name = "TSMI_Main_AllwaysOnTop";
            this.TSMI_Main_AllwaysOnTop.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Main_AllwaysOnTop.Text = "Allways on top";
            this.TSMI_Main_AllwaysOnTop.Click += new System.EventHandler(this.TSMI_Main_AllwaysOnTop_Click);
            // 
            // TSMI_Main_Game
            // 
            this.TSMI_Main_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Game_NewGame,
            this.TSMI_Game_ResetGame});
            this.TSMI_Main_Game.Enabled = false;
            this.TSMI_Main_Game.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMI_Main_Game.ForeColor = System.Drawing.Color.Black;
            this.TSMI_Main_Game.Name = "TSMI_Main_Game";
            this.TSMI_Main_Game.Size = new System.Drawing.Size(47, 20);
            this.TSMI_Main_Game.Text = "Game";
            // 
            // TSMI_Game_NewGame
            // 
            this.TSMI_Game_NewGame.BackColor = System.Drawing.Color.OrangeRed;
            this.TSMI_Game_NewGame.ForeColor = System.Drawing.Color.Black;
            this.TSMI_Game_NewGame.Name = "TSMI_Game_NewGame";
            this.TSMI_Game_NewGame.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Game_NewGame.Text = "Start new game";
            // 
            // TSMI_Game_ResetGame
            // 
            this.TSMI_Game_ResetGame.BackColor = System.Drawing.Color.OrangeRed;
            this.TSMI_Game_ResetGame.ForeColor = System.Drawing.Color.Black;
            this.TSMI_Game_ResetGame.Name = "TSMI_Game_ResetGame";
            this.TSMI_Game_ResetGame.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Game_ResetGame.Text = "Reset game";
            // 
            // TSMI_Main_Settings
            // 
            this.TSMI_Main_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Settings_ColorSettings});
            this.TSMI_Main_Settings.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMI_Main_Settings.Name = "TSMI_Main_Settings";
            this.TSMI_Main_Settings.Size = new System.Drawing.Size(59, 20);
            this.TSMI_Main_Settings.Text = "Settings";
            // 
            // TSMI_Settings_ColorSettings
            // 
            this.TSMI_Settings_ColorSettings.BackColor = System.Drawing.Color.OrangeRed;
            this.TSMI_Settings_ColorSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ColorSettings_Back,
            this.TSMI_ColorSettings_Text,
            this.TSMI_ColorSettings_Reverse});
            this.TSMI_Settings_ColorSettings.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMI_Settings_ColorSettings.ForeColor = System.Drawing.Color.Black;
            this.TSMI_Settings_ColorSettings.Name = "TSMI_Settings_ColorSettings";
            this.TSMI_Settings_ColorSettings.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Settings_ColorSettings.Text = "Color settings";
            // 
            // TSMI_ColorSettings_Back
            // 
            this.TSMI_ColorSettings_Back.BackColor = System.Drawing.Color.OrangeRed;
            this.TSMI_ColorSettings_Back.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMI_ColorSettings_Back.ForeColor = System.Drawing.Color.Black;
            this.TSMI_ColorSettings_Back.Name = "TSMI_ColorSettings_Back";
            this.TSMI_ColorSettings_Back.Size = new System.Drawing.Size(180, 22);
            this.TSMI_ColorSettings_Back.Text = "Set Back Color";
            this.TSMI_ColorSettings_Back.Click += new System.EventHandler(this.TSMI_ColorSettings_Back_Click);
            // 
            // TSMI_ColorSettings_Text
            // 
            this.TSMI_ColorSettings_Text.BackColor = System.Drawing.Color.OrangeRed;
            this.TSMI_ColorSettings_Text.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMI_ColorSettings_Text.ForeColor = System.Drawing.Color.Black;
            this.TSMI_ColorSettings_Text.Name = "TSMI_ColorSettings_Text";
            this.TSMI_ColorSettings_Text.Size = new System.Drawing.Size(180, 22);
            this.TSMI_ColorSettings_Text.Text = "Set Text Color";
            this.TSMI_ColorSettings_Text.Click += new System.EventHandler(this.TSMI_ColorSettings_Text_Click);
            // 
            // TSMI_ColorSettings_Reverse
            // 
            this.TSMI_ColorSettings_Reverse.BackColor = System.Drawing.Color.OrangeRed;
            this.TSMI_ColorSettings_Reverse.ForeColor = System.Drawing.Color.Black;
            this.TSMI_ColorSettings_Reverse.Name = "TSMI_ColorSettings_Reverse";
            this.TSMI_ColorSettings_Reverse.Size = new System.Drawing.Size(180, 22);
            this.TSMI_ColorSettings_Reverse.Text = "Reverse Colors";
            this.TSMI_ColorSettings_Reverse.Click += new System.EventHandler(this.TSMI_ColorSettings_Reverse_Click);
            // 
            // BS_GF_PauseResume
            // 
            this.BS_GF_PauseResume.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_GF_PauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_GF_PauseResume.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BS_GF_PauseResume.ForeColor = System.Drawing.Color.Black;
            this.BS_GF_PauseResume.Location = new System.Drawing.Point(247, 41);
            this.BS_GF_PauseResume.Name = "BS_GF_PauseResume";
            this.BS_GF_PauseResume.Size = new System.Drawing.Size(75, 25);
            this.BS_GF_PauseResume.TabIndex = 5;
            this.BS_GF_PauseResume.Text = "Pause";
            this.BS_GF_PauseResume.UseVisualStyleBackColor = false;
            this.BS_GF_PauseResume.Visible = false;
            // 
            // TSMI_GF_HightScore
            // 
            this.TSMI_GF_HightScore.Name = "TSMI_GF_HightScore";
            this.TSMI_GF_HightScore.Size = new System.Drawing.Size(76, 20);
            this.TSMI_GF_HightScore.Text = "Hight Score";
            // 
            // TB_GF_Username
            // 
            this.TB_GF_Username.BackColor = System.Drawing.Color.Black;
            this.TB_GF_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_GF_Username.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_GF_Username.ForeColor = System.Drawing.Color.OrangeRed;
            this.TB_GF_Username.Location = new System.Drawing.Point(3, 43);
            this.TB_GF_Username.Name = "TB_GF_Username";
            this.TB_GF_Username.Size = new System.Drawing.Size(110, 22);
            this.TB_GF_Username.TabIndex = 7;
            this.TB_GF_Username.Text = "Player";
            this.TB_GF_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // L_Info_Username
            // 
            this.L_Info_Username.AutoSize = true;
            this.L_Info_Username.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Info_Username.ForeColor = System.Drawing.Color.OrangeRed;
            this.L_Info_Username.Location = new System.Drawing.Point(0, 26);
            this.L_Info_Username.Name = "L_Info_Username";
            this.L_Info_Username.Size = new System.Drawing.Size(56, 14);
            this.L_Info_Username.TabIndex = 6;
            this.L_Info_Username.Text = "Username";
            // 
            // BS_GF_ApplyUsername
            // 
            this.BS_GF_ApplyUsername.BackColor = System.Drawing.Color.OrangeRed;
            this.BS_GF_ApplyUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BS_GF_ApplyUsername.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BS_GF_ApplyUsername.ForeColor = System.Drawing.Color.Black;
            this.BS_GF_ApplyUsername.Location = new System.Drawing.Point(119, 41);
            this.BS_GF_ApplyUsername.Name = "BS_GF_ApplyUsername";
            this.BS_GF_ApplyUsername.Size = new System.Drawing.Size(110, 25);
            this.BS_GF_ApplyUsername.TabIndex = 8;
            this.BS_GF_ApplyUsername.Text = "Apply username";
            this.BS_GF_ApplyUsername.UseVisualStyleBackColor = false;
            this.BS_GF_ApplyUsername.Click += new System.EventHandler(this.BS_GF_ApplyUsername_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 511);
            this.Controls.Add(this.TLP_GF_Main);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.MS_GF_Main;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2024";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.TLP_GF_Main.ResumeLayout(false);
            this.TLP_GF_Board.ResumeLayout(false);
            this.PNL_GF_Control.ResumeLayout(false);
            this.PNL_GF_Control.PerformLayout();
            this.MS_GF_Main.ResumeLayout(false);
            this.MS_GF_Main.PerformLayout();
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
        private System.Windows.Forms.Button BS_Board_0;
        private System.Windows.Forms.Panel PNL_GF_Control;
        private System.Windows.Forms.MenuStrip MS_GF_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Main_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Main_AllwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Main_Game;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Main_Settings;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Settings_ColorSettings;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ColorSettings_Back;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ColorSettings_Text;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ColorSettings_Reverse;
        private System.Windows.Forms.TextBox TB_GF_Moves;
        private System.Windows.Forms.Label L_Info_MoveCount;
        private System.Windows.Forms.TextBox TB_GF_Timer;
        private System.Windows.Forms.Label L_Info_Timer;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Game_NewGame;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Game_ResetGame;
        private System.Windows.Forms.Button BS_GF_PauseResume;
        private System.Windows.Forms.Button BS_GF_ApplyUsername;
        private System.Windows.Forms.TextBox TB_GF_Username;
        private System.Windows.Forms.Label L_Info_Username;
        private System.Windows.Forms.ToolStripMenuItem TSMI_GF_HightScore;
    }
}

