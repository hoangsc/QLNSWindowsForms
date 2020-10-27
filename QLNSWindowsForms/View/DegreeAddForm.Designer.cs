﻿namespace QLNSWindowsForms.View
{
    partial class DegreeAddForm
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TenDonViTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.donViBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTenDonVi = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TenDonViTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.TenDonViTextEdit);
            this.dataLayoutControl1.DataSource = this.donViBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(22, 39);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(287, 0, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(180, 53);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TenDonViTextEdit
            // 
            this.TenDonViTextEdit.Location = new System.Drawing.Point(67, 12);
            this.TenDonViTextEdit.Name = "TenDonViTextEdit";
            this.TenDonViTextEdit.Size = new System.Drawing.Size(101, 20);
            this.TenDonViTextEdit.StyleController = this.dataLayoutControl1;
            this.TenDonViTextEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(180, 53);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTenDonVi});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(160, 33);
            // 
            // ItemForTenDonVi
            // 
            this.ItemForTenDonVi.Control = this.TenDonViTextEdit;
            this.ItemForTenDonVi.Location = new System.Drawing.Point(0, 0);
            this.ItemForTenDonVi.Name = "ItemForTenDonVi";
            this.ItemForTenDonVi.Size = new System.Drawing.Size(160, 33);
            this.ItemForTenDonVi.Text = "Tên Đơn Vị";
            this.ItemForTenDonVi.TextSize = new System.Drawing.Size(52, 13);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(103, 129);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(208, 129);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 2;
            this.buttonHuy.Text = "Huỷ";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // DegreeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 176);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "DegreeAddForm";
            this.Text = "Thêm đơn vị";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TenDonViTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenDonVi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit TenDonViTextEdit;
        private System.Windows.Forms.BindingSource donViBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenDonVi;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonHuy;
    }
}