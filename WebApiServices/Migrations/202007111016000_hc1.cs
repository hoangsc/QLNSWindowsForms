namespace WebApiServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hc1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonVis",
                c => new
                    {
                        DonViId = c.Int(nullable: false, identity: true),
                        TenDonVi = c.String(),
                    })
                .PrimaryKey(t => t.DonViId);
            
            CreateTable(
                "dbo.HocVis",
                c => new
                    {
                        HocViId = c.Int(nullable: false, identity: true),
                        TenHocVi = c.String(),
                    })
                .PrimaryKey(t => t.HocViId);
            
            CreateTable(
                "dbo.HopDongs",
                c => new
                    {
                        HopDongId = c.Int(nullable: false, identity: true),
                        NgayKi = c.DateTime(nullable: false),
                        NgayKetThuc = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HopDongId);
            
            CreateTable(
                "dbo.Ngaches",
                c => new
                    {
                        NgachId = c.Int(nullable: false, identity: true),
                        TenNgach = c.String(),
                        HeSoLuong = c.Double(nullable: false),
                        Bac = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NgachId);
            
            CreateTable(
                "dbo.NguoiDungs",
                c => new
                    {
                        NguoiDungId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.NguoiDungId);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        NhanVienId = c.Int(nullable: false, identity: true),
                        HoTen = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.Boolean(nullable: false),
                        DanToc = c.String(),
                        TonGiao = c.String(),
                        SoDienThoai = c.Int(nullable: false),
                        Email = c.String(),
                        DiaChi = c.String(),
                        SoCMND = c.Int(nullable: false),
                        Anh = c.String(),
                        DangVien = c.Boolean(nullable: false),
                        HocViId = c.Int(nullable: false),
                        DonViId = c.Int(nullable: false),
                        HopDongId = c.Int(nullable: false),
                        NgachId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NhanVienId)
                .ForeignKey("dbo.DonVis", t => t.DonViId, cascadeDelete: true)
                .ForeignKey("dbo.HocVis", t => t.HocViId, cascadeDelete: true)
                .ForeignKey("dbo.HopDongs", t => t.HopDongId, cascadeDelete: true)
                .ForeignKey("dbo.Ngaches", t => t.NgachId, cascadeDelete: true)
                .Index(t => t.HocViId)
                .Index(t => t.DonViId)
                .Index(t => t.HopDongId)
                .Index(t => t.NgachId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanViens", "NgachId", "dbo.Ngaches");
            DropForeignKey("dbo.NhanViens", "HopDongId", "dbo.HopDongs");
            DropForeignKey("dbo.NhanViens", "HocViId", "dbo.HocVis");
            DropForeignKey("dbo.NhanViens", "DonViId", "dbo.DonVis");
            DropIndex("dbo.NhanViens", new[] { "NgachId" });
            DropIndex("dbo.NhanViens", new[] { "HopDongId" });
            DropIndex("dbo.NhanViens", new[] { "DonViId" });
            DropIndex("dbo.NhanViens", new[] { "HocViId" });
            DropTable("dbo.NhanViens");
            DropTable("dbo.NguoiDungs");
            DropTable("dbo.Ngaches");
            DropTable("dbo.HopDongs");
            DropTable("dbo.HocVis");
            DropTable("dbo.DonVis");
        }
    }
}
