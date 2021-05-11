namespace Calculator
{
    partial class Calc
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Value1 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.value2Txt = new System.Windows.Forms.TextBox();
            this.value1Txt = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(35, 142);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(89, 29);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(140, 142);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 29);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(246, 142);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 29);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Location = new System.Drawing.Point(95, 47);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(43, 13);
            this.Value1.TabIndex = 0;
            this.Value1.Text = "Value &1";
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Cursor = System.Windows.Forms.Cursors.No;
            this.Value2.Location = new System.Drawing.Point(93, 73);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(46, 13);
            this.Value2.TabIndex = 2;
            this.Value2.Text = " Value &2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "R&esult";
            // 
            // resultTxt
            // 
            this.resultTxt.Location = new System.Drawing.Point(149, 96);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.ReadOnly = true;
            this.resultTxt.Size = new System.Drawing.Size(129, 20);
            this.resultTxt.TabIndex = 5;
            // 
            // value2Txt
            // 
            this.value2Txt.Location = new System.Drawing.Point(149, 70);
            this.value2Txt.Name = "value2Txt";
            this.value2Txt.Size = new System.Drawing.Size(129, 20);
            this.value2Txt.TabIndex = 3;
            // 
            // value1Txt
            // 
            this.value1Txt.Location = new System.Drawing.Point(149, 44);
            this.value1Txt.Name = "value1Txt";
            this.value1Txt.Size = new System.Drawing.Size(129, 20);
            this.value1Txt.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(159, 19);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(91, 13);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Value 1 + Value 2";
            // 
            // Calc
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(371, 203);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.value1Txt);
            this.Controls.Add(this.value2Txt);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Label Value2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.TextBox value2Txt;
        private System.Windows.Forms.TextBox value1Txt;
        private System.Windows.Forms.Label lblDesc;
    }
}

