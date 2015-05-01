namespace Formula1BolidHierarchy
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
            this.panelBolids = new System.Windows.Forms.Panel();
            this.buttonBolid80 = new System.Windows.Forms.Button();
            this.buttonCurrentBolid = new System.Windows.Forms.Button();
            this.buttonBolidAtmo = new System.Windows.Forms.Button();
            this.buttonBolidTurbo = new System.Windows.Forms.Button();
            this.buttonBolid60 = new System.Windows.Forms.Button();
            this.buttonFirstBolid = new System.Windows.Forms.Button();
            this.comboBoxObjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.buttonRemoveObject = new System.Windows.Forms.Button();
            this.panelBolids.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBolids
            // 
            this.panelBolids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBolids.Controls.Add(this.buttonBolid80);
            this.panelBolids.Controls.Add(this.buttonCurrentBolid);
            this.panelBolids.Controls.Add(this.buttonBolidAtmo);
            this.panelBolids.Controls.Add(this.buttonBolidTurbo);
            this.panelBolids.Controls.Add(this.buttonBolid60);
            this.panelBolids.Controls.Add(this.buttonFirstBolid);
            this.panelBolids.Location = new System.Drawing.Point(12, 1);
            this.panelBolids.Name = "panelBolids";
            this.panelBolids.Size = new System.Drawing.Size(279, 145);
            this.panelBolids.TabIndex = 0;
            // 
            // buttonBolid80
            // 
            this.buttonBolid80.Location = new System.Drawing.Point(15, 87);
            this.buttonBolid80.Name = "buttonBolid80";
            this.buttonBolid80.Size = new System.Drawing.Size(75, 23);
            this.buttonBolid80.TabIndex = 5;
            this.buttonBolid80.Text = "Bolid80";
            this.buttonBolid80.UseVisualStyleBackColor = true;
            this.buttonBolid80.Click += new System.EventHandler(this.buttonBolid80_Click);
            // 
            // buttonCurrentBolid
            // 
            this.buttonCurrentBolid.Location = new System.Drawing.Point(15, 116);
            this.buttonCurrentBolid.Name = "buttonCurrentBolid";
            this.buttonCurrentBolid.Size = new System.Drawing.Size(75, 23);
            this.buttonCurrentBolid.TabIndex = 4;
            this.buttonCurrentBolid.Text = "CurrentBolid";
            this.buttonCurrentBolid.UseVisualStyleBackColor = true;
            this.buttonCurrentBolid.Click += new System.EventHandler(this.buttonCurrentBolid_Click);
            // 
            // buttonBolidAtmo
            // 
            this.buttonBolidAtmo.Location = new System.Drawing.Point(15, 58);
            this.buttonBolidAtmo.Name = "buttonBolidAtmo";
            this.buttonBolidAtmo.Size = new System.Drawing.Size(75, 23);
            this.buttonBolidAtmo.TabIndex = 3;
            this.buttonBolidAtmo.Text = "BolidAtmo";
            this.buttonBolidAtmo.UseVisualStyleBackColor = true;
            this.buttonBolidAtmo.Click += new System.EventHandler(this.buttonBolidAtmo_Click);
            // 
            // buttonBolidTurbo
            // 
            this.buttonBolidTurbo.Location = new System.Drawing.Point(177, 58);
            this.buttonBolidTurbo.Name = "buttonBolidTurbo";
            this.buttonBolidTurbo.Size = new System.Drawing.Size(75, 23);
            this.buttonBolidTurbo.TabIndex = 2;
            this.buttonBolidTurbo.Text = "BolidTurbo";
            this.buttonBolidTurbo.UseVisualStyleBackColor = true;
            this.buttonBolidTurbo.Click += new System.EventHandler(this.buttonBolidTurbo_Click);
            // 
            // buttonBolid60
            // 
            this.buttonBolid60.Location = new System.Drawing.Point(96, 36);
            this.buttonBolid60.Name = "buttonBolid60";
            this.buttonBolid60.Size = new System.Drawing.Size(75, 23);
            this.buttonBolid60.TabIndex = 1;
            this.buttonBolid60.Text = "Bolid60";
            this.buttonBolid60.UseVisualStyleBackColor = true;
            this.buttonBolid60.Click += new System.EventHandler(this.buttonBolid60_Click);
            // 
            // buttonFirstBolid
            // 
            this.buttonFirstBolid.Location = new System.Drawing.Point(96, 7);
            this.buttonFirstBolid.Name = "buttonFirstBolid";
            this.buttonFirstBolid.Size = new System.Drawing.Size(75, 23);
            this.buttonFirstBolid.TabIndex = 0;
            this.buttonFirstBolid.Text = "FirstBolid";
            this.buttonFirstBolid.UseVisualStyleBackColor = true;
            this.buttonFirstBolid.Click += new System.EventHandler(this.buttonFirstBolid_Click);
            // 
            // comboBoxObjects
            // 
            this.comboBoxObjects.FormattingEnabled = true;
            this.comboBoxObjects.Location = new System.Drawing.Point(442, 73);
            this.comboBoxObjects.Name = "comboBoxObjects";
            this.comboBoxObjects.Size = new System.Drawing.Size(236, 21);
            this.comboBoxObjects.TabIndex = 1;
            this.comboBoxObjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Objects";
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(697, 73);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialize.TabIndex = 5;
            this.buttonSerialize.Text = "Serialize";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(697, 102);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(75, 23);
            this.buttonDeserialize.TabIndex = 6;
            this.buttonDeserialize.Text = "Deserialize";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // buttonRemoveObject
            // 
            this.buttonRemoveObject.Location = new System.Drawing.Point(342, 73);
            this.buttonRemoveObject.Name = "buttonRemoveObject";
            this.buttonRemoveObject.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveObject.TabIndex = 7;
            this.buttonRemoveObject.Text = "Remove";
            this.buttonRemoveObject.UseVisualStyleBackColor = true;
            this.buttonRemoveObject.Click += new System.EventHandler(this.buttonRemoveObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.buttonRemoveObject);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxObjects);
            this.Controls.Add(this.panelBolids);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBolids.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBolids;
        private System.Windows.Forms.Button buttonBolid80;
        private System.Windows.Forms.Button buttonCurrentBolid;
        private System.Windows.Forms.Button buttonBolidAtmo;
        private System.Windows.Forms.Button buttonBolidTurbo;
        private System.Windows.Forms.Button buttonBolid60;
        private System.Windows.Forms.Button buttonFirstBolid;
        private System.Windows.Forms.ComboBox comboBoxObjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.Button buttonRemoveObject;
    }
}

