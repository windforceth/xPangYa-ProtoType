
namespace xPangPrototype
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSpinCurve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpin = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPx = new System.Windows.Forms.Label();
            this.lblPb = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCurve = new System.Windows.Forms.Label();
            this.lblSpin = new System.Windows.Forms.Label();
            this.flexTime = new System.Windows.Forms.Timer(this.components);
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.txtPB);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PB";
            // 
            // txtPB
            // 
            this.txtPB.Location = new System.Drawing.Point(6, 20);
            this.txtPB.Name = "txtPB";
            this.txtPB.Size = new System.Drawing.Size(62, 21);
            this.txtPB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSpinCurve);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCurve);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSpin);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spin-Curve";
            // 
            // btnSpinCurve
            // 
            this.btnSpinCurve.Location = new System.Drawing.Point(103, 17);
            this.btnSpinCurve.Name = "btnSpinCurve";
            this.btnSpinCurve.Size = new System.Drawing.Size(67, 21);
            this.btnSpinCurve.TabIndex = 4;
            this.btnSpinCurve.Text = "Ok";
            this.btnSpinCurve.UseVisualStyleBackColor = true;
            this.btnSpinCurve.Click += new System.EventHandler(this.btnSpinCurve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curve -";
            // 
            // txtCurve
            // 
            this.txtCurve.Location = new System.Drawing.Point(56, 37);
            this.txtCurve.Name = "txtCurve";
            this.txtCurve.Size = new System.Drawing.Size(43, 21);
            this.txtCurve.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spin -";
            // 
            // txtSpin
            // 
            this.txtSpin.Location = new System.Drawing.Point(56, 17);
            this.txtSpin.Name = "txtSpin";
            this.txtSpin.Size = new System.Drawing.Size(43, 21);
            this.txtSpin.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPx);
            this.groupBox3.Controls.Add(this.lblPb);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox3.Location = new System.Drawing.Point(10, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 58);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PB - PX";
            // 
            // lblPx
            // 
            this.lblPx.AutoSize = true;
            this.lblPx.Location = new System.Drawing.Point(6, 32);
            this.lblPx.Name = "lblPx";
            this.lblPx.Size = new System.Drawing.Size(26, 13);
            this.lblPx.TabIndex = 5;
            this.lblPx.Text = "PX -";
            // 
            // lblPb
            // 
            this.lblPb.AutoSize = true;
            this.lblPb.Location = new System.Drawing.Point(6, 15);
            this.lblPb.Name = "lblPb";
            this.lblPb.Size = new System.Drawing.Size(26, 13);
            this.lblPb.TabIndex = 4;
            this.lblPb.Text = "PB -";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCurve);
            this.groupBox4.Controls.Add(this.lblSpin);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox4.Location = new System.Drawing.Point(98, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(91, 58);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spin - Curve";
            // 
            // lblCurve
            // 
            this.lblCurve.AutoSize = true;
            this.lblCurve.Location = new System.Drawing.Point(6, 32);
            this.lblCurve.Name = "lblCurve";
            this.lblCurve.Size = new System.Drawing.Size(43, 13);
            this.lblCurve.TabIndex = 5;
            this.lblCurve.Text = "Curve -";
            // 
            // lblSpin
            // 
            this.lblSpin.AutoSize = true;
            this.lblSpin.Location = new System.Drawing.Point(14, 15);
            this.lblSpin.Name = "lblSpin";
            this.lblSpin.Size = new System.Drawing.Size(34, 13);
            this.lblSpin.TabIndex = 4;
            this.lblSpin.Text = "Spin -";
            // 
            // flexTime
            // 
            this.flexTime.Enabled = true;
            this.flexTime.Interval = 10;
            this.flexTime.Tick += new System.EventHandler(this.flexTime_Tick);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(72, 20);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(48, 22);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(122, 20);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(48, 22);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 217);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "xPangYa 0.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpin;
        private System.Windows.Forms.Button btnSpinCurve;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPx;
        private System.Windows.Forms.Label lblPb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblCurve;
        private System.Windows.Forms.Label lblSpin;
        private System.Windows.Forms.Timer flexTime;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}

