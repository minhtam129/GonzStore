﻿// <auto-generated />
using System;
using GonzStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GonzStore.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20210107193044_202101080230")]
    partial class _202101080230
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GonzStore.Entities.Banner", b =>
                {
                    b.Property<int>("idBanner")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.HasKey("idBanner");

                    b.HasIndex("UseridUser");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("GonzStore.Entities.ChiTietDonHang", b =>
                {
                    b.Property<int>("idCTDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("donGia")
                        .HasColumnType("int");

                    b.Property<int>("giamGia")
                        .HasColumnType("int");

                    b.Property<string>("hinhSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idDH")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("tenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thuocTinhSP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCTDH");

                    b.HasIndex("idDH");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("GonzStore.Entities.ChinhSachGiaoHang", b =>
                {
                    b.Property<int>("idChinhSachGiaoHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idChinhSachGiaoHang");

                    b.HasIndex("UseridUser");

                    b.ToTable("ChinhSachGiaoHang");
                });

            modelBuilder.Entity("GonzStore.Entities.DieuKhoanDichVu", b =>
                {
                    b.Property<int>("idDieuKhoanDV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idDieuKhoanDV");

                    b.HasIndex("UseridUser");

                    b.ToTable("DieuKhoanDichVu");
                });

            modelBuilder.Entity("GonzStore.Entities.DonHang", b =>
                {
                    b.Property<int>("idDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaGiamGiacodeMGG")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ghiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoDH")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<string>("maGiamGiaDH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayDat")
                        .HasColumnType("datetime2");

                    b.Property<string>("sdtDH")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("tenDH")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("tongSoTien")
                        .HasColumnType("int");

                    b.Property<int>("tongTienHang")
                        .HasColumnType("int");

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idDH");

                    b.HasIndex("MaGiamGiacodeMGG");

                    b.HasIndex("UseridUser");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("GonzStore.Entities.GioHang", b =>
                {
                    b.Property<int>("idGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SanPhamidSP")
                        .HasColumnType("int");

                    b.Property<int>("idSP")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.HasKey("idGioHang");

                    b.HasIndex("SanPhamidSP");

                    b.HasIndex("idUser");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("GonzStore.Entities.GioiThieu", b =>
                {
                    b.Property<int>("idGioiThieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<int>("hinhAnh")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idGioiThieu");

                    b.HasIndex("UseridUser");

                    b.ToTable("GioiThieu");
                });

            modelBuilder.Entity("GonzStore.Entities.IPuser", b =>
                {
                    b.Property<int>("idIPuser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("diachiip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.HasKey("idIPuser");

                    b.HasIndex("idUser");

                    b.ToTable("IPuser");
                });

            modelBuilder.Entity("GonzStore.Entities.LienHe", b =>
                {
                    b.Property<int>("idLH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("hoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayGui")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idLH");

                    b.ToTable("LienHe");
                });

            modelBuilder.Entity("GonzStore.Entities.LoaiSP", b =>
                {
                    b.Property<int>("idLoaiSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<string>("metaTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenLoaiSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typeLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idLoaiSP");

                    b.HasIndex("idUser");

                    b.ToTable("LoaiSP");
                });

            modelBuilder.Entity("GonzStore.Entities.MaGiamGia", b =>
                {
                    b.Property<string>("codeMGG")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<int>("giaTri")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("tenMGG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codeMGG");

                    b.HasIndex("UseridUser");

                    b.ToTable("MaGiamGia");
                });

            modelBuilder.Entity("GonzStore.Entities.QuyDinhChung", b =>
                {
                    b.Property<int>("idQuyDinhChung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idQuyDinhChung");

                    b.HasIndex("UseridUser");

                    b.ToTable("QuyDinhChung");
                });

            modelBuilder.Entity("GonzStore.Entities.SanPham", b =>
                {
                    b.Property<int>("idSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ThuongHieuidThuongHieu")
                        .HasColumnType("int");

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<int>("giaSP")
                        .HasColumnType("int");

                    b.Property<int>("giamGiaSP")
                        .HasColumnType("int");

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idLoaiSP")
                        .HasColumnType("int");

                    b.Property<int>("luotMua")
                        .HasColumnType("int");

                    b.Property<int>("luotXem")
                        .HasColumnType("int");

                    b.Property<string>("metaTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("moTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("soLuongKho")
                        .HasColumnType("int");

                    b.Property<string>("tenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idSP");

                    b.HasIndex("ThuongHieuidThuongHieu");

                    b.HasIndex("UseridUser");

                    b.HasIndex("idLoaiSP");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("GonzStore.Entities.ThuongHieu", b =>
                {
                    b.Property<int>("idThuongHieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("emailThuongHieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("hinhLogo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("sdtThuongHieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenThuongHieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idThuongHieu");

                    b.HasIndex("idUser");

                    b.ToTable("ThuongHieu");
                });

            modelBuilder.Entity("GonzStore.Entities.User", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("diaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("hinhAVT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("hoatDongLanCuoi")
                        .HasColumnType("datetime2");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("sdtUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("tenUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vaiTro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUser");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GonzStore.Entities.Banner", b =>
                {
                    b.HasOne("GonzStore.Entities.User", null)
                        .WithMany("Banners")
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("GonzStore.Entities.ChiTietDonHang", b =>
                {
                    b.HasOne("GonzStore.Entities.DonHang", "DonHang")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("idDH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GonzStore.Entities.ChinhSachGiaoHang", b =>
                {
                    b.HasOne("GonzStore.Entities.User", null)
                        .WithMany("ChinhSachGiaoHangs")
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("GonzStore.Entities.DieuKhoanDichVu", b =>
                {
                    b.HasOne("GonzStore.Entities.User", null)
                        .WithMany("DieuKhoanDichVus")
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("GonzStore.Entities.DonHang", b =>
                {
                    b.HasOne("GonzStore.Entities.MaGiamGia", null)
                        .WithMany("DonHangs")
                        .HasForeignKey("MaGiamGiacodeMGG");

                    b.HasOne("GonzStore.Entities.User", null)
                        .WithMany("DonHangs")
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("GonzStore.Entities.GioHang", b =>
                {
                    b.HasOne("GonzStore.Entities.SanPham", null)
                        .WithMany("GioHangs")
                        .HasForeignKey("SanPhamidSP");

                    b.HasOne("GonzStore.Entities.User", "User")
                        .WithMany("GioHangs")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GonzStore.Entities.GioiThieu", b =>
                {
                    b.HasOne("GonzStore.Entities.User", null)
                        .WithMany("GioiThieus")
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("GonzStore.Entities.IPuser", b =>
                {
                    b.HasOne("GonzStore.Entities.User", "User")
                        .WithMany("IPusers")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GonzStore.Entities.LoaiSP", b =>
                {
                    b.HasOne("GonzStore.Entities.User", "User")
                        .WithMany("LoaiSPs")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GonzStore.Entities.MaGiamGia", b =>
                {
                    b.HasOne("GonzStore.Entities.User", null)
                        .WithMany("MaGiamGias")
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("GonzStore.Entities.QuyDinhChung", b =>
                {
                    b.HasOne("GonzStore.Entities.User", null)
                        .WithMany("QuyDinhChungs")
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("GonzStore.Entities.SanPham", b =>
                {
                    b.HasOne("GonzStore.Entities.ThuongHieu", null)
                        .WithMany("SanPhams")
                        .HasForeignKey("ThuongHieuidThuongHieu");

                    b.HasOne("GonzStore.Entities.User", null)
                        .WithMany("SanPhams")
                        .HasForeignKey("UseridUser");

                    b.HasOne("GonzStore.Entities.LoaiSP", "LoaiSP")
                        .WithMany()
                        .HasForeignKey("idLoaiSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GonzStore.Entities.ThuongHieu", b =>
                {
                    b.HasOne("GonzStore.Entities.User", "User")
                        .WithMany("ThuongHieus")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
