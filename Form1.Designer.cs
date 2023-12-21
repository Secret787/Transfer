namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbx_message = new TextBox();
            dgv_source = new DataGridView();
            dgv_channel = new DataGridView();
            dgv_info = new DataGridView();
            btn_ok = new Button();
            btn_gen = new Button();
            bnt_sym = new Button();
            tbx_proba = new TextBox();
            btn_clear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbl_max_res = new Label();
            lbl_cross_res = new Label();
            btn_solve = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_source).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_channel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_info).BeginInit();
            SuspendLayout();
            // 
            // tbx_message
            // 
            tbx_message.Location = new Point(137, 9);
            tbx_message.Name = "tbx_message";
            tbx_message.Size = new Size(197, 23);
            tbx_message.TabIndex = 0;
            // 
            // dgv_source
            // 
            dgv_source.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_source.ColumnHeadersVisible = false;
            dgv_source.Location = new Point(137, 51);
            dgv_source.Name = "dgv_source";
            dgv_source.RowHeadersVisible = false;
            dgv_source.RowTemplate.Height = 25;
            dgv_source.ScrollBars = ScrollBars.None;
            dgv_source.Size = new Size(197, 231);
            dgv_source.TabIndex = 1;
            // 
            // dgv_channel
            // 
            dgv_channel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_channel.Location = new Point(137, 322);
            dgv_channel.Name = "dgv_channel";
            dgv_channel.RowTemplate.Height = 25;
            dgv_channel.Size = new Size(240, 77);
            dgv_channel.TabIndex = 2;
            // 
            // dgv_info
            // 
            dgv_info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_info.Location = new Point(137, 476);
            dgv_info.Name = "dgv_info";
            dgv_info.RowTemplate.Height = 25;
            dgv_info.Size = new Size(240, 100);
            dgv_info.TabIndex = 3;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(410, 9);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(77, 23);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_gen
            // 
            btn_gen.Location = new Point(410, 113);
            btn_gen.Name = "btn_gen";
            btn_gen.Size = new Size(77, 37);
            btn_gen.TabIndex = 5;
            btn_gen.Text = "Random";
            btn_gen.UseVisualStyleBackColor = true;
            btn_gen.Click += btn_gen_Click;
            // 
            // bnt_sym
            // 
            bnt_sym.Location = new Point(410, 156);
            bnt_sym.Name = "bnt_sym";
            bnt_sym.Size = new Size(77, 37);
            bnt_sym.TabIndex = 6;
            bnt_sym.Text = "Channel";
            bnt_sym.UseVisualStyleBackColor = true;
            bnt_sym.Click += bnt_sym_Click;
            // 
            // tbx_proba
            // 
            tbx_proba.Location = new Point(410, 201);
            tbx_proba.Name = "tbx_proba";
            tbx_proba.Size = new Size(77, 23);
            tbx_proba.TabIndex = 7;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(516, 9);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(77, 23);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "Очистить";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 9;
            label1.Text = "Сообщение";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 415);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 415);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 13;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 415);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "label6";
            // 
            // lbl_max_res
            // 
            lbl_max_res.AutoSize = true;
            lbl_max_res.Location = new Point(232, 415);
            lbl_max_res.Name = "lbl_max_res";
            lbl_max_res.Size = new Size(38, 15);
            lbl_max_res.TabIndex = 15;
            lbl_max_res.Text = "label7";
            // 
            // lbl_cross_res
            // 
            lbl_cross_res.AutoSize = true;
            lbl_cross_res.Location = new Point(339, 415);
            lbl_cross_res.Name = "lbl_cross_res";
            lbl_cross_res.Size = new Size(38, 15);
            lbl_cross_res.TabIndex = 16;
            lbl_cross_res.Text = "label8";
            // 
            // btn_solve
            // 
            btn_solve.Location = new Point(137, 433);
            btn_solve.Name = "btn_solve";
            btn_solve.Size = new Size(97, 37);
            btn_solve.TabIndex = 17;
            btn_solve.Text = "Расчитать";
            btn_solve.UseVisualStyleBackColor = true;
            btn_solve.Click += btn_solve_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 620);
            Controls.Add(btn_solve);
            Controls.Add(lbl_cross_res);
            Controls.Add(lbl_max_res);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_clear);
            Controls.Add(tbx_proba);
            Controls.Add(bnt_sym);
            Controls.Add(btn_gen);
            Controls.Add(btn_ok);
            Controls.Add(dgv_info);
            Controls.Add(dgv_channel);
            Controls.Add(dgv_source);
            Controls.Add(tbx_message);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_source).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_channel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_info).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_message;
        private DataGridView dgv_source;
        private DataGridView dgv_channel;
        private DataGridView dgv_info;
        private Button btn_ok;
        private Button btn_gen;
        private Button bnt_sym;
        private TextBox tbx_proba;
        private Button btn_clear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_max_res;
        private Label lbl_cross_res;
        private Button btn_solve;
    }
}