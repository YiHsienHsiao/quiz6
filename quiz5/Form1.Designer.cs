namespace _2015OOP_Quiz5_win
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMaterialSet = new System.Windows.Forms.GroupBox();
            this.cboxMaterialSet = new System.Windows.Forms.ComboBox();
            this.lblMaterialSet = new System.Windows.Forms.Label();
            this.grpShapeSet = new System.Windows.Forms.GroupBox();
            this.txtPara2 = new System.Windows.Forms.TextBox();
            this.txtPara1 = new System.Windows.Forms.TextBox();
            this.cboxShapeSet = new System.Windows.Forms.ComboBox();
            this.lblPara2 = new System.Windows.Forms.Label();
            this.lblPara1 = new System.Windows.Forms.Label();
            this.lblShapeSet = new System.Windows.Forms.Label();
            this.grpAddShape = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtShapeNum = new System.Windows.Forms.TextBox();
            this.lblShapeNum = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtShowSolution = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.lblSortMethod = new System.Windows.Forms.Label();
            this.cmbSortMethod = new System.Windows.Forms.ComboBox();
            this.rdbSortAscent = new System.Windows.Forms.RadioButton();
            this.rdbSortDescent = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpMaterialSet.SuspendLayout();
            this.grpShapeSet.SuspendLayout();
            this.grpAddShape.SuspendLayout();
            this.grpSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaterialSet
            // 
            this.grpMaterialSet.Controls.Add(this.cboxMaterialSet);
            this.grpMaterialSet.Controls.Add(this.lblMaterialSet);
            this.grpMaterialSet.Location = new System.Drawing.Point(12, 12);
            this.grpMaterialSet.Name = "grpMaterialSet";
            this.grpMaterialSet.Size = new System.Drawing.Size(280, 55);
            this.grpMaterialSet.TabIndex = 0;
            this.grpMaterialSet.TabStop = false;
            this.grpMaterialSet.Text = "材料設定";
            // 
            // cboxMaterialSet
            // 
            this.cboxMaterialSet.FormattingEnabled = true;
            this.cboxMaterialSet.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cboxMaterialSet.Location = new System.Drawing.Point(137, 25);
            this.cboxMaterialSet.Name = "cboxMaterialSet";
            this.cboxMaterialSet.Size = new System.Drawing.Size(121, 20);
            this.cboxMaterialSet.TabIndex = 1;
            // 
            // lblMaterialSet
            // 
            this.lblMaterialSet.AutoSize = true;
            this.lblMaterialSet.Location = new System.Drawing.Point(17, 27);
            this.lblMaterialSet.Name = "lblMaterialSet";
            this.lblMaterialSet.Size = new System.Drawing.Size(53, 12);
            this.lblMaterialSet.TabIndex = 0;
            this.lblMaterialSet.Text = "材料類別";
            // 
            // grpShapeSet
            // 
            this.grpShapeSet.Controls.Add(this.txtPara2);
            this.grpShapeSet.Controls.Add(this.txtPara1);
            this.grpShapeSet.Controls.Add(this.cboxShapeSet);
            this.grpShapeSet.Controls.Add(this.lblPara2);
            this.grpShapeSet.Controls.Add(this.lblPara1);
            this.grpShapeSet.Controls.Add(this.lblShapeSet);
            this.grpShapeSet.Location = new System.Drawing.Point(12, 73);
            this.grpShapeSet.Name = "grpShapeSet";
            this.grpShapeSet.Size = new System.Drawing.Size(280, 100);
            this.grpShapeSet.TabIndex = 0;
            this.grpShapeSet.TabStop = false;
            this.grpShapeSet.Text = "形狀設定";
            // 
            // txtPara2
            // 
            this.txtPara2.Location = new System.Drawing.Point(199, 64);
            this.txtPara2.Name = "txtPara2";
            this.txtPara2.Size = new System.Drawing.Size(59, 22);
            this.txtPara2.TabIndex = 2;
            // 
            // txtPara1
            // 
            this.txtPara1.Location = new System.Drawing.Point(56, 61);
            this.txtPara1.Name = "txtPara1";
            this.txtPara1.Size = new System.Drawing.Size(59, 22);
            this.txtPara1.TabIndex = 2;
            // 
            // cboxShapeSet
            // 
            this.cboxShapeSet.FormattingEnabled = true;
            this.cboxShapeSet.Items.AddRange(new object[] {
            "球",
            "正方體",
            "圓柱體",
            "金字塔"});
            this.cboxShapeSet.Location = new System.Drawing.Point(137, 25);
            this.cboxShapeSet.Name = "cboxShapeSet";
            this.cboxShapeSet.Size = new System.Drawing.Size(121, 20);
            this.cboxShapeSet.TabIndex = 1;
            this.cboxShapeSet.SelectedIndexChanged += new System.EventHandler(this.cboxShapeSet_SelectedIndexChanged);
            // 
            // lblPara2
            // 
            this.lblPara2.AutoSize = true;
            this.lblPara2.Location = new System.Drawing.Point(160, 67);
            this.lblPara2.Name = "lblPara2";
            this.lblPara2.Size = new System.Drawing.Size(33, 12);
            this.lblPara2.TabIndex = 0;
            this.lblPara2.Text = "label1";
            // 
            // lblPara1
            // 
            this.lblPara1.AutoSize = true;
            this.lblPara1.Location = new System.Drawing.Point(17, 64);
            this.lblPara1.Name = "lblPara1";
            this.lblPara1.Size = new System.Drawing.Size(33, 12);
            this.lblPara1.TabIndex = 0;
            this.lblPara1.Text = "label1";
            // 
            // lblShapeSet
            // 
            this.lblShapeSet.AutoSize = true;
            this.lblShapeSet.Location = new System.Drawing.Point(17, 28);
            this.lblShapeSet.Name = "lblShapeSet";
            this.lblShapeSet.Size = new System.Drawing.Size(53, 12);
            this.lblShapeSet.TabIndex = 0;
            this.lblShapeSet.Text = "形狀類別";
            // 
            // grpAddShape
            // 
            this.grpAddShape.Controls.Add(this.btnAdd);
            this.grpAddShape.Controls.Add(this.txtShapeNum);
            this.grpAddShape.Controls.Add(this.lblShapeNum);
            this.grpAddShape.Location = new System.Drawing.Point(12, 179);
            this.grpAddShape.Name = "grpAddShape";
            this.grpAddShape.Size = new System.Drawing.Size(280, 58);
            this.grpAddShape.TabIndex = 0;
            this.grpAddShape.TabStop = false;
            this.grpAddShape.Text = "增加Shape";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "加入";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtShapeNum
            // 
            this.txtShapeNum.Location = new System.Drawing.Point(204, 25);
            this.txtShapeNum.Name = "txtShapeNum";
            this.txtShapeNum.Size = new System.Drawing.Size(59, 22);
            this.txtShapeNum.TabIndex = 2;
            // 
            // lblShapeNum
            // 
            this.lblShapeNum.AutoSize = true;
            this.lblShapeNum.Location = new System.Drawing.Point(169, 30);
            this.lblShapeNum.Name = "lblShapeNum";
            this.lblShapeNum.Size = new System.Drawing.Size(29, 12);
            this.lblShapeNum.TabIndex = 0;
            this.lblShapeNum.Text = "數量";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(18, 243);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(274, 147);
            this.txtAdd.TabIndex = 2;
            // 
            // txtShowSolution
            // 
            this.txtShowSolution.Location = new System.Drawing.Point(511, 63);
            this.txtShowSolution.Multiline = true;
            this.txtShowSolution.Name = "txtShowSolution";
            this.txtShowSolution.Size = new System.Drawing.Size(360, 327);
            this.txtShowSolution.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(311, 34);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.btnConfirm);
            this.grpSort.Controls.Add(this.rdbSortDescent);
            this.grpSort.Controls.Add(this.rdbSortAscent);
            this.grpSort.Controls.Add(this.cmbSortMethod);
            this.grpSort.Controls.Add(this.lblSortMethod);
            this.grpSort.Location = new System.Drawing.Point(299, 64);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(200, 119);
            this.grpSort.TabIndex = 4;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "排序";
            // 
            // lblSortMethod
            // 
            this.lblSortMethod.AutoSize = true;
            this.lblSortMethod.Location = new System.Drawing.Point(10, 34);
            this.lblSortMethod.Name = "lblSortMethod";
            this.lblSortMethod.Size = new System.Drawing.Size(53, 12);
            this.lblSortMethod.TabIndex = 0;
            this.lblSortMethod.Text = "排序方式";
            // 
            // cmbSortMethod
            // 
            this.cmbSortMethod.FormattingEnabled = true;
            this.cmbSortMethod.Items.AddRange(new object[] {
            "重量",
            "體積"});
            this.cmbSortMethod.Location = new System.Drawing.Point(73, 26);
            this.cmbSortMethod.Name = "cmbSortMethod";
            this.cmbSortMethod.Size = new System.Drawing.Size(121, 20);
            this.cmbSortMethod.TabIndex = 1;
            // 
            // rdbSortAscent
            // 
            this.rdbSortAscent.AutoSize = true;
            this.rdbSortAscent.Location = new System.Drawing.Point(12, 64);
            this.rdbSortAscent.Name = "rdbSortAscent";
            this.rdbSortAscent.Size = new System.Drawing.Size(47, 16);
            this.rdbSortAscent.TabIndex = 2;
            this.rdbSortAscent.TabStop = true;
            this.rdbSortAscent.Text = "遞增";
            this.rdbSortAscent.UseVisualStyleBackColor = true;
            // 
            // rdbSortDescent
            // 
            this.rdbSortDescent.AutoSize = true;
            this.rdbSortDescent.Location = new System.Drawing.Point(103, 64);
            this.rdbSortDescent.Name = "rdbSortDescent";
            this.rdbSortDescent.Size = new System.Drawing.Size(47, 16);
            this.rdbSortDescent.TabIndex = 2;
            this.rdbSortDescent.TabStop = true;
            this.rdbSortDescent.Text = "遞減";
            this.rdbSortDescent.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 86);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 402);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtShowSolution);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.grpAddShape);
            this.Controls.Add(this.grpShapeSet);
            this.Controls.Add(this.grpMaterialSet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMaterialSet.ResumeLayout(false);
            this.grpMaterialSet.PerformLayout();
            this.grpShapeSet.ResumeLayout(false);
            this.grpShapeSet.PerformLayout();
            this.grpAddShape.ResumeLayout(false);
            this.grpAddShape.PerformLayout();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaterialSet;
        private System.Windows.Forms.ComboBox cboxMaterialSet;
        private System.Windows.Forms.Label lblMaterialSet;
        private System.Windows.Forms.GroupBox grpShapeSet;
        private System.Windows.Forms.TextBox txtPara2;
        private System.Windows.Forms.TextBox txtPara1;
        private System.Windows.Forms.ComboBox cboxShapeSet;
        private System.Windows.Forms.Label lblPara2;
        private System.Windows.Forms.Label lblPara1;
        private System.Windows.Forms.Label lblShapeSet;
        private System.Windows.Forms.GroupBox grpAddShape;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtShapeNum;
        private System.Windows.Forms.Label lblShapeNum;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtShowSolution;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rdbSortDescent;
        private System.Windows.Forms.RadioButton rdbSortAscent;
        private System.Windows.Forms.ComboBox cmbSortMethod;
        private System.Windows.Forms.Label lblSortMethod;
    }
}

