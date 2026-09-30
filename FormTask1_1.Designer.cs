namespace lab2
{
    partial class FormTask1_1
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.Location = new System.Drawing.Point(209, 203);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(44, 29);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "x =";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY.Location = new System.Drawing.Point(209, 273);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(44, 29);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "y =";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZ.Location = new System.Drawing.Point(209, 343);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(44, 29);
            this.lblZ.TabIndex = 2;
            this.lblZ.Text = "z =";
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbX.Location = new System.Drawing.Point(260, 198);
            this.tbX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 34);
            this.tbX.TabIndex = 1;
            this.tbX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyTextBox_KeyDown);
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // tbY
            // 
            this.tbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbY.Location = new System.Drawing.Point(260, 273);
            this.tbY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 34);
            this.tbY.TabIndex = 2;
            this.tbY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyTextBox_KeyDown);
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // tbZ
            // 
            this.tbZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbZ.Location = new System.Drawing.Point(260, 343);
            this.tbZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(100, 34);
            this.tbZ.TabIndex = 3;
            this.tbZ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnyTextBox_KeyDown);
            this.tbZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(55, 486);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(204, 415);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(163, 49);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTask.Location = new System.Drawing.Point(16, 142);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(251, 29);
            this.lblTask.TabIndex = 9;
            this.lblTask.Text = "Вычислить a, b, если:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(423, 501);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 49);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Следующее";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.Image = global::lab2.Properties.Resources.Снимок_экрана_2026_09_27_104851;
            this.pictureBoxB.Location = new System.Drawing.Point(309, 14);
            this.pictureBoxB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(247, 111);
            this.pictureBoxB.TabIndex = 10;
            this.pictureBoxB.TabStop = false;
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.Image = global::lab2.Properties.Resources.Снимок_экрана_2026_09_27_104949;
            this.pictureBoxA.Location = new System.Drawing.Point(15, 11);
            this.pictureBoxA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(264, 113);
            this.pictureBoxA.TabIndex = 8;
            this.pictureBoxA.TabStop = false;
            // 
            // FormTask1_1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(571, 561);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.pictureBoxA);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTask1_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 1.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.Button btnNext;
    }
}