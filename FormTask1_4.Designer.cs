namespace lab2
{
    partial class FormTask1_4
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
            this.lblFigure = new System.Windows.Forms.Label();
            this.cbFigure = new System.Windows.Forms.ComboBox();
            this.pnlRect = new System.Windows.Forms.Panel();
            this.pbRect = new System.Windows.Forms.PictureBox();
            this.tbRectB = new System.Windows.Forms.TextBox();
            this.lblRectB = new System.Windows.Forms.Label();
            this.tbRectA = new System.Windows.Forms.TextBox();
            this.lblRectA = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlTriangle = new System.Windows.Forms.Panel();
            this.pbTriangle = new System.Windows.Forms.PictureBox();
            this.tbTriH = new System.Windows.Forms.TextBox();
            this.lblTriH = new System.Windows.Forms.Label();
            this.tbTriA = new System.Windows.Forms.TextBox();
            this.lblTriA = new System.Windows.Forms.Label();
            this.pnlTrapezoid = new System.Windows.Forms.Panel();
            this.pbTrapezoid = new System.Windows.Forms.PictureBox();
            this.tbTrB = new System.Windows.Forms.TextBox();
            this.lblTrB = new System.Windows.Forms.Label();
            this.tbTrA = new System.Windows.Forms.TextBox();
            this.lblTrA = new System.Windows.Forms.Label();
            this.tbTrH = new System.Windows.Forms.TextBox();
            this.lblTrH = new System.Windows.Forms.Label();
            this.pnlCircle = new System.Windows.Forms.Panel();
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.tbCircR = new System.Windows.Forms.TextBox();
            this.lblCircR = new System.Windows.Forms.Label();
            this.pnlSector = new System.Windows.Forms.Panel();
            this.pbSector = new System.Windows.Forms.PictureBox();
            this.tbSectR = new System.Windows.Forms.TextBox();
            this.lblSectR = new System.Windows.Forms.Label();
            this.tbSectAngle = new System.Windows.Forms.TextBox();
            this.lblSectAngle = new System.Windows.Forms.Label();
            this.pnlRect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRect)).BeginInit();
            this.pnlTriangle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangle)).BeginInit();
            this.pnlTrapezoid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrapezoid)).BeginInit();
            this.pnlCircle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            this.pnlSector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSector)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFigure
            // 
            this.lblFigure.AutoSize = true;
            this.lblFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFigure.Location = new System.Drawing.Point(10, 15);
            this.lblFigure.Name = "lblFigure";
            this.lblFigure.Size = new System.Drawing.Size(178, 24);
            this.lblFigure.TabIndex = 0;
            this.lblFigure.Text = "Выберите фигуру: ";
            // 
            // cbFigure
            // 
            this.cbFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFigure.FormattingEnabled = true;
            this.cbFigure.Items.AddRange(new object[] {
            "Прямоугольник",
            "Треугольник",
            "Трапеция",
            "Круг",
            "Сектор круга"});
            this.cbFigure.Location = new System.Drawing.Point(194, 12);
            this.cbFigure.Name = "cbFigure";
            this.cbFigure.Size = new System.Drawing.Size(233, 32);
            this.cbFigure.TabIndex = 1;
            this.cbFigure.SelectedIndexChanged += new System.EventHandler(this.cbFigure_SelectedIndexChanged);
            // 
            // pnlRect
            // 
            this.pnlRect.Controls.Add(this.pbRect);
            this.pnlRect.Controls.Add(this.tbRectB);
            this.pnlRect.Controls.Add(this.lblRectB);
            this.pnlRect.Controls.Add(this.tbRectA);
            this.pnlRect.Controls.Add(this.lblRectA);
            this.pnlRect.Location = new System.Drawing.Point(15, 48);
            this.pnlRect.Name = "pnlRect";
            this.pnlRect.Size = new System.Drawing.Size(521, 210);
            this.pnlRect.TabIndex = 2;
            // 
            // pbRect
            // 
            this.pbRect.Image = global::lab2.Properties.Resources.Task1_4_rect;
            this.pbRect.Location = new System.Drawing.Point(280, 0);
            this.pbRect.Name = "pbRect";
            this.pbRect.Size = new System.Drawing.Size(238, 207);
            this.pbRect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRect.TabIndex = 31;
            this.pbRect.TabStop = false;
            // 
            // tbRectB
            // 
            this.tbRectB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRectB.Location = new System.Drawing.Point(142, 113);
            this.tbRectB.Margin = new System.Windows.Forms.Padding(2);
            this.tbRectB.Name = "tbRectB";
            this.tbRectB.Size = new System.Drawing.Size(115, 28);
            this.tbRectB.TabIndex = 28;
            // 
            // lblRectB
            // 
            this.lblRectB.AutoSize = true;
            this.lblRectB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRectB.Location = new System.Drawing.Point(16, 113);
            this.lblRectB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRectB.Name = "lblRectB";
            this.lblRectB.Size = new System.Drawing.Size(120, 24);
            this.lblRectB.TabIndex = 30;
            this.lblRectB.Text = "Введите b =";
            // 
            // tbRectA
            // 
            this.tbRectA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRectA.Location = new System.Drawing.Point(142, 69);
            this.tbRectA.Margin = new System.Windows.Forms.Padding(2);
            this.tbRectA.Name = "tbRectA";
            this.tbRectA.Size = new System.Drawing.Size(115, 28);
            this.tbRectA.TabIndex = 27;
            // 
            // lblRectA
            // 
            this.lblRectA.AutoSize = true;
            this.lblRectA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRectA.Location = new System.Drawing.Point(17, 73);
            this.lblRectA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRectA.Name = "lblRectA";
            this.lblRectA.Size = new System.Drawing.Size(119, 24);
            this.lblRectA.TabIndex = 29;
            this.lblRectA.Text = "Введите a =";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(9, 369);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(445, 369);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 40);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "Следующее";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(216, 262);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(122, 40);
            this.btnCalc.TabIndex = 31;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(174, 318);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 33;
            // 
            // pnlTriangle
            // 
            this.pnlTriangle.Controls.Add(this.pbTriangle);
            this.pnlTriangle.Controls.Add(this.tbTriH);
            this.pnlTriangle.Controls.Add(this.lblTriH);
            this.pnlTriangle.Controls.Add(this.tbTriA);
            this.pnlTriangle.Controls.Add(this.lblTriA);
            this.pnlTriangle.Location = new System.Drawing.Point(14, 48);
            this.pnlTriangle.Name = "pnlTriangle";
            this.pnlTriangle.Size = new System.Drawing.Size(521, 210);
            this.pnlTriangle.TabIndex = 32;
            // 
            // pbTriangle
            // 
            this.pbTriangle.Image = global::lab2.Properties.Resources.Task1_4_Triangle;
            this.pbTriangle.Location = new System.Drawing.Point(280, 0);
            this.pbTriangle.Name = "pbTriangle";
            this.pbTriangle.Size = new System.Drawing.Size(238, 207);
            this.pbTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTriangle.TabIndex = 31;
            this.pbTriangle.TabStop = false;
            // 
            // tbTriH
            // 
            this.tbTriH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTriH.Location = new System.Drawing.Point(142, 113);
            this.tbTriH.Margin = new System.Windows.Forms.Padding(2);
            this.tbTriH.Name = "tbTriH";
            this.tbTriH.Size = new System.Drawing.Size(115, 28);
            this.tbTriH.TabIndex = 28;
            // 
            // lblTriH
            // 
            this.lblTriH.AutoSize = true;
            this.lblTriH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTriH.Location = new System.Drawing.Point(16, 113);
            this.lblTriH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriH.Name = "lblTriH";
            this.lblTriH.Size = new System.Drawing.Size(120, 24);
            this.lblTriH.TabIndex = 30;
            this.lblTriH.Text = "Введите h =";
            // 
            // tbTriA
            // 
            this.tbTriA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTriA.Location = new System.Drawing.Point(142, 69);
            this.tbTriA.Margin = new System.Windows.Forms.Padding(2);
            this.tbTriA.Name = "tbTriA";
            this.tbTriA.Size = new System.Drawing.Size(115, 28);
            this.tbTriA.TabIndex = 27;
            // 
            // lblTriA
            // 
            this.lblTriA.AutoSize = true;
            this.lblTriA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTriA.Location = new System.Drawing.Point(17, 73);
            this.lblTriA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriA.Name = "lblTriA";
            this.lblTriA.Size = new System.Drawing.Size(119, 24);
            this.lblTriA.TabIndex = 29;
            this.lblTriA.Text = "Введите a =";
            // 
            // pnlTrapezoid
            // 
            this.pnlTrapezoid.Controls.Add(this.tbTrH);
            this.pnlTrapezoid.Controls.Add(this.lblTrH);
            this.pnlTrapezoid.Controls.Add(this.pbTrapezoid);
            this.pnlTrapezoid.Controls.Add(this.tbTrB);
            this.pnlTrapezoid.Controls.Add(this.lblTrB);
            this.pnlTrapezoid.Controls.Add(this.tbTrA);
            this.pnlTrapezoid.Controls.Add(this.lblTrA);
            this.pnlTrapezoid.Location = new System.Drawing.Point(15, 48);
            this.pnlTrapezoid.Name = "pnlTrapezoid";
            this.pnlTrapezoid.Size = new System.Drawing.Size(521, 210);
            this.pnlTrapezoid.TabIndex = 33;
            // 
            // pbTrapezoid
            // 
            this.pbTrapezoid.Image = global::lab2.Properties.Resources.Task1_4_Trapez;
            this.pbTrapezoid.Location = new System.Drawing.Point(280, 2);
            this.pbTrapezoid.Name = "pbTrapezoid";
            this.pbTrapezoid.Size = new System.Drawing.Size(238, 207);
            this.pbTrapezoid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrapezoid.TabIndex = 31;
            this.pbTrapezoid.TabStop = false;
            // 
            // tbTrB
            // 
            this.tbTrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTrB.Location = new System.Drawing.Point(142, 91);
            this.tbTrB.Margin = new System.Windows.Forms.Padding(2);
            this.tbTrB.Name = "tbTrB";
            this.tbTrB.Size = new System.Drawing.Size(115, 28);
            this.tbTrB.TabIndex = 28;
            // 
            // lblTrB
            // 
            this.lblTrB.AutoSize = true;
            this.lblTrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrB.Location = new System.Drawing.Point(16, 93);
            this.lblTrB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrB.Name = "lblTrB";
            this.lblTrB.Size = new System.Drawing.Size(120, 24);
            this.lblTrB.TabIndex = 30;
            this.lblTrB.Text = "Введите b =";
            // 
            // tbTrA
            // 
            this.tbTrA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTrA.Location = new System.Drawing.Point(142, 49);
            this.tbTrA.Margin = new System.Windows.Forms.Padding(2);
            this.tbTrA.Name = "tbTrA";
            this.tbTrA.Size = new System.Drawing.Size(115, 28);
            this.tbTrA.TabIndex = 27;
            // 
            // lblTrA
            // 
            this.lblTrA.AutoSize = true;
            this.lblTrA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrA.Location = new System.Drawing.Point(17, 53);
            this.lblTrA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrA.Name = "lblTrA";
            this.lblTrA.Size = new System.Drawing.Size(119, 24);
            this.lblTrA.TabIndex = 29;
            this.lblTrA.Text = "Введите a =";
            // 
            // tbTrH
            // 
            this.tbTrH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTrH.Location = new System.Drawing.Point(141, 133);
            this.tbTrH.Margin = new System.Windows.Forms.Padding(2);
            this.tbTrH.Name = "tbTrH";
            this.tbTrH.Size = new System.Drawing.Size(115, 28);
            this.tbTrH.TabIndex = 32;
            // 
            // lblTrH
            // 
            this.lblTrH.AutoSize = true;
            this.lblTrH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrH.Location = new System.Drawing.Point(15, 133);
            this.lblTrH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrH.Name = "lblTrH";
            this.lblTrH.Size = new System.Drawing.Size(120, 24);
            this.lblTrH.TabIndex = 33;
            this.lblTrH.Text = "Введите h =";
            // 
            // pnlCircle
            // 
            this.pnlCircle.Controls.Add(this.pbCircle);
            this.pnlCircle.Controls.Add(this.tbCircR);
            this.pnlCircle.Controls.Add(this.lblCircR);
            this.pnlCircle.Location = new System.Drawing.Point(14, 48);
            this.pnlCircle.Name = "pnlCircle";
            this.pnlCircle.Size = new System.Drawing.Size(521, 210);
            this.pnlCircle.TabIndex = 34;
            // 
            // pbCircle
            // 
            this.pbCircle.Image = global::lab2.Properties.Resources.Task1_4_Circle;
            this.pbCircle.Location = new System.Drawing.Point(280, 2);
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.Size = new System.Drawing.Size(238, 207);
            this.pbCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCircle.TabIndex = 31;
            this.pbCircle.TabStop = false;
            // 
            // tbCircR
            // 
            this.tbCircR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCircR.Location = new System.Drawing.Point(142, 91);
            this.tbCircR.Margin = new System.Windows.Forms.Padding(2);
            this.tbCircR.Name = "tbCircR";
            this.tbCircR.Size = new System.Drawing.Size(115, 28);
            this.tbCircR.TabIndex = 28;
            // 
            // lblCircR
            // 
            this.lblCircR.AutoSize = true;
            this.lblCircR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCircR.Location = new System.Drawing.Point(16, 93);
            this.lblCircR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCircR.Name = "lblCircR";
            this.lblCircR.Size = new System.Drawing.Size(115, 24);
            this.lblCircR.TabIndex = 30;
            this.lblCircR.Text = "Введите r =";
            // 
            // pnlSector
            // 
            this.pnlSector.Controls.Add(this.pbSector);
            this.pnlSector.Controls.Add(this.tbSectR);
            this.pnlSector.Controls.Add(this.lblSectR);
            this.pnlSector.Controls.Add(this.tbSectAngle);
            this.pnlSector.Controls.Add(this.lblSectAngle);
            this.pnlSector.Location = new System.Drawing.Point(14, 48);
            this.pnlSector.Name = "pnlSector";
            this.pnlSector.Size = new System.Drawing.Size(521, 210);
            this.pnlSector.TabIndex = 34;
            // 
            // pbSector
            // 
            this.pbSector.Image = global::lab2.Properties.Resources.Task1_4_Sector;
            this.pbSector.Location = new System.Drawing.Point(280, 0);
            this.pbSector.Name = "pbSector";
            this.pbSector.Size = new System.Drawing.Size(238, 207);
            this.pbSector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSector.TabIndex = 31;
            this.pbSector.TabStop = false;
            // 
            // tbSectR
            // 
            this.tbSectR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSectR.Location = new System.Drawing.Point(142, 113);
            this.tbSectR.Margin = new System.Windows.Forms.Padding(2);
            this.tbSectR.Name = "tbSectR";
            this.tbSectR.Size = new System.Drawing.Size(115, 28);
            this.tbSectR.TabIndex = 28;
            // 
            // lblSectR
            // 
            this.lblSectR.AutoSize = true;
            this.lblSectR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSectR.Location = new System.Drawing.Point(16, 113);
            this.lblSectR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSectR.Name = "lblSectR";
            this.lblSectR.Size = new System.Drawing.Size(122, 24);
            this.lblSectR.TabIndex = 30;
            this.lblSectR.Text = "Введите R =";
            // 
            // tbSectAngle
            // 
            this.tbSectAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSectAngle.Location = new System.Drawing.Point(142, 69);
            this.tbSectAngle.Margin = new System.Windows.Forms.Padding(2);
            this.tbSectAngle.Name = "tbSectAngle";
            this.tbSectAngle.Size = new System.Drawing.Size(115, 28);
            this.tbSectAngle.TabIndex = 27;
            // 
            // lblSectAngle
            // 
            this.lblSectAngle.AutoSize = true;
            this.lblSectAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSectAngle.Location = new System.Drawing.Point(17, 73);
            this.lblSectAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSectAngle.Name = "lblSectAngle";
            this.lblSectAngle.Size = new System.Drawing.Size(119, 24);
            this.lblSectAngle.TabIndex = 29;
            this.lblSectAngle.Text = "Введите a =";
            // 
            // FormTask1_4
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(558, 420);
            this.Controls.Add(this.pnlSector);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pnlTrapezoid);
            this.Controls.Add(this.pnlRect);
            this.Controls.Add(this.cbFigure);
            this.Controls.Add(this.lblFigure);
            this.Controls.Add(this.pnlCircle);
            this.Controls.Add(this.pnlTriangle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTask1_4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 1.4     Вычисление площадей различных геометрических фигур";
            this.pnlRect.ResumeLayout(false);
            this.pnlRect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRect)).EndInit();
            this.pnlTriangle.ResumeLayout(false);
            this.pnlTriangle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTriangle)).EndInit();
            this.pnlTrapezoid.ResumeLayout(false);
            this.pnlTrapezoid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrapezoid)).EndInit();
            this.pnlCircle.ResumeLayout(false);
            this.pnlCircle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            this.pnlSector.ResumeLayout(false);
            this.pnlSector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFigure;
        private System.Windows.Forms.ComboBox cbFigure;
        private System.Windows.Forms.Panel pnlRect;
        private System.Windows.Forms.TextBox tbRectB;
        private System.Windows.Forms.Label lblRectB;
        private System.Windows.Forms.TextBox tbRectA;
        private System.Windows.Forms.Label lblRectA;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pbRect;
        private System.Windows.Forms.Panel pnlTriangle;
        private System.Windows.Forms.PictureBox pbTriangle;
        private System.Windows.Forms.TextBox tbTriH;
        private System.Windows.Forms.Label lblTriH;
        private System.Windows.Forms.TextBox tbTriA;
        private System.Windows.Forms.Label lblTriA;
        private System.Windows.Forms.Panel pnlTrapezoid;
        private System.Windows.Forms.PictureBox pbTrapezoid;
        private System.Windows.Forms.TextBox tbTrB;
        private System.Windows.Forms.Label lblTrB;
        private System.Windows.Forms.TextBox tbTrA;
        private System.Windows.Forms.Label lblTrA;
        private System.Windows.Forms.TextBox tbTrH;
        private System.Windows.Forms.Label lblTrH;
        private System.Windows.Forms.Panel pnlCircle;
        private System.Windows.Forms.PictureBox pbCircle;
        private System.Windows.Forms.TextBox tbCircR;
        private System.Windows.Forms.Label lblCircR;
        private System.Windows.Forms.Panel pnlSector;
        private System.Windows.Forms.PictureBox pbSector;
        private System.Windows.Forms.TextBox tbSectR;
        private System.Windows.Forms.Label lblSectR;
        private System.Windows.Forms.TextBox tbSectAngle;
        private System.Windows.Forms.Label lblSectAngle;
    }
}