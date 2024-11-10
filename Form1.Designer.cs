using System.Windows.Forms;

namespace Task_6
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
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.datGrdViewIn = new System.Windows.Forms.DataGridView();
            this.datGrdViewRes = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datGrdViewIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGrdViewRes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxN
            // 
            this.txtBoxN.Location = new System.Drawing.Point(164, 98);
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(66, 20);
            this.txtBoxN.TabIndex = 0;
            this.txtBoxN.TextChanged += new System.EventHandler(this.txtBoxN_TextChanged);
            // 
            // datGrdViewIn
            // 
            this.datGrdViewIn.AllowUserToAddRows = false;
            this.datGrdViewIn.Location = new System.Drawing.Point(335, 41);
            this.datGrdViewIn.Name = "datGrdViewIn";
            this.datGrdViewIn.Size = new System.Drawing.Size(303, 192);
            this.datGrdViewIn.TabIndex = 1;
            // 
            // datGrdViewRes
            // 
            this.datGrdViewRes.AllowUserToAddRows = false;
            this.datGrdViewRes.Location = new System.Drawing.Point(335, 267);
            this.datGrdViewRes.Name = "datGrdViewRes";
            this.datGrdViewRes.Size = new System.Drawing.Size(303, 230);
            this.datGrdViewRes.TabIndex = 2;
            this.datGrdViewRes.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(164, 124);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(66, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Введите размер матрицы";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(650, 509);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBoxN);
            this.Controls.Add(this.datGrdViewIn);
            this.Controls.Add(this.datGrdViewRes);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Matrix Processing";
            ((System.ComponentModel.ISupportInitialize)(this.datGrdViewIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGrdViewRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtBoxN;
        private DataGridView datGrdViewIn;
        private DataGridView datGrdViewRes;
        private Button btnStart;
        private TextBox textBox1;
    }

        #endregion
   }


