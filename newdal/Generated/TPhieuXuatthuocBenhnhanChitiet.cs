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
	/// Strongly-typed collection for the TPhieuXuatthuocBenhnhanChitiet class.
	/// </summary>
    [Serializable]
	public partial class TPhieuXuatthuocBenhnhanChitietCollection : ActiveList<TPhieuXuatthuocBenhnhanChitiet, TPhieuXuatthuocBenhnhanChitietCollection>
	{	   
		public TPhieuXuatthuocBenhnhanChitietCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TPhieuXuatthuocBenhnhanChitietCollection</returns>
		public TPhieuXuatthuocBenhnhanChitietCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TPhieuXuatthuocBenhnhanChitiet o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the t_phieu_xuatthuoc_benhnhan_chitiet table.
	/// </summary>
	[Serializable]
	public partial class TPhieuXuatthuocBenhnhanChitiet : ActiveRecord<TPhieuXuatthuocBenhnhanChitiet>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TPhieuXuatthuocBenhnhanChitiet()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TPhieuXuatthuocBenhnhanChitiet(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TPhieuXuatthuocBenhnhanChitiet(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TPhieuXuatthuocBenhnhanChitiet(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("t_phieu_xuatthuoc_benhnhan_chitiet", TableType.Table, DataService.GetInstance("ORM"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPhieuChitiet = new TableSchema.TableColumn(schema);
				colvarIdPhieuChitiet.ColumnName = "id_phieu_chitiet";
				colvarIdPhieuChitiet.DataType = DbType.Int32;
				colvarIdPhieuChitiet.MaxLength = 0;
				colvarIdPhieuChitiet.AutoIncrement = true;
				colvarIdPhieuChitiet.IsNullable = false;
				colvarIdPhieuChitiet.IsPrimaryKey = true;
				colvarIdPhieuChitiet.IsForeignKey = false;
				colvarIdPhieuChitiet.IsReadOnly = false;
				colvarIdPhieuChitiet.DefaultSetting = @"";
				colvarIdPhieuChitiet.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPhieuChitiet);
				
				TableSchema.TableColumn colvarIdPhieu = new TableSchema.TableColumn(schema);
				colvarIdPhieu.ColumnName = "id_phieu";
				colvarIdPhieu.DataType = DbType.Int32;
				colvarIdPhieu.MaxLength = 0;
				colvarIdPhieu.AutoIncrement = false;
				colvarIdPhieu.IsNullable = false;
				colvarIdPhieu.IsPrimaryKey = false;
				colvarIdPhieu.IsForeignKey = false;
				colvarIdPhieu.IsReadOnly = false;
				colvarIdPhieu.DefaultSetting = @"";
				colvarIdPhieu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPhieu);
				
				TableSchema.TableColumn colvarIdKho = new TableSchema.TableColumn(schema);
				colvarIdKho.ColumnName = "id_kho";
				colvarIdKho.DataType = DbType.Int16;
				colvarIdKho.MaxLength = 0;
				colvarIdKho.AutoIncrement = false;
				colvarIdKho.IsNullable = true;
				colvarIdKho.IsPrimaryKey = false;
				colvarIdKho.IsForeignKey = false;
				colvarIdKho.IsReadOnly = false;
				colvarIdKho.DefaultSetting = @"";
				colvarIdKho.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdKho);
				
				TableSchema.TableColumn colvarIdThuoc = new TableSchema.TableColumn(schema);
				colvarIdThuoc.ColumnName = "id_thuoc";
				colvarIdThuoc.DataType = DbType.Int32;
				colvarIdThuoc.MaxLength = 0;
				colvarIdThuoc.AutoIncrement = false;
				colvarIdThuoc.IsNullable = false;
				colvarIdThuoc.IsPrimaryKey = false;
				colvarIdThuoc.IsForeignKey = false;
				colvarIdThuoc.IsReadOnly = false;
				colvarIdThuoc.DefaultSetting = @"";
				colvarIdThuoc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdThuoc);
				
				TableSchema.TableColumn colvarSoLuong = new TableSchema.TableColumn(schema);
				colvarSoLuong.ColumnName = "so_luong";
				colvarSoLuong.DataType = DbType.Int32;
				colvarSoLuong.MaxLength = 0;
				colvarSoLuong.AutoIncrement = false;
				colvarSoLuong.IsNullable = false;
				colvarSoLuong.IsPrimaryKey = false;
				colvarSoLuong.IsForeignKey = false;
				colvarSoLuong.IsReadOnly = false;
				colvarSoLuong.DefaultSetting = @"";
				colvarSoLuong.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSoLuong);
				
				TableSchema.TableColumn colvarDonGia = new TableSchema.TableColumn(schema);
				colvarDonGia.ColumnName = "don_gia";
				colvarDonGia.DataType = DbType.Decimal;
				colvarDonGia.MaxLength = 0;
				colvarDonGia.AutoIncrement = false;
				colvarDonGia.IsNullable = false;
				colvarDonGia.IsPrimaryKey = false;
				colvarDonGia.IsForeignKey = false;
				colvarDonGia.IsReadOnly = false;
				colvarDonGia.DefaultSetting = @"";
				colvarDonGia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDonGia);
				
				TableSchema.TableColumn colvarGiaNhap = new TableSchema.TableColumn(schema);
				colvarGiaNhap.ColumnName = "gia_nhap";
				colvarGiaNhap.DataType = DbType.Decimal;
				colvarGiaNhap.MaxLength = 0;
				colvarGiaNhap.AutoIncrement = false;
				colvarGiaNhap.IsNullable = false;
				colvarGiaNhap.IsPrimaryKey = false;
				colvarGiaNhap.IsForeignKey = false;
				colvarGiaNhap.IsReadOnly = false;
				colvarGiaNhap.DefaultSetting = @"";
				colvarGiaNhap.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGiaNhap);
				
				TableSchema.TableColumn colvarGiaBan = new TableSchema.TableColumn(schema);
				colvarGiaBan.ColumnName = "gia_ban";
				colvarGiaBan.DataType = DbType.Decimal;
				colvarGiaBan.MaxLength = 0;
				colvarGiaBan.AutoIncrement = false;
				colvarGiaBan.IsNullable = true;
				colvarGiaBan.IsPrimaryKey = false;
				colvarGiaBan.IsForeignKey = false;
				colvarGiaBan.IsReadOnly = false;
				colvarGiaBan.DefaultSetting = @"";
				colvarGiaBan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGiaBan);
				
				TableSchema.TableColumn colvarPhuthuDungtuyen = new TableSchema.TableColumn(schema);
				colvarPhuthuDungtuyen.ColumnName = "phuthu_dungtuyen";
				colvarPhuthuDungtuyen.DataType = DbType.Decimal;
				colvarPhuthuDungtuyen.MaxLength = 0;
				colvarPhuthuDungtuyen.AutoIncrement = false;
				colvarPhuthuDungtuyen.IsNullable = true;
				colvarPhuthuDungtuyen.IsPrimaryKey = false;
				colvarPhuthuDungtuyen.IsForeignKey = false;
				colvarPhuthuDungtuyen.IsReadOnly = false;
				colvarPhuthuDungtuyen.DefaultSetting = @"";
				colvarPhuthuDungtuyen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhuthuDungtuyen);
				
				TableSchema.TableColumn colvarPhuthuTraituyen = new TableSchema.TableColumn(schema);
				colvarPhuthuTraituyen.ColumnName = "phuthu_traituyen";
				colvarPhuthuTraituyen.DataType = DbType.Decimal;
				colvarPhuthuTraituyen.MaxLength = 0;
				colvarPhuthuTraituyen.AutoIncrement = false;
				colvarPhuthuTraituyen.IsNullable = true;
				colvarPhuthuTraituyen.IsPrimaryKey = false;
				colvarPhuthuTraituyen.IsForeignKey = false;
				colvarPhuthuTraituyen.IsReadOnly = false;
				colvarPhuthuTraituyen.DefaultSetting = @"";
				colvarPhuthuTraituyen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhuthuTraituyen);
				
				TableSchema.TableColumn colvarSoLo = new TableSchema.TableColumn(schema);
				colvarSoLo.ColumnName = "so_lo";
				colvarSoLo.DataType = DbType.String;
				colvarSoLo.MaxLength = 50;
				colvarSoLo.AutoIncrement = false;
				colvarSoLo.IsNullable = true;
				colvarSoLo.IsPrimaryKey = false;
				colvarSoLo.IsForeignKey = false;
				colvarSoLo.IsReadOnly = false;
				colvarSoLo.DefaultSetting = @"";
				colvarSoLo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSoLo);
				
				TableSchema.TableColumn colvarVat = new TableSchema.TableColumn(schema);
				colvarVat.ColumnName = "vat";
				colvarVat.DataType = DbType.Int32;
				colvarVat.MaxLength = 0;
				colvarVat.AutoIncrement = false;
				colvarVat.IsNullable = false;
				colvarVat.IsPrimaryKey = false;
				colvarVat.IsForeignKey = false;
				colvarVat.IsReadOnly = false;
				colvarVat.DefaultSetting = @"";
				colvarVat.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVat);
				
				TableSchema.TableColumn colvarNgayHethan = new TableSchema.TableColumn(schema);
				colvarNgayHethan.ColumnName = "ngay_hethan";
				colvarNgayHethan.DataType = DbType.DateTime;
				colvarNgayHethan.MaxLength = 0;
				colvarNgayHethan.AutoIncrement = false;
				colvarNgayHethan.IsNullable = false;
				colvarNgayHethan.IsPrimaryKey = false;
				colvarNgayHethan.IsForeignKey = false;
				colvarNgayHethan.IsReadOnly = false;
				colvarNgayHethan.DefaultSetting = @"";
				colvarNgayHethan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayHethan);
				
				TableSchema.TableColumn colvarIdChitietdonthuoc = new TableSchema.TableColumn(schema);
				colvarIdChitietdonthuoc.ColumnName = "id_chitietdonthuoc";
				colvarIdChitietdonthuoc.DataType = DbType.Int64;
				colvarIdChitietdonthuoc.MaxLength = 0;
				colvarIdChitietdonthuoc.AutoIncrement = false;
				colvarIdChitietdonthuoc.IsNullable = false;
				colvarIdChitietdonthuoc.IsPrimaryKey = false;
				colvarIdChitietdonthuoc.IsForeignKey = false;
				colvarIdChitietdonthuoc.IsReadOnly = false;
				colvarIdChitietdonthuoc.DefaultSetting = @"";
				colvarIdChitietdonthuoc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdChitietdonthuoc);
				
				TableSchema.TableColumn colvarIdDonthuoc = new TableSchema.TableColumn(schema);
				colvarIdDonthuoc.ColumnName = "id_donthuoc";
				colvarIdDonthuoc.DataType = DbType.Int64;
				colvarIdDonthuoc.MaxLength = 0;
				colvarIdDonthuoc.AutoIncrement = false;
				colvarIdDonthuoc.IsNullable = true;
				colvarIdDonthuoc.IsPrimaryKey = false;
				colvarIdDonthuoc.IsForeignKey = false;
				colvarIdDonthuoc.IsReadOnly = false;
				colvarIdDonthuoc.DefaultSetting = @"";
				colvarIdDonthuoc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDonthuoc);
				
				TableSchema.TableColumn colvarChiDan = new TableSchema.TableColumn(schema);
				colvarChiDan.ColumnName = "chi_dan";
				colvarChiDan.DataType = DbType.String;
				colvarChiDan.MaxLength = 500;
				colvarChiDan.AutoIncrement = false;
				colvarChiDan.IsNullable = true;
				colvarChiDan.IsPrimaryKey = false;
				colvarChiDan.IsForeignKey = false;
				colvarChiDan.IsReadOnly = false;
				colvarChiDan.DefaultSetting = @"";
				colvarChiDan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarChiDan);
				
				TableSchema.TableColumn colvarIdThuockho = new TableSchema.TableColumn(schema);
				colvarIdThuockho.ColumnName = "id_thuockho";
				colvarIdThuockho.DataType = DbType.Int64;
				colvarIdThuockho.MaxLength = 0;
				colvarIdThuockho.AutoIncrement = false;
				colvarIdThuockho.IsNullable = true;
				colvarIdThuockho.IsPrimaryKey = false;
				colvarIdThuockho.IsForeignKey = false;
				colvarIdThuockho.IsReadOnly = false;
				colvarIdThuockho.DefaultSetting = @"";
				colvarIdThuockho.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdThuockho);
				
				TableSchema.TableColumn colvarMaNhacungcap = new TableSchema.TableColumn(schema);
				colvarMaNhacungcap.ColumnName = "ma_nhacungcap";
				colvarMaNhacungcap.DataType = DbType.String;
				colvarMaNhacungcap.MaxLength = 20;
				colvarMaNhacungcap.AutoIncrement = false;
				colvarMaNhacungcap.IsNullable = true;
				colvarMaNhacungcap.IsPrimaryKey = false;
				colvarMaNhacungcap.IsForeignKey = false;
				colvarMaNhacungcap.IsReadOnly = false;
				colvarMaNhacungcap.DefaultSetting = @"";
				colvarMaNhacungcap.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMaNhacungcap);
				
				TableSchema.TableColumn colvarNgayNhap = new TableSchema.TableColumn(schema);
				colvarNgayNhap.ColumnName = "ngay_nhap";
				colvarNgayNhap.DataType = DbType.DateTime;
				colvarNgayNhap.MaxLength = 0;
				colvarNgayNhap.AutoIncrement = false;
				colvarNgayNhap.IsNullable = true;
				colvarNgayNhap.IsPrimaryKey = false;
				colvarNgayNhap.IsForeignKey = false;
				colvarNgayNhap.IsReadOnly = false;
				colvarNgayNhap.DefaultSetting = @"";
				colvarNgayNhap.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayNhap);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ORM"].AddSchema("t_phieu_xuatthuoc_benhnhan_chitiet",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPhieuChitiet")]
		[Bindable(true)]
		public int IdPhieuChitiet 
		{
			get { return GetColumnValue<int>(Columns.IdPhieuChitiet); }
			set { SetColumnValue(Columns.IdPhieuChitiet, value); }
		}
		  
		[XmlAttribute("IdPhieu")]
		[Bindable(true)]
		public int IdPhieu 
		{
			get { return GetColumnValue<int>(Columns.IdPhieu); }
			set { SetColumnValue(Columns.IdPhieu, value); }
		}
		  
		[XmlAttribute("IdKho")]
		[Bindable(true)]
		public short? IdKho 
		{
			get { return GetColumnValue<short?>(Columns.IdKho); }
			set { SetColumnValue(Columns.IdKho, value); }
		}
		  
		[XmlAttribute("IdThuoc")]
		[Bindable(true)]
		public int IdThuoc 
		{
			get { return GetColumnValue<int>(Columns.IdThuoc); }
			set { SetColumnValue(Columns.IdThuoc, value); }
		}
		  
		[XmlAttribute("SoLuong")]
		[Bindable(true)]
		public int SoLuong 
		{
			get { return GetColumnValue<int>(Columns.SoLuong); }
			set { SetColumnValue(Columns.SoLuong, value); }
		}
		  
		[XmlAttribute("DonGia")]
		[Bindable(true)]
		public decimal DonGia 
		{
			get { return GetColumnValue<decimal>(Columns.DonGia); }
			set { SetColumnValue(Columns.DonGia, value); }
		}
		  
		[XmlAttribute("GiaNhap")]
		[Bindable(true)]
		public decimal GiaNhap 
		{
			get { return GetColumnValue<decimal>(Columns.GiaNhap); }
			set { SetColumnValue(Columns.GiaNhap, value); }
		}
		  
		[XmlAttribute("GiaBan")]
		[Bindable(true)]
		public decimal? GiaBan 
		{
			get { return GetColumnValue<decimal?>(Columns.GiaBan); }
			set { SetColumnValue(Columns.GiaBan, value); }
		}
		  
		[XmlAttribute("PhuthuDungtuyen")]
		[Bindable(true)]
		public decimal? PhuthuDungtuyen 
		{
			get { return GetColumnValue<decimal?>(Columns.PhuthuDungtuyen); }
			set { SetColumnValue(Columns.PhuthuDungtuyen, value); }
		}
		  
		[XmlAttribute("PhuthuTraituyen")]
		[Bindable(true)]
		public decimal? PhuthuTraituyen 
		{
			get { return GetColumnValue<decimal?>(Columns.PhuthuTraituyen); }
			set { SetColumnValue(Columns.PhuthuTraituyen, value); }
		}
		  
		[XmlAttribute("SoLo")]
		[Bindable(true)]
		public string SoLo 
		{
			get { return GetColumnValue<string>(Columns.SoLo); }
			set { SetColumnValue(Columns.SoLo, value); }
		}
		  
		[XmlAttribute("Vat")]
		[Bindable(true)]
		public int Vat 
		{
			get { return GetColumnValue<int>(Columns.Vat); }
			set { SetColumnValue(Columns.Vat, value); }
		}
		  
		[XmlAttribute("NgayHethan")]
		[Bindable(true)]
		public DateTime NgayHethan 
		{
			get { return GetColumnValue<DateTime>(Columns.NgayHethan); }
			set { SetColumnValue(Columns.NgayHethan, value); }
		}
		  
		[XmlAttribute("IdChitietdonthuoc")]
		[Bindable(true)]
		public long IdChitietdonthuoc 
		{
			get { return GetColumnValue<long>(Columns.IdChitietdonthuoc); }
			set { SetColumnValue(Columns.IdChitietdonthuoc, value); }
		}
		  
		[XmlAttribute("IdDonthuoc")]
		[Bindable(true)]
		public long? IdDonthuoc 
		{
			get { return GetColumnValue<long?>(Columns.IdDonthuoc); }
			set { SetColumnValue(Columns.IdDonthuoc, value); }
		}
		  
		[XmlAttribute("ChiDan")]
		[Bindable(true)]
		public string ChiDan 
		{
			get { return GetColumnValue<string>(Columns.ChiDan); }
			set { SetColumnValue(Columns.ChiDan, value); }
		}
		  
		[XmlAttribute("IdThuockho")]
		[Bindable(true)]
		public long? IdThuockho 
		{
			get { return GetColumnValue<long?>(Columns.IdThuockho); }
			set { SetColumnValue(Columns.IdThuockho, value); }
		}
		  
		[XmlAttribute("MaNhacungcap")]
		[Bindable(true)]
		public string MaNhacungcap 
		{
			get { return GetColumnValue<string>(Columns.MaNhacungcap); }
			set { SetColumnValue(Columns.MaNhacungcap, value); }
		}
		  
		[XmlAttribute("NgayNhap")]
		[Bindable(true)]
		public DateTime? NgayNhap 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgayNhap); }
			set { SetColumnValue(Columns.NgayNhap, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdPhieu,short? varIdKho,int varIdThuoc,int varSoLuong,decimal varDonGia,decimal varGiaNhap,decimal? varGiaBan,decimal? varPhuthuDungtuyen,decimal? varPhuthuTraituyen,string varSoLo,int varVat,DateTime varNgayHethan,long varIdChitietdonthuoc,long? varIdDonthuoc,string varChiDan,long? varIdThuockho,string varMaNhacungcap,DateTime? varNgayNhap)
		{
			TPhieuXuatthuocBenhnhanChitiet item = new TPhieuXuatthuocBenhnhanChitiet();
			
			item.IdPhieu = varIdPhieu;
			
			item.IdKho = varIdKho;
			
			item.IdThuoc = varIdThuoc;
			
			item.SoLuong = varSoLuong;
			
			item.DonGia = varDonGia;
			
			item.GiaNhap = varGiaNhap;
			
			item.GiaBan = varGiaBan;
			
			item.PhuthuDungtuyen = varPhuthuDungtuyen;
			
			item.PhuthuTraituyen = varPhuthuTraituyen;
			
			item.SoLo = varSoLo;
			
			item.Vat = varVat;
			
			item.NgayHethan = varNgayHethan;
			
			item.IdChitietdonthuoc = varIdChitietdonthuoc;
			
			item.IdDonthuoc = varIdDonthuoc;
			
			item.ChiDan = varChiDan;
			
			item.IdThuockho = varIdThuockho;
			
			item.MaNhacungcap = varMaNhacungcap;
			
			item.NgayNhap = varNgayNhap;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdPhieuChitiet,int varIdPhieu,short? varIdKho,int varIdThuoc,int varSoLuong,decimal varDonGia,decimal varGiaNhap,decimal? varGiaBan,decimal? varPhuthuDungtuyen,decimal? varPhuthuTraituyen,string varSoLo,int varVat,DateTime varNgayHethan,long varIdChitietdonthuoc,long? varIdDonthuoc,string varChiDan,long? varIdThuockho,string varMaNhacungcap,DateTime? varNgayNhap)
		{
			TPhieuXuatthuocBenhnhanChitiet item = new TPhieuXuatthuocBenhnhanChitiet();
			
				item.IdPhieuChitiet = varIdPhieuChitiet;
			
				item.IdPhieu = varIdPhieu;
			
				item.IdKho = varIdKho;
			
				item.IdThuoc = varIdThuoc;
			
				item.SoLuong = varSoLuong;
			
				item.DonGia = varDonGia;
			
				item.GiaNhap = varGiaNhap;
			
				item.GiaBan = varGiaBan;
			
				item.PhuthuDungtuyen = varPhuthuDungtuyen;
			
				item.PhuthuTraituyen = varPhuthuTraituyen;
			
				item.SoLo = varSoLo;
			
				item.Vat = varVat;
			
				item.NgayHethan = varNgayHethan;
			
				item.IdChitietdonthuoc = varIdChitietdonthuoc;
			
				item.IdDonthuoc = varIdDonthuoc;
			
				item.ChiDan = varChiDan;
			
				item.IdThuockho = varIdThuockho;
			
				item.MaNhacungcap = varMaNhacungcap;
			
				item.NgayNhap = varNgayNhap;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPhieuChitietColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPhieuColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdKhoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdThuocColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SoLuongColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn DonGiaColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn GiaNhapColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn GiaBanColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn PhuthuDungtuyenColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn PhuthuTraituyenColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn SoLoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn VatColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayHethanColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn IdChitietdonthuocColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IdDonthuocColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ChiDanColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn IdThuockhoColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn MaNhacungcapColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayNhapColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPhieuChitiet = @"id_phieu_chitiet";
			 public static string IdPhieu = @"id_phieu";
			 public static string IdKho = @"id_kho";
			 public static string IdThuoc = @"id_thuoc";
			 public static string SoLuong = @"so_luong";
			 public static string DonGia = @"don_gia";
			 public static string GiaNhap = @"gia_nhap";
			 public static string GiaBan = @"gia_ban";
			 public static string PhuthuDungtuyen = @"phuthu_dungtuyen";
			 public static string PhuthuTraituyen = @"phuthu_traituyen";
			 public static string SoLo = @"so_lo";
			 public static string Vat = @"vat";
			 public static string NgayHethan = @"ngay_hethan";
			 public static string IdChitietdonthuoc = @"id_chitietdonthuoc";
			 public static string IdDonthuoc = @"id_donthuoc";
			 public static string ChiDan = @"chi_dan";
			 public static string IdThuockho = @"id_thuockho";
			 public static string MaNhacungcap = @"ma_nhacungcap";
			 public static string NgayNhap = @"ngay_nhap";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
