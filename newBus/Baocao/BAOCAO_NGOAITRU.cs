﻿using System;
using System.Data;
using System.Transactions;
using System.Linq;
using SubSonic;
using VNS.Libs;
using VNS.HIS.DAL;

using System.Text;

using SubSonic;
using NLog;

namespace VNS.HIS.BusRule.Classes
{
    public class BAOCAO_NGOAITRU
    {
        private NLog.Logger log;
        public BAOCAO_NGOAITRU()
        {
            log = LogManager.GetCurrentClassLogger();
        }
        public static DataTable BaocaoTiepdonbenhnhanTonghop(DateTime? FromDate, DateTime? ToDate, int? iddoituongkcb, string nguoitao, string DeparmentCODE)
        {
            return SPs.BaocaoTiepdonbenhnhanTonghop(FromDate, ToDate, iddoituongkcb, nguoitao, DeparmentCODE).GetDataSet().Tables[0];
        }
        public static DataTable BaocaoTiepdonbenhnhanChitiet(int? ObjectType, DateTime? FromDate, DateTime? ToDate, string nguoitao, string DeparmentCODE)
        {
            return SPs.BaocaoTiepdonbenhnhanChitiet(ObjectType, FromDate, ToDate, nguoitao, DeparmentCODE).GetDataSet().Tables[0];
            
        }
        public static DataTable BaocaoMiengiam(int idnhanvienthanhtoan, string tungay, string denngay)
        {
            return SPs.BaocaoMiengiam(idnhanvienthanhtoan, tungay, denngay).GetDataSet().Tables[0];

        }
        public static DataTable BaocaoTamungHoanung(int IdTNV, string tungay, string denngay, short IdKhoanoitru, short IdDoituongKcb, byte kieutamung)
        {
            return SPs.BaocaoTamungHoanung(IdTNV, tungay, denngay, IdKhoanoitru, IdDoituongKcb, kieutamung).GetDataSet().Tables[0];

        }
        public static DataTable BaocaoHuytien(int IdTNV, string tungay, string denngay, byte loaiphieuhuy)
        {
            return SPs.BaocaoHuytien(IdTNV, tungay, denngay, loaiphieuhuy).GetDataSet().Tables[0];

        }
        public static DataTable BaocaoTonghopchiphiBenhvien(int IdTnv, string tungay, string denngay)
        {
            return SPs.BaocaoTonghopchiphiBenhvien(IdTnv, tungay, denngay).GetDataSet().Tables[0];

        }
        public static DataTable BaocaoThutientheokhoaChitiet(string maphongthien, DateTime? FromDate, DateTime? ToDate, string MaDoiTuong, string nhomdichvu, string CreateBy, string MAKHOATHIEN)
        {
            return SPs.BaocaoThutientheokhoaChitiet(maphongthien, FromDate, ToDate, MaDoiTuong, nhomdichvu, CreateBy, MAKHOATHIEN).GetDataSet().Tables[0];
        }
        public static DataTable BaocaoThutientheokhoaTonghop(string maphongthien, DateTime? FromDate, DateTime? ToDate, string MaDoiTuong, string nhomdichvu, string CreateBy, string MAKHOATHIEN)
        {
            return SPs.BaocaoThutientheokhoaTonghop(maphongthien, FromDate, ToDate, MaDoiTuong,  CreateBy,nhomdichvu, MAKHOATHIEN).GetDataSet().Tables[0];
        }


        public static DataTable BaocaoChidinhclsChitiet(DateTime? FromDate, DateTime? ToDate, string MaDoiTuong, string nhomdichvu, string CreateBy, string MAKHOATHIEN, int? NoExam)
        {
            return SPs.BaocaoChidinhclsChitiet(FromDate, ToDate, MaDoiTuong, nhomdichvu, CreateBy, MAKHOATHIEN, NoExam).GetDataSet().Tables[0];
        }
        public static DataTable BaocaoChidinhclsTonghop(DateTime? FromDate, DateTime? ToDate, string MaDoiTuong, string nhomdichvu, string CreateBy, string MAKHOATHIEN, int? NoExam)
        {
            return SPs.BaocaoChidinhclsTonghop(FromDate, ToDate, MaDoiTuong, CreateBy, nhomdichvu, MAKHOATHIEN, NoExam).GetDataSet().Tables[0];
        }



