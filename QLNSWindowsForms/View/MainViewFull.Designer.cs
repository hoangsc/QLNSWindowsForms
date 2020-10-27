namespace QLNSWindowsForms.View
{
    partial class MainViewFull
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
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNhanVienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHocViId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgachId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanToc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDangVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonExExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.DataSource = this.nhanVienBindingSource;
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridControlNhanVien.MainView = this.gridView1;
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(1350, 518);
            this.gridControlNhanVien.TabIndex = 0;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(QLNSWindowsForms.Models.NhanVien);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNhanVienId,
            this.colHocViId,
            this.colDonViId,
            this.colNgayKi,
            this.colNgayKetThuc,
            this.colNgachId,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDanToc,
            this.colTonGiao,
            this.colSoDienThoai,
            this.colEmail,
            this.colDiaChi,
            this.colSoCMND,
            this.colAnh,
            this.colDangVien});
            this.gridView1.GridControl = this.gridControlNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colNhanVienId
            // 
            this.colNhanVienId.Caption = "Id";
            this.colNhanVienId.FieldName = "NhanVienId";
            this.colNhanVienId.Name = "colNhanVienId";
            this.colNhanVienId.Visible = true;
            this.colNhanVienId.VisibleIndex = 0;
            this.colNhanVienId.Width = 25;
            // 
            // colHocViId
            // 
            this.colHocViId.Caption = "Học Vị";
            this.colHocViId.FieldName = "HocVi.TenHocVi";
            this.colHocViId.Name = "colHocViId";
            this.colHocViId.Visible = true;
            this.colHocViId.VisibleIndex = 4;
            this.colHocViId.Width = 59;
            // 
            // colDonViId
            // 
            this.colDonViId.Caption = "Đơn Vị";
            this.colDonViId.FieldName = "DonVi.TenDonVi";
            this.colDonViId.Name = "colDonViId";
            this.colDonViId.Visible = true;
            this.colDonViId.VisibleIndex = 5;
            this.colDonViId.Width = 59;
            // 
            // colNgayKi
            // 
            this.colNgayKi.Caption = "Ngày Kí";
            this.colNgayKi.FieldName = "HopDong.NgayKi";
            this.colNgayKi.Name = "colNgayKi";
            this.colNgayKi.Visible = true;
            this.colNgayKi.VisibleIndex = 6;
            this.colNgayKi.Width = 59;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.Caption = "Ngày Kết Thúc";
            this.colNgayKetThuc.FieldName = "HopDong.NgayKetThuc";
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.Visible = true;
            this.colNgayKetThuc.VisibleIndex = 7;
            this.colNgayKetThuc.Width = 83;
            // 
            // colNgachId
            // 
            this.colNgachId.Caption = "Ngạch";
            this.colNgachId.FieldName = "Ngach.TenNgach";
            this.colNgachId.Name = "colNgachId";
            this.colNgachId.Visible = true;
            this.colNgachId.VisibleIndex = 8;
            this.colNgachId.Width = 65;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ Tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 77;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            this.colNgaySinh.Width = 60;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
            this.colGioiTinh.Width = 58;
            // 
            // colDanToc
            // 
            this.colDanToc.Caption = "Dân Tộc";
            this.colDanToc.FieldName = "DanToc";
            this.colDanToc.Name = "colDanToc";
            this.colDanToc.Visible = true;
            this.colDanToc.VisibleIndex = 9;
            this.colDanToc.Width = 61;
            // 
            // colTonGiao
            // 
            this.colTonGiao.Caption = "Tôn Giáo";
            this.colTonGiao.FieldName = "TonGiao";
            this.colTonGiao.Name = "colTonGiao";
            this.colTonGiao.Visible = true;
            this.colTonGiao.VisibleIndex = 10;
            this.colTonGiao.Width = 58;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.Caption = "Số Điện Thoại";
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 11;
            this.colSoDienThoai.Width = 88;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 12;
            this.colEmail.Width = 52;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 13;
            this.colDiaChi.Width = 63;
            // 
            // colSoCMND
            // 
            this.colSoCMND.Caption = "CMND";
            this.colSoCMND.FieldName = "SoCMND";
            this.colSoCMND.Name = "colSoCMND";
            this.colSoCMND.Visible = true;
            this.colSoCMND.VisibleIndex = 14;
            this.colSoCMND.Width = 52;
            // 
            // colAnh
            // 
            this.colAnh.Caption = "Ảnh";
            this.colAnh.FieldName = "Anh";
            this.colAnh.Name = "colAnh";
            this.colAnh.Visible = true;
            this.colAnh.VisibleIndex = 15;
            this.colAnh.Width = 53;
            // 
            // colDangVien
            // 
            this.colDangVien.Caption = "Đảng Viên";
            this.colDangVien.FieldName = "DangVien";
            this.colDangVien.Name = "colDangVien";
            this.colDangVien.Visible = true;
            this.colDangVien.VisibleIndex = 16;
            this.colDangVien.Width = 96;
            // 
            // buttonExExcel
            // 
            this.buttonExExcel.Location = new System.Drawing.Point(1205, 8);
            this.buttonExExcel.Name = "buttonExExcel";
            this.buttonExExcel.Size = new System.Drawing.Size(133, 23);
            this.buttonExExcel.TabIndex = 1;
            this.buttonExExcel.Text = "Export to file";
            this.buttonExExcel.UseVisualStyleBackColor = true;
            this.buttonExExcel.Click += new System.EventHandler(this.buttonExExcel_Click);
            // 
            // MainViewFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 518);
            this.Controls.Add(this.buttonExExcel);
            this.Controls.Add(this.gridControlNhanVien);
            this.Name = "MainViewFull";
            this.Text = "Chế độ dữ liệu toàn màn hình";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVienId;
        private DevExpress.XtraGrid.Columns.GridColumn colHocViId;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViId;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgachId;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDanToc;
        private DevExpress.XtraGrid.Columns.GridColumn colTonGiao;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colAnh;
        private DevExpress.XtraGrid.Columns.GridColumn colDangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKi;
        private System.Windows.Forms.Button buttonExExcel;
    }
}