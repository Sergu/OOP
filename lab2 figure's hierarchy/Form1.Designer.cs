namespace oop1_figuer_s_hierarchy
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Circle_but = new System.Windows.Forms.Button();
            this.Rect_but = new System.Windows.Forms.Button();
            this.Line_but = new System.Windows.Forms.Button();
            this.CompoboxPen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Polygon_But = new System.Windows.Forms.Button();
            this.numericCorners = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.But_Square = new System.Windows.Forms.Button();
            this.But_Circle = new System.Windows.Forms.Button();
            this.but_AllDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_CountOfObjects = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Current = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCorners)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Circle_but
            // 
            this.Circle_but.Location = new System.Drawing.Point(31, 12);
            this.Circle_but.Name = "Circle_but";
            this.Circle_but.Size = new System.Drawing.Size(96, 37);
            this.Circle_but.TabIndex = 0;
            this.Circle_but.Text = "Ellipse";
            this.Circle_but.UseVisualStyleBackColor = true;
            this.Circle_but.Click += new System.EventHandler(this.Circle_but_Click);
            // 
            // Rect_but
            // 
            this.Rect_but.Location = new System.Drawing.Point(133, 12);
            this.Rect_but.Name = "Rect_but";
            this.Rect_but.Size = new System.Drawing.Size(96, 36);
            this.Rect_but.TabIndex = 1;
            this.Rect_but.Text = "Rectangle";
            this.Rect_but.UseVisualStyleBackColor = true;
            this.Rect_but.Click += new System.EventHandler(this.Rect_but_Click);
            // 
            // Line_but
            // 
            this.Line_but.Location = new System.Drawing.Point(235, 12);
            this.Line_but.Name = "Line_but";
            this.Line_but.Size = new System.Drawing.Size(96, 36);
            this.Line_but.TabIndex = 2;
            this.Line_but.Text = "Line";
            this.Line_but.UseVisualStyleBackColor = true;
            this.Line_but.Click += new System.EventHandler(this.Line_but_Click);
            // 
            // CompoboxPen
            // 
            this.CompoboxPen.FormattingEnabled = true;
            this.CompoboxPen.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Green",
            "Blue",
            "Brown",
            "Purple"});
            this.CompoboxPen.Location = new System.Drawing.Point(493, 21);
            this.CompoboxPen.Name = "CompoboxPen";
            this.CompoboxPen.Size = new System.Drawing.Size(80, 21);
            this.CompoboxPen.TabIndex = 3;
            this.CompoboxPen.SelectedIndexChanged += new System.EventHandler(this.CompoboxPen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pen\'s color";
            // 
            // Polygon_But
            // 
            this.Polygon_But.Location = new System.Drawing.Point(0, 0);
            this.Polygon_But.Name = "Polygon_But";
            this.Polygon_But.Size = new System.Drawing.Size(85, 28);
            this.Polygon_But.TabIndex = 5;
            this.Polygon_But.Text = "Polygon";
            this.Polygon_But.UseVisualStyleBackColor = true;
            this.Polygon_But.Click += new System.EventHandler(this.Polygon_But_Click);
            // 
            // numericCorners
            // 
            this.numericCorners.BackColor = System.Drawing.Color.Silver;
            this.numericCorners.Location = new System.Drawing.Point(106, 49);
            this.numericCorners.Name = "numericCorners";
            this.numericCorners.Size = new System.Drawing.Size(39, 20);
            this.numericCorners.TabIndex = 6;
            this.numericCorners.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericCorners.ValueChanged += new System.EventHandler(this.numericCorners_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Label_Current);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Polygon_But);
            this.panel1.Controls.Add(this.numericCorners);
            this.panel1.Location = new System.Drawing.Point(339, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 72);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aharoni", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Corners";
            // 
            // But_Square
            // 
            this.But_Square.Location = new System.Drawing.Point(133, 55);
            this.But_Square.Name = "But_Square";
            this.But_Square.Size = new System.Drawing.Size(96, 36);
            this.But_Square.TabIndex = 8;
            this.But_Square.Text = "Square";
            this.But_Square.UseVisualStyleBackColor = true;
            this.But_Square.Click += new System.EventHandler(this.But_Square_Click);
            // 
            // But_Circle
            // 
            this.But_Circle.Location = new System.Drawing.Point(31, 55);
            this.But_Circle.Name = "But_Circle";
            this.But_Circle.Size = new System.Drawing.Size(96, 36);
            this.But_Circle.TabIndex = 9;
            this.But_Circle.Text = "Circle";
            this.But_Circle.UseVisualStyleBackColor = true;
            this.But_Circle.Click += new System.EventHandler(this.But_Circle_Click);
            // 
            // but_AllDelete
            // 
            this.but_AllDelete.Location = new System.Drawing.Point(577, 60);
            this.but_AllDelete.Name = "but_AllDelete";
            this.but_AllDelete.Size = new System.Drawing.Size(98, 23);
            this.but_AllDelete.TabIndex = 11;
            this.but_AllDelete.Text = "Delete ALL";
            this.but_AllDelete.UseVisualStyleBackColor = true;
            this.but_AllDelete.Click += new System.EventHandler(this.but_AllDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of Objects";
            // 
            // Label_CountOfObjects
            // 
            this.Label_CountOfObjects.AutoSize = true;
            this.Label_CountOfObjects.Location = new System.Drawing.Point(661, 29);
            this.Label_CountOfObjects.Name = "Label_CountOfObjects";
            this.Label_CountOfObjects.Size = new System.Drawing.Size(13, 13);
            this.Label_CountOfObjects.TabIndex = 14;
            this.Label_CountOfObjects.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current";
            // 
            // Label_Current
            // 
            this.Label_Current.AutoSize = true;
            this.Label_Current.Location = new System.Drawing.Point(103, 31);
            this.Label_Current.Name = "Label_Current";
            this.Label_Current.Size = new System.Drawing.Size(0, 13);
            this.Label_Current.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 478);
            this.Controls.Add(this.Label_CountOfObjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_AllDelete);
            this.Controls.Add(this.But_Circle);
            this.Controls.Add(this.But_Square);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompoboxPen);
            this.Controls.Add(this.Line_but);
            this.Controls.Add(this.Rect_but);
            this.Controls.Add(this.Circle_but);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.numericCorners)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Circle_but;
        private System.Windows.Forms.Button Rect_but;
        private System.Windows.Forms.Button Line_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CompoboxPen;
        private System.Windows.Forms.Button Polygon_But;
        private System.Windows.Forms.NumericUpDown numericCorners;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button But_Square;
        private System.Windows.Forms.Button But_Circle;
        private System.Windows.Forms.Button but_AllDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_CountOfObjects;
        private System.Windows.Forms.Label Label_Current;
        private System.Windows.Forms.Label label4;

    }
}

