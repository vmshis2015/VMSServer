﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using VNS.Libs;
using VNS.HIS.DAL;
using VNS.HIS.UI.BaoCao;
using Microsoft.VisualBasic;


namespace VNS.HIS.UI.Baocao
{
  public class thuoc_baocao
    {
        /// <summary>
        /// hàm thưc hiện việc in phiếu vật tư và thuốc
        /// </summary>
        /// <param name="objDPhieuCapphat"></param>
        /// <param name="dataTable"></param>
        public static void Inphieutonghoplinhthuocnoitru(TPhieuCapphatNoitru objDPhieuCapphat, DataTable dataTable)
        {

            if (objDPhieuCapphat != null)
            {
                // string loaiphieulinh = objDPhieuCapphat.LinhBSung == false ? "Lĩnh thường" : "Lĩnh bổ sung";

                if (objDPhieuCapphat.KieuThuocVt == "VT")
                    PhieuTongHopLinhThuoc(dataTable,
                        objDPhieuCapphat.NgayNhap,"thuoc_noitru_phieutonghopvattunoitru");
                else
                {

                    var query = from thuoc in dataTable.AsEnumerable()
                                where Utility.Int32Dbnull(thuoc[DmucThuoc.Columns.TinhChat]) >= 1
                                select thuoc;

                    if (query.Any())
                    {
                        DataTable m_dtThuocGayNghien = query.CopyToDataTable();
                        if (m_dtThuocGayNghien != null)
                        {
                            PhieuTongHopLinhThuoc(m_dtThuocGayNghien, objDPhieuCapphat.NgayNhap, "thuoc_noitru_phieutonghopthuocgaynghiennoitru");
                        }
                        query = from thuoc in dataTable.AsEnumerable()
                                where Utility.Int32Dbnull(thuoc[DmucThuoc.Columns.TinhChat]) == 0
                                select thuoc;
                        if (query.Any())
                        {
                            DataTable m_dtThuocThuong = query.CopyToDataTable();
                            if (m_dtThuocThuong != null)
                                PhieuTongHopLinhThuoc(m_dtThuocThuong, objDPhieuCapphat.NgayNhap,"thuoc_noitru_phieutonghopthuocnoitru");
                        }

                    }
                    else
                    {
                        query = from thuoc in dataTable.AsEnumerable()
                                where Utility.Int32Dbnull(thuoc[DmucThuoc.Columns.TinhChat], 0) == 0
                                select thuoc;
                        if (query.Any())
                        {
                            dataTable = query.CopyToDataTable();
                            if (dataTable != null)
                            {
                                DataTable m_dtPhieuLinhThuoc = PhieuLinhThuoc(dataTable, "THUOC");
                                if (m_dtPhieuLinhThuoc != null)
                                {
                                    PhieuTongHopLinhThuoc(dataTable, objDPhieuCapphat.NgayNhap,"thuoc_noitru_phieutonghopthuocnoitru");
                                }
                                m_dtPhieuLinhThuoc = PhieuLinhThuoc(dataTable, "VT");
                                if (m_dtPhieuLinhThuoc != null)
                                {

                                    PhieuTongHopLinhThuoc(dataTable, objDPhieuCapphat.NgayNhap, "thuoc_noitru_phieutonghopvattunoitru");
                                }
                            }

                        }



                    }

                }
            }
        }
        public static void PhieuTongHopLinhThuoc(DataTable m_dtReport, DateTime Ngaylapphieu,string reportcode)
        {
            try
            {
                if (m_dtReport.Rows.Count <= 0)
                {
                    Utility.ShowMsg("Không có dữ liệu để in. Mời bạn kiểm tra lại", "Thông báo",
                      MessageBoxIcon.Warning);
                    return;
                }
                string tieude = "", reportname = "";
                var crpt = Utility.GetReport(reportcode, ref tieude, ref reportname);
                if (crpt == null) return;
                THU_VIEN_CHUNG.CreateXML(m_dtReport, "thuoc_noitru_phieutonghopvattunoitru.XML");
                crpt.SetDataSource(m_dtReport);
                var objForm = new frmPrintPreview(tieude, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
                Utility.UpdateLogotoDatatable(ref m_dtReport);
                objForm.crptViewer.ReportSource = crpt;
                objForm.mv_sReportFileName = Path.GetFileName(reportname);
                objForm.mv_sReportCode = reportcode;
                Utility.SetParameterValue(crpt, "ParentBranchName", globalVariables.ParentBranch_Name);
                Utility.SetParameterValue(crpt, "BranchName", globalVariables.Branch_Name);
                Utility.SetParameterValue(crpt, "sCurrentDate", Utility.FormatDateTimeWithThanhPho(Ngaylapphieu));
                Utility.SetParameterValue(crpt, "sTitleReport", tieude);
                Utility.SetParameterValue(crpt, "BottomCondition", THU_VIEN_CHUNG.BottomCondition());
                objForm.ShowDialog();
            }
            catch (Exception ex)
            {

                Utility.CatchException(ex);
            }
            finally
            {
                GC.Collect();
            }


        }
       
        private static DataTable PhieuLinhThuoc(DataTable m_dtreport, string kieuvattuthuoc)
        {
            var query = from thuoc in m_dtreport.AsEnumerable()
                        where Utility.sDbnull(thuoc[DmucThuoc.Columns.KieuThuocvattu]) == kieuvattuthuoc

                        select thuoc;
            if (query.Any()) return query.CopyToDataTable();
            else return null;
        }
        

      public static void BaocaoNhapkhoChitiet(DataTable m_dtReport,string tenbaocao, string sTitleReport, DateTime NgayIn, string FromDateToDate)
        {

            string tieude = "", reportname = "";
            var crpt = Utility.GetReport(tenbaocao, ref tieude, ref reportname);
            if (crpt == null) return;
           
            MoneyByLetter _moneyByLetter = new MoneyByLetter();
           // VNS.HIS.UI.BaoCao.PhieuBaoCao.CRPT_BAOCAO_CHITIET_NHAPKHO crpt = new CRPT_BAOCAO_CHITIET_NHAPKHO();
            var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
            string tinhtong = TinhTong(m_dtReport);
            Utility.UpdateLogotoDatatable(ref m_dtReport);
            try
            {

                crpt.SetDataSource(m_dtReport);
                objForm.crptViewer.ReportSource = crpt;

                //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
                objForm.mv_sReportFileName = Path.GetFileName(reportname);
                objForm.mv_sReportCode = tenbaocao;
                Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
                Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
                Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
                Utility.SetParameterValue(crpt,"sMoneyLetter", _moneyByLetter.sMoneyToLetter(tinhtong));
               //  frmPrintPreview objForm = new frmPrintPreview("", crpt, true, strPatientCode == null ? false : true);
                //  Utility.SetParameterValue(crpt,"TongTien", Total.ToString());
                //Utility.SetParameterValue(crpt,"characterMoney", MoneyByLetter.sMoneyToLetter(Total.ToString()));
                //Utility.SetParameterValue(crpt,"TongTien","10000");
                //Utility.SetParameterValue(crpt,"Staff_Name", BusinessHelper.GetNameByUserName(globalVariables.UserName));
                Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
                Utility.SetParameterValue(crpt,"sTitleReport", tieude);
                Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());
                objForm.ShowDialog();
                // Utility.DefaultNow(this);
            }
            catch (Exception ex)
            {
                if (globalVariables.IsAdmin)
                {
                    Utility.ShowMsg(ex.ToString());
                }
            }
        }
      public static void BaocaohuythuocChitiet(DataTable m_dtReport,string tenbaocao, string sTitleReport, DateTime NgayIn, string FromDateToDate)
      {

          string tieude = "", reportname = "";
          var crpt = Utility.GetReport(tenbaocao, ref tieude, ref reportname);
          if (crpt == null) return;

          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          string tinhtong = TinhTong(m_dtReport);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {


              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;

              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = tenbaocao;
              Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"sMoneyLetter", _moneyByLetter.sMoneyToLetter(tinhtong));
              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", tieude);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());
              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      public static void Baocaotrathuocnhacungcap(DataTable m_dtReport,string tenbaocao, string sTitleReport, DateTime NgayIn, string FromDateToDate)
      {

          string tieude = "", reportname = "";
          var crpt = Utility.GetReport(tenbaocao, ref tieude, ref reportname);
          if (crpt == null) return;

          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          string tinhtong = TinhTong(m_dtReport);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {


              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;

              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = tenbaocao;
              Utility.SetParameterValue(crpt, "ParentBranchName", globalVariables.ParentBranch_Name);
              Utility.SetParameterValue(crpt, "BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt, "FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt, "sMoneyLetter", _moneyByLetter.sMoneyToLetter(tinhtong));
              Utility.SetParameterValue(crpt, "sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt, "sTitleReport", tieude);
              Utility.SetParameterValue(crpt, "BottomCondition", THU_VIEN_CHUNG.BottomCondition());
              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      public static void BaocaoThanhlythuoc(DataTable m_dtReport,string tenbaocao, string sTitleReport, DateTime NgayIn, string FromDateToDate)
      {

          string tieude = "", reportname = "";
          var crpt = Utility.GetReport(tenbaocao, ref tieude, ref reportname);
          if (crpt == null) return;

          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          string tinhtong = TinhTong(m_dtReport);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {


              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;

              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = tenbaocao;
              Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"sMoneyLetter", _moneyByLetter.sMoneyToLetter(tinhtong));
              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", tieude);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());
              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      /// <summary>
      /// BÁO XUÂT NHẬP TỒN KHO CỦA KHO CHẴN
      /// </summary>
      /// <param name="m_dtReport"></param>
      /// <param name="sTitleReport"></param>
      /// <param name="NgayIn"></param>
      /// <param name="FromDateToDate"></param>
      public static void BaocaoNhapxuattonKhochan(DataTable m_dtReport,string kieuthuoc_vt, string sTitleReport, DateTime NgayIn, string FromDateToDate, string tenkho,bool theonhom)
      {

          string tieude = "", reportname = "",reportcode="thuoc_baocao_nhapxuatton_khochan_theonhom";
          ReportDocument crpt = null;
          if (kieuthuoc_vt == "THUOC")
          {
              if (theonhom)
              {
                  reportcode = "thuoc_baocao_nhapxuatton_khochan_theonhom";
                  crpt = Utility.GetReport("thuoc_baocao_nhapxuatton_khochan_theonhom", ref tieude, ref reportname);
              }
              else
              {
                  reportcode = "thuoc_baocao_nhapxuatton_khochan";
                  crpt = Utility.GetReport("thuoc_baocao_nhapxuatton_khochan", ref tieude, ref reportname);
              }
          }
          else//VTTH
          {
              if (theonhom)
              {
                  reportcode = "vt_baocao_nhapxuatton_khochan_theonhom";
                  crpt = Utility.GetReport("vt_baocao_nhapxuatton_khochan_theonhom", ref tieude, ref reportname);
              }
              else
              {
                  reportcode = "vt_baocao_nhapxuatton_khochan";
                  crpt = Utility.GetReport("vt_baocao_nhapxuatton_khochan", ref tieude, ref reportname);
              }
          }
          if (crpt == null) return;
          
          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          // VNS.HIS.UI.BaoCao.PhieuBaoCao.CRPT_BAOCAO_CHITIET_NHAPKHO crpt = new CRPT_BAOCAO_CHITIET_NHAPKHO();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          objForm.mv_sReportFileName = Path.GetFileName(reportname);
          objForm.mv_sReportCode = reportcode;
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {

               m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt,"Phone", globalVariables.Branch_Phone);

              //Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              //Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"Department_Name", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt,"tenkho", tenkho);
              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", sTitleReport);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());

              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }

      public static void BaocaoNhapxuattonTheoquy(DataTable m_dtReport, string kieuthuoc_vt, string sTitleReport, string _tondau,string _toncuoi,DateTime NgayIn, string FromDateToDate, string tenkho, bool theonhom)
      {

          string tieude = "", reportname = "", reportcode = "thuoc_baocao_nhapxuatton_theoquy_theonhom";
          ReportDocument crpt = null;
          if (kieuthuoc_vt == "THUOC")
          {
              if (theonhom)
              {
                  reportcode = "thuoc_baocao_nhapxuatton_theoquy_theonhom";
                  crpt = Utility.GetReport("thuoc_baocao_nhapxuatton_theoquy_theonhom", ref tieude, ref reportname);
              }
              else
              {
                  reportcode = "thuoc_baocao_nhapxuatton_theoquy";
                  crpt = Utility.GetReport("thuoc_baocao_nhapxuatton_theoquy", ref tieude, ref reportname);
              }
          }
          else//VTTH
          {
              if (theonhom)
              {
                  reportcode = "vt_baocao_nhapxuatton_theoquy_theonhom";
                  crpt = Utility.GetReport("vt_baocao_nhapxuatton_theoquy_theonhom", ref tieude, ref reportname);
              }
              else
              {
                  reportcode = "vt_baocao_nhapxuatton_theoquy";
                  crpt = Utility.GetReport("vt_baocao_nhapxuatton_theoquy", ref tieude, ref reportname);
              }
          }
          if (crpt == null) return;

          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          string tinhtong = TinhTong(m_dtReport, "TT_TONCUOI");
          // VNS.HIS.UI.BaoCao.PhieuBaoCao.CRPT_BAOCAO_CHITIET_NHAPKHO crpt = new CRPT_BAOCAO_CHITIET_NHAPKHO();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          objForm.mv_sReportFileName = Path.GetFileName(reportname);
          objForm.mv_sReportCode = reportcode;
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {
              if (theonhom)
                  m_dtReport.DefaultView.Sort = "stt_hthi_nhom,tenbietduoc";
              else
                  m_dtReport.DefaultView.Sort = "tenbietduoc";
              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport.DefaultView);
              objForm.crptViewer.ReportSource = crpt;
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              Utility.SetParameterValue(crpt, "BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt, "Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt, "Phone", globalVariables.Branch_Phone);

              Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              Utility.SetParameterValue(crpt, "Tondau", _tondau);
              Utility.SetParameterValue(crpt, "Toncuoi", _toncuoi);
              Utility.SetParameterValue(crpt, "FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt, "Department_Name", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt, "tenkho", tenkho);
              Utility.SetParameterValue(crpt, "thanhtien_bangchu", _moneyByLetter.sMoneyToLetter(tinhtong.ToString()));
              Utility.SetParameterValue(crpt, "sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt, "sTitleReport", sTitleReport);
              Utility.SetParameterValue(crpt, "BottomCondition", THU_VIEN_CHUNG.BottomCondition());

              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }

      public static void BaocaoNhapxuattonKhochanTheonhom(DataTable m_dtReport, string sTitleReport, DateTime NgayIn, string FromDateToDate, string tenkho)
      {

          string tieude = "", reportname = "";
          var crpt = Utility.GetReport("CRPT_BAOCAO_SLUONG_NHAPXUAT_TON_KHOCHAN_NHOM_LOAI", ref tieude, ref reportname);
          if (crpt == null) return;
          
         
          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          // VNS.HIS.UI.BaoCao.PhieuBaoCao.CRPT_BAOCAO_CHITIET_NHAPKHO crpt = new CRPT_BAOCAO_CHITIET_NHAPKHO();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          //string tinhtong = TinhTong(m_dtReport);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {

              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;
              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = "CRPT_BAOCAO_SLUONG_NHAPXUAT_TON_KHOCHAN_NHOM_LOAI";
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt,"Phone", globalVariables.Branch_Phone);
              //Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              //Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"Department_Name", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt,"tenkho", tenkho);
              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", sTitleReport);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());

              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      /// <summary>
      ///  hàm thực hiện vie báo cáo xuất nhập tồn kho lẻ
      /// </summary>
      /// <param name="m_dtReport"></param>
      /// <param name="sTitleReport"></param>
      /// <param name="NgayIn"></param>
      /// <param name="FromDateToDate"></param>
      /// <param name="tenkho"></param>
      public static void BaocaoNhapxuattonKhole(DataTable m_dtReport,string kieuthuoc_vt, string sTitleReport, DateTime NgayIn, string FromDateToDate, string tenkho,bool Nhomthuoc)
      {

          string tieude = "", reportname = "", reportcode="";
          ReportDocument crpt = null;
          if (kieuthuoc_vt == "THUOC")
          {
              if (Nhomthuoc)
              {
                  reportcode = "thuoc_baocao_nhapxuattonkhole_theonhom";
                  crpt = Utility.GetReport("thuoc_baocao_nhapxuattonkhole_theonhom", ref tieude, ref reportname);
              }
              else
              {
                  reportcode = "thuoc_baocao_nhapxuattonkhole";
                  crpt = Utility.GetReport("thuoc_baocao_nhapxuattonkhole", ref tieude, ref reportname);
              }
          }
          else
          {
              if (Nhomthuoc)
              {
                  reportcode = "vt_baocao_nhapxuattonkhole_theonhom";
                  crpt = Utility.GetReport("vt_baocao_nhapxuattonkhole_theonhom", ref tieude, ref reportname);
              }
              else
              {
                  reportcode = "vt_baocao_nhapxuattonkhole";
                  crpt = Utility.GetReport("vt_baocao_nhapxuattonkhole", ref tieude, ref reportname);
              }
          }
          if (crpt == null) return;
          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {

              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;
              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = reportcode;
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt,"Phone", globalVariables.Branch_Phone);
              //Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              //Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"Department_Name", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt,"tenkho", tenkho);
              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", tieude);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());

              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      public static void ThethuocChitiet(DataTable m_dtReport,string kieuthuoc_vt, string sTitleReport, DateTime NgayIn, string FromDateToDate, string tenkho)
      {

          string tieude = "", reportname = "";
          var crpt = Utility.GetReport(kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc_chitiet" : "vt_thevt_chitiet", ref tieude, ref reportname);
          if (crpt == null) return;

          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {

              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;
              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc_chitiet" : "vt_thevt_chitiet";
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG DƯỢC   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt,"Phone", globalVariables.Branch_Phone);

              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", tieude);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());

              objForm.ShowDialog();
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      public static void Thethuoc(DataTable m_dtReport,string kieuthuoc_vt, string sTitleReport, DateTime NgayIn, string FromDateToDate, string tenkho)
      {

          string tieude = "", reportname = "";
          var crpt = Utility.GetReport(kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc" : "vt_thevt", ref tieude, ref reportname);
          if (crpt == null) return;

          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {

              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;
              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc" : "vt_thevt";
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt,"Phone", globalVariables.Branch_Phone);

              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"Department_Name", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt,"tenkho", tenkho);
              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", sTitleReport);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());

              objForm.ShowDialog();
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      public static void Thethuockhochan(DataTable m_dtReport,string kieuthuoc_vt, string sTitleReport, DateTime NgayIn, string FromDateToDate, string tenkho)
      {

          string tieude = "", reportname = "";
          var crpt = Utility.GetReport(kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc_khochan" : "vt_thevt_khochan", ref tieude, ref reportname);
          if (crpt == null) return;

          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {

              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;
              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc_khochan" : "vt_thevt_khochan";
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt,"Phone", globalVariables.Branch_Phone);

              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"Department_Name", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt,"tenkho", tenkho);
              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", sTitleReport);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());

              objForm.ShowDialog();
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      public static void Thethuoctutruc(DataTable m_dtReport, string kieuthuoc_vt, string sTitleReport, DateTime NgayIn, string FromDateToDate, string tenkho)
      {

          string tieude = "", reportname = "";
          var crpt = Utility.GetReport(kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc_tutruc" : "vt_thevt_tutruc", ref tieude, ref reportname);
          if (crpt == null) return;


          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          var objForm = new frmPrintPreview(tieude, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {

              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;
              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc_tutruc" : "vt_thevt_tutruc";
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              Utility.SetParameterValue(crpt, "BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt, "Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt, "Phone", globalVariables.Branch_Phone);
              //Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              //Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt, "FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt, "Department_Name", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt, "tenkho", tenkho);
              Utility.SetParameterValue(crpt, "sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt, "sTitleReport", tieude);
              Utility.SetParameterValue(crpt, "BottomCondition", THU_VIEN_CHUNG.BottomCondition());

              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      public static void ThethuocKhole(DataTable m_dtReport,string kieuthuoc_vt, string sTitleReport, DateTime NgayIn, string FromDateToDate, string tenkho)
      {

          string tieude = "", reportname = "";
          var crpt = Utility.GetReport(kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc_khole" : "vt_thevt_khole", ref tieude, ref reportname);
          if (crpt == null) return;
          
         
          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          var objForm = new frmPrintPreview(tieude, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {

              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;
              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = kieuthuoc_vt == "THUOC" ? "thuoc_thethuoc_khole" : "vt_thevt_khole";
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt,"Phone", globalVariables.Branch_Phone);
              //Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              //Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"Department_Name", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt,"tenkho", tenkho);
              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt, "sTitleReport", tieude);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());

              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }
      public static void baocao_nhapthuoctheo_nhacungcap(DataTable m_dtReport,string tenbaocao, string sTitleReport, DateTime NgayIn, string FromDateToDate)
      {

          MoneyByLetter _moneyByLetter = new MoneyByLetter();
          string tieude = "", reportname = "";
          var crpt = Utility.GetReport(tenbaocao, ref tieude, ref reportname);
          if (crpt == null) return;
          
        //  VNS.HIS.UI.BaoCao.Reports.CRPT_PHIEU_BIENBAN_BANGIAO_HOADON crpt = new CRPT_PHIEU_BIENBAN_BANGIAO_HOADON();
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          string tinhtong = TinhTong(m_dtReport,"thanhtien");
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {

              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              objForm.crptViewer.ReportSource = crpt;
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = tenbaocao;
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"Address", globalVariables.Branch_Address);
              Utility.SetParameterValue(crpt,"Phone", globalVariables.Branch_Phone);

              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"Department_Name", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt,"sMoneyLetter", _moneyByLetter.sMoneyToLetter(tinhtong));
              Utility.SetParameterValue(crpt,"TongSoTien", tinhtong);

              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", tieude);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());
             
              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }

      public static void Baocaothuochethan(DataTable m_dtReport, string sTitleReport, DateTime NgayIn, string FromDateToDate)
      {

          MoneyByLetter _moneyByLetter = new MoneyByLetter();
           string tieude="", reportname = "";
          ReportDocument crpt = Utility.GetReport("thuoc_baocao_thuochethan" ,ref tieude,ref reportname);
          if (crpt == null) return;
          var objForm = new frmPrintPreview(sTitleReport, crpt, true, m_dtReport.Rows.Count <= 0 ? false : true);
          string tinhtong = TinhTong(m_dtReport, "thanhtien");
          Utility.UpdateLogotoDatatable(ref m_dtReport);
          try
          {
              m_dtReport.AcceptChanges();
              crpt.SetDataSource(m_dtReport);
              //crpt.DataDefinition.FormulaFields["Formula_1"].Text = Strings.Chr(34) + "  PHÒNG TIẾP ĐÓN   ".Replace("#$X$#", Strings.Chr(34) + "&Chr(13)&" + Strings.Chr(34)) + Strings.Chr(34);
              objForm.mv_sReportFileName = Path.GetFileName(reportname);
              objForm.mv_sReportCode = "thuoc_baocao_thuochethan";
              objForm.crptViewer.ReportSource = crpt;
             
              Utility.SetParameterValue(crpt,"ParentBranchName", globalVariables.ParentBranch_Name);
              Utility.SetParameterValue(crpt,"BranchName", globalVariables.Branch_Name);
              Utility.SetParameterValue(crpt,"FromDateToDate", FromDateToDate);
              Utility.SetParameterValue(crpt,"KhoaPhong", globalVariables.KhoaDuoc);
              Utility.SetParameterValue(crpt,"sMoneyLetter", _moneyByLetter.sMoneyToLetter(tinhtong));
              Utility.SetParameterValue(crpt,"TongSoTien", tinhtong);

              Utility.SetParameterValue(crpt,"sCurrentDate", Utility.FormatDateTimeWithThanhPho(NgayIn));
              Utility.SetParameterValue(crpt,"sTitleReport", sTitleReport);
              Utility.SetParameterValue(crpt,"BottomCondition", THU_VIEN_CHUNG.BottomCondition());
              objForm.crptViewer.ReportSource = crpt;
              objForm.ShowDialog();
              // Utility.DefaultNow(this);
          }
          catch (Exception ex)
          {
              if (globalVariables.IsAdmin)
              {
                  Utility.ShowMsg(ex.ToString());
              }
          }
      }

        private static string TinhTong(DataTable dataTable)
        {
            string sumoftotal = Utility.sDbnull(dataTable.AsEnumerable().Sum(
                c => c.Field<decimal>(TPhieuNhapxuatthuocChitiet.ThanhTienColumn.ColumnName)));
            return sumoftotal;
        }
        private static string TinhTong(DataTable dataTable,string ColName)
        {
            string sumoftotal = Utility.sDbnull(dataTable.AsEnumerable().Sum(
                c => c.Field<decimal>(ColName)));
            return sumoftotal;
        }
    }
}