        public static DataTable BaocaoThutienkhamTonghop(DateTime? FromDate, DateTime? ToDate, string maDoituongKCB, string maTNV,short idLoaithanhtoan, string MAKHOATHIEN)
        {
            return SPs.BaocaoThutienkhamTonghop(FromDate, ToDate, maDoituongKCB, maTNV,idLoaithanhtoan, MAKHOATHIEN).GetDataSet().Tables[0];
        }
        public static DataTable BaocaoDoanhthuphongkham(DateTime? FromDate, DateTime? ToDate, string maDoituongKCB, string maTNV, short? idKieuthanhtoan, string MAKHOATHIEN)
        {
            return SPs.BaocaoDoanhthuphongkham(FromDate, ToDate, maDoituongKCB, maTNV, idKieuthanhtoan, MAKHOATHIEN).GetDataSet().Tables[0];
        }
        public static DataTable BaocaoDoanhthuphongkhamTonghop(DateTime? FromDate, DateTime? ToDate, string maDoituongKCB, string maTNV, short? idKieuthanhtoan, string MAKHOATHIEN)
        {
            return SPs.BaocaoDoanhthuphongkhamTonghop(FromDate, ToDate, maDoituongKCB, maTNV, idKieuthanhtoan, MAKHOATHIEN).GetDataSet().Tables[0];
        }
        public static DataTable BaocaoThutienkhamChitiet(DateTime? FromDate, DateTime? ToDate, string MaDoiTuong, string CreateBy,short idLoaithanhtoan, string MAKHOATHIEN)
        {
            return SPs.BaocaoThutienkhamChitiet(FromDate, ToDate, MaDoiTuong, CreateBy,idLoaithanhtoan, MAKHOATHIEN).GetDataSet().Tables[0];
        }

        public static DataTable BaocaoDanhsachhoadonThuphi(DateTime? TuNgay, DateTime? DenNgay, int? LoaiTimKiem, string DoiTuong, string NguoiThu, int? NTNT, int? cohoadon, string maquyen, int? fromserie, int? toserie, string KhoaThucHien)
        {
            return SPs.BaocaoDanhsachhoadonThuphi(TuNgay, DenNgay, LoaiTimKiem, DoiTuong, NguoiThu, NTNT, cohoadon,maquyen,fromserie,toserie, KhoaThucHien).GetDataSet().Tables[0];
        }

        public static DataTable BaocaoThuvienphiTonghop(string makhoaKCB, DateTime? FromDate, DateTime? ToDate, string NGUOITHU, string DOITUONG, int? NTNT, int? Cohoadon, int? TTCHOT)
        {
            return SPs.BaocaoThuvienphiTonghop(makhoaKCB, FromDate, ToDate, NGUOITHU, DOITUONG, NTNT, Cohoadon, TTCHOT).GetDataSet().Tables[0];
        }

        public static DataTable BaocaoThuvienphiChitiet(string makhoaKCB, DateTime? FromDate, DateTime? ToDate, string NGUOITHU, string DOITUONG, int? NTNT, int? Cohoadon, int? TTCHOT)
        {
            return SPs.BaocaoThuvienphiChitiet(makhoaKCB, FromDate, ToDate, NGUOITHU, DOITUONG, NTNT, Cohoadon, TTCHOT).GetDataSet().Tables[0];
        }
        public static DataTable BaoCaoThongkeKhamChuaBenh(DateTime? FromDate, DateTime? ToDate, int DoiTuong, int TrangThai, int GioiTinh, int NhanVien)
        {
            return
                SPs.BaocaoThongkeKhamchuabenh(FromDate, ToDate, DoiTuong, GioiTinh, NhanVien, TrangThai).GetDataSet().
                    Tables[0];
        }
        public static DataTable BaoCaoThongkeChuyenVienDi(DateTime? FromDate, DateTime? ToDate, int DoiTuong, int TrangThai, int NoiChuyenDi)
        {
            return
                SPs.BaocaoThongkeChuyenviendi(FromDate, ToDate, NoiChuyenDi, TrangThai, DoiTuong).GetDataSet().
                    Tables[0];
        }
        public static DataTable BaoCaoThongkeChuyenVienDen(DateTime? FromDate, DateTime? ToDate, int DoiTuong, int TrangThai, int NoiChuyenDen)
        {
            return
                SPs.BaocaoThongkeChuyenvienden(FromDate, ToDate, NoiChuyenDen, TrangThai, DoiTuong).GetDataSet().
                    Tables[0];
        }
        public static DataTable BaoCaoThongkeNhapvienChitiet(DateTime? FromDate, DateTime? ToDate, int DoiTuong, int khoanoitru)
        {
            return
                SPs.BaocaoThongkeNhapvienChitiet(FromDate, ToDate, DoiTuong,khoanoitru).GetDataSet().
                    Tables[0];
        }
        public static DataTable BaoCaoThongkeNhapvienTonghop(DateTime? FromDate, DateTime? ToDate, int DoiTuong, int khoanoitru)
        {
            return
                SPs.BaocaoThongkeNhapvienTonghop(FromDate, ToDate, DoiTuong, khoanoitru).GetDataSet().
                    Tables[0];
        }
    }
}