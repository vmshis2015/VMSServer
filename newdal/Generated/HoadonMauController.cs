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
    /// Controller class for hoadon_mau
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class HoadonMauController
    {
        // Preload our schema..
        HoadonMau thisSchemaLoad = new HoadonMau();
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
        public HoadonMauCollection FetchAll()
        {
            HoadonMauCollection coll = new HoadonMauCollection();
            Query qry = new Query(HoadonMau.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HoadonMauCollection FetchByID(object IdHoadonMau)
        {
            HoadonMauCollection coll = new HoadonMauCollection().Where("id_hoadon_mau", IdHoadonMau).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public HoadonMauCollection FetchByQuery(Query qry)
        {
            HoadonMauCollection coll = new HoadonMauCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdHoadonMau)
        {
            return (HoadonMau.Delete(IdHoadonMau) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdHoadonMau)
        {
            return (HoadonMau.Destroy(IdHoadonMau) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string MauHoadon,string KiHieu,string MaQuyen,string SerieDau,string SerieCuoi,DateTime NgayHieuluc,DateTime NgayHethieuluc,short TrangThai,DateTime NgayTao,string NguoiTao,DateTime? NgaySua,string NguoiSua)
	    {
		    HoadonMau item = new HoadonMau();
		    
            item.MauHoadon = MauHoadon;
            
            item.KiHieu = KiHieu;
            
            item.MaQuyen = MaQuyen;
            
            item.SerieDau = SerieDau;
            
            item.SerieCuoi = SerieCuoi;
            
            item.NgayHieuluc = NgayHieuluc;
            
            item.NgayHethieuluc = NgayHethieuluc;
            
            item.TrangThai = TrangThai;
            
            item.NgayTao = NgayTao;
            
            item.NguoiTao = NguoiTao;
            
            item.NgaySua = NgaySua;
            
            item.NguoiSua = NguoiSua;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(long IdHoadonMau,string MauHoadon,string KiHieu,string MaQuyen,string SerieDau,string SerieCuoi,DateTime NgayHieuluc,DateTime NgayHethieuluc,short TrangThai,DateTime NgayTao,string NguoiTao,DateTime? NgaySua,string NguoiSua)
	    {
		    HoadonMau item = new HoadonMau();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdHoadonMau = IdHoadonMau;
				
			item.MauHoadon = MauHoadon;
				
			item.KiHieu = KiHieu;
				
			item.MaQuyen = MaQuyen;
				
			item.SerieDau = SerieDau;
				
			item.SerieCuoi = SerieCuoi;
				
			item.NgayHieuluc = NgayHieuluc;
				
			item.NgayHethieuluc = NgayHethieuluc;
				
			item.TrangThai = TrangThai;
				
			item.NgayTao = NgayTao;
				
			item.NguoiTao = NguoiTao;
				
			item.NgaySua = NgaySua;
				
			item.NguoiSua = NguoiSua;
				
	        item.Save(UserName);
	    }
    }
}