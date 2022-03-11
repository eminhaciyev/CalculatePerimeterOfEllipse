
namespace CalcPerimeterOfEllipseWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSizeValue = new System.Windows.Forms.TextBox();
            this.btnSendToServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBigDIameterValue = new System.Windows.Forms.Label();
            this.lblSmallDiameterValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPerimeterResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pcbLoader = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bracelet Size";
            // 
            // txtSizeValue
            // 
            this.txtSizeValue.Location = new System.Drawing.Point(319, 86);
            this.txtSizeValue.Multiline = true;
            this.txtSizeValue.Name = "txtSizeValue";
            this.txtSizeValue.Size = new System.Drawing.Size(148, 24);
            this.txtSizeValue.TabIndex = 1;
            // 
            // btnSendToServer
            // 
            this.btnSendToServer.Location = new System.Drawing.Point(353, 130);
            this.btnSendToServer.Name = "btnSendToServer";
            this.btnSendToServer.Size = new System.Drawing.Size(114, 35);
            this.btnSendToServer.TabIndex = 2;
            this.btnSendToServer.Text = "Send To Server";
            this.btnSendToServer.UseVisualStyleBackColor = true;
            this.btnSendToServer.Click += new System.EventHandler(this.btnSendToServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Big Diameter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(319, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Small Diameter";
            // 
            // lblBigDIameterValue
            // 
            this.lblBigDIameterValue.AutoSize = true;
            this.lblBigDIameterValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBigDIameterValue.Location = new System.Drawing.Point(161, 255);
            this.lblBigDIameterValue.Name = "lblBigDIameterValue";
            this.lblBigDIameterValue.Size = new System.Drawing.Size(0, 21);
            this.lblBigDIameterValue.TabIndex = 5;
            // 
            // lblSmallDiameterValue
            // 
            this.lblSmallDiameterValue.AutoSize = true;
            this.lblSmallDiameterValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSmallDiameterValue.Location = new System.Drawing.Point(463, 254);
            this.lblSmallDiameterValue.Name = "lblSmallDiameterValue";
            this.lblSmallDiameterValue.Size = new System.Drawing.Size(0, 21);
            this.lblSmallDiameterValue.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Perimeter Result";
            // 
            // lblPerimeterResult
            // 
            this.lblPerimeterResult.AutoSize = true;
            this.lblPerimeterResult.Location = new System.Drawing.Point(199, 374);
            this.lblPerimeterResult.Name = "lblPerimeterResult";
            this.lblPerimeterResult.Size = new System.Drawing.Size(0, 15);
            this.lblPerimeterResult.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(345, 296);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 35);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pcbLoader
            // 
            this.pcbLoader.Image = global::CalcPerimeterOfEllipseWinForm.Properties.Resources.Spinner_loading;
            this.pcbLoader.Location = new System.Drawing.Point(199, 221);
            this.pcbLoader.Name = "pcbLoader";
            this.pcbLoader.Size = new System.Drawing.Size(96, 98);
            this.pcbLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLoader.TabIndex = 10;
            this.pcbLoader.TabStop = false;
            this.pcbLoader.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(40, 441);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Calculate approximation formulas of perimeter of ellipse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(535, 555);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pcbLoader);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPerimeterResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSmallDiameterValue);
            this.Controls.Add(this.lblBigDIameterValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendToServer);
            this.Controls.Add(this.txtSizeValue);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calc";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSizeValue;
        private System.Windows.Forms.Button btnSendToServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBigDIameterValue;
        private System.Windows.Forms.Label lblSmallDiameterValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPerimeterResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox pcbLoader;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
    }
}

