using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace VNS.HIS.DAL
{
    /// <summary>
    /// Controller class for dmuc_dichvucls_chitiet
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class DmucDichvuclsChitietController
    {
        // Preload our schema..
        DmucDichvuclsChitiet thisSchemaLoad = new DmucDichvuclsChitiet();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public DmucDichvuclsChitietCollection FetchAll()
        {
            DmucDichvuclsChitietCollection coll = new DmucDichvuclsChitietCollection();
            Query qry = new Query(DmucDichvuclsChitiet.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public DmucDichvuclsChitietCollection FetchByID(object IdChitietdichvu)
        {
            DmucDichvuclsChitietCollection coll = new DmucDichvuclsChitietCollection().Where("id_chitietdichvu", IdChitietdichvu).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public DmucDichvuclsChitietCollection FetchByQuery(Query qry)
        {
            DmucDichvuclsChitietCollection coll = new DmucDichvuclsChitietCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdChitietdichvu)
        {
            return (DmucDichvuclsChitiet.Delete(IdChitietdichvu) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdChitietdichvu)
        {
            return (DmucDichvuclsChitiet.Destroy(IdChitietdichvu) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string MaChitietdichvu,string TenChitietdichvu,string TenBhyt,short IdDichvu,string MaDonvitinh,string BinhthuongNam,string BinhthuongNu,byte? TrangThai,byte? HienThi,decimal? DonGia,string MotaThem,int? SttHthi,short? IdKhoaThuchien,short? IdPhongThuchien,string ChiDan,string NhomBaocao,DateTime? NgayTao,string NguoiTao,DateTime? NgaySua,string NguoiSua,string MaKhoathuchien,byte? TuTuc,decimal? GiaBhyt,decimal? PhuthuDungtuyen,decimal? PhuthuTraituyen,byte? CoChitiet,int? IdCha,int? IdVungkhaosat,string Bodypart,string ViewPosition,string MauChuan,string MauCanhan,byte? LaChiphithem)
	    {
		    DmucDichvuclsChitiet item = new DmucDichvuclsChitiet();
		    
            item.MaChitietdichvu = MaChitietdichvu;
            
            item.TenChitietdichvu = TenChitietdichvu;
            
            item.TenBhyt = TenBhyt;
            
            item.IdDichvu = IdDichvu;
            
            item.MaDonvitinh = MaDonvitinh;
            
            item.BinhthuongNam = BinhthuongNam;
            
            item.BinhthuongNu = BinhthuongNu;
            
            item.TrangThai = TrangThai;
            
            item.HienThi = HienThi;
            
            item.DonGia = DonGia;
            
            item.MotaThem = MotaThem;
            
            item.SttHthi = SttHthi;
            
            item.IdKhoaThuchien = IdKhoaThuchien;
            
            item.IdPhongThuchien = IdPhongThuchien;
            
            item.ChiDan = ChiDan;
            
            item.NhomBaocao = NhomBaocao;
            
            item.NgayTao = NgayTao;
            
            item.NguoiTao = NguoiTao;
            
            item.NgaySua = NgaySua;
            
            item.NguoiSua = NguoiSua;
            
            item.MaKhoathuchien = MaKhoathuchien;
            
            item.TuTuc = TuTuc;
            
            item.GiaBhyt = GiaBhyt;
            
            item.PhuthuDungtuyen = PhuthuDungtuyen;
            
            item.PhuthuTraituyen = PhuthuTraituyen;
            
            item.CoChitiet = CoChitiet;
            
            item.IdCha = IdCha;
            
            item.IdVungkhaosat = IdVungkhaosat;
            
            item.Bodypart = Bodypart;
            
            item.ViewPosition = ViewPosition;
            
            item.MauChuan = MauChuan;
            
            item.MauCanhan = MauCanhan;
            
            item.LaChiphithem = LaChiphithem;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdChitietdichvu,string MaChitietdichvu,string TenChitietdichvu,string TenBhyt,short IdDichvu,string MaDonvitinh,string BinhthuongNam,string BinhthuongNu,byte? TrangThai,byte? HienThi,decimal? DonGia,string MotaThem,int? SttHthi,short? IdKhoaThuchien,short? IdPhongThuchien,string ChiDan,string NhomBaocao,DateTime? NgayTao,string NguoiTao,DateTime? NgaySua,string NguoiSua,string MaKhoathuchien,byte? TuTuc,decimal? GiaBhyt,decimal? PhuthuDungtuyen,decimal? PhuthuTraituyen,byte? CoChitiet,int? IdCha,int? IdVungkhaosat,string Bodypart,string ViewPosition,string MauChuan,string MauCanhan,byte? LaChiphithem)
	    {
		    DmucDichvuclsChitiet item = new DmucDichvuclsChitiet();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdChitietdichvu = IdChitietdichvu;
				
			item.MaChitietdichvu = MaChitietdichvu;
				
			item.TenChitietdichvu = TenChitietdichvu;
				
			item.TenBhyt = TenBhyt;
				
			item.IdDichvu = IdDichvu;
				
			item.MaDonvitinh = MaDonvitinh;
				
			item.BinhthuongNam = BinhthuongNam;
				
			item.BinhthuongNu = BinhthuongNu;
				
			item.TrangThai = TrangThai;
				
			item.HienThi = HienThi;
				
			item.DonGia = DonGia;
				
			item.MotaThem = MotaThem;
				
			item.SttHthi = SttHthi;
				
			item.IdKhoaThuchien = IdKhoaThuchien;
				
			item.IdPhongThuchien = IdPhongThuchien;
				
			item.ChiDan = ChiDan;
				
			item.NhomBaocao = NhomBaocao;
				
			item.NgayTao = NgayTao;
				
			item.NguoiTao = NguoiTao;
				
			item.NgaySua = NgaySua;
				
			item.NguoiSua = NguoiSua;
				
			item.MaKhoathuchien = MaKhoathuchien;
				
			item.TuTuc = TuTuc;
				
			item.GiaBhyt = GiaBhyt;
				
			item.PhuthuDungtuyen = PhuthuDungtuyen;
				
			item.PhuthuTraituyen = PhuthuTraituyen;
				
			item.CoChitiet = CoChitiet;
				
			item.IdCha = IdCha;
				
			item.IdVungkhaosat = IdVungkhaosat;
				
			item.Bodypart = Bodypart;
				
			item.ViewPosition = ViewPosition;
				
			item.MauChuan = MauChuan;
				
			item.MauCanhan = MauCanhan;
				
			item.LaChiphithem = LaChiphithem;
				
	        item.Save(UserName);
	    }
    }
}
