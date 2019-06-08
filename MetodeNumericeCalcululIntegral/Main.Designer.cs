namespace MetodeNumericeCalcululIntegral
{
    partial class Main
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
            this.btn_Integrate = new System.Windows.Forms.Button();
            this.lbl_Func = new System.Windows.Forms.Label();
            this.lbl_Integral = new System.Windows.Forms.Label();
            this.lbl_FromA = new System.Windows.Forms.Label();
            this.lbl_ToB = new System.Windows.Forms.Label();
            this.lbl_IntegralFunc = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_Func = new System.Windows.Forms.TextBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // btn_Integrate
            // 
            this.btn_Integrate.Location = new System.Drawing.Point(367, 396);
            this.btn_Integrate.Name = "btn_Integrate";
            this.btn_Integrate.Size = new System.Drawing.Size(167, 54);
            this.btn_Integrate.TabIndex = 3;
            this.btn_Integrate.Text = "Integrate";
            this.btn_Integrate.UseVisualStyleBackColor = true;
            this.btn_Integrate.Click += new System.EventHandler(this.btn_Integrate_Click);
            // 
            // lbl_Func
            // 
            this.lbl_Func.AutoSize = true;
            this.lbl_Func.Location = new System.Drawing.Point(106, 23);
            this.lbl_Func.Name = "lbl_Func";
            this.lbl_Func.Size = new System.Drawing.Size(68, 30);
            this.lbl_Func.TabIndex = 1;
            this.lbl_Func.Text = "f(x) = ";
            // 
            // lbl_Integral
            // 
            this.lbl_Integral.AutoSize = true;
            this.lbl_Integral.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Integral.Location = new System.Drawing.Point(77, 192);
            this.lbl_Integral.Name = "lbl_Integral";
            this.lbl_Integral.Size = new System.Drawing.Size(54, 65);
            this.lbl_Integral.TabIndex = 2;
            this.lbl_Integral.Text = "∫";
            // 
            // lbl_FromA
            // 
            this.lbl_FromA.AutoSize = true;
            this.lbl_FromA.Location = new System.Drawing.Point(89, 268);
            this.lbl_FromA.Name = "lbl_FromA";
            this.lbl_FromA.Size = new System.Drawing.Size(24, 30);
            this.lbl_FromA.TabIndex = 3;
            this.lbl_FromA.Text = "a";
            // 
            // lbl_ToB
            // 
            this.lbl_ToB.AutoSize = true;
            this.lbl_ToB.Location = new System.Drawing.Point(89, 162);
            this.lbl_ToB.Name = "lbl_ToB";
            this.lbl_ToB.Size = new System.Drawing.Size(25, 30);
            this.lbl_ToB.TabIndex = 4;
            this.lbl_ToB.Text = "b";
            // 
            // lbl_IntegralFunc
            // 
            this.lbl_IntegralFunc.AutoSize = true;
            this.lbl_IntegralFunc.Location = new System.Drawing.Point(134, 214);
            this.lbl_IntegralFunc.Name = "lbl_IntegralFunc";
            this.lbl_IntegralFunc.Size = new System.Drawing.Size(96, 30);
            this.lbl_IntegralFunc.TabIndex = 5;
            this.lbl_IntegralFunc.Text = "f(x) dx = ";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(129, 379);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(100, 35);
            this.txt_A.TabIndex = 1;
            // 
            // txt_Func
            // 
            this.txt_Func.Location = new System.Drawing.Point(168, 23);
            this.txt_Func.Name = "txt_Func";
            this.txt_Func.Size = new System.Drawing.Size(353, 35);
            this.txt_Func.TabIndex = 0;
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(236, 211);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(274, 35);
            this.txt_Result.TabIndex = 20;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(129, 420);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(100, 35);
            this.txt_B.TabIndex = 2;
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(81, 379);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(50, 30);
            this.lbl_A.TabIndex = 10;
            this.lbl_A.Text = "a = ";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Location = new System.Drawing.Point(80, 420);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(51, 30);
            this.lbl_B.TabIndex = 11;
            this.lbl_B.Text = "b = ";
            // 
            // plot1
            // 
            this.plot1.Location = new System.Drawing.Point(599, 23);
            this.plot1.Margin = new System.Windows.Forms.Padding(0);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(632, 446);
            this.plot1.TabIndex = 12;
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 505);
            this.Controls.Add(this.plot1);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_Func);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.lbl_IntegralFunc);
            this.Controls.Add(this.lbl_ToB);
            this.Controls.Add(this.lbl_FromA);
            this.Controls.Add(this.lbl_Integral);
            this.Controls.Add(this.lbl_Func);
            this.Controls.Add(this.btn_Integrate);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Integrate;
        private System.Windows.Forms.Label lbl_Func;
        private System.Windows.Forms.Label lbl_Integral;
        private System.Windows.Forms.Label lbl_FromA;
        private System.Windows.Forms.Label lbl_ToB;
        private System.Windows.Forms.Label lbl_IntegralFunc;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_Func;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
        private OxyPlot.WindowsForms.PlotView plot1;
    }
}

