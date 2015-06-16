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
    /// Controller class for t_dmuc_kho
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TDmucKhoController
    {
        // Preload our schema..
        TDmucKho thisSchemaLoad = new TDmucKho();
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
        public TDmucKhoCollection FetchAll()
        {
            TDmucKhoCollection coll = new TDmucKhoCollection();
            Query qry = new Query(TDmucKho.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TDmucKhoCollection FetchByID(object IdKho)
        {
            TDmucKhoCollection coll = new TDmucKhoCollection().Where("id_kho", IdKho).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TDmucKhoCollection FetchByQuery(Query qry)
        {
            TDmucKhoCollection coll = new TDmucKhoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdKho)
        {
            return (TDmucKho.Delete(IdKho) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdKho)
        {
            return (TDmucKho.Destroy(IdKho) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string MaKho,string TenKho,int? SttHthi,string KieuKho,string KhoThuocVt,short IdKhoaphong,string MotaThem,byte? LaQuaythuoc,byte? KtraTon,DateTime? NgaySua,DateTime? NgayTao,string NguoiSua,string NguoiTao,byte? LaTuthuoc,string LoaiBnhan,byte? TrangThai,byte? TuTuc,byte? ChophepChongia)
	    {
		    TDmucKho item = new TDmucKho();
		    
            item.MaKho = MaKho;
            
            item.TenKho = TenKho;
            
            item.SttHthi = SttHthi;
            
            item.KieuKho = KieuKho;
            
            item.KhoThuocVt = KhoThuocVt;
            
            item.IdKhoaphong = IdKhoaphong;
            
            item.MotaThem = MotaThem;
            
            item.LaQuaythuoc = LaQuaythuoc;
            
            item.KtraTon = KtraTon;
            
            item.NgaySua = NgaySua;
            
            item.NgayTao = NgayTao;
            
            item.NguoiSua = NguoiSua;
            
            item.NguoiTao = NguoiTao;
            
            item.LaTuthuoc = LaTuthuoc;
            
            item.LoaiBnhan = LoaiBnhan;
            
            item.TrangThai = TrangThai;
            
            item.TuTuc = TuTuc;
            
            item.ChophepChongia = ChophepChongia;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdKho,string MaKho,string TenKho,int? SttHthi,string KieuKho,string KhoThuocVt,short IdKhoaphong,string MotaThem,byte? LaQuaythuoc,byte? KtraTon,DateTime? NgaySua,DateTime? NgayTao,string NguoiSua,string NguoiTao,byte? LaTuthuoc,string LoaiBnhan,byte? TrangThai,byte? TuTuc,byte? ChophepChongia)
	    {
		    TDmucKho item = new TDmucKho();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdKho = IdKho;
				
			item.MaKho = MaKho;
				
			item.TenKho = TenKho;
				
			item.SttHthi = SttHthi;
				
			item.KieuKho = KieuKho;
				
			item.KhoThuocVt = KhoThuocVt;
				
			item.IdKhoaphong = IdKhoaphong;
				
			item.MotaThem = MotaThem;
				
			item.LaQuaythuoc = LaQuaythuoc;
				
			item.KtraTon = KtraTon;
				
			item.NgaySua = NgaySua;
				
			item.NgayTao = NgayTao;
				
			item.NguoiSua = NguoiSua;
				
			item.NguoiTao = NguoiTao;
				
			item.LaTuthuoc = LaTuthuoc;
				
			item.LoaiBnhan = LoaiBnhan;
				
			item.TrangThai = TrangThai;
				
			item.TuTuc = TuTuc;
				
			item.ChophepChongia = ChophepChongia;
				
	        item.Save(UserName);
	    }
    }
}