using System;
using System.Collections.Generic;
namespace Demo
{
    enum Menu
    {
        ThoatChuongTrinh = 0,
        NhapTuFile,
        XuatDuLieu,
        DemSoPhanSoAmTrongMang,
        DemSoPhanSoDuongTrongMang,
        DemPhanSoCoTuSoXTrongMang,
        DemPhanSoCoMauSoXTrongMang,
        TimPhanSoAmLonNhat,
        TimPhanSoAmNhoNhat,
        TimPhanSoDuongLonNhat,
        TimPhanSoDuongNhoNhat,
        TimTatCaCacPhanSoAm,
        TimTatCaCacPhanSoDuong,
        TImTatCaViTrCuaPhanSoXTrongMang,
        TimTatCaViTriCuaPhanSoAmTrongMang,
        TimTatCaViTriCuaPhanSoDuongTrongMang,
        TinhTongTatCaCacPhanSoAm,
        TinhTongTatCaCacPhanSoDuong,
        TinhTongTatCaCacPhanSoCoTuX,
        TinhTongTatCaCacPhanSoCoMauX,
        XoaMotPhanSoTaiViTri,
        XoaPhanSoDauTienTrongMang,
        XoaPhanSoCuoiCungTrongMang,
        XoaPhanSoXTrongMang,
        XoaTatCaPhanSoCoTuX,
        XoaTatCaPhanSoCoMauX,
        XoaTatCaPhanSoCoGiaTriBangPhanSoDauTienTrongMang,
        XoaTatCaPhanSoCoGiaTriBangPhanSoCuoiCungTrongMang,
        XoaTatCaPhanSoCoGiaTriNhoNhat,
        XoaTatCaPhanSoCoGiaTriLonNhat,
        XoaTatCaPhanSoAm,
        XoaTatCaPhanSoDuong,
        ThemMotPhanSoTaiViTri,
        ThemPhanSoTaiViTriDauTienTrongMang,
        SapXepPhanSo
    }
    enum KieuSapXep
    {
        Thoat = 0,
        SapXepTang,
        SapXepGiam
    }
    class MenuClass
    {
        private static void XuatMenu()
        {
            Console.WriteLine("================================ HE THONG MENU ================================");
            Console.WriteLine("{0}. Thoat chuong trinh", (int)Menu.ThoatChuongTrinh);
            Console.WriteLine("{0}. Nhap du lieu", (int)Menu.NhapTuFile);
            Console.WriteLine("{0}. Xuat danh sach phan so hien hanh", (int)Menu.XuatDuLieu);
            Console.WriteLine("{0}. Dem phan so am trong danh sach", (int)Menu.DemSoPhanSoAmTrongMang);
            Console.WriteLine("{0}. Dem phan so duong trong danh sach", (int)Menu.DemSoPhanSoDuongTrongMang);
            Console.WriteLine("{0}. Dem phan so co tu so cho truoc", (int)Menu.DemPhanSoCoTuSoXTrongMang);
            Console.WriteLine("{0}. Dem phan so co mau so cho truoc", (int)Menu.DemPhanSoCoMauSoXTrongMang);
            Console.WriteLine("{0}. Tim phan so am lon nhat", (int)Menu.TimPhanSoAmLonNhat);
            Console.WriteLine("{0}. Tim phan so am nho nhat", (int)Menu.TimPhanSoAmNhoNhat);
            Console.WriteLine("{0}. Tim phan so duong lon nhat", (int)Menu.TimPhanSoDuongLonNhat);
            Console.WriteLine("{0}. Tim phan so duong nho nhat", (int)Menu.TimPhanSoDuongNhoNhat);
            Console.WriteLine("{0}. Tim tat ca cac phan so am", (int)Menu.TimTatCaCacPhanSoAm);
            Console.WriteLine("{0}. TIm tat ca cac phan so duong", (int)Menu.TimTatCaCacPhanSoDuong);
            Console.WriteLine("{0}. Tim vi tri tat ca cac phan so X trong danh sach", (int)Menu.TImTatCaViTrCuaPhanSoXTrongMang);
            Console.WriteLine("{0}. Tim vi tri tat ca cac phan so am trong danh sach", (int)Menu.TimTatCaViTriCuaPhanSoAmTrongMang);
            Console.WriteLine("{0}. Tim vi tri tat ca cac phan so duong trong danh sach", (int)Menu.TimTatCaViTriCuaPhanSoDuongTrongMang);
            Console.WriteLine("{0}. Tinh tong cac phan so am", (int)Menu.TinhTongTatCaCacPhanSoAm);
            Console.WriteLine("{0}. Tinh tong cac phan so duong", (int)Menu.TinhTongTatCaCacPhanSoDuong);
            Console.WriteLine("{0}. Tinh tong tat ca cac phan so co tu la X", (int)Menu.TinhTongTatCaCacPhanSoCoTuX);
            Console.WriteLine("{0}. Tinh tong tat ca cac phan so co mau la X", (int)Menu.TinhTongTatCaCacPhanSoCoMauX);
            Console.WriteLine("{0}. Xoa phan so tai vi tri", (int)Menu.XoaMotPhanSoTaiViTri);
            Console.WriteLine("{0}. Xoa phan so dau tien cua danh sach", (int)Menu.XoaPhanSoDauTienTrongMang);
            Console.WriteLine("{0}. Xoa phan so cuoi cung cua danh sach", (int)Menu.XoaPhanSoCuoiCungTrongMang);
            Console.WriteLine("{0}. Xoa tat ca phan so X trong danh sach", (int)Menu.XoaPhanSoXTrongMang);
            Console.WriteLine("{0}. Xoa tat ca phan so co tu so X trong danh sach", (int)Menu.XoaTatCaPhanSoCoTuX);
            Console.WriteLine("{0}. Xoa tat ca phan so co mau so X trong danh sach", (int)Menu.XoaTatCaPhanSoCoMauX);
            Console.WriteLine("{0}. Xoa tat ca phan so co gia tri giong voi phan so dau tien trong danh sach", (int)Menu.XoaTatCaPhanSoCoGiaTriBangPhanSoDauTienTrongMang);
            Console.WriteLine("{0}. Xoa tat ca phan so co gia tri giong voi phan so cuoi cung trong danh sach", (int)Menu.XoaTatCaPhanSoCoGiaTriBangPhanSoCuoiCungTrongMang);
            Console.WriteLine("{0}. Xoa tat ca phan so co gia tri nho nhat", (int)Menu.XoaTatCaPhanSoCoGiaTriNhoNhat);
            Console.WriteLine("{0}. Xoa tat ca phan so co gia tri lon nhat", (int)Menu.XoaTatCaPhanSoCoGiaTriLonNhat);
            Console.WriteLine("{0}. Xoa tat ca phan so am", (int)Menu.XoaTatCaPhanSoAm);
            Console.WriteLine("{0}. Xoa tat ca phan so duong", (int)Menu.XoaTatCaPhanSoDuong);
            Console.WriteLine("{0}. Them phan so tai vi tri cho truoc", (int)Menu.ThemMotPhanSoTaiViTri);
            Console.WriteLine("{0}. Them phan so tai vi tri dau tien trong danh sach", (int)Menu.ThemPhanSoTaiViTriDauTienTrongMang);
            Console.WriteLine("{0}. Sap xep danh sach phan so", (int)Menu.SapXepPhanSo);
            Console.WriteLine("===============================================================================");
        }
        public static Menu ChonMenu()
        {
            Console.Clear();
            Menu menu = new Menu();
            XuatMenu();
            Console.Write("Xin hay chon 1 so de chon chuc nang tuong ung: ");
            menu = (Menu)int.Parse(Console.ReadLine());
            return menu;
        }
        public static void XuLyMenu(Menu menu, DanhSachPhanSo a)
        {
            #region Variable
            int kq = 0;
            int x = 0;
            string line = "";
            PhanSo phanSoX = new PhanSo();
            List<int> index = new List<int>();
            DanhSachPhanSo dsKq = new DanhSachPhanSo();
            PhanSo phanSokq = new PhanSo();
            #endregion
            Console.Clear();
            switch (menu)
            {
                #region Case 0
                case Menu.ThoatChuongTrinh:
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 1
                case Menu.NhapTuFile:
                    a.DocFile("D:\\PS.txt");
                    Console.WriteLine("Da doc thanh cong!");
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
                    break;
                #endregion
                #region Case 2
                case Menu.XuatDuLieu:
                    Console.WriteLine("Danh sach phan so hien hanh");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
                    break;
                #endregion
                #region Case 3
                case Menu.DemSoPhanSoAmTrongMang:
                    kq = a.DemPhanSoAmDuong(0);
                    Console.WriteLine("Trong danh sach co tat ca " + kq + " phan so am!");
                    Console.WriteLine("Dnah sach phan so hien hanh:");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bay ky de tiep tuc!");
                    break;
                #endregion
                #region Case 4
                case Menu.DemSoPhanSoDuongTrongMang:
                    kq = a.DemPhanSoAmDuong(1);
                    Console.WriteLine("Trong danh sach co tat ca " + kq + " phan so duong!");
                    Console.WriteLine("Dnah sach phan so hien hanh:");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bay ky de tiep tuc!");
                    break;
                #endregion
                #region Case 5
                case Menu.DemPhanSoCoTuSoXTrongMang:
                    Console.Write("Xin hay nhap tu so can tim: ");
                    x = int.Parse(Console.ReadLine());
                    kq = a.DemPhanSoTuMau(x, 0);

                    Console.Clear();
                    if (kq != 0)
                    {
                        Console.WriteLine("So phan so co tu so {0} la: {1}", x, kq);
                    }
                    else
                    {
                        Console.WriteLine("Khong co phan so nao co tu so {0} trong danh sach!", x);
                    }
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bay ky de tiep tuc!");
                    break;
                #endregion
                #region Case 6
                case Menu.DemPhanSoCoMauSoXTrongMang:
                    Console.Write("Xin hay nhap tu so can tim: ");
                    x = int.Parse(Console.ReadLine());
                    kq = a.DemPhanSoTuMau(x, 1);
                    Console.Clear();
                    if (kq != 0)
                    {
                        Console.WriteLine("So phan so co mau so {0} la: {1}", x, kq);
                    }
                    else
                    {
                        Console.WriteLine("Khong co phan so nao co mau so {0} trong danh sach!", x);
                    }
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bay ky de tiep tuc!");
                    break;
                #endregion
                #region Case 7
                case Menu.TimPhanSoAmLonNhat:
                    phanSokq = a.TimPhanSoCoMax_AmDuong(0);
                    Console.Write("Phan so am lon nhat la: ");
                    Console.WriteLine(phanSokq);
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
                    break;
                #endregion
                #region Case 8
                case Menu.TimPhanSoAmNhoNhat:
                    phanSokq = a.TimPhanSoCoMin_AmDuong(0);
                    Console.WriteLine("Phan so am nho nhat la: {0}", phanSokq);
                    Console.WriteLine("Danh sach phan so hien hanh:");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 9
                case Menu.TimPhanSoDuongLonNhat:
                    phanSokq = a.TimPhanSoCoMax_AmDuong(1);
                    Console.WriteLine("Phan so duong lon nhat la: " + phanSokq);
                    Console.WriteLine("Danh sach phan so hien hanh:");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 10
                case Menu.TimPhanSoDuongNhoNhat:
                    phanSokq = a.TimPhanSoCoMin_AmDuong(1);
                    Console.WriteLine("Phan so duong nho nhat la: {0}", phanSokq);
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 11
                case Menu.TimTatCaCacPhanSoAm:
                    dsKq = a.TimPhanSoAmDuong(0);
                    if (dsKq.DemPhanSo() == 0)
                    {
                        Console.WriteLine("Khong co phan so am trong danh sach");
                    }
                    else
                    {
                        Console.WriteLine("Cac phan so am trong danh sach: ");
                        Console.WriteLine(dsKq);
                    }
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 12
                case Menu.TimTatCaCacPhanSoDuong:
                    dsKq = a.TimPhanSoAmDuong(1);
                    if (dsKq.DemPhanSo() == 0)
                    {
                        Console.WriteLine("Khong co phan so duong trong danh sach");
                    }
                    else
                    {
                        Console.WriteLine("Cac phan so duong trong danh sach: ");
                        Console.WriteLine(dsKq);
                    }
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 13
                case Menu.TImTatCaViTrCuaPhanSoXTrongMang:
                    Console.Write("Xin hay nhap phan so can tim (cu phap: tu/mau): ");
                    line = Console.ReadLine();
                    if (!ThuVienDungChung.KiemTraPhanSo(line))
                    {
                        Console.WriteLine("Phan so khong hop le");
                    }
                    else
                    {
                        phanSokq = new PhanSo(line);
                        index = a.TimViTriCuaPhanSoX(phanSokq);
                        if (index.Count == 0)
                            Console.WriteLine("Phan so {0} khong xuat hien trong danh sach!", phanSokq);
                        else
                        {
                            Console.WriteLine("Cac vi tri cua phan so " + phanSokq + " la:");
                            int count = 0;
                            foreach (var item in index)
                            {
                                Console.Write(item + 1 + "\t");
                                count++;
                                if (count % 10 == 0)
                                    Console.Write("\n");
                            }
                        }
                    }
                    Console.WriteLine("\nDanh sach phan so hien hanh");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 14
                case Menu.TimTatCaViTriCuaPhanSoAmTrongMang:
                    index = a.TimViTriPhanSo_AmDuong(0);
                    if (index.Count == 0)
                        Console.WriteLine("Khong co phan so am nao trong danh sach");
                    else
                    {
                        Console.WriteLine("Vi tri cac phan so am la: ");
                        int count = 0;
                        foreach (var i in index)
                        {
                            Console.Write(i + 1 + "\t");
                            count++;
                            if (count % 10 == 0)
                                Console.Write("\n");
                        }
                    }
                    Console.WriteLine("\nDanh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 15
                case Menu.TimTatCaViTriCuaPhanSoDuongTrongMang:
                    index = a.TimViTriPhanSo_AmDuong(1);
                    if (index.Count == 0)
                        Console.WriteLine("Khong co phan so duong nao trong danh sach!");
                    else
                    {
                        Console.WriteLine("Vi tri cac phan so duong la:");
                        int count = 0;
                        foreach (var i in index)
                        {
                            Console.Write(i + 1 + "\t");
                            count++;
                            if (count % 10 == 0)
                                Console.WriteLine("");
                        }
                    }
                    Console.WriteLine("\nDanh sach phan so hien hanh:");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 16
                case Menu.TinhTongTatCaCacPhanSoAm:
                    phanSokq = a.TinhTongCacPhanSo_AmDuong(0);
                    Console.WriteLine("Tong tat ca cac phan so am trong danh sach la: " + phanSokq);
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 17
                case Menu.TinhTongTatCaCacPhanSoDuong:
                    phanSokq = a.TinhTongCacPhanSo_AmDuong(1);
                    Console.WriteLine("Tong tat ca cac phan so duong trong danh sach la: " + phanSokq);
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 18
                case Menu.TinhTongTatCaCacPhanSoCoTuX:
                    Console.Write("Xin hay nhap tu so can tinh: ");
                    x = int.Parse(Console.ReadLine());
                    phanSokq = a.TinhTongCacPhanSo_TuMau(x, 0);
                    Console.Clear();
                    Console.WriteLine("Tong tat ca cac phan so co tu {0} la: {1}", x, phanSokq);
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 19
                case Menu.TinhTongTatCaCacPhanSoCoMauX:
                    Console.Write("Xin hay nhap mau so can tinh: ");
                    x = int.Parse(Console.ReadLine());
                    phanSokq = a.TinhTongCacPhanSo_TuMau(x, 1);
                    Console.Clear();
                    Console.WriteLine("Tong tat ca cac phan so co mau {0} la: {1}", x, phanSokq);
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 20
                case Menu.XoaMotPhanSoTaiViTri:
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.Write("Xin hay nhap vi tri can xoa: ");
                    x = int.Parse(Console.ReadLine());
                    x--;
                    if ((x < 0) || (x >= a.DemPhanSo()))
                    {
                        Console.WriteLine("Vi tri khong ton tai!");
                    }
                    else
                    {
                        a.XoaPhanSoTaiViTri(x);
                        Console.WriteLine("Xoa thanh cong! Danh sach phan so sau khi xoa: ");
                        Console.WriteLine(a);
                    }
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 21
                case Menu.XoaPhanSoDauTienTrongMang:
                    Console.WriteLine("Danh sach phan so truoc khi xoa: ");
                    Console.WriteLine(a);
                    a.XoaPhanSoDauTien();
                    Console.WriteLine("Danh sach phan so sau khi xoa: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
                    break;
                #endregion
                #region Case 22
                case Menu.XoaPhanSoCuoiCungTrongMang:
                    Console.WriteLine("Danh sach phan so sau khi xoa: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Danh sach phan so sau khi xoa: ");
                    a.XoaPhanSoCuoiCung();
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 23
                case Menu.XoaPhanSoXTrongMang:
                    Console.Write("Xin hay nhap phan so can xoa (cu phap: tu/mau): ");
                    phanSoX = new PhanSo(Console.ReadLine());
                    Console.Clear();
                    if (!a.XoaTatCaPhanSoX(phanSoX))
                        Console.WriteLine("Khong tim thay phan so {0} trong danh sach!", phanSoX);
                    else
                        Console.WriteLine("Da xoa phan so {0} thanh cong!", phanSoX);
                    Console.WriteLine("Danh sach phan so hien hanh:");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 24
                case Menu.XoaTatCaPhanSoCoTuX:
                    Console.Write("Xin hay nhap tu so cua phan so can xoa: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (!a.XoaTatCaPhanSoCung_TuMau(x, 0))
                        Console.WriteLine("Khong tim thay phan so co tu {0} trong danh sach!", x);
                    else
                        Console.WriteLine("Da xoa phan so co tu so {0} ra khoi danh sach", x);
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 25
                case Menu.XoaTatCaPhanSoCoMauX:
                    Console.Write("Xin hay nhap mau so cua phan so can xoa: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (!a.XoaTatCaPhanSoCung_TuMau(x, 1))
                        Console.WriteLine("Khong tim thay phan so co mau so {0} trong danh sach!", x);
                    else
                        Console.WriteLine("Da xoa phan so co mau so {0} ra khoi danh sach", x);
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                    break;
                #endregion
                #region Case 26
                case Menu.XoaTatCaPhanSoCoGiaTriBangPhanSoDauTienTrongMang:
                    Console.WriteLine("Danh sach phan so truoc khi xoa: ");
                    Console.WriteLine(a);
                    a.XoaTatCaPhanSoCoGiaTriGiongPhanSo_DauTienCuoiCung(0);
                    Console.WriteLine("Xoa thanh cong! Danh sach phan so sau khi xoa: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 27
                case Menu.XoaTatCaPhanSoCoGiaTriBangPhanSoCuoiCungTrongMang:
                    Console.WriteLine("Danh sach phan so truoc khi xoa: ");
                    Console.WriteLine(a);
                    a.XoaTatCaPhanSoCoGiaTriGiongPhanSo_DauTienCuoiCung(1);
                    Console.WriteLine("Xoa thanh cong! Danh sach phan so sau khi xoa: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 28
                case Menu.XoaTatCaPhanSoCoGiaTriNhoNhat:
                    Console.WriteLine("Danh sach phan so truoc khi xoa: ");
                    Console.WriteLine(a);
                    phanSokq = a.TimPhanSoCoMin_Max(0);
                    Console.WriteLine("Phan so co gia tri nho nhat la: " + phanSokq);
                    a.XoaTatCaPhanSoCoGiaTriLonNhat_NhoNhat(0);
                    Console.WriteLine("Da xoa thanh cong! Danh sach phan so sau khi xoa: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 29
                case Menu.XoaTatCaPhanSoCoGiaTriLonNhat:
                    Console.WriteLine("Danh sach phan so truoc khi xoa: ");
                    Console.WriteLine(a);
                    phanSokq = a.TimPhanSoCoMin_Max(1);
                    Console.WriteLine("Phan so co gia tri lon nhat la: " + phanSokq);
                    a.XoaTatCaPhanSoCoGiaTriLonNhat_NhoNhat(1);
                    Console.WriteLine("Da xoa thanh cong! Danh sach phan so sau khi xoa: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 30
                case Menu.XoaTatCaPhanSoAm:
                    Console.WriteLine("Danh sach phan so truoc khi xoa: ");
                    Console.WriteLine(a);
                    a.XoaTatCaPhanSoAm_Duong(0);
                    Console.WriteLine("Da xoa thanh cong! Danh sach phan so sau khi xoa: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 31
                case Menu.XoaTatCaPhanSoDuong:
                    Console.WriteLine("Danh sach phan so truoc khi xoa: ");
                    Console.WriteLine(a);
                    a.XoaTatCaPhanSoAm_Duong(1);
                    Console.WriteLine("Da xoa thanh cong! Danh sach phan so sau khi xoa: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 32
                case Menu.ThemMotPhanSoTaiViTri:
                    Console.Write("Xin hay nhap phan so can them (cu phap: tu/mau): ");
                    phanSoX = new PhanSo(Console.ReadLine());
                    Console.Write("Xin hay nhap vi tri cua phan so: ");
                    x = int.Parse(Console.ReadLine());
                    if (a.ThemPhanSoTaiViTri(phanSoX, x - 1))
                        Console.WriteLine("Da them phan so {0} vao vi tri thu {1} thanh cong!", phanSoX, x);
                    else
                        Console.WriteLine("Them phan so that bai! Xin hay thu lai!");
                    Console.WriteLine("Danh sach phan so hien hanh:");
                    Console.WriteLine(a);
                    break;
                #endregion
                #region Case 33
                case Menu.ThemPhanSoTaiViTriDauTienTrongMang:
                    Console.WriteLine("Xin hay nhap phan so can them (cu phap: tu/mau): ");
                    phanSoX = new PhanSo(Console.ReadLine());
                    a.ThemPhanSoTaiViTriDauTien(phanSoX);
                    Console.WriteLine("Da them thanh cong!");
                    Console.WriteLine("Danh sach phan so hien hanh: ");
                    Console.WriteLine(a);
                    Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                    break;
                #endregion
                #region Case 34
                case Menu.SapXepPhanSo:
                    KieuSapXep sortType = new KieuSapXep();
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("============================= KIEU SAP XEP =============================");
                        Console.WriteLine("{0}. Quay tro lai Menu chinh", (int)KieuSapXep.Thoat);
                        Console.WriteLine("{0}. Sap xep theo chieu tang cua phan so", (int)KieuSapXep.SapXepTang);
                        Console.WriteLine("{0}. Sap xep theo chieu giam cua phan so", (int)KieuSapXep.SapXepGiam);
                        Console.WriteLine("========================================================================");
                        Console.Write("Xin hay nhap 1 so de chon chuc nang tuong ung: ");
                        sortType = (KieuSapXep)int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (sortType)
                        {
                            case KieuSapXep.Thoat:
                                Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                                break;
                            case KieuSapXep.SapXepTang:
                                a.SapXepDanhSachPhanSoTheoChieuTang();
                                Console.WriteLine("Da sap xep thanh cong! Danh sach phan so hien hanh:");
                                Console.WriteLine(a);
                                Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                                Console.ReadKey();
                                break;
                            case KieuSapXep.SapXepGiam:
                                a.SapXepDanhSachPhanSoTheoChieuGiam();
                                Console.WriteLine("Da sap xep thanh cong! Danh sach phan so hien hanh:");
                                Console.WriteLine(a);
                                Console.WriteLine("Nhan 1 phim bat ky de tiep tuc!");
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }
                    } while (sortType != KieuSapXep.Thoat);
                    break;
                #endregion  
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
